Public Class frm_Cliente
    Dim vpassou = True

    Public Sub carrega_grid_cliente()
        Try
            dgvCliente.DataSource = cls_Cliente.ReadClientes
            dgvCliente.Columns(0).Visible = False
            dgvCliente.Columns(1).Width = 395
            dgvCliente.Columns(1).HeaderText = "Nome do Cliente"
            dgvCliente.Columns(1).ReadOnly = True
            dgvCliente.Columns(2).Visible = False

            If dgvCliente.Rows.Count <> 0 Then
                dgvProduto.Columns(0).Width = 80
                dgvProduto.Columns(1).Width = 140
                dgvProduto.Columns(2).Width = 140
                dgvProduto.Columns(0).HeaderText = "COMPRA"
                dgvProduto.Columns(1).HeaderText = "DATA"
                dgvProduto.Columns(2).HeaderText = "TIPO PAG."
            End If

            If dgvCliente.Rows.Count = 0 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                btnCadCompleto.Enabled = False
                txtProcura.Enabled = False
                lblCodCli.Text = 0
                lblDataCad.Text = Now.Date
                lblNome.Text = "NÃO HÁ CLIENTES CADASTRADOS NO MOMENTO!!!"
            Else
                txtProcura.Enabled = True
                btnEditar.Enabled = True
                btnExcluir.Enabled = True
                btnCadCompleto.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub fecha_campos_cliente()
        frm_CadCliente.txtCodCli.Enabled = False
        frm_CadCliente.txtNome.Enabled = False
        frm_CadCliente.dtpCadastro.Enabled = False
        frm_CadCliente.mtbCep.Enabled = False
        frm_CadCliente.txtCnpj.Enabled = False
        frm_CadCliente.txtEndereco.Enabled = False
        frm_CadCliente.txtNumero.Enabled = False
        frm_CadCliente.txtBairro.Enabled = False
        frm_CadCliente.txtCidade.Enabled = False
        frm_CadCliente.cbxUf.Enabled = False
        frm_CadCliente.mtbTelCel.Enabled = False
        frm_CadCliente.mtbTelRes.Enabled = False
        frm_CadCliente.txtEmail.Enabled = False

        frm_CadCliente.btnLimpa.Enabled = False
        frm_CadCliente.btnConfirma.Enabled = False
        frm_CadCliente.btnCancelar.Enabled = False
        frm_CadCliente.btnVerificaCep.Enabled = False
    End Sub

    Private Sub carrega_campos_cliente()
        Try
            Dim clsCliente As New cls_Cliente

            clsCliente = clsCliente.cadastroCompleto(lblCodCli.Text)

            frm_CadCliente.txtCodCli.Text = clsCliente.acodigo
            frm_CadCliente.txtNome.Text = clsCliente.anome
            frm_CadCliente.dtpCadastro.Value = lblDataCad.Text
            frm_CadCliente.mtbCep.Text = clsCliente.acep
            frm_CadCliente.txtCnpj.Text = clsCliente.acnpj
            frm_CadCliente.txtEndereco.Text = clsCliente.arua
            frm_CadCliente.txtNumero.Text = clsCliente.anumero
            frm_CadCliente.txtBairro.Text = clsCliente.abairro
            frm_CadCliente.txtCidade.Text = clsCliente.acidade
            frm_CadCliente.cbxUf.Text = clsCliente.auf
            frm_CadCliente.mtbTelCel.Text = clsCliente.atelcel
            frm_CadCliente.mtbTelRes.Text = clsCliente.atelres
            frm_CadCliente.txtEmail.Text = clsCliente.aemail
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_Cliente_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
        frm_Principal.carregass()
    End Sub

    Private Sub frm_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_grid_cliente()
    End Sub

    Private Sub dgvCliente_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCliente.SelectionChanged
        Try
            If dgvCliente.Rows.Count <> 0 Then
                lblCodCli.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(0).Value
                lblNome.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(1).Value
                lblDataCad.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(2).Value
                dgvProduto.DataSource = cls_ProdSer.carregaGridCliente(lblCodCli.Text)
                If dgvProduto.Rows.Count = 0 Then
                    btnHistoricoVenda.Enabled = False
                Else
                    btnHistoricoVenda.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcura.TextChanged
        Try
            dgvCliente.DataSource = cls_Cliente.ProduraClientes(txtProcura.Text)
            dgvCliente.Columns(0).Visible = False
            dgvCliente.Columns(1).Width = 395
            dgvCliente.Columns(1).HeaderText = "Nome do Cliente"
            dgvCliente.Columns(1).ReadOnly = True

            dgvProduto.DataSource = cls_ProdSer.carregaGridCliente(lblCodCli.Text)
            dgvProduto.Columns(0).Width = 80
            dgvProduto.Columns(1).Width = 140
            dgvProduto.Columns(2).Width = 140
            dgvProduto.Columns(0).HeaderText = "COMPRA"
            dgvProduto.Columns(1).HeaderText = "DATA"
            dgvProduto.Columns(2).HeaderText = "TIPO PAG."

            If dgvCliente.Rows.Count = 0 Then
                lblCodCli.Text = 0
                lblDataCad.Text = Now.Date
                lblNome.Text = "NENHUM CLIENTE FOI SELECIONADO!!!"
                dgvProduto.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCadCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadCompleto.Click
        frm_CadCliente.Show()
        Me.Enabled = False
        fecha_campos_cliente()
        carrega_campos_cliente()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja Deletar o Cliente " & lblNome.Text & " de Seu banco de dados?", "Exclusão de Cliente!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim vCliente As New cls_Cliente
                vCliente.CUDCliente(lblCodCli.Text, "d")
                MessageBox.Show("Cliente deletado com Sucesso", "Exclusão de Cliente!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_grid_cliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCliente.Click
        frm_CadCliente.Show()
        Me.Enabled = False
        frm_CadCliente.btnNovo.Enabled = False
        frm_CadCliente.btnEditar.Enabled = False
        frm_CadCliente.btnExcluir.Enabled = False
        frm_CadCliente.txtNome.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        frm_CadCliente.Show()
        Me.Enabled = False
        carrega_campos_cliente()
        frm_CadCliente.btnNovo.Enabled = False
        frm_CadCliente.btnEditar.Enabled = False
        frm_CadCliente.btnExcluir.Enabled = False
        frm_CadCliente.txtNome.Focus()
    End Sub

    Private Sub btnDuvida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuvida.Click
        MessageBox.Show("Esse formulário é para informar os dados do Cliente selecionado e seu histórico de compras!!!", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub btnHistoricoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoricoVenda.Click
        Me.Enabled = False
        frm_HistoricoVenda.Show()
    End Sub

End Class