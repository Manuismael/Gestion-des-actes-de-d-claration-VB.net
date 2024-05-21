Imports System.Data.OleDb
Public Class BirthList
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manu\Documents\Visual Studio 2015\Projects\MyActes\MyActes.accdb;Persist Security Info=False"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub BirthList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher()
    End Sub
    Private Sub afficher()
        Dim con As New OleDbConnection(Me.Provider)
        con.Open()
        Dim sel As String = "Select * from birth"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        tableau.Rows.Clear()
        Do While ret.Read
            tableau.Rows.Add(ret.Item("childname"), ret.Item("childsurname"), ret.Item("birthday"), ret.Item("birthplace"), ret.Item("hospital"), ret.Item("mothername"), ret.Item("dadname"), ret.Item("reference"), ret.Item("id"))
        Loop

    End Sub

    Private Sub birthDate_ValueChanged(sender As Object, e As EventArgs) Handles birthDate.ValueChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Childname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value
        Childprenom.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(1).Value
        birthDate.Value = tableau.Rows(tableau.CurrentRow.Index).Cells(2).Value
        comm.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(3).Value
        hsp.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(4).Value
        Mothname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(5).Value
        Fathname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(6).Value
        Noref.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(7).Value
        num.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(8).Value
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim nom, pre, com, hp, mn, dn, rf, id As String
        nom = Childname.Text
        pre = Childprenom.Text
        com = comm.Text
        hp = hsp.Text
        mn = Mothname.Text
        dn = Fathname.Text
        rf = Noref.Text
        id = num.Text

        Dim dat As DateTime
        dat = birthDate.Value

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update birth set childname = '" & nom & "', childsurname = '" & pre & "', birthday = '" & dat & "', birthplace = '" & com & "', hospital = '" & hp & "', reference = '" & rf & "', mothername = '" & mn & "', dadname = '" & dn & "' where id =" & id
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
        id = tableau.Rows(tableau.CurrentRow.Index).Cells(8).Value
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Delete * from birth where id = " & id
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim dashboard As New Dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim login As New Login()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub tableau_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableau.CellContentClick

    End Sub
End Class