<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Fathname = New System.Windows.Forms.TextBox()
        Me.dadname = New System.Windows.Forms.Label()
        Me.Commune = New System.Windows.Forms.ComboBox()
        Me.birthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Mothname = New System.Windows.Forms.TextBox()
        Me.mothername = New System.Windows.Forms.Label()
        Me.Noref = New System.Windows.Forms.TextBox()
        Me.Hopital = New System.Windows.Forms.TextBox()
        Me.ref = New System.Windows.Forms.Label()
        Me.hospital = New System.Windows.Forms.Label()
        Me.Childprenom = New System.Windows.Forms.TextBox()
        Me.birthplace = New System.Windows.Forms.Label()
        Me.Childsurname = New System.Windows.Forms.Label()
        Me.Childname = New System.Windows.Forms.TextBox()
        Me.birthday = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 590)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Dubai Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Ivory
        Me.Button3.Location = New System.Drawing.Point(11, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(210, 52)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Actes de terrain" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Dubai Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Ivory
        Me.Button2.Location = New System.Drawing.Point(11, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Actes de Mariage"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Dubai Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Ivory
        Me.Button1.Location = New System.Drawing.Point(11, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Actes de Naissances"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(2, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MyActes"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1176, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 49)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Deconnexion"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(235, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 49)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(4, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 48)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Acte de Naissance"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Fathname)
        Me.Panel3.Controls.Add(Me.dadname)
        Me.Panel3.Controls.Add(Me.Commune)
        Me.Panel3.Controls.Add(Me.birthDate)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Mothname)
        Me.Panel3.Controls.Add(Me.mothername)
        Me.Panel3.Controls.Add(Me.Noref)
        Me.Panel3.Controls.Add(Me.Hopital)
        Me.Panel3.Controls.Add(Me.ref)
        Me.Panel3.Controls.Add(Me.hospital)
        Me.Panel3.Controls.Add(Me.Childprenom)
        Me.Panel3.Controls.Add(Me.birthplace)
        Me.Panel3.Controls.Add(Me.Childsurname)
        Me.Panel3.Controls.Add(Me.Childname)
        Me.Panel3.Controls.Add(Me.birthday)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(237, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1080, 539)
        Me.Panel3.TabIndex = 3
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Honeydew
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Green
        Me.Button8.Location = New System.Drawing.Point(811, 45)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(154, 49)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "Voir Liste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Fathname
        '
        Me.Fathname.Location = New System.Drawing.Point(347, 407)
        Me.Fathname.Name = "Fathname"
        Me.Fathname.Size = New System.Drawing.Size(614, 22)
        Me.Fathname.TabIndex = 25
        '
        'dadname
        '
        Me.dadname.AutoSize = True
        Me.dadname.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dadname.ForeColor = System.Drawing.Color.Green
        Me.dadname.Location = New System.Drawing.Point(117, 407)
        Me.dadname.Name = "dadname"
        Me.dadname.Size = New System.Drawing.Size(210, 25)
        Me.dadname.TabIndex = 24
        Me.dadname.Text = "Nom  et Prénom de la Mère:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Commune
        '
        Me.Commune.FormattingEnabled = True
        Me.Commune.Items.AddRange(New Object() {"Adjarra", "Porto-Novo", "Avrankou", "Missérété"})
        Me.Commune.Location = New System.Drawing.Point(754, 218)
        Me.Commune.Name = "Commune"
        Me.Commune.Size = New System.Drawing.Size(207, 24)
        Me.Commune.TabIndex = 4
        '
        'birthDate
        '
        Me.birthDate.Location = New System.Drawing.Point(272, 219)
        Me.birthDate.Name = "birthDate"
        Me.birthDate.Size = New System.Drawing.Size(207, 22)
        Me.birthDate.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(112, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(502, 55)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Enregistrement Acte de Naissance"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(487, 456)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 49)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Enregistrer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Mothname
        '
        Me.Mothname.Location = New System.Drawing.Point(347, 349)
        Me.Mothname.Name = "Mothname"
        Me.Mothname.Size = New System.Drawing.Size(614, 22)
        Me.Mothname.TabIndex = 21
        '
        'mothername
        '
        Me.mothername.AutoSize = True
        Me.mothername.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mothername.ForeColor = System.Drawing.Color.Green
        Me.mothername.Location = New System.Drawing.Point(117, 349)
        Me.mothername.Name = "mothername"
        Me.mothername.Size = New System.Drawing.Size(191, 25)
        Me.mothername.TabIndex = 20
        Me.mothername.Text = "Nom  et Prénom du Père:"
        '
        'Noref
        '
        Me.Noref.Location = New System.Drawing.Point(758, 288)
        Me.Noref.Name = "Noref"
        Me.Noref.Size = New System.Drawing.Size(207, 22)
        Me.Noref.TabIndex = 19
        '
        'Hopital
        '
        Me.Hopital.Location = New System.Drawing.Point(273, 290)
        Me.Hopital.Name = "Hopital"
        Me.Hopital.Size = New System.Drawing.Size(207, 22)
        Me.Hopital.TabIndex = 18
        '
        'ref
        '
        Me.ref.AutoSize = True
        Me.ref.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.ForeColor = System.Drawing.Color.Green
        Me.ref.Location = New System.Drawing.Point(574, 286)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(170, 25)
        Me.ref.TabIndex = 17
        Me.ref.Text = "Numéro de Référence:"
        '
        'hospital
        '
        Me.hospital.AutoSize = True
        Me.hospital.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hospital.ForeColor = System.Drawing.Color.Green
        Me.hospital.Location = New System.Drawing.Point(117, 288)
        Me.hospital.Name = "hospital"
        Me.hospital.Size = New System.Drawing.Size(136, 25)
        Me.hospital.TabIndex = 16
        Me.hospital.Text = "Hopital Naissace:"
        '
        'Childprenom
        '
        Me.Childprenom.Location = New System.Drawing.Point(754, 150)
        Me.Childprenom.Name = "Childprenom"
        Me.Childprenom.Size = New System.Drawing.Size(207, 22)
        Me.Childprenom.TabIndex = 14
        '
        'birthplace
        '
        Me.birthplace.AutoSize = True
        Me.birthplace.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthplace.ForeColor = System.Drawing.Color.Green
        Me.birthplace.Location = New System.Drawing.Point(574, 218)
        Me.birthplace.Name = "birthplace"
        Me.birthplace.Size = New System.Drawing.Size(162, 25)
        Me.birthplace.TabIndex = 13
        Me.birthplace.Text = "Commune Naissance:"
        '
        'Childsurname
        '
        Me.Childsurname.AutoSize = True
        Me.Childsurname.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Childsurname.ForeColor = System.Drawing.Color.Green
        Me.Childsurname.Location = New System.Drawing.Point(574, 150)
        Me.Childsurname.Name = "Childsurname"
        Me.Childsurname.Size = New System.Drawing.Size(153, 25)
        Me.Childsurname.TabIndex = 12
        Me.Childsurname.Text = "Prénom de l'enfant:"
        '
        'Childname
        '
        Me.Childname.Location = New System.Drawing.Point(272, 151)
        Me.Childname.Name = "Childname"
        Me.Childname.Size = New System.Drawing.Size(207, 22)
        Me.Childname.TabIndex = 10
        '
        'birthday
        '
        Me.birthday.AutoSize = True
        Me.birthday.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.ForeColor = System.Drawing.Color.Green
        Me.birthday.Location = New System.Drawing.Point(117, 219)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(121, 25)
        Me.birthday.TabIndex = 9
        Me.birthday.Text = "Date naissance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(117, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nom de l'enfant:"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1320, 591)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Honeydew
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Noref As TextBox
    Friend WithEvents Hopital As TextBox
    Friend WithEvents ref As Label
    Friend WithEvents hospital As Label
    Friend WithEvents Childprenom As TextBox
    Friend WithEvents birthplace As Label
    Friend WithEvents Childsurname As Label
    Friend WithEvents Childname As TextBox
    Friend WithEvents birthday As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Mothname As TextBox
    Friend WithEvents mothername As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Commune As ComboBox
    Friend WithEvents birthDate As DateTimePicker
    Friend WithEvents Fathname As TextBox
    Friend WithEvents dadname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
End Class
