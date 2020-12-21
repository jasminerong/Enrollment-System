Imports System.Data.OleDb
Public Class Login



    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\Jasmin\Documents\Visual Studio 2010\Projects\Min\Min\bin\Debug\StudentEnrollmentSystem_FINAL.accdb;"
    Dim adapter As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ds = New DataSet
        adapter = New OleDbDataAdapter("select*from [account] where [username]='" & TextBox1.Text & "' and [password]='" & TextBox2.Text & "'", con)
        adapter.Fill(ds, "account")

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please fill up the necessary fields")

        ElseIf ds.Tables("account").Rows.Count > 0 Then
            MessageBox.Show("Logged in successfully!")
            Main.Show()

            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()

        Else
            MessageBox.Show("Username or Password is Incorrect")
            TextBox1.Clear()
            TextBox2.Clear()

        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If

    End Sub


End Class
