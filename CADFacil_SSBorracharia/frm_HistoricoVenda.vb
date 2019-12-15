Public Class frm_HistoricoVenda
    Dim vpassou As Boolean = False
    Dim vncaixa As Integer = 0

    Private Sub carrega_grid()
        Try
            Dim vDataInicio As String = Convert.ToDateTime(dtpInicio.Text).ToString("MM/dd/yyyy")
            Dim vDataTermino As String = Convert.ToDateTime(dtpTermino.Text).ToString("MM/dd/yyyy")

            lblNome.Text = frm_Cliente.lblNome.Text

            If cbxTodos.Checked = False Then
                dgvHistorico.DataSource = cls_Caixa.carregaGridHistPesquisa(frm_Cliente.lblCodCli.Text, vDataInicio, vDataTermino, cbxPagamento.Text)
            Else
                dgvHistorico.DataSource = cls_Caixa.carregaGridHistorico(frm_Cliente.lblCodCli.Text)
                cbxPagamento.DataSource = cls_Caixa.carregaComboPagam(frm_Cliente.lblCodCli.Text)
                cbxPagamento.ValueMember = "tipopagam"
            End If

            dgvHistorico.Columns(0).Visible = False
            dgvHistorico.Columns(1).HeaderText = "Qtde"
            dgvHistorico.Columns(1).Width = 70
            dgvHistorico.Columns(2).HeaderText = "Produto"
            dgvHistorico.Columns(2).Width = 300
            dgvHistorico.Columns(3).Visible = False
            dgvHistorico.Columns(4).Visible = False
            dgvHistorico.Columns(5).Visible = False
            dgvHistorico.Columns(6).Visible = False
            dgvHistorico.Columns(7).Visible = False
            dgvHistorico.Columns.Add("vUnidade", "Unid.")
            dgvHistorico.Columns.Add("vTotal", "Total")
            dgvHistorico.Columns(8).Width = 130
            dgvHistorico.Columns(9).Width = 130
            dgvHistorico.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvHistorico.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvHistorico.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvHistorico.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable

            For t = 0 To dgvHistorico.Rows.Count - 1
                dgvHistorico.Rows(t).Cells(8).Value = String.Format("{0:C}", dgvHistorico.Rows(t).Cells(3).Value)
                dgvHistorico.Rows(t).Cells(9).Value = String.Format("{0:C}", dgvHistorico.Rows(t).Cells(4).Value)
            Next

            If dgvHistorico.Rows.Count = 0 Then
                lblDesc.Text = 0%
                dtpDataCompra.Text = "01/01/2010"
                lblTipoPagam.Text = ""
                btnExcluir.Enabled = False
            Else
                dgvHistorico.Rows(0).Selected = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_HistoricoVenda_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Cliente.Enabled = True
        frm_Cliente.carrega_grid_cliente()
    End Sub

    Private Sub frm_HistoricoVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_grid()
    End Sub

    Private Sub dgvHistorico_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvHistorico.SelectionChanged
        Try
            If dgvHistorico.Rows.Count <> 0 Then
                vncaixa = dgvHistorico.Rows(dgvHistorico.CurrentRow.Index).Cells(0).Value
                lblDesc.Text = dgvHistorico.Rows(dgvHistorico.CurrentRow.Index).Cells(5).Value & "%"
                dtpDataCompra.Text = dgvHistorico.Rows(dgvHistorico.CurrentRow.Index).Cells(6).Value
                lblTipoPagam.Text = dgvHistorico.Rows(dgvHistorico.CurrentRow.Index).Cells(7).Value

                btnExcluir.Enabled = True
            Else
                lblDesc.Text = 0%
                dtpDataCompra.Text = "01/01/2010"
                lblTipoPagam.Text = ""
                btnExcluir.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbxTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTodos.CheckedChanged
        dgvHistorico.DataSource = Nothing

        If vpassou = True Then
            dgvHistorico.Columns.Remove("vUnidade")
            dgvHistorico.Columns.Remove("vTotal")
            carrega_grid()
        End If

        vpassou = True
    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        If cbxTodos.Checked = False Then
            dgvHistorico.DataSource = Nothing

            If vpassou = True Then
                dgvHistorico.Columns.Remove("vUnidade")
                dgvHistorico.Columns.Remove("vTotal")
                carrega_grid()
            End If
        End If
    End Sub

    Private Sub dtpTermino_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTermino.ValueChanged
        If cbxTodos.Checked = False Then
            dgvHistorico.DataSource = Nothing

            If vpassou = True Then
                dgvHistorico.Columns.Remove("vUnidade")
                dgvHistorico.Columns.Remove("vTotal")
                carrega_grid()
            End If
        End If
    End Sub

    Private Sub cbxPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPagamento.SelectedIndexChanged
        If cbxTodos.Checked = False Then
            dgvHistorico.DataSource = Nothing

            If vpassou = True Then
                dgvHistorico.Columns.Remove("vUnidade")
                dgvHistorico.Columns.Remove("vTotal")
                carrega_grid()
            End If
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja Deletar a Compra Selecionada?", "Exclusão de Compra!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim vCaixa As New cls_Caixa
                vCaixa.CUDCaixa(vncaixa, 2)
                dgvHistorico.DataSource = Nothing
                dgvHistorico.Columns.Remove("vUnidade")
                dgvHistorico.Columns.Remove("vTotal")
                MessageBox.Show("Compra deletado com sucesso!!!", "Exclusão de Compra!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_grid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

End Class