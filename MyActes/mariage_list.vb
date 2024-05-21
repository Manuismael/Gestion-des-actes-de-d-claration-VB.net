Imports System.Data.OleDb

Public Class mariage_list
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\MyActes\MyActes.accdb;Persist Security Info=False"
    Private Sub mariage_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficher()
    End Sub
    Private Sub afficher()
        Dim con As New OleDbConnection(Me.Provider)
        con.Open()
        Dim sel As String = "Select * from mariage"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        list_mariage.Rows.Clear()
        Do While ret.Read
            list_mariage.Rows.Add(ret.Item("ref"), ret.Item("epoux"), ret.Item("epouse"), ret.Item("officier"), ret.Item("datema"), ret.Item("commune"), ret.Item("tem1"), ret.Item("tem2"), ret.Item("id"))
        Loop

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        refma.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(0).Value
        epx.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(1).Value
        eps.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(2).Value
        off.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(3).Value
        datma.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(4).Value
        comm.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(5).Value
        temoin1.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(6).Value
        temoin2.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(7).Value
        num.Text = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(8).Value
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ref, ep, epse, ofc, com, t1, t2, id As String
        ref = refma.Text
        ep = epx.Text
        epse = eps.Text
        ofc = off.Text
        com = comm.Text
        t1 = temoin1.Text
        t2 = temoin2.Text
        id = num.Text

        Dim dat As DateTime
        dat = datma.Value

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update mariage set epoux = '" & ep & "', epouse = '" & epse & "', datema = '" & dat & "', commune = '" & com & "', officier = '" & ofc & "', ref = '" & ref & "', tem1 = '" & t1 & "', tem2 = '" & t2 & "' where id =" & id
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
        id = list_mariage.Rows(list_mariage.CurrentRow.Index).Cells(8).Value
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Delete * from mariage where id = " & id
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