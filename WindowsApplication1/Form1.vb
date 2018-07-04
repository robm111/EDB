Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        TextBox3.Text = Date.Now
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox3.Text = Date.Now
    End Sub



    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If (ListView2.SelectedItems.Count > 0) Then
            Dim SelectedDriver As String
            SelectedDriver = ListView2.SelectedItems(0).SubItems(0).Text
            If SelectedDriver = "1" Then
                ListView3.Show()
                ListView5.Hide()
                ListView4.Hide()
            End If

            If SelectedDriver = "2" Then
                ListView4.Show()
                ListView3.Hide()
                ListView5.Hide()
            End If

            If SelectedDriver = "3" Then
                ListView5.Show()
                ListView3.Hide()
                ListView4.Hide()
            End If
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form3.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems Is Nothing Then
                MsgBox("No transaction selected")
            End If
            Dim delTrans As String
            Dim delCust As String
            Dim delTime As String
            Dim delInvoice As String

            delTrans = ListView1.SelectedItems(0).SubItems(2).Text
            delCust = ListView1.SelectedItems(0).SubItems(1).Text
            delTime = ListView1.SelectedItems(0).SubItems(0).Text
            delInvoice = ListView1.SelectedItems(0).SubItems(3).Text

            Using LVStream As New IO.StreamWriter("today.nas", True)
                LVStream.WriteLine(Environment.NewLine & delCust & ", invoiced: " & delInvoice & ", trans #" & delTrans & ", ETA: " & delTime)



            End Using

            Dim i As ListViewItem
            i = ListView1.SelectedItems(0)
            If ListView1.SelectedItems.Count > 0 Then
                i.Remove()
            End If
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selecttruck.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListView2.SelectedItems.Count > 0 Then
            Dim i As ListViewItem
            'i = ListView2.SelectedItems(0)
            If ListView2.SelectedItems.Count > 0 Then
                ' i.Remove()
                ListView2.SelectedItems(0).SubItems(1).Text = ""
                ListView2.SelectedItems(0).SubItems(2).Text = ""
                ListView2.SelectedItems(0).SubItems(3).Text = ""
                ListView2.SelectedItems(0).SubItems(4).Text = ""
            End If
        End If
    End Sub

    Private Sub ListView3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ListView2.SelectedIndices Is Nothing Then
            MessageBox.Show("Nothing selected.")
            GoTo Nopes
        End If
        If ListView3.SelectedItems.Count < 1 And ListView4.SelectedItems.Count < 1 And ListView5.SelectedItems.Count < 1 Then
            MessageBox.Show("No transactions selected.")
            GoTo Nopes
        End If

        If ListView2.SelectedItems(0).SubItems(0).Text.ToString = "1" Then
            If ListView3.SelectedItems.Count > 0 Then
                Dim i As ListViewItem
                Dim etaQuote = ListView3.SelectedItems(0).SubItems(2).Text
                Dim addbacktoTrans As New ListViewItem(etaQuote)

                addbacktoTrans.SubItems.Add(ListView3.SelectedItems(0).SubItems(1))
                addbacktoTrans.SubItems.Add(ListView3.SelectedItems(0).SubItems(0))
                ListView1.Items.Add(addbacktoTrans)
                i = ListView3.SelectedItems(0)
                If ListView3.SelectedItems.Count > 0 Then
                    i.Remove()
                End If
            End If
        End If

        If ListView2.SelectedItems(0).SubItems(0).Text = "2" Then


            If ListView4.SelectedItems.Count > 0 Then
                Dim i As ListViewItem
                Dim etaQuote = ListView4.SelectedItems(0).SubItems(2).Text
                Dim addbacktoTrans As New ListViewItem(etaQuote)

                addbacktoTrans.SubItems.Add(ListView4.SelectedItems(0).SubItems(1))
                addbacktoTrans.SubItems.Add(ListView4.SelectedItems(0).SubItems(0))
                ListView1.Items.Add(addbacktoTrans)
                i = ListView4.SelectedItems(0)
                If ListView4.SelectedItems.Count > 0 Then
                    i.Remove()
                End If
            End If
        End If

        If ListView2.SelectedItems(0).SubItems(0).Text = "3" Then


            If ListView5.SelectedItems.Count > 0 Then
                Dim i As ListViewItem
                Dim etaQuote = ListView5.SelectedItems(0).SubItems(2).Text
                Dim addbacktoTrans As New ListViewItem(etaQuote)

                addbacktoTrans.SubItems.Add(ListView5.SelectedItems(0).SubItems(1))
                addbacktoTrans.SubItems.Add(ListView5.SelectedItems(0).SubItems(0))
                ListView1.Items.Add(addbacktoTrans)
                i = ListView5.SelectedItems(0)
                If ListView5.SelectedItems.Count > 0 Then
                    i.Remove()
                End If
            End If
        End If
