Imports System.Data.OleDb
Public Class terrain
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\MyActes\MyActes.accdb;Persist Security Info=False"
    Private Sub Childsurname_Click(sender As Object, e As EventArgs) Handles Childsurname.Click

    End Sub

    Private Sub Childname_TextChanged(sender As Object, e As EventArgs) Handles vend.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ven, ac, sit, sup, pri, te1, te2, ref As String
        ven = vend.Text
        ac = ach.Text
        sit = commune.Text
        sup = superficie.Text
        pri = prix.Text
        te1 = tem1.Text
        te2 = tem2.Text
        ref = numref.Text

        Dim dat As DateTime
        dat = datvent.Value

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "INSERT INTO terrain (vendeur, acheteur, datevend, site, superficie, prix, tem1, tem2, ref) VALUES (?,?,?,?,?,?,?,?,?)"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", ven)
            command.Parameters.AddWithValue("?", ac)
            command.Parameters.AddWithValue("?", dat)
            command.Parameters.AddWithValue("?", sit)
            command.Parameters.AddWithValue("?", sup)
            command.Parameters.AddWithValue("?", pri)
            command.Parameters.AddWithValue("?", te1)
            command.Parameters.AddWithValue("?", te2)
            command.Parameters.AddWithValue("?", ref)

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

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class