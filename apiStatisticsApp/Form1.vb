Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Public currentDirectory As String = My.Application.Info.DirectoryPath

    Private Async Sub Submit_Query_Button_Click(sender As Object, e As EventArgs) Handles Submit_Query_Button.Click


        For offset As Integer = 0 To Data_Query_Limit_NumericUpDown.Value - 1 Step 20
            Debug.WriteLine("Offset : " & offset & " Limit : " & offset + 20)

        Next





        Dim jsonString = Await Submit_API_Request_And_Generate_File(0, 5)
        Dim jsonObject As JObject = JObject.Parse(jsonString)
        Dim resultArray As JArray = jsonObject.SelectToken("data.job_search.result")

        For Each item As JObject In resultArray
            Debug.WriteLine(item.SelectToken("company.name"))
            Data_URL_ListBox.Items.Add(item.SelectToken("company.name"))
        Next



        'Data_URL_ListBox.Items.Add("Test1")
    End Sub



    Public Async Function Submit_API_Request_And_Generate_File(offset As Integer, limit As Integer) As Task(Of String)

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
                .limit = limit,
                .monthlyRate = Nothing,
                .offset = offset,
                .term = "",
                .workingHour = New List(Of String)()
            }
        }
        ' Test Url
        Dim apiUrl As String = "http://10.0.21.24:8089/v1/seek"


        'Dim apiUrl As String = "https://api.moovup.com/v2/seeker"

        Dim bearerToken As String = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiI1MGJkOTdiOC1iZjg1LTRhYzQtOTY4ZS01M2Q5NGMzYjJjMTgiLCJpYXQiOjE2OTQ1MDYwNTQsImlzcyI6Im1vb3Z1cCIsInN1YiI6IjdmN2JlMTZjLTVjMmUtNGEzMC05ZTQxLTA4ZDZkYjA1M2VjMCIsImFub255bW91cz8iOnRydWV9.2y2CpTlXOdvoGQ5ukfTag8IvIvyMMVTum21mZeZgV9A"

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
End Class
