Imports System.Data.OleDb
Public Class frm_sr_caamount
    Public dbcon As OleDbConnection

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        DataGridView1.Visible = TrackBar1.Value
        Dim casrconcmd As OleDbCommand
        'Dim casrda As OleDbDataAdapter
        'Dim casrds As DataSet
        Dim casrconstr As String
        ''Dim ttconcmd As OleDbCommand
        'Dim ttconstrg2 As String
        'Dim datareader As OleDbDataReader
        Dim da As OleDbDataAdapter
        Dim data As DataSet
        dbcon.Open()
        casrconstr = "select acno,bankname,bname,opendate,depoamt from ACCOUNTS where type='CURRENT ACCOUNT'and depoamt= " & (TrackBar1.Value)
        casrconcmd = New OleDbCommand(casrconstr, dbcon)

        da = New OleDbDataAdapter(casrconcmd)
        data = New DataSet()
        da.Fill(data, "mm")
        DataGridView1.DataSource = data.Tables("mm").DefaultView




        dbcon.Close()
    End Sub

    Private Sub frm_sr_fdamt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbcon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb")
    End Sub
End Class