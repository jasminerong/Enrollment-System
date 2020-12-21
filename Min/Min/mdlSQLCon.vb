Imports System.Data.OleDb


Module mdlSQLCon
    Public con As New OleDbConnection 'connection
    Public cmd As New OleDbCommand 'command

    Sub testCon()
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Jasmin\Documents\Visual Studio 2010\Projects\Min\Min\bin\Debug\StudentEnrollmentSystem_FINAL.accdb;"
            con.Open()
            'MsgBox("Successfully Connected to the MS Database!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
