Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("No customer/stop exists.")
            GoTo Nopes
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("No invoice number exists.")
            GoTo Nopes
        End If
        If String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("No ETA exists.")
            GoTo Nopes
        End If

        Dim item As New ListViewItem(TextBox3.Text)
        item.SubItems.Add(TextBox1.Text)
        item.SubItems.Add(TextBox2.Text)
        item.SubItems.Add(System.DateTime.Now.ToString("HH:mm:ss"))
        Form1.ListView1.Items.Add(item)
        Me.Close()

Nopes:
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class