<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_ferramenta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_ferramenta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_num_serie = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MARCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.cmb_tipo_ferramenta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_mf = New System.Windows.Forms.TextBox()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NÚMERO DE SÉRIE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MARCA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MODELO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(253, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MF:"
        '
        'txt_num_serie
        '
        Me.txt_num_serie.Location = New System.Drawing.Point(25, 171)
        Me.txt_num_serie.Name = "txt_num_serie"
        Me.txt_num_serie.Size = New System.Drawing.Size(152, 20)
        Me.txt_num_serie.TabIndex = 4
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(25, 112)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(152, 20)
        Me.txt_modelo.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MARCAToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 26)
        '
        'MARCAToolStripMenuItem
        '
        Me.MARCAToolStripMenuItem.Name = "MARCAToolStripMenuItem"
        Me.MARCAToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.MARCAToolStripMenuItem.Text = "MARCA"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(190, 231)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(152, 49)
        Me.btn_cadastrar.TabIndex = 9
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'cmb_tipo_ferramenta
        '
        Me.cmb_tipo_ferramenta.FormattingEnabled = True
        Me.cmb_tipo_ferramenta.Items.AddRange(New Object() {"", "PARAFUSADEIRA ANGULAR", "PISTOLA ANGULAR", "SOPRADOR TERMICO", "LIXADEIRA ORBITAL"})
        Me.cmb_tipo_ferramenta.Location = New System.Drawing.Point(356, 111)
        Me.cmb_tipo_ferramenta.Name = "cmb_tipo_ferramenta"
        Me.cmb_tipo_ferramenta.Size = New System.Drawing.Size(152, 21)
        Me.cmb_tipo_ferramenta.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(353, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TIPO DE FERRAMENTA:"
        '
        'txt_mf
        '
        Me.txt_mf.Location = New System.Drawing.Point(215, 68)
        Me.txt_mf.Name = "txt_mf"
        Me.txt_mf.Size = New System.Drawing.Size(97, 20)
        Me.txt_mf.TabIndex = 12
        Me.txt_mf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_marca
        '
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Items.AddRange(New Object() {"", "ATLAS COPCO", "DESOUTTER", "INGERSOL", "STEINEL", "BOSCH", "MAKITA"})
        Me.cmb_marca.Location = New System.Drawing.Point(356, 171)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(152, 21)
        Me.cmb_marca.TabIndex = 13
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(433, 246)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 34)
        Me.btn_voltar.TabIndex = 14
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'frm_cadastro_ferramenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(536, 337)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.cmb_marca)
        Me.Controls.Add(Me.txt_mf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_tipo_ferramenta)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_num_serie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_ferramenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE FERRAMENTAS"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_num_serie As TextBox
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MARCAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents cmb_tipo_ferramenta As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_mf As TextBox
    Friend WithEvents cmb_marca As ComboBox
    Friend WithEvents btn_voltar As Button
End Class
