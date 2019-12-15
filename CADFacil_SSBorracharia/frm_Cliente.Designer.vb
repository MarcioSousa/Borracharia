<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cliente))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCadCompleto = New System.Windows.Forms.Button()
        Me.btnDuvida = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAddCliente = New System.Windows.Forms.Button()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtProcura = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodCli = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblDataCad = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnHistoricoVenda = New System.Windows.Forms.Button()
        Me.dgvProduto = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnCadCompleto)
        Me.Panel2.Controls.Add(Me.btnDuvida)
        Me.Panel2.Controls.Add(Me.btnVoltar)
        Me.Panel2.Controls.Add(Me.btnExcluir)
        Me.Panel2.Controls.Add(Me.btnEditar)
        Me.Panel2.Controls.Add(Me.btnAddCliente)
        Me.Panel2.Controls.Add(Me.dgvCliente)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.txtProcura)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(439, 505)
        Me.Panel2.TabIndex = 19
        '
        'btnCadCompleto
        '
        Me.btnCadCompleto.AutoSize = True
        Me.btnCadCompleto.FlatAppearance.BorderSize = 0
        Me.btnCadCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadCompleto.Image = CType(resources.GetObject("btnCadCompleto.Image"), System.Drawing.Image)
        Me.btnCadCompleto.Location = New System.Drawing.Point(383, 455)
        Me.btnCadCompleto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCadCompleto.Name = "btnCadCompleto"
        Me.btnCadCompleto.Size = New System.Drawing.Size(42, 42)
        Me.btnCadCompleto.TabIndex = 25
        Me.btnCadCompleto.UseVisualStyleBackColor = False
        '
        'btnDuvida
        '
        Me.btnDuvida.AutoSize = True
        Me.btnDuvida.FlatAppearance.BorderSize = 0
        Me.btnDuvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuvida.Image = CType(resources.GetObject("btnDuvida.Image"), System.Drawing.Image)
        Me.btnDuvida.Location = New System.Drawing.Point(110, 455)
        Me.btnDuvida.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDuvida.Name = "btnDuvida"
        Me.btnDuvida.Size = New System.Drawing.Size(42, 42)
        Me.btnDuvida.TabIndex = 24
        Me.btnDuvida.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.AutoSize = True
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.Location = New System.Drawing.Point(9, 455)
        Me.btnVoltar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(42, 42)
        Me.btnVoltar.TabIndex = 23
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.AutoSize = True
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(333, 455)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(42, 42)
        Me.btnExcluir.TabIndex = 22
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = True
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(210, 455)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(42, 42)
        Me.btnEditar.TabIndex = 21
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAddCliente
        '
        Me.btnAddCliente.AutoSize = True
        Me.btnAddCliente.FlatAppearance.BorderSize = 0
        Me.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCliente.Image = CType(resources.GetObject("btnAddCliente.Image"), System.Drawing.Image)
        Me.btnAddCliente.Location = New System.Drawing.Point(160, 455)
        Me.btnAddCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddCliente.Name = "btnAddCliente"
        Me.btnAddCliente.Size = New System.Drawing.Size(42, 42)
        Me.btnAddCliente.TabIndex = 20
        Me.btnAddCliente.UseVisualStyleBackColor = True
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AllowUserToResizeColumns = False
        Me.dgvCliente.AllowUserToResizeRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(4, 71)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(421, 377)
        Me.dgvCliente.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Lista de Clientes"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'txtProcura
        '
        Me.txtProcura.Location = New System.Drawing.Point(38, 14)
        Me.txtProcura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProcura.MaxLength = 40
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.Size = New System.Drawing.Size(387, 26)
        Me.txtProcura.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblCodCli)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblNome)
        Me.Panel1.Controls.Add(Me.lblDataCad)
        Me.Panel1.Controls.Add(Me.label4)
        Me.Panel1.Location = New System.Drawing.Point(445, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 86)
        Me.Panel1.TabIndex = 20
        '
        'lblCodCli
        '
        Me.lblCodCli.AutoSize = True
        Me.lblCodCli.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodCli.Location = New System.Drawing.Point(80, 19)
        Me.lblCodCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodCli.Name = "lblCodCli"
        Me.lblCodCli.Size = New System.Drawing.Size(0, 18)
        Me.lblCodCli.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Cliente:"
        '
        'lblNome
        '
        Me.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(9, 49)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(380, 29)
        Me.lblNome.TabIndex = 19
        '
        'lblDataCad
        '
        Me.lblDataCad.AutoSize = True
        Me.lblDataCad.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataCad.Location = New System.Drawing.Point(275, 17)
        Me.lblDataCad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataCad.Name = "lblDataCad"
        Me.lblDataCad.Size = New System.Drawing.Size(0, 18)
        Me.lblDataCad.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(191, 19)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(76, 18)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Dt. Cad.:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnHistoricoVenda)
        Me.Panel3.Controls.Add(Me.dgvProduto)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(445, 92)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(397, 415)
        Me.Panel3.TabIndex = 21
        '
        'btnHistoricoVenda
        '
        Me.btnHistoricoVenda.AutoSize = True
        Me.btnHistoricoVenda.FlatAppearance.BorderSize = 0
        Me.btnHistoricoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistoricoVenda.Image = CType(resources.GetObject("btnHistoricoVenda.Image"), System.Drawing.Image)
        Me.btnHistoricoVenda.Location = New System.Drawing.Point(4, 365)
        Me.btnHistoricoVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHistoricoVenda.Name = "btnHistoricoVenda"
        Me.btnHistoricoVenda.Size = New System.Drawing.Size(42, 42)
        Me.btnHistoricoVenda.TabIndex = 28
        Me.btnHistoricoVenda.UseVisualStyleBackColor = False
        '
        'dgvProduto
        '
        Me.dgvProduto.AllowUserToAddRows = False
        Me.dgvProduto.AllowUserToDeleteRows = False
        Me.dgvProduto.AllowUserToResizeColumns = False
        Me.dgvProduto.AllowUserToResizeRows = False
        Me.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduto.Location = New System.Drawing.Point(3, 21)
        Me.dgvProduto.MultiSelect = False
        Me.dgvProduto.Name = "dgvProduto"
        Me.dgvProduto.ReadOnly = True
        Me.dgvProduto.RowHeadersVisible = False
        Me.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduto.Size = New System.Drawing.Size(386, 337)
        Me.dgvProduto.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Histórico do Cliente"
        '
        'frm_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(845, 510)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Cliente"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCadCompleto As System.Windows.Forms.Button
    Friend WithEvents btnDuvida As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAddCliente As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtProcura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCodCli As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblDataCad As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProduto As System.Windows.Forms.DataGridView
    Friend WithEvents btnHistoricoVenda As System.Windows.Forms.Button
End Class
