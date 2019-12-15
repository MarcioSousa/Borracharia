<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Servico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Servico))
        Me.txtValorSer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomeSer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodSer = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnDuvida = New System.Windows.Forms.Button()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.dgvServico = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValorSer
        '
        Me.txtValorSer.Enabled = False
        Me.txtValorSer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorSer.Location = New System.Drawing.Point(83, 73)
        Me.txtValorSer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorSer.Name = "txtValorSer"
        Me.txtValorSer.Size = New System.Drawing.Size(110, 23)
        Me.txtValorSer.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Valor: R$"
        '
        'txtNomeSer
        '
        Me.txtNomeSer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeSer.Enabled = False
        Me.txtNomeSer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeSer.Location = New System.Drawing.Point(83, 42)
        Me.txtNomeSer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomeSer.Name = "txtNomeSer"
        Me.txtNomeSer.Size = New System.Drawing.Size(377, 23)
        Me.txtNomeSer.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Codigo"
        '
        'txtCodSer
        '
        Me.txtCodSer.Enabled = False
        Me.txtCodSer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSer.Location = New System.Drawing.Point(83, 11)
        Me.txtCodSer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodSer.Name = "txtCodSer"
        Me.txtCodSer.Size = New System.Drawing.Size(87, 23)
        Me.txtCodSer.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtCodSer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtValorSer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtNomeSer)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 113)
        Me.Panel1.TabIndex = 82
        '
        'btnCancela
        '
        Me.btnCancela.Enabled = False
        Me.btnCancela.FlatAppearance.BorderSize = 0
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.Location = New System.Drawing.Point(398, 124)
        Me.btnCancela.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(47, 47)
        Me.btnCancela.TabIndex = 99
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(239, 124)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 47)
        Me.btnEditar.TabIndex = 106
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(292, 124)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(47, 47)
        Me.btnExcluir.TabIndex = 105
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(186, 124)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(47, 47)
        Me.btnAdicionar.TabIndex = 104
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Enabled = False
        Me.btnLimpar.FlatAppearance.BorderSize = 0
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.Location = New System.Drawing.Point(133, 124)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(47, 47)
        Me.btnLimpar.TabIndex = 100
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(27, 124)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(47, 47)
        Me.btnHome.TabIndex = 103
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnDuvida
        '
        Me.btnDuvida.FlatAppearance.BorderSize = 0
        Me.btnDuvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuvida.Image = CType(resources.GetObject("btnDuvida.Image"), System.Drawing.Image)
        Me.btnDuvida.Location = New System.Drawing.Point(80, 124)
        Me.btnDuvida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDuvida.Name = "btnDuvida"
        Me.btnDuvida.Size = New System.Drawing.Size(47, 47)
        Me.btnDuvida.TabIndex = 101
        Me.btnDuvida.UseVisualStyleBackColor = True
        '
        'btnConfirma
        '
        Me.btnConfirma.Enabled = False
        Me.btnConfirma.FlatAppearance.BorderSize = 0
        Me.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirma.Image = CType(resources.GetObject("btnConfirma.Image"), System.Drawing.Image)
        Me.btnConfirma.Location = New System.Drawing.Point(345, 124)
        Me.btnConfirma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(47, 47)
        Me.btnConfirma.TabIndex = 98
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'dgvServico
        '
        Me.dgvServico.AllowUserToAddRows = False
        Me.dgvServico.AllowUserToDeleteRows = False
        Me.dgvServico.AllowUserToResizeColumns = False
        Me.dgvServico.AllowUserToResizeRows = False
        Me.dgvServico.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvServico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServico.Location = New System.Drawing.Point(4, 178)
        Me.dgvServico.MultiSelect = False
        Me.dgvServico.Name = "dgvServico"
        Me.dgvServico.RowHeadersVisible = False
        Me.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServico.Size = New System.Drawing.Size(468, 224)
        Me.dgvServico.TabIndex = 107
        '
        'frm_Servico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(475, 408)
        Me.Controls.Add(Me.dgvServico)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnDuvida)
        Me.Controls.Add(Me.btnConfirma)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Servico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviços"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtValorSer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNomeSer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodSer As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnDuvida As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents dgvServico As System.Windows.Forms.DataGridView
End Class
