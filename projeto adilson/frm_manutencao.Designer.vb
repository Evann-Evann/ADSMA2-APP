<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_manutencao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_manutencao))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_srm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_hora_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_turno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_data = New System.Windows.Forms.DateTimePicker()
        Me.cmb_hora_termino = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_problema = New System.Windows.Forms.RichTextBox()
        Me.txt_servico = New System.Windows.Forms.RichTextBox()
        Me.cmb_situacao = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PROBLEMA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 532)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SERVIÇO REALIZADO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NÚMERO DA ORDEM DE ENTRADA (SRM):"
        '
        'txt_srm
        '
        Me.txt_srm.Location = New System.Drawing.Point(12, 216)
        Me.txt_srm.Name = "txt_srm"
        Me.txt_srm.Size = New System.Drawing.Size(140, 20)
        Me.txt_srm.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "HORÁRIO DE INÍCIO:"
        '
        'cmb_hora_inicio
        '
        Me.cmb_hora_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.cmb_hora_inicio.Location = New System.Drawing.Point(12, 86)
        Me.cmb_hora_inicio.Name = "cmb_hora_inicio"
        Me.cmb_hora_inicio.Size = New System.Drawing.Size(86, 20)
        Me.cmb_hora_inicio.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TURNO:"
        '
        'cmb_turno
        '
        Me.cmb_turno.FormattingEnabled = True
        Me.cmb_turno.Items.AddRange(New Object() {"", "A", "B", "C"})
        Me.cmb_turno.Location = New System.Drawing.Point(201, 35)
        Me.cmb_turno.Name = "cmb_turno"
        Me.cmb_turno.Size = New System.Drawing.Size(80, 21)
        Me.cmb_turno.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA:"
        '
        'cmb_data
        '
        Me.cmb_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data.Location = New System.Drawing.Point(12, 32)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(105, 20)
        Me.cmb_data.TabIndex = 0
        '
        'cmb_hora_termino
        '
        Me.cmb_hora_termino.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.cmb_hora_termino.Location = New System.Drawing.Point(12, 138)
        Me.cmb_hora_termino.Name = "cmb_hora_termino"
        Me.cmb_hora_termino.Size = New System.Drawing.Size(86, 20)
        Me.cmb_hora_termino.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "HORÁRIO DE TÉRMINO:"
        '
        'txt_problema
        '
        Me.txt_problema.Location = New System.Drawing.Point(12, 405)
        Me.txt_problema.Name = "txt_problema"
        Me.txt_problema.Size = New System.Drawing.Size(776, 113)
        Me.txt_problema.TabIndex = 18
        Me.txt_problema.Text = ""
        '
        'txt_servico
        '
        Me.txt_servico.Location = New System.Drawing.Point(12, 551)
        Me.txt_servico.Name = "txt_servico"
        Me.txt_servico.Size = New System.Drawing.Size(776, 125)
        Me.txt_servico.TabIndex = 19
        Me.txt_servico.Text = ""
        '
        'cmb_situacao
        '
        Me.cmb_situacao.FormattingEnabled = True
        Me.cmb_situacao.Items.AddRange(New Object() {"", "EM MANUTENCAO", "FERRAMENTA REPARADA", "FERRAMENTA AGUARDARA PECA"})
        Me.cmb_situacao.Location = New System.Drawing.Point(307, 216)
        Me.cmb_situacao.Name = "cmb_situacao"
        Me.cmb_situacao.Size = New System.Drawing.Size(267, 21)
        Me.cmb_situacao.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "SITUAÇÃO DA FERRAMENTA:"
        '
        'btn_salvar
        '
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.Location = New System.Drawing.Point(615, 35)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(173, 62)
        Me.btn_salvar.TabIndex = 22
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(615, 119)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(173, 62)
        Me.btn_voltar.TabIndex = 24
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_dados.Location = New System.Drawing.Point(12, 252)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.Size = New System.Drawing.Size(743, 73)
        Me.dgv_dados.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(158, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 31)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "MF"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "NÚMERO DE SÉRIE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "MODELO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "MARCA"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "CLIENTE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "SITUAÇÃO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'frm_manutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 702)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_situacao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_hora_termino)
        Me.Controls.Add(Me.cmb_hora_inicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_data)
        Me.Controls.Add(Me.txt_servico)
        Me.Controls.Add(Me.cmb_turno)
        Me.Controls.Add(Me.txt_problema)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_srm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_manutencao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANUTENÇÃO DE FERRAMENTA"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_srm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_hora_inicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_turno As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_data As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_hora_termino As DateTimePicker
    Friend WithEvents txt_problema As RichTextBox
    Friend WithEvents txt_servico As RichTextBox
    Friend WithEvents cmb_situacao As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
