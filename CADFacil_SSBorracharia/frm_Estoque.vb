Public Class frm_Estoque

    Private Sub carrega_grid()
        dgvEstoque.DataSource = cls_ProdSer.ReadPreencheGridEstoque()
        dgvEstoque.Columns(0).Width = 70
        dgvEstoque.Columns(1).Width = 270
        dgvEstoque.Columns(2).Width = 150
        dgvEstoque.Columns(0).HeaderText = "Cod."
        dgvEstoque.Columns(1).HeaderText = "Nome do Produto"
        dgvEstoque.Columns(2).HeaderText = "Marca"
        dgvEstoque.Columns(3).HeaderText = "Cadastro"
        dgvEstoque.Columns(4).Visible = False
        dgvEstoque.Columns(5).Visible = False
        dgvEstoque.Columns(6).Visible = False
        dgvEstoque.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvEstoque.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvEstoque.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvEstoque.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub frm_Estoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_grid()
    End Sub

    Private Sub frm_Estoque_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
        frm_Principal.carregass()
    End Sub

    Private Sub dgvEstoque_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEstoque.SelectionChanged
        txtNomeProd.Text = dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(1).Value
        dtpDataUlt.Value = dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(4).Value
        txtQtdeAtual.Text = dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(5).Value
        txtQtdeMin.Text = dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(6).Value
    End Sub

    Private Sub btnInicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicial.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        txtEstocar.Enabled = True
        dtpDataUlt.Value = Today
        dtpDataUlt.Enabled = True
        txtEstocar.Focus()
        btnConfirma.Enabled = True
        btnCancelar.Enabled = True
        btnNovo.Enabled = False
        btnDiminuir.Enabled = False
        dgvEstoque.Enabled = False
    End Sub

    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        Try
            If txtEstocar.Enabled = True Then
                If txtEstocar.Text <> 0 And txtEstocar.Text <> "" Then
                    Dim gravaProduto As New cls_ProdSer

                    gravaProduto.aqtdeestocar = txtEstocar.Text
                    gravaProduto.adataestoque = dtpDataUlt.Text
                    gravaProduto.aqtdeatualestoque = CDec(txtEstocar.Text) + CDec(txtQtdeAtual.Text)
                    gravaProduto.CUDEstoque(dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(0).Value, 6)
                    gravaProduto.CUDEstoque(dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(0).Value, 7)
                    txtEstocar.Enabled = False
                    dtpDataUlt.Enabled = False

                    txtEstocar.Text = ""
                    dgvEstoque.DataSource = Nothing
                    carrega_grid()
                    btnConfirma.Enabled = False
                    btnCancelar.Enabled = False
                    btnNovo.Enabled = True
                    btnDiminuir.Enabled = True
                    dgvEstoque.Enabled = True
                End If
            Else
                If txtDiminui.Text <> 0 And txtDiminui.Text <> "" Then
                    Dim gravaProduto As New cls_ProdSer

                    gravaProduto.adataestoque = dtpDataUlt.Text
                    gravaProduto.aqtdeatualestoque = CDec(txtQtdeAtual.Text) - CDec(txtDiminui.Text)
                    gravaProduto.CUDEstoque(dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(0).Value, 6)
                    gravaProduto.CUDEstoque(dgvEstoque.Rows(dgvEstoque.CurrentRow.Index).Cells(0).Value, 7)
                    txtDiminui.Enabled = False
                    dtpDataUlt.Enabled = False

                    txtDiminui.Text = ""
                    dgvEstoque.DataSource = Nothing
                    carrega_grid()
                    btnConfirma.Enabled = False
                    btnCancelar.Enabled = False
                    btnNovo.Enabled = True
                    btnDiminuir.Enabled = True
                    dgvEstoque.Enabled = True
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Erro na leitura dos campos... Digite novamente nos campos acima!!!", "Erro de Preenchimento de Campos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub txtEstocar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEstocar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDiminuir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiminuir.Click
        txtDiminui.Enabled = True
        dtpDataUlt.Value = Today
        dtpDataUlt.Enabled = True
        dgvEstoque.Enabled = False
        txtEstocar.Focus()
        btnConfirma.Enabled = True
        btnCancelar.Enabled = True
        btnNovo.Enabled = False
        btnDiminuir.Enabled = False
    End Sub

    Private Sub txtDiminui_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiminui.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtEstocar.Enabled = False
        txtDiminui.Enabled = False
        dtpDataUlt.Enabled = False
        txtEstocar.Text = ""
        dgvEstoque.Enabled = True
        btnConfirma.Enabled = False
        btnCancelar.Enabled = False
        btnNovo.Enabled = True
        btnDiminuir.Enabled = True
    End Sub

    Private Sub btnAjuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjuda.Click
        MessageBox.Show("Esse formulário é para o preenchimento dos dados de Estoque de seus Produtos. Preencha corretamente!!", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class