<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        JobCollection_ListBox = New ListBox()
        Submit_Query_Button = New Button()
        Job_Description_RichTextBox = New RichTextBox()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label5 = New Label()
        Query_All_Jobs_Detail_By_Id_Button = New Button()
        JobCollectionRawDataFiles_ComboBox = New ComboBox()
        Job_Searching_ProgressBar = New ProgressBar()
        Progress_Label = New Label()
        Label_ttt = New Label()
        Job_Searching_Status_Label = New Label()
        Total_Completed_Dist_Label = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' JobCollection_ListBox
        ' 
        JobCollection_ListBox.FormattingEnabled = True
        JobCollection_ListBox.ItemHeight = 19
        JobCollection_ListBox.Location = New Point(32, 178)
        JobCollection_ListBox.Name = "JobCollection_ListBox"
        JobCollection_ListBox.Size = New Size(472, 346)
        JobCollection_ListBox.TabIndex = 0
        ' 
        ' Submit_Query_Button
        ' 
        Submit_Query_Button.Location = New Point(180, 54)
        Submit_Query_Button.Name = "Submit_Query_Button"
        Submit_Query_Button.Size = New Size(122, 29)
        Submit_Query_Button.TabIndex = 1
        Submit_Query_Button.Text = "送出並生成檔案"
        Submit_Query_Button.UseVisualStyleBackColor = True
        ' 
        ' Job_Description_RichTextBox
        ' 
        Job_Description_RichTextBox.Location = New Point(522, 154)
        Job_Description_RichTextBox.Name = "Job_Description_RichTextBox"
        Job_Description_RichTextBox.Size = New Size(457, 370)
        Job_Description_RichTextBox.TabIndex = 4
        Job_Description_RichTextBox.Text = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(522, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 19)
        Label4.TabIndex = 9
        Label4.Text = "工作敘述 (原始資料) : "
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(121, 55)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(53, 27)
        NumericUpDown1.TabIndex = 10
        NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 19)
        Label5.TabIndex = 11
        Label5.Text = "間隔秒數 : "
        ' 
        ' Query_All_Jobs_Detail_By_Id_Button
        ' 
        Query_All_Jobs_Detail_By_Id_Button.Location = New Point(852, 94)
        Query_All_Jobs_Detail_By_Id_Button.Name = "Query_All_Jobs_Detail_By_Id_Button"
        Query_All_Jobs_Detail_By_Id_Button.Size = New Size(127, 29)
        Query_All_Jobs_Detail_By_Id_Button.TabIndex = 13
        Query_All_Jobs_Detail_By_Id_Button.Text = "依檔案查詢敘述"
        Query_All_Jobs_Detail_By_Id_Button.UseVisualStyleBackColor = True
        ' 
        ' JobCollectionRawDataFiles_ComboBox
        ' 
        JobCollectionRawDataFiles_ComboBox.FormattingEnabled = True
        JobCollectionRawDataFiles_ComboBox.Location = New Point(522, 96)
        JobCollectionRawDataFiles_ComboBox.Name = "JobCollectionRawDataFiles_ComboBox"
        JobCollectionRawDataFiles_ComboBox.Size = New Size(324, 27)
        JobCollectionRawDataFiles_ComboBox.TabIndex = 12
        ' 
        ' Job_Searching_ProgressBar
        ' 
        Job_Searching_ProgressBar.Location = New Point(32, 122)
        Job_Searching_ProgressBar.Name = "Job_Searching_ProgressBar"
        Job_Searching_ProgressBar.Size = New Size(410, 29)
        Job_Searching_ProgressBar.TabIndex = 14
        ' 
        ' Progress_Label
        ' 
        Progress_Label.AutoSize = True
        Progress_Label.Location = New Point(407, 94)
        Progress_Label.Name = "Progress_Label"
        Progress_Label.Size = New Size(35, 19)
        Progress_Label.TabIndex = 16
        Progress_Label.Text = "0 %"
        ' 
        ' Label_ttt
        ' 
        Label_ttt.AutoSize = True
        Label_ttt.Location = New Point(32, 94)
        Label_ttt.Name = "Label_ttt"
        Label_ttt.Size = New Size(80, 19)
        Label_ttt.TabIndex = 17
        Label_ttt.Text = "任務狀態 : "
        ' 
        ' Job_Searching_Status_Label
        ' 
        Job_Searching_Status_Label.AutoSize = True
        Job_Searching_Status_Label.Location = New Point(118, 94)
        Job_Searching_Status_Label.Name = "Job_Searching_Status_Label"
        Job_Searching_Status_Label.Size = New Size(54, 19)
        Job_Searching_Status_Label.TabIndex = 18
        Job_Searching_Status_Label.Text = "等待中"
        ' 
        ' Total_Completed_Dist_Label
        ' 
        Total_Completed_Dist_Label.AutoSize = True
        Total_Completed_Dist_Label.Location = New Point(448, 132)
        Total_Completed_Dist_Label.Name = "Total_Completed_Dist_Label"
        Total_Completed_Dist_Label.Size = New Size(43, 19)
        Total_Completed_Dist_Label.TabIndex = 19
        Total_Completed_Dist_Label.Text = "(0/0)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1004, 600)
        Controls.Add(Total_Completed_Dist_Label)
        Controls.Add(Job_Searching_Status_Label)
        Controls.Add(Label_ttt)
        Controls.Add(Progress_Label)
        Controls.Add(Job_Searching_ProgressBar)
        Controls.Add(Query_All_Jobs_Detail_By_Id_Button)
        Controls.Add(JobCollectionRawDataFiles_ComboBox)
        Controls.Add(Label5)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label4)
        Controls.Add(Job_Description_RichTextBox)
        Controls.Add(Submit_Query_Button)
        Controls.Add(JobCollection_ListBox)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents JobCollection_ListBox As ListBox
    Friend WithEvents Submit_Query_Button As Button
    Friend WithEvents Job_Description_RichTextBox As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Query_All_Jobs_Detail_By_Id_Button As Button
    Friend WithEvents JobCollectionRawDataFiles_ComboBox As ComboBox
    Friend WithEvents Job_Searching_ProgressBar As ProgressBar
    Friend WithEvents Progress_Label As Label
    Friend WithEvents Label_ttt As Label
    Friend WithEvents Job_Searching_Status_Label As Label
    Friend WithEvents Total_Completed_Dist_Label As Label
End Class
