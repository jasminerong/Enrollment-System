Imports System.Data.OleDb

Public Class Register
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Jasmin\Documents\Visual Studio 2010\Projects\Min\Min\bin\Debug\StudentEnrollmentSystem_FINAL.accdb;"
    Dim adapter As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        ds = New DataSet

        If Regpassword.Text <> Regpassword2.Text Then
            MsgBox("Password do not match!")


        ElseIf Regusername.Text = "" Or Regpassword.Text = "" Or Regpassword2.Text = "" Then
            MsgBox("Please fill up necessary fields!")
        Else
            adapter = New OleDbDataAdapter("Insert into [account] ([username],[password]) VALUES " & "('" & Regusername.Text & "','" & Regpassword.Text & "')", con)
            adapter.Fill(ds, "account")
            Regusername.Clear()
            Regpassword.Clear()
            Regpassword2.Clear()
            MsgBox("User registered!")
            Login.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Regpassword.PasswordChar = "*"

        Else
            Regpassword.PasswordChar = ""
        End If
        If CheckBox1.Checked = False Then
            Regpassword2.PasswordChar = "*"

        Else
            Regpassword2.PasswordChar = ""
        End If
    End Sub
End Class