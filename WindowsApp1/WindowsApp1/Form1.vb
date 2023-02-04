Imports System.IO
Imports iTextSharp.text
Imports Newtonsoft.Json


Public Class Form1
    Dim FilePath As String = System.IO.Path.Combine(System.IO.Directory.GetParent(Application.ExecutablePath).FullName, "../../marco-garcia.json")
    Dim clientInformation As Info

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loadJson.Click

        Dim jsonString As String = File.ReadAllText(FilePath)
        clientInformation = JsonConvert.DeserializeObject(Of Info)(jsonString)

        valueName.Text = clientInformation.firstName + " " + clientInformation.lastName
        valueEmail.Text = clientInformation.email
        valuePhoneNumber.Text = clientInformation.phoneNumber
        valueBirthday.Text = clientInformation.birthDay
        valueGender.Text = clientInformation.gender
        valueAddress.Text = clientInformation.address
        valueObjective.Text = clientInformation.objective
        valueTertiary.Text = clientInformation.school
        valueCourse.Text = clientInformation.course

        generatePDF.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles generatePDF.Click
        Dim pdfWriter As New Document()

        Dim fileName = clientInformation.firstName + "_" + clientInformation.lastName + ".pdf"
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName)
        Dim pdfResult As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfWriter, New FileStream(fileName, FileMode.Create))

        pdfWriter.Open()

        Dim name As Paragraph = New Paragraph(clientInformation.firstName + " " + clientInformation.lastName)
        name.Font.Size = 25
        name.SpacingAfter = 50

        Dim objective As Paragraph = New Paragraph("Objective:   " + clientInformation.objective)
        objective.SpacingAfter = 30

        Dim contact As Paragraph = New Paragraph("Contact Details")
        contact.Font.Size = 20
        contact.SpacingAfter = 10
        Dim email As Paragraph = New Paragraph("Email:   " + clientInformation.email)
        Dim phoneNumber As Paragraph = New Paragraph("Phone number:   " + clientInformation.phoneNumber)
        Dim address As Paragraph = New Paragraph("Address:   " + clientInformation.address)
        address.SpacingAfter = 30

        Dim schoolDetails As Paragraph = New Paragraph("Tertiary")
        schoolDetails.Font.Size = 20
        schoolDetails.SpacingAfter = 10
        Dim course As Paragraph = New Paragraph("Course: " + clientInformation.course)
        Dim tertiary As Paragraph = New Paragraph("School: " + clientInformation.school)
        tertiary.SpacingAfter = 30

        Dim skills As Paragraph = New Paragraph("Skills:")
        skills.Font.Size = 20
        skills.SpacingAfter = 10
        Dim skillOne As Paragraph = New Paragraph("- " + clientInformation.skillOne)
        Dim skillTwo As Paragraph = New Paragraph("- " + clientInformation.skillTwo)

        pdfWriter.Add(name)

        pdfWriter.Add(objective)

        pdfWriter.Add(contact)
        pdfWriter.Add(email)
        pdfWriter.Add(phoneNumber)
        pdfWriter.Add(address)

        pdfWriter.Add(schoolDetails)
        pdfWriter.Add(course)
        pdfWriter.Add(tertiary)

        pdfWriter.Add(skills)
        pdfWriter.Add(skillOne)
        pdfWriter.Add(skillTwo)
        pdfWriter.Close()

        MessageBox.Show("Resume successfully created!")
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generatePDF.Enabled = False
    End Sub
End Class

Public Class Info
    Public Property firstName As String
    Public Property lastName As String
    Public Property email As String
    Public Property phoneNumber As String
    Public Property gender As String
    Public Property birthDay As String
    Public Property address As String
    Public Property objective As String
    Public Property course As String
    Public Property skillOne As String
    Public Property skillTwo As String
    Public Property school As String
End Class
