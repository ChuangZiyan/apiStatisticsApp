Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class Form1



    Public currentDirectory As String = My.Application.Info.DirectoryPath
    Public JobCollectionDir As String = currentDirectory + "\JobCollectionRawData"
    Public bearerToken As String = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiI1MGJkOTdiOC1iZjg1LTRhYzQtOTY4ZS01M2Q5NGMzYjJjMTgiLCJpYXQiOjE2OTQ1MDYwNTQsImlzcyI6Im1vb3Z1cCIsInN1YiI6IjdmN2JlMTZjLTVjMmUtNGEzMC05ZTQxLTA4ZDZkYjA1M2VjMCIsImFub255bW91cz8iOnRydWV9.2y2CpTlXOdvoGQ5ukfTag8IvIvyMMVTum21mZeZgV9A"

    Private Async Sub Submit_Query_Button_Click(sender As Object, e As EventArgs) Handles Submit_Query_Button.Click

        Dim filePath As String = JobCollectionDir + "\JobCollectionRawData_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt"

        For offset As Integer = 0 To Data_Query_Limit_NumericUpDown.Value - 1 Step 20
            Debug.WriteLine("Offset : " & offset)

            Dim jsonString = Await Submit_Get_Jobs_Collection_API_Request(offset)

            ' If get error exit the sub
            If jsonString = "error" Then
                MsgBox("發生其他錯誤，停止查詢")
                Exit Sub
            End If

            Dim jsonObject As JObject = JObject.Parse(jsonString)
            Dim resultArray As JArray = jsonObject.SelectToken("data.job_search.result")

            Using writer As New StreamWriter(filePath, True)

                For Each item As JObject In resultArray
                    JobCollection_ListBox.Items.Add(item.SelectToken("company.name"))
                    writer.WriteLine(item.SelectToken("_id").ToString() + "&nbsp;" + item.SelectToken("company.name").ToString())
                Next
                writer.Close()
            End Using


            Await Delay_msec(NumericUpDown1.Value * 1000)
        Next

        'Data_URL_ListBox.Items.Add("Test1")
    End Sub



    Public Async Function Submit_Get_Jobs_Collection_API_Request(offset As Integer) As Task(Of String)

        Dim requestData As New With {
        .query = "
            query QueryJobs (
              $company: ID
              $exclude: [ID]
              $district: [ID]
              $employment: [Employment]
              $workingHour: [JobSearchWorkingHour]
              $fromWorkingDaysPerWeek: Float
              $fromWorkingHoursPerDay: Float
              $hourlyRate: Float
              $monthlyRate: Float
              $jobType: [ID]
              $limit: Int
              $offset: Int
              $term: String
              $latlng: MLatLng
            ) {
              job_search(
                company: $company
                exclude: $exclude
                term: $term,
                district: $district,
                employment: $employment,
                from_working_days_per_week: $fromWorkingDaysPerWeek,
                from_working_hours_per_day: $fromWorkingHoursPerDay,
                hourly_rate: $hourlyRate,
                monthly_rate: $monthlyRate,
                job_type: $jobType,
                limit: $limit,
                offset: $offset,
                working_hour: $workingHour,
                latlng: $latlng
              ) {
                ...jobSearchResultFragment
              }
            }

            fragment jobSearchResultFragment on JobSearchResult {
              result {
                ...jobFragmentCore
              }
              total
            }

            fragment jobFragmentCore on Job {
              _id
              address {
                district_name
                district_short_code
              }
              company {
                company_logo_thumbnail
                name
              }
              employment
              from_hourly_rate
              from_monthly_rate
              job_name
              slug {
                locale
                value
              }
            }
            ",
            .variables = New With {
                .company = Nothing,
                .district = New List(Of String)(),
                .employment = New List(Of String)() From {"PartTime"},
                .fromWorkingDaysPerWeek = Nothing,
                .fromWorkingHoursPerDay = Nothing,
                .hourlyRate = Nothing,
                .jobType = New List(Of String)(),
                .latlng = Nothing,
                .limit = 20,
                .monthlyRate = Nothing,
                .offset = offset,
                .term = "",
                .workingHour = New List(Of String)()
            }
        }
        ' Test Url
        'Dim apiUrl As String = "http://10.0.21.24:8089/v1/seek"

        Dim apiUrl As String = "https://api.moovup.com/v2/seeker"

        Using httpClient As New HttpClient()

            httpClient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", bearerToken)
            Dim jsonRequestData As String = JsonConvert.SerializeObject(requestData)
            Dim content As New StringContent(jsonRequestData, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)

            If response.IsSuccessStatusCode Then
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                'Debug.WriteLine("############ responseBody: ############### ")
                'Debug.WriteLine(responseBody)
                'Job_Description_RichTextBox.Text = responseBody
                Return responseBody
            Else
                'Debug.WriteLine("http status code : " & response.StatusCode)
                MsgBox("查詢失敗! Http status code : " & response.StatusCode)
                'Job_Description_RichTextBox.Text = response.StatusCode.ToString()
            End If
        End Using


        Return "error"

    End Function

    Public Async Function Submit_Get_Job_Detail_API_Request(job_Id As String) As Task(Of String)
        Debug.WriteLine("Get Job Detail By Id : " + job_Id)


        Dim requestData As New With {
            .query = "query GetJobsByIDs (  $ids: [ID]) {  get_jobs (    _id: $ids  ) {    ...jobFragmentFull  }}fragment jobFragmentFull on Job {  published_at  _id  _updated_at  address {    _id    address    district_name    district_short_code    lat    lng  }  address_on_map  allowances {    description    name  }  attributes {    category    category_display_sequence    name    name_display_sequence  }  alternative_sat  career_level  cert  company {    _id    about    company_logo_medium    company_logo_thumbnail    name  }  education_requirement {    category    level    name  }  employment  end_date  from_hourly_rate  from_monthly_rate  from_working_days_per_week  from_working_hours_per_day  job_description  job_name  job_types {    category    name    short_code  }  shift_required  skill {    name  }  slug {    locale    value  }  spoken_skill {    level    name  }  start_date  to_hourly_rate  to_monthly_rate  to_working_days_per_week  to_working_hours_per_day  vacancy  working_hour {    _id    day_of_week    end_time    start_time  }  written_skill {    level    name  }  state  is_applied  is_closed  is_suspended}",
            .variables = New With {
                .ids = New List(Of String) From {job_Id}
            }
        }

        Dim apiUrl As String = "https://api.moovup.com/v2/seeker"

        Using httpClient As New HttpClient()

            httpClient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", bearerToken)
            Dim jsonRequestData As String = JsonConvert.SerializeObject(requestData)
            Dim content As New StringContent(jsonRequestData, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)

            If response.IsSuccessStatusCode Then
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Debug.WriteLine("############ responseBody: ############### ")
                Debug.WriteLine(responseBody)
                Job_Description_RichTextBox.Text = responseBody
                Return responseBody
            Else
                Debug.WriteLine("http status code : " & response.StatusCode)
                Job_Description_RichTextBox.Text = response.StatusCode.ToString()
            End If

        End Using


        Return "error"

    End Function




    Public Shared Async Function Delay_msec(msec As Integer) As Task
        Await Task.Delay(msec)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check if Folder exists
        If Not Directory.Exists(JobCollectionDir) Then
            Directory.CreateDirectory(JobCollectionDir)
        End If

        'Render job collection combobox
        Dim files() As String = IO.Directory.GetFiles(JobCollectionDir)
        For Each file As String In files
            Debug.WriteLine(file)
            If Path.GetExtension(file) = ".txt" Then
                Dim myfile = Path.GetFileNameWithoutExtension(file)
                JobCollectionRawDataFiles_ComboBox.Items.Add(myfile)
            End If
        Next



    End Sub

    Private Sub JobCollectionRawDataFiles_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobCollectionRawDataFiles_ComboBox.SelectedIndexChanged
        Try

            JobCollection_ListBox.Items.Clear()
            Dim filePath = JobCollectionDir + "\" + JobCollectionRawDataFiles_ComboBox.Text + ".txt"
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Debug.WriteLine(line)
                    JobCollection_ListBox.Items.Add(line)

                End While
            End Using
        Catch ex As Exception
            Debug.WriteLine("readfile error：" & ex.Message)
        End Try

    End Sub

    Private Sub Query_All_Jobs_Detail_By_Id_Button_Click(sender As Object, e As EventArgs) Handles Query_All_Jobs_Detail_By_Id_Button.Click
        MsgBox("Not Yet implemented")
    End Sub



End Class
