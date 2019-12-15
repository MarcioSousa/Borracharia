<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HistoricoVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HistoricoVenda))
        Me.dgvHistorico = New System.Windows.Forms.DataGridView()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.dtpDataCompra = New System.Windows.Forms.DateTimePicker()
        Me.lblTipoPagam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbxTodos = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxPagamento = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpTermino = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.dgvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvHistorico
        '
        Me.dgvHistorico.AllowUserToAddRows = False
        Me.dgvHistorico.AllowUserToDeleteRows = False
        Me.dgvHistorico.AllowUserToResizeColumns = False
        Me.dgvHistorico.AllowUserToResizeRows = False
        Me.dgvHistorico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorico.Location = New System.Drawing.Point(4, 38)
        Me.dgvHistorico.MultiSelect = False
        Me.dgvHistorico.Name = "dgvHistorico"
        Me.dgvHistorico.ReadOnly = True
        Me.dgvHistorico.RowHeadersVisible = False
        Me.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorico.Size = New System.Drawing.Size(653, 270)
        Me.dgvHistorico.TabIndex = 30
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNome.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(3, 5)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(117, 18)
        Me.lblNome.TabIndex = 31
        Me.lblNome.Text = "Nome Cliente"
        '
        'dtpDataCompra
        '
        Me.dtpDataCompra.Enabled = False
        Me.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataCompra.Location = New System.Drawing.Point(100, 5)
        Me.dtpDataCompra.Name = "dtpDataCompra"
        Me.dtpDataCompra.Size = New System.Drawing.Size(121, 27)
        Me.dtpDataCompra.TabIndex = 32
        '
        'lblTipoPagam
        '
        Me.lblTipoPagam.AutoSize = True
        Me.lblTipoPagam.Location = New System.Drawing.Point(306, 11)
        Me.lblTipoPagam.Name = "lblTipoPagam"
        Me.lblTipoPagam.Size = New System.Drawing.Size(92, 18)
        Me.lblTipoPagam.TabIndex = 33
        Me.lblTipoPagam.Text = "DINHEIRO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(440, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Desconto:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(537, 11)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(47, 18)
        Me.lblDesc.TabIndex = 35
        Me.lblDesc.Text = "Desc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Pag.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Compra:"
        '
        'btnExcluir
        '
        Me.btnExcluir.AutoSize = True
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(12, 473)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(42, 42)
        Me.btnExcluir.TabIndex = 38
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dgvHistorico)
        Me.Panel1.Controls.Add(Me.dtpDataCompra)
        Me.Panel1.Controls.Add(Me.lblTipoPagam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Location = New System.Drawing.Point(12, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 315)
        Me.Panel1.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblNome)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(665, 32)
        Me.Panel2.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cbxTodos)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(12, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(665, 95)
        Me.Panel3.TabIndex = 43
        '
        'cbxTodos
        '
        Me.cbxTodos.AutoSize = True
        Me.cbxTodos.Checked = True
        Me.cbxTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxTodos.Location = New System.Drawing.Point(36, 50)
        Me.cbxTodos.Name = "cbxTodos"
        Me.cbxTodos.Size = New System.Drawing.Size(74, 22)
        Me.cbxTodos.TabIndex = 46
        Me.cbxTodos.Text = "Todos"
        Me.cbxTodos.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.cbxPagamento)
        Me.Panel5.Location = New System.Drawing.Point(481, -2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(182, 97)
        Me.Panel5.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Pagamento"
        '
        'cbxPagamento
        '
        Me.cbxPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPagamento.FormattingEnabled = True
        Me.cbxPagamento.Location = New System.Drawing.Point(14, 36)
        Me.cbxPagamento.Name = "cbxPagamento"
        Me.cbxPagamento.Size = New System.Drawing.Size(143, 26)
        Me.cbxPagamento.TabIndex = 43
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.dtpInicio)
        Me.Panel4.Controls.Add(Me.dtpTermino)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(164, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(317, 97)
        Me.Panel4.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Compra:"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(167, 16)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(121, 27)
        Me.dtpInicio.TabIndex = 38
        '
        'dtpTermino
        '
        Me.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermino.Location = New System.Drawing.Point(167, 49)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(121, 27)
        Me.dtpTermino.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Término"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Início"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Filtro de pesquisa"
        '
        'btnFechar
        '
        Me.btnFechar.AutoSize = True
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(635, 473)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(42, 42)
        Me.btnFechar.TabIndex = 44
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frm_HistoricoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(687, 528)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_HistoricoVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historico Completo de Vendas"
        CType(Me.dgvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents dtpDataCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTipoPagam As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxPagamento As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
