﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Data_Query_Limit_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Job_Description_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.JobCollectionRawDataFiles_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Query_All_Jobs_Detail_By_Id_Button = New System.Windows.Forms.Button()
        CType(Me.Data_Query_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JobCollection_ListBox
        '
        Me.JobCollection_ListBox.FormattingEnabled = True
        Me.JobCollection_ListBox.ItemHeight = 19
        Me.JobCollection_ListBox.Location = New System.Drawing.Point(32, 121)
        Me.JobCollection_ListBox.Name = "JobCollection_ListBox"
        Me.JobCollection_ListBox.Size = New System.Drawing.Size(472, 403)
        Me.JobCollection_ListBox.TabIndex = 0
        '
        'Submit_Query_Button
        '
        Me.Submit_Query_Button.Location = New System.Drawing.Point(382, 49)
        Me.Submit_Query_Button.Name = "Submit_Query_Button"
        Me.Submit_Query_Button.Size = New System.Drawing.Size(122, 29)
        Me.Submit_Query_Button.TabIndex = 1
        Me.Submit_Query_Button.Text = "送出並生成檔案"
        Me.Submit_Query_Button.UseVisualStyleBackColor = True
        '
        'Data_Query_Limit_NumericUpDown
        '
        Me.Data_Query_Limit_NumericUpDown.Location = New System.Drawing.Point(118, 47)
        Me.Data_Query_Limit_NumericUpDown.Name = "Data_Query_Limit_NumericUpDown"
        Me.Data_Query_Limit_NumericUpDown.Size = New System.Drawing.Size(89, 27)
        Me.Data_Query_Limit_NumericUpDown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "最大筆數 : "
        '
        'Job_Description_RichTextBox
        '
        Me.Job_Description_RichTextBox.Location = New System.Drawing.Point(522, 154)
        Me.Job_Description_RichTextBox.Name = "Job_Description_RichTextBox"
        Me.Job_Description_RichTextBox.Size = New System.Drawing.Size(439, 370)
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
        Me.NumericUpDown1.Location = New System.Drawing.Point(323, 47)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(53, 27)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "間隔秒數 : "
        '
        'JobCollectionRawDataFiles_ComboBox
        '
        Me.JobCollectionRawDataFiles_ComboBox.FormattingEnabled = True
        Me.JobCollectionRawDataFiles_ComboBox.Location = New System.Drawing.Point(32, 83)
        Me.JobCollectionRawDataFiles_ComboBox.Name = "JobCollectionRawDataFiles_ComboBox"
        Me.JobCollectionRawDataFiles_ComboBox.Size = New System.Drawing.Size(344, 27)
        Me.JobCollectionRawDataFiles_ComboBox.TabIndex = 12
        '
        'Query_All_Jobs_Detail_By_Id_Button
        '
        Me.Query_All_Jobs_Detail_By_Id_Button.Location = New System.Drawing.Point(382, 81)
        Me.Query_All_Jobs_Detail_By_Id_Button.Name = "Query_All_Jobs_Detail_By_Id_Button"
        Me.Query_All_Jobs_Detail_By_Id_Button.Size = New System.Drawing.Size(122, 29)
        Me.Query_All_Jobs_Detail_By_Id_Button.TabIndex = 13
        Me.Query_All_Jobs_Detail_By_Id_Button.Text = "依檔案查詢敘述"
        Me.Query_All_Jobs_Detail_By_Id_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 600)
        Me.Controls.Add(Me.Query_All_Jobs_Detail_By_Id_Button)
        Me.Controls.Add(Me.JobCollectionRawDataFiles_ComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Job_Description_RichTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Data_Query_Limit_NumericUpDown)
        Me.Controls.Add(Me.Submit_Query_Button)
        Me.Controls.Add(Me.JobCollection_ListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Data_Query_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents JobCollection_ListBox As ListBox
    Friend WithEvents Submit_Query_Button As Button
    Friend WithEvents Data_Query_Limit_NumericUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Job_Description_RichTextBox As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents JobCollectionRawDataFiles_ComboBox As ComboBox
    Friend WithEvents Query_All_Jobs_Detail_By_Id_Button As Button
End Class
