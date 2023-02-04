<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.loadJson = New System.Windows.Forms.Button()
        Me.generatePDF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.valueName = New System.Windows.Forms.TextBox()
        Me.valuePhoneNumber = New System.Windows.Forms.TextBox()
        Me.valueEmail = New System.Windows.Forms.TextBox()
        Me.valueGender = New System.Windows.Forms.TextBox()
        Me.valueBirthday = New System.Windows.Forms.TextBox()
        Me.valueCourse = New System.Windows.Forms.TextBox()
        Me.valueTertiary = New System.Windows.Forms.TextBox()
        Me.valueObjective = New System.Windows.Forms.TextBox()
        Me.valueAddress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'loadJson
        '
        Me.loadJson.Location = New System.Drawing.Point(175, 356)
        Me.loadJson.Name = "loadJson"
        Me.loadJson.Size = New System.Drawing.Size(126, 23)
        Me.loadJson.TabIndex = 0
        Me.loadJson.Text = "Load JSON"
        Me.loadJson.UseVisualStyleBackColor = True
        '
        'generatePDF
        '
        Me.generatePDF.Location = New System.Drawing.Point(435, 356)
        Me.generatePDF.Name = "generatePDF"
        Me.generatePDF.Size = New System.Drawing.Size(127, 23)
        Me.generatePDF.TabIndex = 1
        Me.generatePDF.Text = "Generate PDF"
        Me.generatePDF.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Birthday:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Gender:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tertiary:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(356, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Course:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(356, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Objective:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(684, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "/"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(320, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 25)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Resume Creator"
        '
        'valueName
        '
        Me.valueName.Location = New System.Drawing.Point(103, 92)
        Me.valueName.Name = "valueName"
        Me.valueName.ReadOnly = True
        Me.valueName.Size = New System.Drawing.Size(100, 20)
        Me.valueName.TabIndex = 14
        '
        'valuePhoneNumber
        '
        Me.valuePhoneNumber.Location = New System.Drawing.Point(143, 163)
        Me.valuePhoneNumber.Name = "valuePhoneNumber"
        Me.valuePhoneNumber.ReadOnly = True
        Me.valuePhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.valuePhoneNumber.TabIndex = 18
        '
        'valueEmail
        '
        Me.valueEmail.Location = New System.Drawing.Point(103, 129)
        Me.valueEmail.Name = "valueEmail"
        Me.valueEmail.ReadOnly = True
        Me.valueEmail.Size = New System.Drawing.Size(100, 20)
        Me.valueEmail.TabIndex = 19
        '
        'valueGender
        '
        Me.valueGender.Location = New System.Drawing.Point(110, 244)
        Me.valueGender.Name = "valueGender"
        Me.valueGender.ReadOnly = True
        Me.valueGender.Size = New System.Drawing.Size(100, 20)
        Me.valueGender.TabIndex = 20
        '
        'valueBirthday
        '
        Me.valueBirthday.Location = New System.Drawing.Point(110, 207)
        Me.valueBirthday.Name = "valueBirthday"
        Me.valueBirthday.ReadOnly = True
        Me.valueBirthday.Size = New System.Drawing.Size(100, 20)
        Me.valueBirthday.TabIndex = 21
        '
        'valueCourse
        '
        Me.valueCourse.Location = New System.Drawing.Point(417, 166)
        Me.valueCourse.Name = "valueCourse"
        Me.valueCourse.ReadOnly = True
        Me.valueCourse.Size = New System.Drawing.Size(100, 20)
        Me.valueCourse.TabIndex = 22
        '
        'valueTertiary
        '
        Me.valueTertiary.Location = New System.Drawing.Point(417, 129)
        Me.valueTertiary.Name = "valueTertiary"
        Me.valueTertiary.ReadOnly = True
        Me.valueTertiary.Size = New System.Drawing.Size(100, 20)
        Me.valueTertiary.TabIndex = 23
        '
        'valueObjective
        '
        Me.valueObjective.Location = New System.Drawing.Point(417, 92)
        Me.valueObjective.Name = "valueObjective"
        Me.valueObjective.ReadOnly = True
        Me.valueObjective.Size = New System.Drawing.Size(100, 20)
        Me.valueObjective.TabIndex = 24
        '
        'valueAddress
        '
        Me.valueAddress.Location = New System.Drawing.Point(110, 281)
        Me.valueAddress.Name = "valueAddress"
        Me.valueAddress.ReadOnly = True
        Me.valueAddress.Size = New System.Drawing.Size(100, 20)
        Me.valueAddress.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 420)
        Me.Controls.Add(Me.valueAddress)
        Me.Controls.Add(Me.valueObjective)
        Me.Controls.Add(Me.valueTertiary)
        Me.Controls.Add(Me.valueCourse)
        Me.Controls.Add(Me.valueBirthday)
        Me.Controls.Add(Me.valueGender)
        Me.Controls.Add(Me.valueEmail)
        Me.Controls.Add(Me.valuePhoneNumber)
        Me.Controls.Add(Me.valueName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.generatePDF)
        Me.Controls.Add(Me.loadJson)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loadJson As Button
    Friend WithEvents generatePDF As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents valueName As TextBox
    Friend WithEvents valuePhoneNumber As TextBox
    Friend WithEvents valueEmail As TextBox
    Friend WithEvents valueGender As TextBox
    Friend WithEvents valueBirthday As TextBox
    Friend WithEvents valueCourse As TextBox
    Friend WithEvents valueTertiary As TextBox
    Friend WithEvents valueObjective As TextBox
    Friend WithEvents valueAddress As TextBox
End Class
