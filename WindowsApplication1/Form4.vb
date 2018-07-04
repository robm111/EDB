Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.ListView2.SelectedItems.Count > 0 Then
            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "1" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(15)

                Form1.ListView2.Items(0).SubItems(4).Text = ETRf
                Form1.ListView2.Items(0).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(0).SubItems(3).Text = leavetime

                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "2" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(15)

                Form1.ListView2.Items(1).SubItems(4).Text = ETRf
                Form1.ListView2.Items(1).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(1).SubItems(3).Text = leavetime

                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "3" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(15)

                Form1.ListView2.Items(2).SubItems(4).Text = ETRf
                Form1.ListView2.Items(2).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(2).SubItems(3).Text = leavetime
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Form1.ListView2.SelectedItems.Count > 0 Then
            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "1" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(30)

                Form1.ListView2.Items(0).SubItems(4).Text = ETRf
                Form1.ListView2.Items(0).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(0).SubItems(3).Text = leavetime

                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "2" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(30)

                Form1.ListView2.Items(1).SubItems(4).Text = ETRf
                Form1.ListView2.Items(1).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(1).SubItems(3).Text = leavetime

                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "3" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(30)

                Form1.ListView2.Items(2).SubItems(4).Text = ETRf
                Form1.ListView2.Items(2).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(2).SubItems(3).Text = leavetime

                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form1.ListView2.SelectedItems.Count > 0 Then
            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "1" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(45)

                Form1.ListView2.Items(0).SubItems(4).Text = ETRf
                Form1.ListView2.Items(0).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(0).SubItems(3).Text = leavetime

                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "2" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(45)

                Form1.ListView2.Items(1).SubItems(4).Text = ETRf
                Form1.ListView2.Items(1).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(1).SubItems(3).Text = leavetime

                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "3" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(45)

                Form1.ListView2.Items(2).SubItems(4).Text = ETRf
                Form1.ListView2.Items(2).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(2).SubItems(3).Text = leavetime

                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Form1.ListView2.SelectedItems.Count > 0 Then
            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "1" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"

                ETRf = ETRf.AddMinutes(60)
                Form1.ListView2.Items(0).SubItems(4).Text = ETRf
                Form1.ListView2.Items(0).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(0).SubItems(3).Text = leavetime

                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "2" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(60)
                Form1.ListView2.Items(1).SubItems(4).Text = ETRf
                Form1.ListView2.Items(1).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(1).SubItems(3).Text = leavetime


                Me.Close()
            End If

            If Form1.ListView2.SelectedItems(0).SubItems(0).Text = "3" Then
                Dim leavetime As DateTime = DateTime.Now.ToString("HH:mm")
                Dim ETRf As DateTime = DateTime.Now.ToString("HH:mm")
                Dim format As String = "HH:mm"
                ETRf = ETRf.AddMinutes(60)
                Form1.ListView2.Items(2).SubItems(4).Text = ETRf
                Form1.ListView2.Items(2).SubItems(2).Text = DateTime.Now.ToString("d")
                Form1.ListView2.Items(2).SubItems(3).Text = leavetime


                Me.Close()
            End If
        End If
    End Sub
End Class