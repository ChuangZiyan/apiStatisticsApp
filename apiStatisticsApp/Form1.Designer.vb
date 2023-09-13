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
        Me.Data_URL_ListBox = New System.Windows.Forms.ListBox()
        Me.Submit_Query_Button = New System.Windows.Forms.Button()
        Me.Data_Query_Limit_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Job_Description_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Data_Query_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_URL_ListBox
        '
        Me.Data_URL_ListBox.FormattingEnabled = True
        Me.Data_URL_ListBox.ItemHeight = 19
        Me.Data_URL_ListBox.Location = New System.Drawing.Point(32, 83)
        Me.Data_URL_ListBox.Name = "Data_URL_ListBox"
        Me.Data_URL_ListBox.Size = New System.Drawing.Size(426, 441)
        Me.Data_URL_ListBox.TabIndex = 0
        '
        'Submit_Query_Button
        '
        Me.Submit_Query_Button.Location = New System.Drawing.Point(364, 49)
        Me.Submit_Query_Button.Name = "Submit_Query_Button"
        Me.Submit_Query_Button.Size = New System.Drawing.Size(94, 29)
        Me.Submit_Query_Button.TabIndex = 1
        Me.Submit_Query_Button.Text = "送出"
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
        Me.Job_Description_RichTextBox.Location = New System.Drawing.Point(489, 154)
        Me.Job_Description_RichTextBox.Name = "Job_Description_RichTextBox"
        Me.Job_Description_RichTextBox.Size = New System.Drawing.Size(472, 370)
        Me.Job_Description_RichTextBox.TabIndex = 4
        Me.Job_Description_RichTextBox.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(489, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "公司名稱 : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(575, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(386, 27)
        Me.TextBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "聯繫方式 : "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(575, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(386, 27)
        Me.TextBox2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "工作敘述 (原始資料) : "
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(299, 48)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(53, 27)
        Me.NumericUpDown1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "間隔秒數 : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 600)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Job_Description_RichTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Data_Query_Limit_NumericUpDown)
        Me.Controls.Add(Me.Submit_Query_Button)
        Me.Controls.Add(Me.Data_URL_ListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Data_Query_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data_URL_ListBox As ListBox
    Friend WithEvents Submit_Query_Button As Button
    Friend WithEvents Data_Query_Limit_NumericUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Job_Description_RichTextBox As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
End Class
