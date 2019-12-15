<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosEServiçosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbxFundo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnF8 = New System.Windows.Forms.Button()
        Me.btnF7 = New System.Windows.Forms.Button()
        Me.btnF6 = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.btnF4 = New System.Windows.Forms.Button()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.btnF2 = New System.Windows.Forms.Button()
        Me.btnF1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCliente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssProdServ = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssVenda = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbCompleto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbProduto = New System.Windows.Forms.ToolStripButton()
        Me.tsbServico = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbVenda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGrafico = New System.Windows.Forms.ToolStripButton()
        Me.tsbEstoque = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEncerra = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBackup = New System.Windows.Forms.ToolStripButton()
        Me.dgvVerEst = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblLetre1 = New System.Windows.Forms.Label()
        Me.lblLetre2 = New System.Windows.Forms.Label()
        Me.lblLetre3 = New System.Windows.Forms.Label()
        Me.lblLetre4 = New System.Windows.Forms.Label()
        Me.pbxWatts = New System.Windows.Forms.PictureBox()
        Me.lblLetre5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxFundo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvVerEst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxWatts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(893, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ProdutosEServiçosToolStripMenuItem1, Me.ServiçosToolStripMenuItem, Me.ToolStripMenuItem2, Me.VendaToolStripMenuItem, Me.ToolStripMenuItem1, Me.SairToolStripMenuItem1})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CadastrarToolStripMenuItem.Text = "Cadastros"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Image = CType(resources.GetObject("ClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ClienteToolStripMenuItem.Text = "Clientes"
        '
        'ProdutosEServiçosToolStripMenuItem1
        '
        Me.ProdutosEServiçosToolStripMenuItem1.Image = CType(resources.GetObject("ProdutosEServiçosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ProdutosEServiçosToolStripMenuItem1.Name = "ProdutosEServiçosToolStripMenuItem1"
        Me.ProdutosEServiçosToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ProdutosEServiçosToolStripMenuItem1.Text = "Produtos"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(119, 6)
        '
        'VendaToolStripMenuItem
        '
        Me.VendaToolStripMenuItem.Image = CType(resources.GetObject("VendaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendaToolStripMenuItem.Name = "VendaToolStripMenuItem"
        Me.VendaToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VendaToolStripMenuItem.Text = "Venda"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 6)
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Image = CType(resources.GetObject("SairToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContatoToolStripMenuItem})
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'ContatoToolStripMenuItem
        '
        Me.ContatoToolStripMenuItem.Image = CType(resources.GetObject("ContatoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContatoToolStripMenuItem.Name = "ContatoToolStripMenuItem"
        Me.ContatoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ContatoToolStripMenuItem.Text = "Contato"
        '
        'pbxFundo
        '
        Me.pbxFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxFundo.Image = CType(resources.GetObject("pbxFundo.Image"), System.Drawing.Image)
        Me.pbxFundo.Location = New System.Drawing.Point(0, 0)
        Me.pbxFundo.Name = "pbxFundo"
        Me.pbxFundo.Size = New System.Drawing.Size(893, 530)
        Me.pbxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFundo.TabIndex = 13
        Me.pbxFundo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnF8)
        Me.GroupBox1.Controls.Add(Me.btnF7)
        Me.GroupBox1.Controls.Add(Me.btnF6)
        Me.GroupBox1.Controls.Add(Me.btnF5)
        Me.GroupBox1.Controls.Add(Me.btnF4)
        Me.GroupBox1.Controls.Add(Me.btnF3)
        Me.GroupBox1.Controls.Add(Me.btnF2)
        Me.GroupBox1.Controls.Add(Me.btnF1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 246)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnF8
        '
        Me.btnF8.AutoSize = True
        Me.btnF8.FlatAppearance.BorderSize = 0
        Me.btnF8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF8.Location = New System.Drawing.Point(6, 205)
        Me.btnF8.Name = "btnF8"
        Me.btnF8.Size = New System.Drawing.Size(191, 30)
        Me.btnF8.TabIndex = 15
        Me.btnF8.Text = "F8 - Encerrar"
        Me.btnF8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF8.UseVisualStyleBackColor = True
        '
        'btnF7
        '
        Me.btnF7.AutoSize = True
        Me.btnF7.FlatAppearance.BorderSize = 0
        Me.btnF7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF7.Location = New System.Drawing.Point(6, 178)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(191, 30)
        Me.btnF7.TabIndex = 14
        Me.btnF7.Text = "F7 - Verifica Estoque"
        Me.btnF7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF7.UseVisualStyleBackColor = True
        '
        'btnF6
        '
        Me.btnF6.AutoSize = True
        Me.btnF6.FlatAppearance.BorderSize = 0
        Me.btnF6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF6.Location = New System.Drawing.Point(6, 151)
        Me.btnF6.Name = "btnF6"
        Me.btnF6.Size = New System.Drawing.Size(191, 30)
        Me.btnF6.TabIndex = 13
        Me.btnF6.Text = "F6 - Mostrar Gráficos"
        Me.btnF6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF6.UseVisualStyleBackColor = True
        '
        'btnF5
        '
        Me.btnF5.AutoSize = True
        Me.btnF5.FlatAppearance.BorderSize = 0
        Me.btnF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF5.Location = New System.Drawing.Point(6, 124)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(191, 30)
        Me.btnF5.TabIndex = 12
        Me.btnF5.Text = "F5 - Iniciar Venda"
        Me.btnF5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF5.UseVisualStyleBackColor = True
        '
        'btnF4
        '
        Me.btnF4.AutoSize = True
        Me.btnF4.FlatAppearance.BorderSize = 0
        Me.btnF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF4.Location = New System.Drawing.Point(6, 97)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(191, 30)
        Me.btnF4.TabIndex = 11
        Me.btnF4.Text = "F4 - Listar Serviços"
        Me.btnF4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF4.UseVisualStyleBackColor = True
        '
        'btnF3
        '
        Me.btnF3.AutoSize = True
        Me.btnF3.FlatAppearance.BorderSize = 0
        Me.btnF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF3.Location = New System.Drawing.Point(6, 70)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(191, 30)
        Me.btnF3.TabIndex = 10
        Me.btnF3.Text = "F3 - Listar Produtos"
        Me.btnF3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF3.UseVisualStyleBackColor = True
        '
        'btnF2
        '
        Me.btnF2.AutoSize = True
        Me.btnF2.FlatAppearance.BorderSize = 0
        Me.btnF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF2.Location = New System.Drawing.Point(6, 43)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(191, 30)
        Me.btnF2.TabIndex = 9
        Me.btnF2.Text = "F2 - Vendas"
        Me.btnF2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF2.UseVisualStyleBackColor = True
        '
        'btnF1
        '
        Me.btnF1.AutoSize = True
        Me.btnF1.FlatAppearance.BorderSize = 0
        Me.btnF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF1.Location = New System.Drawing.Point(6, 16)
        Me.btnF1.Name = "btnF1"
        Me.btnF1.Size = New System.Drawing.Size(191, 30)
        Me.btnF1.TabIndex = 8
        Me.btnF1.Text = "F1 - Novo Cliente"
        Me.btnF1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnF1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tssCliente, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.tssProdServ, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.tssVenda})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 508)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(893, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "Clientes Cadastrados:"
        '
        'tssCliente
        '
        Me.tssCliente.Name = "tssCliente"
        Me.tssCliente.Size = New System.Drawing.Size(13, 17)
        Me.tssCliente.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(174, 17)
        Me.ToolStripStatusLabel4.Text = "Produtos/Serviços Cadastrados:"
        '
        'tssProdServ
        '
        Me.tssProdServ.Name = "tssProdServ"
        Me.tssProdServ.Size = New System.Drawing.Size(13, 17)
        Me.tssProdServ.Text = "0"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel6.Text = "|"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel7.Text = "Vendas Efetuadas:"
        '
        'tssVenda
        '
        Me.tssVenda.Name = "tssVenda"
        Me.tssVenda.Size = New System.Drawing.Size(13, 17)
        Me.tssVenda.Text = "0"
        '
        'tsbNovo
        '
        Me.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNovo.Image = CType(resources.GetObject("tsbNovo.Image"), System.Drawing.Image)
        Me.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNovo.Name = "tsbNovo"
        Me.tsbNovo.Size = New System.Drawing.Size(44, 44)
        Me.tsbNovo.Text = "Novo Cliente"
        '
        'tsbCompleto
        '
        Me.tsbCompleto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCompleto.Image = CType(resources.GetObject("tsbCompleto.Image"), System.Drawing.Image)
        Me.tsbCompleto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCompleto.Name = "tsbCompleto"
        Me.tsbCompleto.Size = New System.Drawing.Size(44, 44)
        Me.tsbCompleto.Text = "Lista de Cadastro de Clientes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'tsbProduto
        '
        Me.tsbProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProduto.Image = CType(resources.GetObject("tsbProduto.Image"), System.Drawing.Image)
        Me.tsbProduto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProduto.Name = "tsbProduto"
        Me.tsbProduto.Size = New System.Drawing.Size(44, 44)
        Me.tsbProduto.Text = "Lista de Produtos"
        '
        'tsbServico
        '
        Me.tsbServico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbServico.Image = CType(resources.GetObject("tsbServico.Image"), System.Drawing.Image)
        Me.tsbServico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbServico.Name = "tsbServico"
        Me.tsbServico.Size = New System.Drawing.Size(44, 44)
        Me.tsbServico.Text = "Lista de Serviços"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'tsbVenda
        '
        Me.tsbVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbVenda.Image = CType(resources.GetObject("tsbVenda.Image"), System.Drawing.Image)
        Me.tsbVenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVenda.Name = "tsbVenda"
        Me.tsbVenda.Size = New System.Drawing.Size(44, 44)
        Me.tsbVenda.Text = "Iniciar Venda"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 47)
        '
        'tsbGrafico
        '
        Me.tsbGrafico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrafico.Image = CType(resources.GetObject("tsbGrafico.Image"), System.Drawing.Image)
        Me.tsbGrafico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrafico.Name = "tsbGrafico"
        Me.tsbGrafico.Size = New System.Drawing.Size(44, 44)
        Me.tsbGrafico.Text = "Gráficos"
        '
        'tsbEstoque
        '
        Me.tsbEstoque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEstoque.Image = CType(resources.GetObject("tsbEstoque.Image"), System.Drawing.Image)
        Me.tsbEstoque.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEstoque.Name = "tsbEstoque"
        Me.tsbEstoque.Size = New System.Drawing.Size(44, 44)
        Me.tsbEstoque.Text = "Estoque"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 47)
        '
        'tsbEncerra
        '
        Me.tsbEncerra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEncerra.Image = CType(resources.GetObject("tsbEncerra.Image"), System.Drawing.Image)
        Me.tsbEncerra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEncerra.Name = "tsbEncerra"
        Me.tsbEncerra.Size = New System.Drawing.Size(44, 44)
        Me.tsbEncerra.Text = "Fechar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.tsbCompleto, Me.ToolStripSeparator1, Me.tsbProduto, Me.tsbServico, Me.ToolStripSeparator2, Me.tsbVenda, Me.ToolStripSeparator3, Me.tsbGrafico, Me.tsbEstoque, Me.btnBackup, Me.ToolStripSeparator4, Me.tsbEncerra})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 47)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBackup
        '
        Me.btnBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(44, 44)
        Me.btnBackup.Text = "Backup"
        '
        'dgvVerEst
        '
        Me.dgvVerEst.AllowUserToAddRows = False
        Me.dgvVerEst.AllowUserToDeleteRows = False
        Me.dgvVerEst.AllowUserToResizeColumns = False
        Me.dgvVerEst.AllowUserToResizeRows = False
        Me.dgvVerEst.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvVerEst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVerEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVerEst.Location = New System.Drawing.Point(222, 90)
        Me.dgvVerEst.MultiSelect = False
        Me.dgvVerEst.Name = "dgvVerEst"
        Me.dgvVerEst.ReadOnly = True
        Me.dgvVerEst.RowHeadersVisible = False
        Me.dgvVerEst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVerEst.Size = New System.Drawing.Size(392, 230)
        Me.dgvVerEst.TabIndex = 16
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "SSBorracharia"
        Me.SaveFileDialog1.Filter = "BD|.sdf"
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(12, 390)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(100, 100)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 17
        Me.pbxLogo.TabStop = False
        '
        'lblLetre1
        '
        Me.lblLetre1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLetre1.AutoSize = True
        Me.lblLetre1.BackColor = System.Drawing.Color.Transparent
        Me.lblLetre1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetre1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLetre1.Location = New System.Drawing.Point(118, 390)
        Me.lblLetre1.Name = "lblLetre1"
        Me.lblLetre1.Size = New System.Drawing.Size(166, 18)
        Me.lblLetre1.TabIndex = 18
        Me.lblLetre1.Text = "CADFácil Sistemas"
        '
        'lblLetre2
        '
        Me.lblLetre2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLetre2.AutoSize = True
        Me.lblLetre2.BackColor = System.Drawing.Color.Transparent
        Me.lblLetre2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetre2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLetre2.Location = New System.Drawing.Point(118, 433)
        Me.lblLetre2.Name = "lblLetre2"
        Me.lblLetre2.Size = New System.Drawing.Size(89, 18)
        Me.lblLetre2.TabIndex = 19
        Me.lblLetre2.Text = "Contatos:"
        '
        'lblLetre3
        '
        Me.lblLetre3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLetre3.AutoSize = True
        Me.lblLetre3.BackColor = System.Drawing.Color.Transparent
        Me.lblLetre3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetre3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLetre3.Location = New System.Drawing.Point(118, 451)
        Me.lblLetre3.Name = "lblLetre3"
        Me.lblLetre3.Size = New System.Drawing.Size(183, 18)
        Me.lblLetre3.TabIndex = 20
        Me.lblLetre3.Text = "(11) 9 9797 3185 tim"
        '
        'lblLetre4
        '
        Me.lblLetre4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLetre4.AutoSize = True
        Me.lblLetre4.BackColor = System.Drawing.Color.Transparent
        Me.lblLetre4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetre4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLetre4.Location = New System.Drawing.Point(118, 469)
        Me.lblLetre4.Name = "lblLetre4"
        Me.lblLetre4.Size = New System.Drawing.Size(189, 18)
        Me.lblLetre4.TabIndex = 21
        Me.lblLetre4.Text = "(11) 9 5052 7217 vivo"
        '
        'pbxWatts
        '
        Me.pbxWatts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbxWatts.BackColor = System.Drawing.Color.Transparent
        Me.pbxWatts.Image = CType(resources.GetObject("pbxWatts.Image"), System.Drawing.Image)
        Me.pbxWatts.Location = New System.Drawing.Point(297, 448)
        Me.pbxWatts.Name = "pbxWatts"
        Me.pbxWatts.Size = New System.Drawing.Size(20, 20)
        Me.pbxWatts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxWatts.TabIndex = 22
        Me.pbxWatts.TabStop = False
        '
        'lblLetre5
        '
        Me.lblLetre5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLetre5.AutoSize = True
        Me.lblLetre5.BackColor = System.Drawing.Color.Transparent
        Me.lblLetre5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetre5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLetre5.Location = New System.Drawing.Point(140, 409)
        Me.lblLetre5.Name = "lblLetre5"
        Me.lblLetre5.Size = New System.Drawing.Size(124, 18)
        Me.lblLetre5.TabIndex = 23
        Me.lblLetre5.Text = "Marcio Sousa"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 530)
        Me.Controls.Add(Me.lblLetre5)
        Me.Controls.Add(Me.pbxWatts)
        Me.Controls.Add(Me.lblLetre4)
        Me.Controls.Add(Me.lblLetre3)
        Me.Controls.Add(Me.lblLetre2)
        Me.Controls.Add(Me.lblLetre1)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.dgvVerEst)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbxFundo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADFacil Sistemas - Borracharia"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxFundo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvVerEst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxWatts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosEServiçosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbxFundo As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnF8 As System.Windows.Forms.Button
    Friend WithEvents btnF7 As System.Windows.Forms.Button
    Friend WithEvents btnF6 As System.Windows.Forms.Button
    Friend WithEvents btnF5 As System.Windows.Forms.Button
    Friend WithEvents btnF4 As System.Windows.Forms.Button
    Friend WithEvents btnF3 As System.Windows.Forms.Button
    Friend WithEvents btnF2 As System.Windows.Forms.Button
    Friend WithEvents btnF1 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssCliente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssProdServ As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssVenda As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCompleto As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbProduto As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbServico As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbVenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrafico As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEstoque As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEncerra As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ServiçosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvVerEst As System.Windows.Forms.DataGridView
    Friend WithEvents btnBackup As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblLetre1 As System.Windows.Forms.Label
    Friend WithEvents lblLetre2 As System.Windows.Forms.Label
    Friend WithEvents lblLetre3 As System.Windows.Forms.Label
    Friend WithEvents lblLetre4 As System.Windows.Forms.Label
    Friend WithEvents pbxWatts As System.Windows.Forms.PictureBox
    Friend WithEvents lblLetre5 As System.Windows.Forms.Label
End Class
