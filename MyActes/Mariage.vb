Imports System.Data.OleDb
Imports System.Security.Policy
Public Class Mariage
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\MyActes\MyActes.accdb;Persist Security Info=False"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ep, eps, com, ofc, ref, t1, t2 As String
        ep = epoux.Text
        eps = epouse.Text
        com = commune.Text
        ofc = officier.Text
        ref = refma.Text
        t1 = tem1.Text
        t2 = tem2.Text

        Dim dat As DateTime
        dat = datma.Value

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "INSERT INTO mariage (epoux, epouse, datema, commune, officier, ref, tem1, tem2) VALUES (?,?,?,?,?,?,?,?)"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", ep)
            command.Parameters.AddWithValue("?", eps)
            command.Parameters.AddWithValue("?", dat)
            command.Parameters.AddWithValue("?", com)
            command.Parameters.AddWithValue("?", ofc)
            command.Parameters.AddWithValue("?", ref)
            command.Parameters.AddWithValue("?", t1)
            command.Parameters.AddWithValue("?", t2)

            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Acte Enregistrer")

            Else
                MessageBox.Show("Erreur")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class