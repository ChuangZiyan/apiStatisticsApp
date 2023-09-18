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
        Me.JobCollection_ListBox = New System.Windows.Forms.ListBox()
        Me.Submit_Query_Button = New System.Windows.Forms.Button()
        Me.Job_Description_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Query_All_Jobs_Detail_By_Id_Button = New System.Windows.Forms.Button()
        Me.JobCollectionRawDataFiles_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Job_Searching_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Progress_Label = New System.Windows.Forms.Label()
        Me.Label_ttt = New System.Windows.Forms.Label()
        Me.Job_Searching_Status_Label = New System.Windows.Forms.Label()
        Me.Total_Completed_Dist_Label = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JobCollection_ListBox
        '
        Me.JobCollection_ListBox.FormattingEnabled = True
        Me.JobCollection_ListBox.ItemHeight = 19
        Me.JobCollection_ListBox.Location = New System.Drawing.Point(32, 178)
        Me.JobCollection_ListBox.Name = "JobCollection_ListBox"
        Me.JobCollection_ListBox.Size = New System.Drawing.Size(472, 346)
        Me.JobCollection_ListBox.TabIndex = 0
        '
        'Submit_Query_Button
        '
        Me.Submit_Query_Button.Location = New System.Drawing.Point(180, 54)
        Me.Submit_Query_Button.Name = "Submit_Query_Button"
        Me.Submit_Query_Button.Size = New System.Drawing.Size(122, 29)
        Me.Submit_Query_Button.TabIndex = 1
        Me.Submit_Query_Button.Text = "送出並生成檔案"
        Me.Submit_Query_Button.UseVisualStyleBackColor = True
        '
        'Job_Description_RichTextBox
        '
        Me.Job_Description_RichTextBox.Location = New System.Drawing.Point(522, 154)
        Me.Job_Description_RichTextBox.Name = "Job_Description_RichTextBox"
        Me.Job_Description_RichTextBox.Size = New System.Drawing.Size(457, 370)
        Me.Job_Description_RichTextBox.TabIndex = 4
        Me.Job_Description_RichTextBox.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(522, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "工作敘述 (原始資料) : "
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(121, 55)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(53, 27)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "間隔秒數 : "
        '
        'Query_All_Jobs_Detail_By_Id_Button
        '
        Me.Query_All_Jobs_Detail_By_Id_Button.Location = New System.Drawing.Point(852, 94)
        Me.Query_All_Jobs_Detail_By_Id_Button.Name = "Query_All_Jobs_Detail_By_Id_Button"
        Me.Query_All_Jobs_Detail_By_Id_Button.Size = New System.Drawing.Size(127, 29)
        Me.Query_All_Jobs_Detail_By_Id_Button.TabIndex = 13
        Me.Query_All_Jobs_Detail_By_Id_Button.Text = "依檔案查詢敘述"
        Me.Query_All_Jobs_Detail_By_Id_Button.UseVisualStyleBackColor = True
        '
        'JobCollectionRawDataFiles_ComboBox
        '
        Me.JobCollectionRawDataFiles_ComboBox.FormattingEnabled = True
        Me.JobCollectionRawDataFiles_ComboBox.Location = New System.Drawing.Point(522, 96)
        Me.JobCollectionRawDataFiles_ComboBox.Name = "JobCollectionRawDataFiles_ComboBox"
        Me.JobCollectionRawDataFiles_ComboBox.Size = New System.Drawing.Size(324, 27)
        Me.JobCollectionRawDataFiles_ComboBox.TabIndex = 12
        '
        'Job_Searching_ProgressBar
        '
        Me.Job_Searching_ProgressBar.Location = New System.Drawing.Point(32, 122)
        Me.Job_Searching_ProgressBar.Name = "Job_Searching_ProgressBar"
        Me.Job_Searching_ProgressBar.Size = New System.Drawing.Size(410, 29)
        Me.Job_Searching_ProgressBar.TabIndex = 14
        '
        'Progress_Label
        '
        Me.Progress_Label.AutoSize = True
        Me.Progress_Label.Location = New System.Drawing.Point(233, 94)
        Me.Progress_Label.Name = "Progress_Label"
        Me.Progress_Label.Size = New System.Drawing.Size(35, 19)
        Me.Progress_Label.TabIndex = 16
        Me.Progress_Label.Text = "0 %"
        '
        'Label_ttt
        '
        Me.Label_ttt.AutoSize = True
        Me.Label_ttt.Location = New System.Drawing.Point(32, 94)
        Me.Label_ttt.Name = "Label_ttt"
        Me.Label_ttt.Size = New System.Drawing.Size(80, 19)
        Me.Label_ttt.TabIndex = 17
        Me.Label_ttt.Text = "任務狀態 : "
        '
        'Job_Searching_Status_Label
        '
        Me.Job_Searching_Status_Label.AutoSize = True
        Me.Job_Searching_Status_Label.Location = New System.Drawing.Point(118, 94)
        Me.Job_Searching_Status_Label.Name = "Job_Searching_Status_Label"
        Me.Job_Searching_Status_Label.Size = New System.Drawing.Size(54, 19)
        Me.Job_Searching_Status_Label.TabIndex = 18
        Me.Job_Searching_Status_Label.Text = "等待中"
        '
        'Total_Completed_Dist_Label
        '
        Me.Total_Completed_Dist_Label.AutoSize = True
        Me.Total_Completed_Dist_Label.Location = New System.Drawing.Point(448, 132)
        Me.Total_Completed_Dist_Label.Name = "Total_Completed_Dist_Label"
        Me.Total_Completed_Dist_Label.Size = New System.Drawing.Size(43, 19)
        Me.Total_Completed_Dist_Label.TabIndex = 19
        Me.Total_Completed_Dist_Label.Text = "(0/0)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 600)
        Me.Controls.Add(Me.Total_Completed_Dist_Label)
        Me.Controls.Add(Me.Job_Searching_Status_Label)
        Me.Controls.Add(Me.Label_ttt)
        Me.Controls.Add(Me.Progress_Label)
        Me.Controls.Add(Me.Job_Searching_ProgressBar)
        Me.Controls.Add(Me.Query_All_Jobs_Detail_By_Id_Button)
        Me.Controls.Add(Me.JobCollectionRawDataFiles_ComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Job_Description_RichTextBox)
        Me.Controls.Add(Me.Submit_Query_Button)
        Me.Controls.Add(Me.JobCollection_ListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
