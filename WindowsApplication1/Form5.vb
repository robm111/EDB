Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim transFile As String
        Dim deletedFile As String
        Dim reportFolder As String
        reportFolder = "c:\edb\reports"


        transFile = My.Computer.FileSystem.ReadAllText("c:\edb\reports\today.dlv")
        deletedFile = My.Computer.FileSystem.ReadAllText("c:\edb\reports\today.nas")
        TextBox1.Text = transFile
        TextBox2.Text = deletedFile


        My.Computer.FileSystem.CurrentDirectory = "c:\edb\reports"
        Dim workingPath As String
        workingPath = "c:\edb\reports"
        For Each foundFile As String In (
                System.IO.Directory.GetFiles("c:\edb\reports\", "*.dlv", IO.SearchOption.TopDirectoryOnly))
            Dim filePath As String = foundFile
            Dim slashPosition As Integer = filePath.LastIndexOf("\")
            Dim filenameOnly As String = filePath.Substring(slashPosition + 1)
            foundFile = filenameOnly
            ListBox1.Items.Add(foundFile)
            TextBox3.Text = My.Computer.FileSystem.CurrentDirectory
        Next

        My.Computer.FileSystem.CurrentDirectory = reportFolder
        For Each foundFile As String In (
            System.IO.Directory.GetFiles("c:\edb\reports\", "*.nas", IO.SearchOption.TopDirectoryOnly))
            'FileIO.SearchOption.SearchTopLevelOnly, "*.nas")
            Dim filePath As String = foundFile
            Dim slashPosition As Integer = filePath.LastIndexOf("\")
            Dim filenameOnly As String = filePath.Substring(slashPosition + 1)
            foundFile = filenameOnly
            ListBox2.Items.Add(foundFile)
            TextBox4.Text = My.Computer.FileSystem.CurrentDirectory
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        On Error GoTo Welp
        Dim deletedFile As String

        deletedFile = My.Computer.FileSystem.ReadAllText(ListBox2.SelectedItem)
        TextBox2.Text = deletedFile

ExitHere:
        On Error Resume Next
        Exit Sub
Welp:
        Select Case Err.Number
            ' Add cases for each
            ' error number you want to trap.
            Case Else
                ' Add "last-ditch" error handler.
                MessageBox.Show("Error: " & Err.Description)
        End Select
        Resume ExitHere
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error GoTo Welp
        Dim deliveredTrans As String

        deliveredTrans = My.Computer.FileSystem.ReadAllText(ListBox1.SelectedItem)
        TextBox1.Text = deliveredTrans

ExitHere:
        On Error Resume Next
        Exit Sub

Welp:
        Select Case Err.Number
            ' Add cases for each
            ' error number you want to trap.
            Case Else
                ' Add "last-ditch" error handler.
                MessageBox.Show("Error: " & Err.Description)
        End Select
        Resume ExitHere

    End Sub
End Class