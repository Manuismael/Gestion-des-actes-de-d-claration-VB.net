Imports System.Data.OleDb
Public Class Dashboard
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\MyActes\MyActes.accdb;Persist Security Info=False"
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim terrains As New terrain()
        terrains.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim login As New Login()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim chname, chsurname, birthplace, hospital, mumname, dadname
        chname = Childname.Text
        chsurname = Childprenom.Text
        birthplace = Commune.Text
        hospital = Hopital.Text
        mumname = Mothname.Text
        dadname = Fathname.Text

        Dim ref As String
        ref = Noref.Text

        Dim birthday As DateTime
        birthday = birthDate.Value

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "INSERT INTO birth (childname, childsurname, birthday, birthplace, hospital, reference, mothername, dadname) VALUES (?,?,?,?,?,?,?,?)"
            Dim command As New OleDbCommand(req, con)
            command.Parameters.AddWithValue("?", chname)
            command.Parameters.AddWithValue("?", chsurname)
            command.Parameters.AddWithValue("?", birthday)
            command.Parameters.AddWithValue("?", birthplace)
            command.Parameters.AddWithValue("?", hospital)
            command.Parameters.AddWithValue("?", ref)
            command.Parameters.AddWithValue("?", mumname)
            command.Parameters.AddWithValue("?", dadname)

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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim birthlist As New BirthList()
        birthlist.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim mariage As New Mariage()
        mariage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class