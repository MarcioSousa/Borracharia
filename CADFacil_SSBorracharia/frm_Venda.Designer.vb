<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Venda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Venda))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.dgvVenda = New System.Windows.Forms.DataGridView()
        Me.CODPROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTDE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VUNID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALUNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdSer = New System.Windows.Forms.TextBox()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCodCli = New System.Windows.Forms.Label()
        Me.btnConfirmaCliente = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnCaixa = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxPagamento = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPedido = New System.Windows.Forms.Label()
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Prod./Serv.:"
        '
        'btnConfirma
        '
        Me.btnConfirma.AutoSize = True
        Me.btnConfirma.FlatAppearance.BorderSize = 0
        Me.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirma.Image = CType(resources.GetObject("btnConfirma.Image"), System.Drawing.Image)
        Me.btnConfirma.Location = New System.Drawing.Point(930, 6)
        Me.btnConfirma.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(40, 40)
        Me.btnConfirma.TabIndex = 5
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'btnLimpa
        '
        Me.btnLimpa.AutoSize = True
        Me.btnLimpa.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpa.FlatAppearance.BorderSize = 0
        Me.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpa.Image = CType(resources.GetObject("btnLimpa.Image"), System.Drawing.Image)
        Me.btnLimpa.Location = New System.Drawing.Point(966, 18)
        Me.btnLimpa.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(40, 40)
        Me.btnLimpa.TabIndex = 6
        Me.btnLimpa.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(712, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Valor Unid: R$"
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(841, 12)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(86, 27)
        Me.txtValor.TabIndex = 4
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvVenda
        '
        Me.dgvVenda.AllowUserToAddRows = False
        Me.dgvVenda.AllowUserToDeleteRows = False
        Me.dgvVenda.AllowUserToResizeColumns = False
        Me.dgvVenda.AllowUserToResizeRows = False
        Me.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODPROD, Me.QTDE, Me.DataGridViewTextBoxColumn4, Me.VUNID, Me.TOTAL, Me.VALUNI, Me.VALORTOTAL})
        Me.dgvVenda.Location = New System.Drawing.Point(4, 136)
        Me.dgvVenda.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgvVenda.MultiSelect = False
        Me.dgvVenda.Name = "dgvVenda"
        Me.dgvVenda.RowHeadersVisible = False
        Me.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVenda.Size = New System.Drawing.Size(1004, 404)
        Me.dgvVenda.TabIndex = 7
        '
        'CODPROD
        '
        Me.CODPROD.HeaderText = "CodProd"
        Me.CODPROD.Name = "CODPROD"
        Me.CODPROD.ReadOnly = True
        '
        'QTDE
        '
        Me.QTDE.HeaderText = "Qtde"
        Me.QTDE.Name = "QTDE"
        Me.QTDE.ReadOnly = True
        Me.QTDE.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Produto / Serviço"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 490
        '
        'VUNID
        '
        Me.VUNID.HeaderText = "ValorUnid."
        Me.VUNID.Name = "VUNID"
        Me.VUNID.ReadOnly = True
        Me.VUNID.Width = 150
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "Valor Total"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 150
        '
        'VALUNI
        '
        Me.VALUNI.HeaderText = "ValorUnidade"
        Me.VALUNI.Name = "VALUNI"
        Me.VALUNI.ReadOnly = True
        Me.VALUNI.Visible = False
        Me.VALUNI.Width = 150
        '
        'VALORTOTAL
        '
        Me.VALORTOTAL.HeaderText = "ValorTotal"
        Me.VALORTOTAL.Name = "VALORTOTAL"
        Me.VALORTOTAL.ReadOnly = True
        Me.VALORTOTAL.Visible = False
        Me.VALORTOTAL.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(579, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Qtde:"
        '
        'txtProdSer
        '
        Me.txtProdSer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProdSer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProdSer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdSer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdSer.Location = New System.Drawing.Point(255, 12)
        Me.txtProdSer.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtProdSer.Name = "txtProdSer"
        Me.txtProdSer.Size = New System.Drawing.Size(316, 27)
        Me.txtProdSer.TabIndex = 2
        '
        'txtQtde
        '
        Me.txtQtde.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtde.Location = New System.Drawing.Point(632, 12)
        Me.txtQtde.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(70, 27)
        Me.txtQtde.TabIndex = 3
        Me.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtCodProd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnConfirma)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtQtde)
        Me.Panel1.Controls.Add(Me.txtValor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtProdSer)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(4, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 58)
        Me.Panel1.TabIndex = 0
        '
        'txtCodProd
        '
        Me.txtCodProd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(50, 12)
        Me.txtCodProd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(86, 27)
        Me.txtCodProd.TabIndex = 1
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Cod:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 25)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Total Compra"
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalCompra.Enabled = False
        Me.txtTotalCompra.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompra.Location = New System.Drawing.Point(50, 43)
        Me.txtTotalCompra.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.ReadOnly = True
        Me.txtTotalCompra.Size = New System.Drawing.Size(104, 24)
        Me.txtTotalCompra.TabIndex = 78
        Me.txtTotalCompra.Text = "0,00"
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVoltar
        '
        Me.btnVoltar.AutoSize = True
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.Location = New System.Drawing.Point(4, 640)
        Me.btnVoltar.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(80, 80)
        Me.btnVoltar.TabIndex = 78
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Cod:"
        '
        'lblCodCli
        '
        Me.lblCodCli.AutoSize = True
        Me.lblCodCli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodCli.Location = New System.Drawing.Point(238, 11)
        Me.lblCodCli.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCodCli.Name = "lblCodCli"
        Me.lblCodCli.Size = New System.Drawing.Size(0, 16)
        Me.lblCodCli.TabIndex = 24
        '
        'btnConfirmaCliente
        '
        Me.btnConfirmaCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmaCliente.FlatAppearance.BorderSize = 0
        Me.btnConfirmaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmaCliente.Image = CType(resources.GetObject("btnConfirmaCliente.Image"), System.Drawing.Image)
        Me.btnConfirmaCliente.Location = New System.Drawing.Point(502, 18)
        Me.btnConfirmaCliente.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnConfirmaCliente.Name = "btnConfirmaCliente"
        Me.btnConfirmaCliente.Size = New System.Drawing.Size(40, 40)
        Me.btnConfirmaCliente.TabIndex = 5
        Me.btnConfirmaCliente.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Nome do Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(4, 31)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(488, 27)
        Me.txtCliente.TabIndex = 2
        '
        'btnCaixa
        '
        Me.btnCaixa.AutoSize = True
        Me.btnCaixa.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCaixa.FlatAppearance.BorderSize = 0
        Me.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaixa.Image = CType(resources.GetObject("btnCaixa.Image"), System.Drawing.Image)
        Me.btnCaixa.Location = New System.Drawing.Point(925, 640)
        Me.btnCaixa.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnCaixa.Name = "btnCaixa"
        Me.btnCaixa.Size = New System.Drawing.Size(81, 80)
        Me.btnCaixa.TabIndex = 78
        Me.btnCaixa.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(277, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 25)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Pagamento"
        '
        'cbxPagamento
        '
        Me.cbxPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPagamento.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPagamento.FormattingEnabled = True
        Me.cbxPagamento.Items.AddRange(New Object() {"DINHEIRO", "CHEQUE", "DÉBITO", "CRÉDITO", "MARCAR"})
        Me.cbxPagamento.Location = New System.Drawing.Point(282, 41)
        Me.cbxPagamento.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cbxPagamento.Name = "cbxPagamento"
        Me.cbxPagamento.Size = New System.Drawing.Size(151, 26)
        Me.cbxPagamento.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(576, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 25)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Desconto"
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(581, 36)
        Me.txtDesconto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtDesconto.MaxLength = 4
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(56, 31)
        Me.txtDesconto.TabIndex = 84
        Me.txtDesconto.Text = "0"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(647, 44)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 23)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(816, 7)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 25)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(835, 36)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(114, 24)
        Me.txtTotal.TabIndex = 87
        Me.txtTotal.Text = "0,00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(794, 36)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(31, 24)
        Me.TextBox2.TabIndex = 89
        Me.TextBox2.Text = "R$"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(11, 43)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(29, 24)
        Me.TextBox1.TabIndex = 88
        Me.TextBox1.Text = "R$"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbxPagamento)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.txtDesconto)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtTotalCompra)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(4, 545)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 85)
        Me.Panel3.TabIndex = 88
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1014, 735)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pbxLogo.Location = New System.Drawing.Point(599, 3)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(306, 68)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 90
        Me.pbxLogo.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(322, 9)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 18)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "PEDIDO Nº:"
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPedido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedido.Location = New System.Drawing.Point(427, 6)
        Me.lblPedido.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(32, 22)
        Me.lblPedido.TabIndex = 93
        Me.lblPedido.Text = "10"
        '
        'frm_Venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 735)
        Me.Controls.Add(Me.lblPedido)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblCodCli)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnConfirmaCliente)
        Me.Controls.Add(Me.btnCaixa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvVenda)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Venda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda"
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents dgvVenda As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProdSer As System.Windows.Forms.TextBox
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCompra As System.Windows.Forms.TextBox
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmaCliente As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblCodCli As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCaixa As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxPagamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblPedido As System.Windows.Forms.Label
    Friend WithEvents CODPROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTDE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VUNID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALUNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALORTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
