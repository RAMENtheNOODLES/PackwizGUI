Imports System.ComponentModel
Imports System.Net.Http
Imports System.Text.Json
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports JsonSerializer = System.Text.Json.JsonSerializer

Namespace PackwizUtils
    Public Class PackwizUtils
        Private Shared ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()
        Private Shared ReadOnly options As New JsonSerializerOptions With {
                .WriteIndented = True
            }

        ''' <summary>
        ''' Inits the mods table
        ''' </summary>
        ''' <param name="EnableAdvancedMode">Whether to sow the Mod ID and Slug Columns</param>
        ''' <returns>The initialized mods Table</returns>
        Public Shared Function InitModsTable(Optional EnableAdvancedMode As Boolean = False) As DataGridView
            Dim modsTable As New DataGridView
            With modsTable
                .ColumnCount = 6
                .ReadOnly = True
                .AllowUserToOrderColumns = False
                .AllowDrop = False
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .Location = New Point(8, 8)

                .AutoSizeRowsMode =
                            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnMode.AllCells
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
                .GridColor = Color.Black
                .ForeColor = Color.Black
                .RowHeadersVisible = False

                .Columns(0).Name = "Mod ID"
                .Columns(0).Visible = EnableAdvancedMode
                .Columns(1).Name = "Slug"
                .Columns(1).Visible = EnableAdvancedMode
                .Columns(2).Name = "Mod Name"
                .Columns(3).Name = "Author"
                .Columns(4).Name = "Description"
                .Columns(5).Name = "Provider"
                .Columns(5).Visible = True

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = True
                .Dock = DockStyle.Fill
            End With

            Return modsTable
        End Function

        Private Shared Function DecodeCurseforgeAPIKey(key As String) As String
            Return Text.Encoding.UTF8.GetString(Convert.FromBase64String(key))
        End Function

        ''' <summary>
        ''' Sets the proper UserAgent headers and returns a get request back
        ''' </summary>
        ''' <param name="URI">the uri to send the get request to</param>
        ''' <returns></returns>
        Public Shared Function GetRequestMessage(URI As String, Optional isCurseforge As Boolean = False) As HttpRequestMessage
            'User-Agent: github_username/project_name/1.56.0 (contact@launcher.com)
            Dim request = New HttpRequestMessage(HttpMethod.Get, URI)

            Dim ver = My.Application.Info.Version

            request.Headers.UserAgent.Add(New Headers.ProductInfoHeaderValue("PackwizGUI", $"{ver}"))
            request.Headers.UserAgent.Add(New Headers.ProductInfoHeaderValue($"(RAMENtheNOODLES/PackwizGUI [cookiejar499@gmail.com])"))
            If isCurseforge Then
                request.Headers.Add("x-api-key", DecodeCurseforgeAPIKey(My.Settings.CurseForgeAPIKey))
            End If

            Return request
        End Function

        Public Shared Function GetMinecraftVersion() As String
            Return ReadFromFile($"{My.Settings.ProjectDirectory}/pack.toml").Split("minecraft = """)(1).Split("""")(0)
        End Function

        ''' <summary>
        ''' Searches for a specific mod using Modrinth's API
        ''' </summary>
        ''' <param name="modsTable">The table that should be updated</param>
        ''' <param name="client">The http client to use to send the request</param>
        ''' <param name="SearchQuery">The query used to search for a mod</param>
        ''' <returns></returns>
        Public Shared Async Function DoSearch(modsTable As DataGridView, client As HttpClient,
                                              Optional SearchQuery As String = "", Optional Limit As Integer = 10, Optional Offset As Integer = 0) As Task
            Try
                Dim firstHalf As ArrayList

                Logger.Debug($"Minecraft Version: {GetMinecraftVersion()}")

                Dim tmp = client.Send(GetRequestMessage($"https://api.modrinth.com/v2/search?query=""{SearchQuery}""&limit={Limit}&offset={Offset}" &
                                                        $"&facets=[[""project_type:mod""],[""versions:{GetMinecraftVersion()}""]]"))
                'Logger.Debug(tmp.RequestMessage)
                Dim responseBody As String = Await tmp.Content.ReadAsStringAsync()
                Dim parseJson As JObject = JObject.Parse(responseBody)

                firstHalf = ParseMods(parseJson)

                tmp = client.Send(GetRequestMessage($"https://api.curseforge.com/v1/mods/search?gameId=432&gameVersion={GetMinecraftVersion()}" &
                                                    $"&classId=6&searchFilter=""{SearchQuery}""&pageSize={Limit}&index={Offset}", True))
                responseBody = Await tmp.Content.ReadAsStringAsync()
                parseJson = JObject.Parse(responseBody)

                firstHalf.AddRange(ParseModsFromCurseForge(parseJson))

                AddNewMods(modsTable, firstHalf)
            Catch ex As Exception
                Logger.Error(ex, "Exception Caught!")
            End Try
        End Function

        ''' <summary>
        ''' Refreshes the mods table for mod searching
        ''' </summary>
        ''' <param name="modsTable">The table that should be refreshed</param>
        ''' <param name="client">The http client to use to send the request</param>
        ''' <param name="SearchQuery">The query used to search for a mod</param>
        ''' <see cref="DoSearch(DataGridView, HttpClient, String)"/>
        Public Shared Async Sub RefreshMods(modsTable As DataGridView, client As HttpClient, Optional SearchQuery As String = "",
                                            Optional Limit As Integer = 10, Optional Offset As Integer = 0)
            modsTable.Rows.Clear()
            Await DoSearch(modsTable, client, SearchQuery, Limit, Offset)
        End Sub

        ''' <summary>
        ''' Adds a new mod to the given table
        ''' </summary>
        ''' <param name="modsTable">The table to add the new mod to</param>
        ''' <param name="modID">The `project_id` of the mod</param>
        ''' <param name="slug"></param>
        ''' <param name="title"></param>
        ''' <param name="author"></param>
        ''' <param name="description"></param>
        Public Shared Sub AddNewMod(modsTable As DataGridView, modID As String, slug As String, title As String, author As String, description As String, Optional provider As String = "modrinth")
            With modsTable.Rows(modsTable.Rows.Add())
                .Cells(0).Value = modID
                .Cells(1).Value = slug
                .Cells(2).Value = title
                .Cells(3).Value = author
                .Cells(4).Value = description
                .Cells(5).Value = provider
            End With
        End Sub

        ''' <summary>
        ''' Adds an entire list of mods to the given table
        ''' </summary>
        ''' <param name="modsTable">The table to add the new mods to</param>
        ''' <param name="mods">The list of mods to add to the table</param>
        ''' <see cref="AddNewMod(DataGridView, String, String, String, String, String)"/>
        Public Shared Sub AddNewMods(modsTable As DataGridView, mods As ArrayList)
            For Each item As Dictionary(Of String, String) In mods
                Dim modID As String = item.Item("project_id")
                Dim slug As String = item.Item("slug")
                Dim title As String = item.Item("title")
                Dim author As String = item.Item("author")
                Dim description As String = item.Item("description")
                Dim provider As String = item.GetValueOrDefault("provider", "modrinth")

                PackwizUtils.AddNewMod(modsTable, modID, slug, title, author, description, provider)
                IndexMod(modID, slug, title, author, description)
            Next
        End Sub

        ''' <summary>
        ''' Parses mods given from a JSON object and outputs an ArrayList
        ''' </summary>
        ''' <param name="JSON">The JSON object to parse</param>
        ''' <returns>A parsed list of mods</returns>
        Public Shared Function ParseMods(JSON As JObject) As ArrayList
            Dim mods As New ArrayList()

            Dim hits As JArray = JSON.SelectToken("$.hits")

            For i As Integer = 0 To hits.ToArray().Length - 1
                Dim tmp As New Dictionary(Of String, String) From {
                    {"project_id", StripJSONKeyFromString(hits(i).ElementAt(0).ToString())},
                    {"project_type", StripJSONKeyFromString(hits(i).ElementAt(1).ToString())},
                    {"slug", StripJSONKeyFromString(hits(i).ElementAt(2).ToString())},
                    {"author", StripJSONKeyFromString(hits(i).ElementAt(3).ToString())},
                    {"title", StripJSONKeyFromString(hits(i).ElementAt(4).ToString())},
                    {"description", StripJSONKeyFromString(hits(i).ElementAt(5).ToString())},
                    {"provider", "modrinth"}
                }

                mods.Add(tmp)
            Next

            Return mods
        End Function

        ''' <summary>
        ''' Parses mods given from a JSON object and outputs an ArrayList
        ''' </summary>
        ''' <param name="JSON">The JSON object to parse</param>
        ''' <returns>A parsed list of mods</returns>
        Public Shared Function ParseModsFromCurseForge(JSON As JObject) As ArrayList
            Dim mods As New ArrayList()

            Dim hits As JArray = JSON.SelectToken("$.data")

            For i As Integer = 0 To hits.ToArray().Length - 1
                Dim tmp As New Dictionary(Of String, String) From {
                    {"project_id", StripJSONKeyFromString(hits(i).ElementAt(0).ToString())},
                    {"project_type", "mod"},
                    {"slug", StripJSONKeyFromString(hits(i).ElementAt(3).ToString())},
                    {"author", ""},
                    {"title", StripJSONKeyFromString(hits(i).ElementAt(2).ToString())},
                    {"description", StripJSONKeyFromString(hits(i).ElementAt(5).ToString())},
                    {"provider", "curseforge"}
                }

                mods.Add(tmp)
            Next

            Return mods
        End Function

        ''' <summary>
        ''' Sends a get request to the specified URI and outputs the response as JSON
        ''' </summary>
        ''' <param name="URI">The uri to send the request to</param>
        ''' <param name="client">The Http Client to use to send the request</param>
        ''' <returns>The response as JSON</returns>
        Public Shared Function ParseJson(URI As String, client As HttpClient, Optional isCurseforge As Boolean = False) As JObject
            Dim responseBody As String
            Try
                Dim tmp = client.Send(GetRequestMessage(URI, isCurseforge))
                responseBody = tmp.Content.ReadAsStringAsync().Result
                Logger.Debug(JValue.Parse(responseBody).ToString(Formatting.Indented))
                Return JObject.Parse(responseBody)
            Catch ex As Exception
                Logger.Error(ex, "Exception Caught!")
            End Try

            Return Nothing
        End Function

        Public Shared Function GetMissingModInfoFromCurseForge(ModID As String, client As HttpClient) As Dictionary(Of String, String)
            Logger.Debug("Getting Missing Mod Info From CurseForge")
            Dim result = ParseJson($"https://api.curseforge.com/v1/mods/{ModID}", client, True)
            Try
                Dim tmp As New Dictionary(Of String, String) From {
                    {"slug", result.SelectToken("data").SelectToken("slug")},
                    {"project_type", "mod"},
                    {"description", result.SelectToken("data").SelectToken("summary")}
                }

                Return tmp
            Catch ex As Exception
                Logger.Error(ex, $"Error getting missing information from {ModID}")
            End Try

            Return New Dictionary(Of String, String) From {
                    {"slug", ""},
                    {"project_type", "mod"},
                    {"description", ""}
            }
        End Function

        ''' <summary>
        ''' Attempts to retrieve missing mod info by using Modrinth's API
        ''' </summary>
        ''' <param name="ModID">The `project_id` of the mod</param>
        ''' <param name="client">The Http Client to use to send the request</param>
        ''' <param name="IsNumeric">Whether the ModID is only numbers (i.e. a curseforge project id)</param>
        ''' <returns>A dictionary containing the remaining missing information</returns>
        Public Shared Function GetMissingModInfo(ModID As String, client As HttpClient, Optional IsNumeric As Boolean = False) As Dictionary(Of String, String)
            If IsNumeric Then
                Return GetMissingModInfoFromCurseForge(ModID, client)
            End If

            Dim result = ParseJson($"https://api.modrinth.com/v2/project/{ModID}", client)
            Try
                Dim tmp As New Dictionary(Of String, String) From {
                    {"slug", result.SelectToken("slug")},
                    {"project_type", result.SelectToken("project_type")},
                    {"description", result.SelectToken("description")}
                }

                Return tmp
            Catch ex As Exception
                Logger.Warn($"Mod ID: {ModID}")
                Logger.Error(ex, "Exception Caught!")
            End Try

            Return Nothing
        End Function

        ''' <summary>
        ''' Strips the colon and double-quotes (") from a JSON key
        ''' </summary>
        ''' <param name="str">The key to strip</param>
        ''' <returns>The stripped key</returns>
        Public Shared Function StripJSONKeyFromString(str As String) As String
            Return str.Split(": ")(1).Replace("""", "")
        End Function

        ''' <summary>
        ''' Returns a list of all of the files in the `/mods/` directory
        ''' </summary>
        ''' <returns>A list containing all of the mods in the project</returns>
        Public Shared Function GetInstalledMods() As ObjectModel.ReadOnlyCollection(Of String)
            If My.Settings.ProjectDirectory Is "" Then
                Return Nothing
            End If

            Return My.Computer.FileSystem.GetFiles(My.Settings.ProjectDirectory & "/mods/")
        End Function

        Public Shared Sub WriteToFile(file As String, text As String, Optional Append As Boolean = False)
            'My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
            My.Computer.FileSystem.WriteAllText(file, text, Append)
        End Sub

        Public Shared Function ReadFromFile(file As String) As String
            Try
                Return My.Computer.FileSystem.ReadAllText(file)
            Catch ex As Exception
                WriteToFile(file, "")
                Logger.Warn(ex, "Could not read file...")
            End Try
            Return ""
        End Function

        Public Shared Function GetIndexedMods() As Mods
            Dim out = JsonConvert.DeserializeObject(Of Mods)(ReadFromFile(My.Settings.ProjectDirectory & My.Settings.ModIndexFileName))

            If out Is Nothing Then
                Return Nothing
            End If

            Return out
        End Function

        Public Shared Function CheckIfModIsIndexed(modId As String) As Boolean
            Dim result = False
            Try
                If GetIndexedMods() Is Nothing Then
                    Exit Try
                Else
                    result = GetIndexedMods()._Mod.ContainsKey(modId)
                End If
            Catch ex As Exception
                Logger.Info($"Mod {modId} is not indexed...")
                result = False
            End Try

            Return result

        End Function

        Public Shared Function GetIndexedMod(modId As String) As _Mod
            If Not CheckIfModIsIndexed(modId) Then
                Return Nothing
            End If

            Return GetIndexedMods()._Mod.Item(modId)
        End Function

        Public Shared Sub SerializeIndex(ModsIndex As Mods)
            Dim jsonString = JsonSerializer.Serialize(ModsIndex, options)
            WriteToFile(My.Settings.ProjectDirectory & My.Settings.ModIndexFileName, jsonString)
        End Sub

        Public Shared Sub AddToIndexedMods(ModToAdd As _Mod, modID As String)
            Dim updatedMods As Mods = If(GetIndexedMods(), New Mods(New Dictionary(Of String, _Mod)))

            updatedMods._Mod.Add(modID, ModToAdd)

            SerializeIndex(updatedMods)
        End Sub

        Public Shared Sub IndexMod(modID As String, slug As String, title As String, author As String, description As String)
            If CheckIfModIsIndexed(modID) Then
                Return
            End If

            Dim ModToIndex As New _Mod(modID, slug, title, author, description)

            AddToIndexedMods(ModToIndex, modID)
        End Sub

        Public Shared Sub IndexMod(ModToIndex As Dictionary(Of String, String))
            IndexMod(ModToIndex("project_id"), ModToIndex("slug"), ModToIndex("title"), ModToIndex("author"), ModToIndex("description"))
        End Sub

        Public Shared Sub UnindexMod(modId As String)
            If Not CheckIfModIsIndexed(modId) Then
                Return
            End If

            Dim NewModsIndex As Mods = GetIndexedMods()

            NewModsIndex._Mod.Remove(modId)
            SerializeIndex(NewModsIndex)
        End Sub
    End Class

    Public Class _Mod
        Private Property ModID As String
        Public Property Slug As String
        Public Property Title As String
        Public Property Author As String
        Public Property Description As String

        Sub New(modID As String, slug As String, title As String, author As String, description As String)
            Me.ModID = modID
            Me.Slug = slug
            Me.Title = title
            Me.Author = author
            Me.Description = description
        End Sub
    End Class

    Public Class Mods
        Public Property _Mod As Dictionary(Of String, _Mod)

        Sub New(Mods As Dictionary(Of String, _Mod))
            _Mod = Mods
        End Sub
    End Class

    Public Module PackwizCommands
        Private ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

        Public Sub RemoveMod(slug As String)
            Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} remove {slug} -y; {My.Settings.PackwizFile} refresh".RunCMD()
        End Sub

        Public Sub AddMod(slug As String, Optional fromModrinth As Boolean = True)
            '"C:\Users\romme\Documents\Fogger-Pack"
            '"C:\Users\romme\Downloads\Windows 64-bit\packwiz.exe"
            Logger.Debug($"Installing: {slug}, from {If(fromModrinth, "modrinth", "curseforge")}")
            If fromModrinth Then
                Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} modrinth add {slug} -y".RunCMD(False, True)
            Else
                Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} curseforge add {slug} -y".RunCMD(False, True)
            End If
            RefreshPackwiz()
        End Sub

        Public Sub RefreshPackwiz()
            Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} refresh".RunCMD(False, True)
        End Sub

        Public Sub InitPackwiz()
            Throw New NotImplementedException
        End Sub

        Public Sub PinMod(slug As String)
            Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} pin {slug}".RunCMD()
        End Sub

        Public Sub UnpinMod(slug As String)
            Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} pin {slug}".RunCMD()
        End Sub

        Public Sub UpdateMods(Optional slug As String = "")
            Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} update {slug} -y".RunCMD()
        End Sub

        Public Sub UpdateAllMods()
            Call $"cd {My.Settings.ProjectDirectory} && {My.Settings.PackwizFile} update -a -y".RunCMD()
        End Sub
    End Module
End Namespace
