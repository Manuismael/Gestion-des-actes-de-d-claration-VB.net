Imports System.Data.OleDb
Public Class Login
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\MyActes\MyActes.accdb;Persist Security Info=False"

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cod, idt As String
        idt = identifiant.Text
        cod = code.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "SELECT COUNT(*) FROM users WHERE identifiant= ? AND code= ?"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", idt)
            command.Parameters.AddWithValue("?", cod)
            If command.ExecuteScalar > 0 Then
                Dim birthlist As New BirthList()
                birthlist.Show()
                Me.Hide()
            Else
                MessageBox.Show("Uitlisateur non enregistrer", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles code.TextChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
