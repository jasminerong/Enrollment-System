Imports System.Data.OleDb
Public Class Main
 
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
         MsgBox("Data successfully saved to the DB")

        Else
            addedit()

        End If
    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        testCon()
        displayData(False)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.RowIndex < 0 Then
                Exit Sub

            End If

            Dim grid = DirectCast(sender, DataGridView)

            If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If grid.Columns(e.ColumnIndex).Name = "Column13" Then
                    TabControl1.SelectedIndex = 0

                    TextBox2.Text = CStr(grid.Rows(e.RowIndex).Cells(1).Value)
                    TextBox3.Text = CStr(grid.Rows(e.RowIndex).Cells(2).Value)
                    ComboBox1.Text = CDate(grid.Rows(e.RowIndex).Cells(3).Value)
                    DateTimePicker1.Text = CDate(grid.Rows(e.RowIndex).Cells(4).Value)
                    ComboBox2.Text = CInt(grid.Rows(e.RowIndex).Cells(5).Value)
                    ComboBox3.Text = CInt(grid.Rows(e.RowIndex).Cells(6).Value)
                    TextBox4.Text = CStr(grid.Rows(e.RowIndex).Cells(7).Value)
                    TextBox5.Text = CStr(grid.Rows(e.RowIndex).Cells(8).Value)
                    TextBox6.Text = CStr(grid.Rows(e.RowIndex).Cells(9).Value)
                    TextBox7.Text = CStr(grid.Rows(e.RowIndex).Cells(10).Value)
                    TextBox8.Text = CStr(grid.Rows(e.RowIndex).Cells(11).Value)

                    isEdit = True
                    recID = CInt(grid.Rows(e.RowIndex).Cells(0).Value)

                ElseIf grid.Columns(e.ColumnIndex).Name = "Column14" Then
                    If MsgBox("Are you sure do you want to delete the record of " & CStr(grid.Rows(e.RowIndex).Cells(2).Value) & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        If InsertUpdateDelete("DELETE FROM Record WHERE ID = " & grid.Rows(e.RowIndex).Cells(0).Value & "") Then
                            MsgBox("Successfully Deleted!", MsgBoxStyle.Information, "Success")
                            displayData(False)
                        Else
                            MsgBox("Failed to delete!", MsgBoxStyle.Critical, "Error")
                            displayData(False)
                        End If

                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub addedit()
        Try
            Dim query As String 'variable for sql query
            If isEdit Then
                query = "UPDATE Record SET Fname ='" & TextBox2.Text & "',Lname ='" & TextBox3.Text & "',Gender ='" & ComboBox1.Text & "',Birthdate='" & DateTimePicker1.Text & "',Yearlevel='" & ComboBox2.Text & "',Course='" & ComboBox3.Text & "' ,Subject_one='" & TextBox4.Text & "',Subject_two='" & TextBox5.Text & "' ,Subject_three='" & TextBox6.Text & "' ,Subject_four='" & TextBox7.Text & "' ,Subject_five='" & TextBox8.Text & "' WHERE ID = " & recID & ""
            Else
                query = "INSERT INTO Record(Fname,Lname,Gender,Birthdate,Yearlevel,Course,Subject_one,Subject_two,Subject_three,Subject_four,Subject_five,) VALUES('" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "'," & DateTimePicker1.Text & "','" & ComboBox2.Text & "', '" & ComboBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "' ,'" & TextBox7.Text & "','" & TextBox8.Text & ")"
            End If


            If InsertUpdateDelete(query) Then
                If isEdit Then
                    MsgBox("Data successfully updated to the DB!", MsgBoxStyle.Information, "Success")
                    isEdit = False
                    reset()
                Else
                    MsgBox("Data successfully inserted to the DB!", MsgBoxStyle.Information, "Success")
                    reset()
                End If
                TabControl1.SelectedIndex = 1
                displayData(False)

            Else
                If isEdit Then
                    MsgBox("Failed to update!", MsgBoxStyle.Critical, "Error")
                    isEdit = False
                Else
                    MsgBox("Failed to insert!", MsgBoxStyle.Critical, "Error")
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reset()
        isEdit = False
    End Sub

    Sub reset()
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        displayData(True)
    End Sub

    Sub displayData(ByVal isSearch As Boolean)
        Try
            Dim query As String

            If isSearch Then
                query = "SELECT * FROM Record WHERE Lname LIKE '" & Button4.Text & "%'"
            Else
                query = "SELECT * FROM Record"
            End If

            Dim dr As OleDbDataReader

            cmd = New OleDbCommand(query, con)
            dr = cmd.ExecuteReader

            DataGridView1.Rows.Clear()

            While dr.Read
                DataGridView1.Rows.Add(dr("ID"), dr("Fname"), dr("Lname"), dr("Gender"), dr("Birthdate"), dr("Yearlevel"), dr("Course"), dr("Subject_one"), dr("Subject_two"), dr("Subject_three"), dr("Subject_four"), dr("Subject_five"), "Edit", "Delete")
            End While

            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


   
    
End Class