Nopes:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '  If String.IsNullOrEmpty(ListView2.SelectedItems(0).SubItems(1).Text) Then
        '  MessageBox.Show("No active driver selected.")
        '  GoTo Nopes
        '   End If

        If ListView1.SelectedItems.Count > 0 And ListView2.SelectedItems.Count > 0 Then
            If String.IsNullOrEmpty(ListView2.SelectedItems(0).SubItems(1).Text) Then
                MessageBox.Show("No active driver selected.")
                GoTo Nopes
            End If

            Dim SelectedDriver As String

            SelectedDriver = ListView2.SelectedItems(0).SubItems(0).Text

            If SelectedDriver = "1" Then

                Dim invoicenum = ListView1.SelectedItems(0).SubItems(2).Text
                Dim driverassign As New ListViewItem(invoicenum)
                driverassign.SubItems.Add(ListView1.SelectedItems(0).SubItems(1).Text)
                driverassign.SubItems.Add(ListView1.SelectedItems(0).SubItems(0).Text)
                ListView3.Items.Add(driverassign)
                Dim i As ListViewItem
                i = ListView1.SelectedItems(0)
                i.Remove()

            End If
            If SelectedDriver = "2" Then

                Dim invoicenum = ListView1.SelectedItems(0).SubItems(2).Text
                Dim driverassign As New ListViewItem(invoicenum)
                driverassign.SubItems.Add(ListView1.SelectedItems(0).SubItems(1).Text)
                driverassign.SubItems.Add(ListView1.SelectedItems(0).SubItems(0).Text)
                ListView4.Items.Add(driverassign)
                Dim i As ListViewItem
                i = ListView1.SelectedItems(0)
                i.Remove()
            End If
            If SelectedDriver = "3" Then

                Dim invoicenum = ListView1.SelectedItems(0).SubItems(2).Text
                Dim driverassign As New ListViewItem(invoicenum)
                driverassign.SubItems.Add(ListView1.SelectedItems(0).SubItems(1).Text)
                driverassign.SubItems.Add(ListView1.SelectedItems(0).SubItems(0).Text)
                ListView5.Items.Add(driverassign)
                Dim i As ListViewItem
                i = ListView1.SelectedItems(0)
                i.Remove()
            End If
        End If
