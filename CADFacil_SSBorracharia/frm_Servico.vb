Public Class frm_Servico
    Dim vpassou = True

    Private Sub limpa_campos()
        txtNomeSer.Text = ""
        txtValorSer.Text = ""
        txtNomeSer.Focus()
    End Sub

    Private Sub desabilita_campos()
        txtNomeSer.Enabled = False
        txtValorSer.Enabled = False
        btnConfirma.Enabled = False
        btnCancela.Enabled = False
        btnLimpar.Enabled = False
        dgvServico.Enabled = True
        btnAdicionar.Enabled = True
    End Sub

    Private Sub habilita_campos()
        txtCodSer.Text = ""
        txtNomeSer.Enabled = True
        txtValorSer.Enabled = True
        btnConfirma.Enabled = True
        btnCancela.Enabled = True
        btnLimpar.Enabled = True

        btnEditar.Enabled = False
        btnAdicionar.Enabled = False
        btnExcluir.Enabled = False
        dgvServico.Enabled = False

        If dgvServico.Rows.Count <> 0 Then
            txtValorSer.Text = dgvServico.Rows(dgvServico.CurrentRow.Index).Cells(2).Value
        End If
    End Sub

    Private Sub carrega_grid()
        Try
            dgvServico.Columns.Clear()
            dgvServico.DataSource = cls_ProdSer.ReadServico
            dgvServico.Columns.Add("vPreco", "Preço")

            For t = 0 To dgvServico.Rows.Count - 1
                dgvServico.Rows(t).Cells(3).Value = String.Format("{0:C}", dgvServico.Rows(t).Cells(2).Value)
            Next

            dgvServico.Columns(0).Width = 50
            dgvServico.Columns(1).Width = 283
            dgvServico.Columns(3).Width = 115
            dgvServico.Columns(2).Visible = False
            dgvServico.Columns(0).HeaderText = "Cod"
            dgvServico.Columns(1).HeaderText = "Nome do Serviço"
            dgvServico.Columns(0).ReadOnly = True
            dgvServico.Columns(1).ReadOnly = True
            dgvServico.Columns(3).ReadOnly = True
            dgvServico.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvServico.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvServico.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

            If dgvServico.Rows.Count = 0 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                txtCodSer.Text = "0"
                txtNomeSer.Text = "NÃO HÁ SERVIÇOS CADASTRADOS NO MOMENTO!!!"
                txtValorSer.Text = ""
            Else
                btnEditar.Enabled = True
                btnExcluir.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub verifica_campos()
        If txtNomeSer.Text = "" Then
            MessageBox.Show("Campo 'Nome do Serviço' está vazio, digite o Nome do Serviço no campo acima!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNomeSer.Focus()
            vpassou = False
        ElseIf txtValorSer.Text = "" Then
            MessageBox.Show("Campo 'Valor' está vazio, digite o valor no campo acima!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtValorSer.Focus()
            vpassou = False
        Else
            vpassou = True
        End If
    End Sub

    Private Sub frm_Servico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
        frm_Principal.carregass()
    End Sub

    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        verifica_campos()

        Try
            If vpassou = True Then
                Dim vServico As New cls_ProdSer
                vServico.anomeprodser = txtNomeSer.Text
                vServico.aprecovendaprod = txtValorSer.Text

                If txtCodSer.Text = "" Then
                    vServico.acodigoprod = 0
                    vServico.CUDProdSer(0, 4)
                    desabilita_campos()
                    carrega_grid()
                Else
                    vServico.acodigoprod = txtCodSer.Text
                    vServico.CUDProdSer(txtCodSer.Text, 5)
                    carrega_grid()
                    desabilita_campos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_Servico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_grid()
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        habilita_campos()
        limpa_campos()
    End Sub

    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        desabilita_campos()
        carrega_grid()
    End Sub

    Private Sub dgvServico_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvServico.SelectionChanged
        Try
            txtCodSer.Text = dgvServico.Rows(dgvServico.CurrentRow.Index).Cells(0).Value
            txtNomeSer.Text = dgvServico.Rows(dgvServico.CurrentRow.Index).Cells(1).Value
            txtValorSer.Text = String.Format("{0:C}", dgvServico.Rows(dgvServico.CurrentRow.Index).Cells(2).Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        limpa_campos()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try
            If MessageBox.Show("Deseja Deletar o Serviço " & txtNomeSer.Text & " de seu Banco de Dados?", "Exclusão de Serviço!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim vServico As New cls_ProdSer
                vServico.CUDProdSer(txtCodSer.Text, 3)
                MessageBox.Show("Serviço deletado com Sucesso!!!", "Exclusão de Serviço!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_grid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        habilita_campos()
        btnLimpar.Enabled = True
        btnConfirma.Enabled = True
        btnCancela.Enabled = True
        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnDuvida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuvida.Click
        MessageBox.Show("Esse formulário é para o preenchimento dos dados de seus Serviços. Preencha corretamente. Você poderá fazer alterações nesses campos futuramente!!", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtNomeSer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomeSer.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub txtValorSer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorSer.LostFocus
        Try
            Dim vTeste As Decimal
            If txtValorSer.Text <> "" Then
                vTeste = txtValorSer.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtValorSer.Text = ""
            txtValorSer.Focus()
        End Try
    End Sub

    Private Sub txtValorSer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorSer.KeyPress
        Try
            If e.KeyChar = "'" Then
                e.Handled = True
                Exit Sub
            End If
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                If e.KeyChar <> "," Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class