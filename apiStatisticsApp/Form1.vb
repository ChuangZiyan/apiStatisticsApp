Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Collections
Imports System.Text.RegularExpressions

Public Class Form1



    Public currentDirectory As String = My.Application.Info.DirectoryPath
    Public JobCollectionDir As String = currentDirectory + "\JobCollectionRawData"
    Public bearerToken As String = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiI1MGJkOTdiOC1iZjg1LTRhYzQtOTY4ZS01M2Q5NGMzYjJjMTgiLCJpYXQiOjE2OTQ1MDYwNTQsImlzcyI6Im1vb3Z1cCIsInN1YiI6IjdmN2JlMTZjLTVjMmUtNGEzMC05ZTQxLTA4ZDZkYjA1M2VjMCIsImFub255bW91cz8iOnRydWV9.2y2CpTlXOdvoGQ5ukfTag8IvIvyMMVTum21mZeZgV9A"

    Private Async Sub Submit_Query_Button_Click(sender As Object, e As EventArgs) Handles Submit_Query_Button.Click

        Dim filePath As String = JobCollectionDir + "\JobCollectionRawData_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt"



        Dim districtList As New List(Of String) From {
            "000006", "000007", "000008", "000009", "000010", "000011", "000012", "000013", "000014", "000015",
            "000016", "000017", "000018", "000019", "000020", "000021", "000022", "000023", "000024", "000025",
            "000026", "000027", "000028", "000029", "000030", "000031", "000032", "000033", "000034", "000035",
            "000036", "000037"}


        ' For test
        Dim districtList_test As New List(Of String) From {"000037", "000008"}

        Dim dist_index As Integer = 0

        For Each dist In districtList
            Debug.WriteLine("#####" & dist)
            dist_index += 1
            Total_Completed_Dist_Label.Text = "(" & dist_index & "/" & districtList.Count & ")"
            Job_Searching_Status_Label.Text = "查詢地區 " + dist + " 中..."


            'Continue For
            Dim parmDistList As New List(Of String) From {dist}

            Dim totalDataCount = Await Submit_Get_Jobs_Collection_API_Request(20, parmDistList)

            Dim totalDataCountJsonObject As JObject = JObject.Parse(totalDataCount)

            Dim dist_total_data_count As Integer = totalDataCountJsonObject.SelectToken("data.job_search.total")



            ' Reset progress bar
            Dim total_run As Integer = Math.Ceiling(dist_total_data_count / 20)
            Job_Searching_ProgressBar.Value = 0
            Progress_Label.Text = "0%"

            ' start query
            Dim run As Integer = 0
            For offset As Integer = 0 To dist_total_data_count - 1 Step 20
                Debug.WriteLine("Offset : " & offset)

                ' Get jobs collection
                Dim jsonString = Await Submit_Get_Jobs_Collection_API_Request(offset, parmDistList)

                ' If get error exit the sub
                If jsonString = "error" Then
                    MsgBox("發生其他錯誤，停止查詢")
                    Exit Sub
                End If

                Dim jobsIDjsonObject As JObject = JObject.Parse(jsonString)
                Dim jobsresultArray As JArray = jobsIDjsonObject.SelectToken("data.job_search.result")

                Dim jobIdList As New List(Of String)

                ' Add job id to list
                For Each item As JObject In jobsresultArray
                    jobIdList.Add(item.SelectToken("_id").ToString())
                Next

                ' wait 500 msec before calling next api
                Await Delay_msec(500)

                ' Get Jobs detail by Id array
                Dim jobsDetailResultString = Await Submit_Get_Job_Detail_API_Request(jobIdList)
                Dim jobsDetailJsonObject As JObject = JObject.Parse(jobsDetailResultString)
                Dim jobsDetailResultArray As JArray = jobsDetailJsonObject.SelectToken("data.get_jobs")


                ' Save to file line by line
                Using writer As New StreamWriter(filePath, True)

                    For Each item As JObject In jobsDetailResultArray

                        Dim job_Id = item.SelectToken("_id").ToString()
                        Dim job_company_name = item.SelectToken("company.name").ToString()
                        Dim job_description = item.SelectToken("job_description").ToString() '.Replace(vbCrLf, "").Replace(vbLf, "")


                        'Filter out phone numbers
                        Dim phoneNumberPattern As String = "(\d{8})" ' match whatsapp
                        Dim phoneNumber_regex As New Regex(phoneNumberPattern)
                        Dim number_match As Match = phoneNumber_regex.Match(job_description)

                        Dim phoneNumber = "N/A"

                        If number_match.Success Then
                            phoneNumber = number_match.Value
                        End If

                        'Filter out Email
                        Dim emailPattern As String = "\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b"
                        Dim email_regex As New Regex(emailPattern)
                        Dim email_match As Match = email_regex.Match(job_description)

                        Dim email_str = "N/A"

                        If email_match.Success Then
                            email_str = email_match.Value
                        End If

                        Dim job_item = job_Id + "&nbsp;" + job_company_name + "&nbsp;" + email_str + "&nbsp;" + phoneNumber

                        'JobCollection_ListBox.Items.Add(job_item)
                        writer.WriteLine(job_item)
                    Next
                    writer.Close()
                End Using


                ' Render progress bar
                run += 1
                Dim my_progress = Math.Ceiling(run / total_run * 100)
                Job_Searching_ProgressBar.Value = my_progress
                Progress_Label.Text = my_progress.ToString() + "%"

                If total_run > run Then
                    Await Delay_msec(NumericUpDown1.Value * 1000)
                End If

            Next


        Next

        'Exit Sub
        Job_Searching_Status_Label.Text = "任務完成"
        'Data_URL_ListBox.Items.Add("Test1")
    End Sub



    Public Async Function Submit_Get_Jobs_Collection_API_Request(offset As Integer, distList As List(Of String)) As Task(Of String)

        ' employment : FullTime | PartTime

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
                .district = distList,
                .employment = New List(Of String)() From {},
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

    Public Async Function Submit_Get_Job_Detail_API_Request(job_Ids As List(Of String)) As Task(Of String)



        Dim requestData As New With {
            .query = "query GetJobsByIDs (  $ids: [ID]) {  get_jobs (    _id: $ids  ) {    ...jobFragmentFull  }}fragment jobFragmentFull on Job {  published_at  _id  _updated_at  address {    _id    address    district_name    district_short_code    lat    lng  }  address_on_map  allowances {    description    name  }  attributes {    category    category_display_sequence    name    name_display_sequence  }  alternative_sat  career_level  cert  company {    _id    about    company_logo_medium    company_logo_thumbnail    name  }  education_requirement {    category    level    name  }  employment  end_date  from_hourly_rate  from_monthly_rate  from_working_days_per_week  from_working_hours_per_day  job_description  job_name  job_types {    category    name    short_code  }  shift_required  skill {    name  }  slug {    locale    value  }  spoken_skill {    level    name  }  start_date  to_hourly_rate  to_monthly_rate  to_working_days_per_week  to_working_hours_per_day  vacancy  working_hour {    _id    day_of_week    end_time    start_time  }  written_skill {    level    name  }  state  is_applied  is_closed  is_suspended}",
            .variables = New With {
                .ids = job_Ids'New List(Of String) From {"6b73fee4-700c-49f1-8382-7f9160bd7490", "e5cc9a11-f7b4-4818-a17d-e1ff95e6885d"}
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
                'Job_Description_RichTextBox.Text = responseBody
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

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Async Sub Query_All_Jobs_Detail_By_Id_Button_Click(sender As Object, e As EventArgs) Handles Query_All_Jobs_Detail_By_Id_Button.Click
        'MsgBox("Not Yet implemented")



        'Dim jsonString = Await Submit_Get_Job_Detail_API_Request()
        'Job_Description_RichTextBox.Text = jsonString


    End Sub



End Class
