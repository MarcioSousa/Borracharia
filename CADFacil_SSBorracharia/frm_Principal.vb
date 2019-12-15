Public Class frm_Principal

    Private Sub tsbEncerra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEncerra.Click
        If MessageBox.Show("Deseja encerrar o Sistema?", "Encerrando Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Sistema Encerrado. Obrigado por utilizar o sistema desenvolvido por CADFácil Sistemas (Marcio Sousa)", "Sistema Encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub tsbNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNovo.Click
        frm_CadCliente.Show()
        Me.Enabled = False
        frm_CadCliente.btnEditar.Enabled = False
        frm_CadCliente.btnExcluir.Enabled = False
        frm_CadCliente.btnNovo.Enabled = False
        frm_CadCliente.btnVoltar.Enabled = False
        frm_CadCliente.txtNome.Focus()
    End Sub
    Private Sub tsbCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCompleto.Click
        frm_Cliente.Show()
        Me.Enabled = False
    End Sub
    Private Sub tsbProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbProduto.Click
        frm_Produto.Show()
        Me.Enabled = False
    End Sub
    Private Sub tsbServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbServico.Click
        frm_Servico.Show()
        Me.Enabled = False
    End Sub
    Private Sub tsbVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbVenda.Click
        frm_Venda.Show()
        Me.Enabled = False
        frm_Venda.txtCliente.Focus()
    End Sub
    Private Sub tsbGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrafico.Click
        frm_Grafico.Show()
        Me.Enabled = False
    End Sub
    Private Sub tsbEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEstoque.Click
        frm_Estoque.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF1.Click
        frm_CadCliente.Show()
        Me.Enabled = False
        frm_CadCliente.btnEditar.Enabled = False
        frm_CadCliente.btnExcluir.Enabled = False
        frm_CadCliente.btnNovo.Enabled = False
        frm_CadCliente.btnVoltar.Enabled = False
        frm_CadCliente.txtNome.Focus()
    End Sub
    Private Sub btnF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF2.Click
        frm_Cliente.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnF3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF3.Click
        frm_Produto.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnF4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF4.Click
        frm_Servico.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnF5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF5.Click
        frm_Venda.Show()
        Me.Enabled = False
        frm_Venda.txtCliente.Focus()
    End Sub
    Private Sub btnF6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF6.Click
        frm_Grafico.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnF7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF7.Click
        frm_Estoque.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnF8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF8.Click
        If MessageBox.Show("Deseja encerrar o Sistema?", "Encerrando Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Sistema Encerrado. Obrigado por utilizar o sistema desenvolvido por CADFácil Sistemas (Marcio Sousa)", "Sistema Encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub frm_Principal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            frm_CadCliente.Show()
            Me.Enabled = False
            frm_CadCliente.btnEditar.Enabled = False
            frm_CadCliente.btnExcluir.Enabled = False
            frm_CadCliente.btnNovo.Enabled = False
            frm_CadCliente.btnVoltar.Enabled = False
            frm_CadCliente.txtNome.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            frm_Cliente.Show()
            Me.Enabled = False
        ElseIf e.KeyCode = Keys.F3 Then
            frm_Produto.Show()
            Me.Enabled = False
        ElseIf e.KeyCode = Keys.F4 Then
            frm_Servico.Show()
            Me.Enabled = False
        ElseIf e.KeyCode = Keys.F5 Then
            frm_Venda.Show()
            Me.Enabled = False
            frm_Venda.txtCliente.Focus()
        ElseIf e.KeyCode = Keys.F6 Then
            frm_Grafico.Show()
            Me.Enabled = False
        ElseIf e.KeyCode = Keys.F7 Then
            frm_Estoque.Show()
            Me.Enabled = False
        ElseIf e.KeyCode = Keys.F8 Then
            If MessageBox.Show("Deseja encerrar o Sistema?", "Encerrando Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Sistema Encerrado. Obrigado por utilizar o sistema desenvolvido por CADFácil Sistemas (Marcio Sousa)", "Sistema Encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregass()
        pbxLogo.Parent = pbxFundo
        pbxWatts.Parent = pbxFundo
        lblLetre1.Parent = pbxFundo
        lblLetre2.Parent = pbxFundo
        lblLetre3.Parent = pbxFundo
        lblLetre4.Parent = pbxFundo
        lblLetre5.Parent = pbxFundo
    End Sub

    Public Sub carregass()
        tssCliente.Text = cls_Cliente.totalCliente
        tssProdServ.Text = cls_ProdSer.totalProduto
        tssVenda.Text = cls_Caixa.totalCaixa
        dgvVerEst.DataSource = cls_ProdSer.carregaEstoqueNeg
        If dgvVerEst.Rows.Count <> 0 Then
            dgvVerEst.Visible = True
            dgvVerEst.Columns(0).Width = 40
            dgvVerEst.Columns(1).Width = 250
            dgvVerEst.Columns(2).Width = 40
            dgvVerEst.Columns(3).Width = 40
            dgvVerEst.Columns(0).HeaderText = "COD."
            dgvVerEst.Columns(1).HeaderText = "PRODUTOS PARA ESTOCAR"
            dgvVerEst.Columns(2).HeaderText = "EST."
            dgvVerEst.Columns(3).HeaderText = "MIN."
        Else
            dgvVerEst.Visible = False
        End If

    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click

        SaveFileDialog1.FileName = "SSBorracharia" & Today.Date.Day & "-" & Today.Date.Month

        If MessageBox.Show("Deseja fazer backup (Salvar) todo banco de dados?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile("C:\Users\marci\Documents\Visual Studio 2010\Projects\CADFacil_SSBorracharia\CADFacil_SSBorracharia\SSBorracharia.sdf", SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        If MessageBox.Show("Deseja encerrar o Sistema?", "Encerrando Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Sistema Encerrado. Obrigado por utilizar o sistema desenvolvido por CADFácil Sistemas (Marcio Sousa)", "Sistema Encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        frm_Cliente.Show()
        Me.Enabled = False
    End Sub

    Private Sub ProdutosEServiçosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosEServiçosToolStripMenuItem1.Click
        frm_Produto.Show()
        Me.Enabled = False
    End Sub

    Private Sub ServiçosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiçosToolStripMenuItem.Click
        frm_Servico.Show()
        Me.Enabled = False
    End Sub

    Private Sub VendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendaToolStripMenuItem.Click
        frm_Venda.Show()
        Me.Enabled = False
        frm_Venda.txtCliente.Focus()
    End Sub

    Private Sub ContatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoToolStripMenuItem.Click
        MessageBox.Show("Software desenvolvido por CADFácil Sistemas - Marcio Sousa." & vbCrLf & "Espero qua aproveite todos os recursos desenvolvidos pelo sistema." & vbCrLf & vbCrLf & "Qualquer dúvida, entre em contato:" & vbCrLf & "(11)9 9797.3185 Tim WattsApp." & vbCrLf & "(11)9 5052.7217 vivo." & vbCrLf & "(11) 4013.5278." & vbCrLf & vbCrLf & "Facebook:   facebook.com/marciosousaitu" & vbCrLf & "Email:          cadfacilsistemas@gmail.com", "Contatos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class