<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class terrain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.commune = New System.Windows.Forms.ComboBox()
        Me.datvent = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.prix = New System.Windows.Forms.TextBox()
        Me.superficie = New System.Windows.Forms.TextBox()
        Me.ref = New System.Windows.Forms.Label()
        Me.hospital = New System.Windows.Forms.Label()
        Me.ach = New System.Windows.Forms.TextBox()
        Me.birthplace = New System.Windows.Forms.Label()
        Me.Childsurname = New System.Windows.Forms.Label()
        Me.vend = New System.Windows.Forms.TextBox()
        Me.birthday = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.numref = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tem2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tem1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Honeydew
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Green
        Me.Button8.Location = New System.Drawing.Point(848, 56)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(154, 49)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "Voir Liste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button8.UseVisualStyleBackColor = False
        '
        'commune
        '
        Me.commune.FormattingEnabled = True
        Me.commune.Items.AddRange(New Object() {"Adjarra", "Porto-Novo", "Avrankou", "Missérété"})
        Me.commune.Location = New System.Drawing.Point(795, 229)
        Me.commune.Name = "commune"
        Me.commune.Size = New System.Drawing.Size(207, 24)
        Me.commune.TabIndex = 4
        '
        'datvent
        '
        Me.datvent.Location = New System.Drawing.Point(293, 230)
        Me.datvent.Name = "datvent"
        Me.datvent.Size = New System.Drawing.Size(207, 22)
        Me.datvent.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(53, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(583, 55)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Enregistrement Acte de vente de terrain"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(489, 567)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 49)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Enregistrer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'prix
        '
        Me.prix.Location = New System.Drawing.Point(795, 299)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(207, 22)
        Me.prix.TabIndex = 19
        '
        'superficie
        '
        Me.superficie.Location = New System.Drawing.Point(294, 301)
        Me.superficie.Name = "superficie"
        Me.superficie.Size = New System.Drawing.Size(207, 22)
        Me.superficie.TabIndex = 18
        '
        'ref
        '
        Me.ref.AutoSize = True
        Me.ref.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.ForeColor = System.Drawing.Color.Green
        Me.ref.Location = New System.Drawing.Point(539, 296)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(110, 25)
        Me.ref.TabIndex = 17
        Me.ref.Text = "Prix de vente:"
        '
        'hospital
        '
        Me.hospital.AutoSize = True
        Me.hospital.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hospital.ForeColor = System.Drawing.Color.Green
        Me.hospital.Location = New System.Drawing.Point(58, 299)
        Me.hospital.Name = "hospital"
        Me.hospital.Size = New System.Drawing.Size(165, 25)
        Me.hospital.TabIndex = 16
        Me.hospital.Text = "Superficie du terrain:"
        '
        'ach
        '
        Me.ach.Location = New System.Drawing.Point(795, 161)
        Me.ach.Name = "ach"
        Me.ach.Size = New System.Drawing.Size(207, 22)
        Me.ach.TabIndex = 14
        '
        'birthplace
        '
        Me.birthplace.AutoSize = True
        Me.birthplace.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthplace.ForeColor = System.Drawing.Color.Green
        Me.birthplace.Location = New System.Drawing.Point(539, 227)
        Me.birthplace.Name = "birthplace"
        Me.birthplace.Size = New System.Drawing.Size(149, 25)
        Me.birthplace.TabIndex = 13
        Me.birthplace.Text = "Adresse du terrain:"
        '
        'Childsurname
        '
        Me.Childsurname.AutoSize = True
        Me.Childsurname.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Childsurname.ForeColor = System.Drawing.Color.Green
        Me.Childsurname.Location = New System.Drawing.Point(539, 161)
        Me.Childsurname.Name = "Childsurname"
        Me.Childsurname.Size = New System.Drawing.Size(225, 25)
        Me.Childsurname.TabIndex = 12
        Me.Childsurname.Text = "Nom et Prénom de l'acheteur:"
        '
        'vend
        '
        Me.vend.Location = New System.Drawing.Point(295, 162)
        Me.vend.Name = "vend"
        Me.vend.Size = New System.Drawing.Size(207, 22)
        Me.vend.TabIndex = 10
        '
        'birthday
        '
        Me.birthday.AutoSize = True
        Me.birthday.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.ForeColor = System.Drawing.Color.Green
        Me.birthday.Location = New System.Drawing.Point(58, 230)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(113, 25)
        Me.birthday.TabIndex = 9
        Me.birthday.Text = "Date de vente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(58, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nom et Prénom du vendeur:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(236, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 49)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(4, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(323, 48)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Acte de vente de terrain" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1177, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 49)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Deconnexion"
        Me.Button4.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 774)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.Controls.Add(Me.numref)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.tem2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.tem1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.commune)
        Me.Panel3.Controls.Add(Me.datvent)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.prix)
        Me.Panel3.Controls.Add(Me.superficie)
        Me.Panel3.Controls.Add(Me.ref)
        Me.Panel3.Controls.Add(Me.hospital)
        Me.Panel3.Controls.Add(Me.ach)
        Me.Panel3.Controls.Add(Me.birthplace)
        Me.Panel3.Controls.Add(Me.Childsurname)
        Me.Panel3.Controls.Add(Me.vend)
        Me.Panel3.Controls.Add(Me.birthday)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(238, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1080, 724)
        Me.Panel3.TabIndex = 7
        '
        'numref
        '
        Me.numref.Location = New System.Drawing.Point(544, 460)
        Me.numref.Name = "numref"
        Me.numref.Size = New System.Drawing.Size(207, 22)
        Me.numref.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(354, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Numéro de référence:"
        '
        'tem2
        '
        Me.tem2.Location = New System.Drawing.Point(795, 369)
        Me.tem2.Name = "tem2"
        Me.tem2.Size = New System.Drawing.Size(207, 22)
        Me.tem2.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(539, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Nom et Prénom du Temoin 2:"
        '
        'tem1
        '
        Me.tem1.Location = New System.Drawing.Point(295, 372)
        Me.tem1.Name = "tem1"
        Me.tem1.Size = New System.Drawing.Size(207, 22)
        Me.tem1.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(58, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nom et Prénom du Temoin 1:"
        '
        'terrain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 774)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "terrain"
        Me.Text = "Dashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents commune As ComboBox
    Friend WithEvents datvent As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents prix As TextBox
    Friend WithEvents superficie As TextBox
    Friend WithEvents ref As Label
    Friend WithEvents hospital As Label
    Friend WithEvents ach As TextBox
    Friend WithEvents birthplace As Label
    Friend WithEvents Childsurname As Label
    Friend WithEvents vend As TextBox
    Friend WithEvents birthday As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tem2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tem1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numref As TextBox
    Friend WithEvents Label6 As Label
End Class
