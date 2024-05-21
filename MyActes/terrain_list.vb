Imports System.Data.OleDb

Public Class terrain_list
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\MyActes\MyActes.accdb;Persist Security Info=False"
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub terrain_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficher()
    End Sub

    Private Sub afficher()
        Dim con As New OleDbConnection(Me.Provider)
        con.Open()
        Dim sel As String = "Select * from terrain"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        list_terrain.Rows.Clear()
        Do While ret.Read
            list_terrain.Rows.Add(ret.Item("ref"), ret.Item("site"), ret.Item("superficie"), ret.Item("prix"), ret.Item("acheteur"), ret.Item("vendeur"), ret.Item("tem1"), ret.Item("tem2"), ret.Item("datevend"), ret.Item("id"))
        Loop

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        refe.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(0).Value
        comm.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(1).Value
        super.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(2).Value
        pris.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(3).Value
        achat.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(4).Value
        vente.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(5).Value
        temoin1.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(6).Value
        temoin2.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(7).Value
        venDate.Value = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(8).Value
        num.Text = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(9).Value
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim ref, com, sup, pri, ach, nve, nach, t1, t2, id

        ref = refe.Text
        com = comm.Text
        pri = pris.Text
        nach = achat.Text
        nve = vente.Text
        t1 = temoin1.Text
        t2 = temoin2.Text
        id = num.Text
        sup = super.Text

        Dim dat As DateTime
        dat = venDate.Value

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update terrain set vendeur = '" & nve & "', acheteur = '" & nach & "', datevend = '" & dat & "', site = '" & com & "', superficie = '" & sup & "', prix = '" & pri & "', tem1 = '" & t1 & "', tem2 = '" & t2 & "',ref = '" & ref & "' where id =" & id
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Modificaton effectué")
                Call afficher()
            Else
                MessageBox.Show("Modificaton non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim id As String
        id = list_terrain.Rows(list_terrain.CurrentRow.Index).Cells(9).Value
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Delete * from terrain where id = " & id
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Suppression effectué")
                Call afficher()
            Else
                MessageBox.Show("Suppression non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class