Nopes:
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If ListView2.Equals(0) Then
            MessageBox.Show("Nothing selected.")
            GoTo Nopes
        End If

        If ListView2.SelectedItems.Count < 1 Then
            MessageBox.Show("No deliveries selected to end.")
            GoTo Nopes
        End If
        Dim strFile1 As String, strFile2 As String
        Dim strDTStamp1 As String, strDTStamp2 As String
        Dim strDiff As String
        Dim dte As DateTime = DateTime.Now.ToString("d")
        Dim formats() As String = {"G", "MM/yyyy", "MM\/dd\/yyyy HH:mm",
                                  "yyyyMMdd"}
        Dim dtefile As String = DateTime.Now.ToString("yyyyMMdd")
        strFile1 = "c:\edb\reports\today.dlv"
        'strFile2 = "today.nas"
        strDTStamp1 = FileDateTime(strFile1)
        strDTStamp2 = dte
        strDiff = DateDiff("d", strDTStamp1, strDTStamp2) 'diff in days
        If strDiff <> 0 Then
            My.Computer.FileSystem.CopyFile(
    "c:\edb\reports\today.dlv",
    dtefile & ".dlv")
            My.Computer.FileSystem.CopyFile(
    "c:\edb\reports\today.nas",
    dtefile & ".nas")
            My.Computer.FileSystem.DeleteFile("c:\edb\reports\today.dlv")
            My.Computer.FileSystem.DeleteFile("c:\edb\reports\today.nas")
            Using LVStream As New IO.StreamWriter("c:\edb\reports\today.dlv", True)
                LVStream.WriteLine("")
            End Using
            Using LVStream As New IO.StreamWriter("c:\edb\reports\today.nas", True)
                LVStream.WriteLine("")
            End Using
        End If

        Debug.Print(strDiff)
        Debug.Print(strDTStamp1)
        Debug.Print(dte)


        Dim DelItems As String
        Dim DelDriver As String
        Dim DelEndTime As String
        Dim DelCust As String
        Dim DelInv As String
        'DelDriver = ListView2.SelectedItems(0).SubItems(1).Text.ToString()
        DelDriver = ListView2.SelectedItems(0).SubItems(1).Text.ToString()
        ' DelCust = ListView3.SelectedItems(0).SubItems(1).Text.ToString()
        ' DelInv = ListView3.SelectedItems(0).SubItems(0).Text.ToString()

        If (ListView2.SelectedItems.Count > 0) Then
            Dim SelectedDriver As String
            SelectedDriver = ListView2.SelectedItems(0).SubItems(0).Text

            If SelectedDriver = "1" Then
                ' If ListView3.SelectedItems.Count <1 Then
                'GoTo Nopes
                'End If

                Using LVStream As New IO.StreamWriter("c:\edb\reports\today.dlv", True)
                    LVStream.WriteLine(Environment.NewLine & DelDriver)

                    For Each LVi As ListViewItem In ListView3.Items

                        Dim LVRow As String = ""
                        For Each LVCell As ListViewItem.ListViewSubItem _
               In LVi.SubItems

                            LVRow &= "   " & LVCell.Text & ","
                        Next
                        LVRow = LVRow.Remove(LVRow.Length - 1, 1)
                        LVStream.WriteLine(LVRow)
                    Next

                    LVStream.WriteLine("   Delivery ended:  " & Date.Now)

                End Using

                For i = 0 To ListView3.Items.Count - 1
                    ListView3.Items(i).Selected = True
                Next i

                'DelDriver = ListView2.SelectedItems(0).SubItems(1).Text.ToString()
                ' DelCust = ListView3.SelectedItems(0).SubItems(1).Text.ToString()
                ' DelInv = ListView3.SelectedItems(0).SubItems(0).Text.ToString()

                DelEndTime = Date.Now

                ' My.Computer.FileSystem.WriteAllText("today.dlv", Environment.NewLine + Environment.NewLine + DelEndTime, True)
                'My.Computer.FileSystem.WriteAllText("today.dlv", Environment.NewLine + DelDriver, True)
                'My.Computer.FileSystem.WriteAllText("today.dlv", Environment.NewLine + "    " + DelCust + ",  invoice number: #" + DelInv, True)

                ListView2.SelectedItems(0).SubItems(2).Text = ""
                ListView2.SelectedItems(0).SubItems(3).Text = ""
                ListView2.SelectedItems(0).SubItems(4).Text = ""

                ListView3.Items.Clear()
            End If

            If SelectedDriver = "2" Then
                For i = 0 To ListView4.Items.Count - 1
                    ListView4.Items(i).Selected = True
                Next i


                DelDriver = ListView2.SelectedItems(0).SubItems(1).Text.ToString()
                DelCust = ListView4.SelectedItems(0).SubItems(1).Text.ToString()
                DelInv = ListView4.SelectedItems(0).SubItems(0).Text.ToString()

                DelEndTime = Date.Now

                Using LVStream As New IO.StreamWriter("c:\edb\reports\today.dlv", True)
                    LVStream.WriteLine(Environment.NewLine & DelDriver)

                    For Each LVi As ListViewItem In ListView4.Items

                        Dim LVRow As String = ""
                        For Each LVCell As ListViewItem.ListViewSubItem _
               In LVi.SubItems

                            LVRow &= "   " & LVCell.Text & ","
                        Next
                        LVRow = LVRow.Remove(LVRow.Length - 1, 1)
                        LVStream.WriteLine(LVRow)
                    Next

                    LVStream.WriteLine("   Delivery ended:  " & Date.Now)

                End Using
                ListView2.SelectedItems(0).SubItems(2).Text = ""
                ListView2.SelectedItems(0).SubItems(3).Text = ""
                ListView2.SelectedItems(0).SubItems(4).Text = ""

                ListView4.Items.Clear()
            End If

            If SelectedDriver = "3" Then

                For i = 0 To ListView5.Items.Count - 1
                    ListView5.Items(i).Selected = True
                Next i




                DelDriver = ListView2.SelectedItems(0).SubItems(1).Text.ToString()
                DelCust = ListView5.SelectedItems(0).SubItems(1).Text.ToString()
                DelInv = ListView5.SelectedItems(0).SubItems(0).Text.ToString()

                DelEndTime = Date.Now

                Using LVStream As New IO.StreamWriter("c:\edb\reports\today.dlv", True)
                    LVStream.WriteLine(Environment.NewLine & DelDriver)

                    For Each LVi As ListViewItem In ListView5.Items

                        Dim LVRow As String = ""
                        For Each LVCell As ListViewItem.ListViewSubItem _
               In LVi.SubItems

                            LVRow &= "   " & LVCell.Text & ","
                        Next
                        LVRow = LVRow.Remove(LVRow.Length - 1, 1)
                        LVStream.WriteLine(LVRow)
                    Next

                    LVStream.WriteLine("   Delivery ended:  " & Date.Now)

                End Using
                ListView2.SelectedItems(0).SubItems(2).Text = ""
                ListView2.SelectedItems(0).SubItems(3).Text = ""
                ListView2.SelectedItems(0).SubItems(4).Text = ""


                ListView5.Items.Clear()
            End If
        End If


Nopes:
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub
End Class
