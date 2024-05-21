<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mariage_list
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.list_mariage = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.num = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.temoin2 = New System.Windows.Forms.TextBox()
        Me.dadname = New System.Windows.Forms.Label()
        Me.comm = New System.Windows.Forms.ComboBox()
        Me.datma = New System.Windows.Forms.DateTimePicker()
        Me.temoin1 = New System.Windows.Forms.TextBox()
        Me.mothername = New System.Windows.Forms.Label()
        Me.refma = New System.Windows.Forms.TextBox()
        Me.off = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hospital = New System.Windows.Forms.Label()
        Me.eps = New System.Windows.Forms.TextBox()
        Me.birthplace = New System.Windows.Forms.Label()
        Me.Childsurname = New System.Windows.Forms.Label()
        Me.epx = New System.Windows.Forms.TextBox()
        Me.birthday = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.epoux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.epouse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.officier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.commune = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tem1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tem2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.list_mariage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(7, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 55)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Liste des Actes de Mariage:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1768, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 49)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Deconnexion"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.list_mariage)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.num)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.temoin2)
        Me.Panel3.Controls.Add(Me.dadname)
        Me.Panel3.Controls.Add(Me.comm)
        Me.Panel3.Controls.Add(Me.datma)
        Me.Panel3.Controls.Add(Me.temoin1)
        Me.Panel3.Controls.Add(Me.mothername)
        Me.Panel3.Controls.Add(Me.refma)
        Me.Panel3.Controls.Add(Me.off)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.hospital)
        Me.Panel3.Controls.Add(Me.eps)
        Me.Panel3.Controls.Add(Me.birthplace)
        Me.Panel3.Controls.Add(Me.Childsurname)
        Me.Panel3.Controls.Add(Me.epx)
        Me.Panel3.Controls.Add(Me.birthday)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(246, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1676, 1007)
        Me.Panel3.TabIndex = 15
        '
        'list_mariage
        '
        Me.list_mariage.BackgroundColor = System.Drawing.Color.Honeydew
        Me.list_mariage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.list_mariage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ref, Me.epoux, Me.epouse, Me.officier, Me.datema, Me.commune, Me.tem1, Me.tem2, Me.id})
        Me.list_mariage.Location = New System.Drawing.Point(17, 127)
        Me.list_mariage.Name = "list_mariage"
        Me.list_mariage.RowHeadersWidth = 51
        Me.list_mariage.RowTemplate.Height = 24
        Me.list_mariage.Size = New System.Drawing.Size(897, 613)
        Me.list_mariage.TabIndex = 47
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Honeydew
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Green
        Me.Button8.Location = New System.Drawing.Point(761, 33)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(154, 49)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Enregistrer"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(992, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 25)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Id:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'num
        '
        Me.num.AutoSize = True
        Me.num.Location = New System.Drawing.Point(1192, 163)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(0, 16)
        Me.num.TabIndex = 45
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(1466, 656)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(154, 49)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "Supprimer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1269, 656)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(154, 49)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Modifier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Dubai Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1054, 656)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 49)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "Charger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button5.UseVisualStyleBackColor = False
        '
        'temoin2
        '
        Me.temoin2.Location = New System.Drawing.Point(1195, 574)
        Me.temoin2.Name = "temoin2"
        Me.temoin2.Size = New System.Drawing.Size(425, 22)
        Me.temoin2.TabIndex = 41
        '
        'dadname
        '
        Me.dadname.AutoSize = True
        Me.dadname.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dadname.ForeColor = System.Drawing.Color.Green
        Me.dadname.Location = New System.Drawing.Point(992, 574)
        Me.dadname.Name = "dadname"
        Me.dadname.Size = New System.Drawing.Size(155, 25)
        Me.dadname.TabIndex = 40
        Me.dadname.Text = "Témoin de l'épouse:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'comm
        '
        Me.comm.FormattingEnabled = True
        Me.comm.Items.AddRange(New Object() {"Adjarra", "Porto-Novo", "Avrankou", "Missérété"})
        Me.comm.Location = New System.Drawing.Point(1195, 347)
        Me.comm.Name = "comm"
        Me.comm.Size = New System.Drawing.Size(425, 24)
        Me.comm.TabIndex = 26
        '
        'datma
        '
        Me.datma.Location = New System.Drawing.Point(1195, 299)
        Me.datma.MaxDate = New Date(2024, 5, 19, 0, 0, 0, 0)
        Me.datma.Name = "datma"
        Me.datma.Size = New System.Drawing.Size(425, 22)
        Me.datma.TabIndex = 39
        Me.datma.Value = New Date(2024, 5, 19, 0, 0, 0, 0)
        '
        'temoin1
        '
        Me.temoin1.Location = New System.Drawing.Point(1195, 511)
        Me.temoin1.Name = "temoin1"
        Me.temoin1.Size = New System.Drawing.Size(425, 22)
        Me.temoin1.TabIndex = 38
        '
        'mothername
        '
        Me.mothername.AutoSize = True
        Me.mothername.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mothername.ForeColor = System.Drawing.Color.Green
        Me.mothername.Location = New System.Drawing.Point(992, 511)
        Me.mothername.Name = "mothername"
        Me.mothername.Size = New System.Drawing.Size(148, 25)
        Me.mothername.TabIndex = 37
        Me.mothername.Text = "Témoin de l'époux:"
        '
        'refma
        '
        Me.refma.Location = New System.Drawing.Point(1195, 453)
        Me.refma.Name = "refma"
        Me.refma.Size = New System.Drawing.Size(425, 22)
        Me.refma.TabIndex = 36
        '
        'off
        '
        Me.off.Location = New System.Drawing.Point(1195, 403)
        Me.off.Name = "off"
        Me.off.Size = New System.Drawing.Size(425, 22)
        Me.off.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(992, 452)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Référence:"
        '
        'hospital
        '
        Me.hospital.AutoSize = True
        Me.hospital.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hospital.ForeColor = System.Drawing.Color.Green
        Me.hospital.Location = New System.Drawing.Point(992, 400)
        Me.hospital.Name = "hospital"
        Me.hospital.Size = New System.Drawing.Size(143, 25)
        Me.hospital.TabIndex = 33
        Me.hospital.Text = "Officier célébrant:"
        '
        'eps
        '
        Me.eps.Location = New System.Drawing.Point(1195, 249)
        Me.eps.Name = "eps"
        Me.eps.Size = New System.Drawing.Size(425, 22)
        Me.eps.TabIndex = 32
        '
        'birthplace
        '
        Me.birthplace.AutoSize = True
        Me.birthplace.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthplace.ForeColor = System.Drawing.Color.Green
        Me.birthplace.Location = New System.Drawing.Point(992, 346)
        Me.birthplace.Name = "birthplace"
        Me.birthplace.Size = New System.Drawing.Size(87, 25)
        Me.birthplace.TabIndex = 31
        Me.birthplace.Text = "Commune:"
        '
        'Childsurname
        '
        Me.Childsurname.AutoSize = True
        Me.Childsurname.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Childsurname.ForeColor = System.Drawing.Color.Green
        Me.Childsurname.Location = New System.Drawing.Point(992, 249)
        Me.Childsurname.Name = "Childsurname"
        Me.Childsurname.Size = New System.Drawing.Size(67, 25)
        Me.Childsurname.TabIndex = 30
        Me.Childsurname.Text = "Epouse:"
        '
        'epx
        '
        Me.epx.Location = New System.Drawing.Point(1195, 197)
        Me.epx.Name = "epx"
        Me.epx.Size = New System.Drawing.Size(425, 22)
        Me.epx.TabIndex = 29
        '
        'birthday
        '
        Me.birthday.AutoSize = True
        Me.birthday.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.ForeColor = System.Drawing.Color.Green
        Me.birthday.Location = New System.Drawing.Point(992, 299)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(132, 25)
        Me.birthday.TabIndex = 28
        Me.birthday.Text = "Date de mariage:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(992, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Epoux:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Dubai Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Ivory
        Me.Button2.Location = New System.Drawing.Point(11, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Actes de Mariage"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Dubai Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Ivory
        Me.Button3.Location = New System.Drawing.Point(11, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(210, 52)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Actes de terrain" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Dubai Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Ivory
        Me.Button1.Location = New System.Drawing.Point(11, 122)
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
        Me.Label1.Location = New System.Drawing.Point(2, 11)
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
        Me.Panel1.Location = New System.Drawing.Point(-2, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 1063)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(241, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1530, 49)
        Me.Panel2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai Medium", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(3, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 48)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Acte de Mariage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ref
        '
        Me.ref.HeaderText = "Référence"
        Me.ref.MinimumWidth = 6
        Me.ref.Name = "ref"
        Me.ref.ReadOnly = True
        Me.ref.Width = 125
        '
        'epoux
        '
        Me.epoux.HeaderText = "Epoux"
        Me.epoux.MinimumWidth = 6
        Me.epoux.Name = "epoux"
        Me.epoux.ReadOnly = True
        Me.epoux.Width = 125
        '
        'epouse
        '
        Me.epouse.HeaderText = "Epouse"
        Me.epouse.MinimumWidth = 6
        Me.epouse.Name = "epouse"
        Me.epouse.ReadOnly = True
        Me.epouse.Width = 125
        '
        'officier
        '
        Me.officier.HeaderText = "Officier célébrant"
        Me.officier.MinimumWidth = 6
        Me.officier.Name = "officier"
        Me.officier.ReadOnly = True
        Me.officier.Width = 125
        '
        'datema
        '
        Me.datema.HeaderText = "Date du mariage"
        Me.datema.MinimumWidth = 6
        Me.datema.Name = "datema"
        Me.datema.ReadOnly = True
        Me.datema.Width = 125
        '
        'commune
        '
        Me.commune.HeaderText = "Commune"
        Me.commune.MinimumWidth = 6
        Me.commune.Name = "commune"
        Me.commune.ReadOnly = True
        Me.commune.Width = 125
        '
        'tem1
        '
        Me.tem1.HeaderText = "Témoin de l'époux"
        Me.tem1.MinimumWidth = 6
        Me.tem1.Name = "tem1"
        Me.tem1.ReadOnly = True
        Me.tem1.Width = 125
        '
        'tem2
        '
        Me.tem2.HeaderText = "Témoin de l'épouse"
        Me.tem2.MinimumWidth = 6
        Me.tem2.Name = "tem2"
        Me.tem2.ReadOnly = True
        Me.tem2.Width = 125
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'mariage_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1920, 1055)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "mariage_list"
        Me.Text = "mariage_list"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.list_mariage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents list_mariage As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents num As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents temoin2 As TextBox
    Friend WithEvents dadname As Label
    Friend WithEvents comm As ComboBox
    Friend WithEvents datma As DateTimePicker
    Friend WithEvents temoin1 As TextBox
    Friend WithEvents mothername As Label
    Friend WithEvents refma As TextBox
    Friend WithEvents off As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents hospital As Label
    Friend WithEvents eps As TextBox
    Friend WithEvents birthplace As Label
    Friend WithEvents Childsurname As Label
    Friend WithEvents epx As TextBox
    Friend WithEvents birthday As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ref As DataGridViewTextBoxColumn
    Friend WithEvents epoux As DataGridViewTextBoxColumn
    Friend WithEvents epouse As DataGridViewTextBoxColumn
    Friend WithEvents officier As DataGridViewTextBoxColumn
    Friend WithEvents datema As DataGridViewTextBoxColumn
    Friend WithEvents commune As DataGridViewTextBoxColumn
    Friend WithEvents tem1 As DataGridViewTextBoxColumn
    Friend WithEvents tem2 As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class
