Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data source =D:\2cp 2018-2019\projet\testedesigedata\testedesigedata\bin\Debug\Affectation (1).mdb")
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand("SELECT * FROM MODULES ;", con)
        con.Open()

        Dim dt As New OleDbDataAdapter(cmd)
        Dim dtreturn As New DataSet
        dt.Fill(dtreturn)
        DataGridView1.DataSource = dtreturn.Tables(0)
        con.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black

    End Sub
End Class
