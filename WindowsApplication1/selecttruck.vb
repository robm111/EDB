Public Class selecttruck
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ListView2.Items.Clear()
        Dim driver1 As New ListViewItem(1)
        driver1.SubItems.Add(TextBox6.Text)
        driver1.SubItems.Add("")
        driver1.SubItems.Add("")
        driver1.SubItems.Add("")
        Form1.ListView2.Items.Add(driver1)
        Dim driver2 As New ListViewItem(2)
        driver2.SubItems.Add(TextBox5.Text)
        driver2.SubItems.Add("")
        driver2.SubItems.Add("")
        driver2.SubItems.Add("")
        Form1.ListView2.Items.Add(driver2)
        Dim driver3 As New ListViewItem(3)
        driver3.SubItems.Add(TextBox4.Text)
        driver3.SubItems.Add("")
        driver3.SubItems.Add("")
        driver3.SubItems.Add("")
        Form1.ListView2.Items.Add(driver3)

        Me.Close()
    End Sub
End Class