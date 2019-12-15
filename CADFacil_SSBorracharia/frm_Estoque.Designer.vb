<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Estoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Estoque))
        Me.dgvEstoque = New System.Windows.Forms.DataGridView()
        Me.dtpDataUlt = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.txtQtdeAtual = New System.Windows.Forms.TextBox()
        Me.txtQtdeMin = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnInicial = New System.Windows.Forms.Button()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.btnAjuda = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDiminuir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtEstocar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiminui = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEstoque
        '
        Me.dgvEstoque.AllowUserToAddRows = False
        Me.dgvEstoque.AllowUserToDeleteRows = False
        Me.dgvEstoque.AllowUserToResizeColumns = False
        Me.dgvEstoque.AllowUserToResizeRows = False
        Me.dgvEstoque.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstoque.Location = New System.Drawing.Point(2, 157)
        Me.dgvEstoque.MultiSelect = False
        Me.dgvEstoque.Name = "dgvEstoque"
        Me.dgvEstoque.ReadOnly = True
        Me.dgvEstoque.RowHeadersVisible = False
        Me.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstoque.Size = New System.Drawing.Size(621, 301)
        Me.dgvEstoque.TabIndex = 8
        '
        'dtpDataUlt
        '
        Me.dtpDataUlt.Enabled = False
        Me.dtpDataUlt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataUlt.Location = New System.Drawing.Point(491, 12)
        Me.dtpDataUlt.Name = "dtpDataUlt"
        Me.dtpDataUlt.Size = New System.Drawing.Size(123, 22)
        Me.dtpDataUlt.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Dt Últ. Est."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Qtde Atual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Qtde Mín."
        '
        'txtNomeProd
        '
        Me.txtNomeProd.Enabled = False
        Me.txtNomeProd.Location = New System.Drawing.Point(85, 10)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.Size = New System.Drawing.Size(318, 22)
        Me.txtNomeProd.TabIndex = 14
        '
        'txtQtdeAtual
        '
        Me.txtQtdeAtual.Enabled = False
        Me.txtQtdeAtual.Location = New System.Drawing.Point(85, 48)
        Me.txtQtdeAtual.Name = "txtQtdeAtual"
        Me.txtQtdeAtual.Size = New System.Drawing.Size(79, 22)
        Me.txtQtdeAtual.TabIndex = 15
        '
        'txtQtdeMin
        '
        Me.txtQtdeMin.Enabled = False
        Me.txtQtdeMin.Location = New System.Drawing.Point(245, 48)
        Me.txtQtdeMin.Name = "txtQtdeMin"
        Me.txtQtdeMin.Size = New System.Drawing.Size(79, 22)
        Me.txtQtdeMin.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnInicial)
        Me.Panel3.Controls.Add(Me.btnConfirma)
        Me.Panel3.Controls.Add(Me.btnAjuda)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnDiminuir)
        Me.Panel3.Controls.Add(Me.btnNovo)
        Me.Panel3.Location = New System.Drawing.Point(2, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(621, 61)
        Me.Panel3.TabIndex = 80
        '
        'btnInicial
        '
        Me.btnInicial.FlatAppearance.BorderSize = 0
        Me.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicial.Image = CType(resources.GetObject("btnInicial.Image"), System.Drawing.Image)
        Me.btnInicial.Location = New System.Drawing.Point(144, 6)
        Me.btnInicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInicial.Name = "btnInicial"
        Me.btnInicial.Size = New System.Drawing.Size(47, 47)
        Me.btnInicial.TabIndex = 73
        Me.btnInicial.UseVisualStyleBackColor = True
        '
        'btnConfirma
        '
        Me.btnConfirma.Enabled = False
        Me.btnConfirma.FlatAppearance.BorderSize = 0
        Me.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirma.Image = CType(resources.GetObject("btnConfirma.Image"), System.Drawing.Image)
        Me.btnConfirma.Location = New System.Drawing.Point(356, 6)
        Me.btnConfirma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(47, 47)
        Me.btnConfirma.TabIndex = 68
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'btnAjuda
        '
        Me.btnAjuda.FlatAppearance.BorderSize = 0
        Me.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjuda.Image = CType(resources.GetObject("btnAjuda.Image"), System.Drawing.Image)
        Me.btnAjuda.Location = New System.Drawing.Point(197, 6)
        Me.btnAjuda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAjuda.Name = "btnAjuda"
        Me.btnAjuda.Size = New System.Drawing.Size(47, 47)
        Me.btnAjuda.TabIndex = 71
        Me.btnAjuda.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(409, 6)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(47, 47)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnDiminuir
        '
        Me.btnDiminuir.FlatAppearance.BorderSize = 0
        Me.btnDiminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiminuir.Image = CType(resources.GetObject("btnDiminuir.Image"), System.Drawing.Image)
        Me.btnDiminuir.Location = New System.Drawing.Point(303, 6)
        Me.btnDiminuir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDiminuir.Name = "btnDiminuir"
        Me.btnDiminuir.Size = New System.Drawing.Size(47, 47)
        Me.btnDiminuir.TabIndex = 76
        Me.btnDiminuir.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(250, 6)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(47, 47)
        Me.btnNovo.TabIndex = 74
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtEstocar
        '
        Me.txtEstocar.Enabled = False
        Me.txtEstocar.Location = New System.Drawing.Point(399, 48)
        Me.txtEstocar.MaxLength = 8
        Me.txtEstocar.Name = "txtEstocar"
        Me.txtEstocar.Size = New System.Drawing.Size(79, 22)
        Me.txtEstocar.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Estocar"
        '
        'txtDiminui
        '
        Me.txtDiminui.Enabled = False
        Me.txtDiminui.Location = New System.Drawing.Point(535, 48)
        Me.txtDiminui.MaxLength = 8
        Me.txtDiminui.Name = "txtDiminui"
        Me.txtDiminui.Size = New System.Drawing.Size(79, 22)
        Me.txtDiminui.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Dimin."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtDiminui)
        Me.Panel1.Controls.Add(Me.dtpDataUlt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtEstocar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtNomeProd)
        Me.Panel1.Controls.Add(Me.txtQtdeMin)
        Me.Panel1.Controls.Add(Me.txtQtdeAtual)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 87)
        Me.Panel1.TabIndex = 86
        '
        'frm_Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(627, 462)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvEstoque)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque"
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEstoque As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDataUlt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNomeProd As System.Windows.Forms.TextBox
    Friend WithEvents txtQtdeAtual As System.Windows.Forms.TextBox
    Friend WithEvents txtQtdeMin As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnInicial As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents btnAjuda As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnDiminuir As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents txtEstocar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiminui As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
