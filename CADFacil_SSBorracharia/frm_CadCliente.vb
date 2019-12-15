Public Class frm_CadCliente
    Dim vpassou = True

    Private Sub limpa_Campos()
        txtNome.Text = ""
        dtpCadastro.Value = Today
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        mtbCep.Text = ""
        txtEmail.Text = ""
        cbxUf.Text = "SP"
        mtbTelRes.Text = ""
        mtbTelCel.Text = ""
        txtNome.Focus()
    End Sub

    Private Sub habilita_Campos()
        txtNome.Enabled = True
        dtpCadastro.Enabled = True
        txtCnpj.Enabled = True
        cbxUf.Enabled = True
        btnVerificaCep.Enabled = True
        txtEndereco.Enabled = True
        txtNumero.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        mtbCep.Enabled = True
        txtEmail.Enabled = True
        mtbTelRes.Enabled = True
        mtbTelCel.Enabled = True
        txtNome.Focus()
    End Sub

    Private Sub verifica_campos()
        If txtNome.Text = "" Then
            MessageBox.Show("Preencha o campo Nome com o Nome do Cliente!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            vpassou = False
        ElseIf cbxUf.Text = "" Then
            MessageBox.Show("Coloque o Estado correto no campo 'UF'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbxUf.Text = ""
            vpassou = False
        Else
            vpassou = True
        End If
    End Sub

    Private Sub desabilita_campos()
        txtNome.Enabled = False
        dtpCadastro.Enabled = False
        txtCnpj.Enabled = False
        txtEndereco.Enabled = False
        txtNumero.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        mtbCep.Enabled = False
        txtEmail.Enabled = False
        mtbTelRes.Enabled = False
        mtbTelCel.Enabled = False
        btnVerificaCep.Enabled = False
        btnConfirma.Enabled = False
        btnCancelar.Enabled = False
        btnLimpa.Enabled = False

        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
    End Sub

    Private Sub frm_CadCliente_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If frm_Cliente.Enabled = False Then
            frm_Cliente.Enabled = True
            frm_Cliente.carrega_grid_cliente()
        Else
            frm_Principal.Enabled = True
            frm_Principal.carregass()
        End If
    End Sub

    Private Sub btnVerificaCep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificaCep.Click
        Try
            Dim vClasse As New cls_Cliente
            vClasse.verificaCep(mtbCep.Text)
            txtEndereco.Text = vClasse.arua
            txtBairro.Text = vClasse.abairro
            txtCidade.Text = vClasse.acidade
            cbxUf.Text = vClasse.auf
        Catch ex As Exception
            MessageBox.Show("Erro ao verificar CEP!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        verifica_campos()

        Try
            If vpassou = True Then
                Dim vCliente As New cls_Cliente
                vCliente.anome = txtNome.Text
                vCliente.adatacadastro = dtpCadastro.Text
                vCliente.acep = mtbCep.Text
                vCliente.acnpj = txtCnpj.Text
                vCliente.arua = txtEndereco.Text
                vCliente.anumero = txtNumero.Text
                vCliente.abairro = txtBairro.Text
                vCliente.acidade = txtCidade.Text
                vCliente.auf = cbxUf.Text
                vCliente.atelcel = mtbTelCel.Text
                vCliente.atelres = mtbTelRes.Text
                vCliente.aemail = txtEmail.Text

                If txtCodCli.Text = "" Then
                    vCliente.CUDCliente(0, "c")
                    Me.Close()
                Else
                    vCliente.CUDCliente(txtCodCli.Text, "u")
                    desabilita_campos()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Digite manualmente os campos acima!!! Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        limpa_Campos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Deseja Cancelar o cadastro?", "Cancelando Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            txtNome.Focus()
        End If
    End Sub

    Private Sub btnInicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicial.Click
        frm_Cliente.Close()
        Me.Close()
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Try
            habilita_Campos()
            btnLimpa.Enabled = True
            btnConfirma.Enabled = True
            btnCancelar.Enabled = True
            btnNovo.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Não foi possível editar o cliente selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja Deletar o Cliente " & txtNome.Text & " de Seu banco de dados?", "Exclusão de Cliente!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim vCliente As New cls_Cliente
                vCliente.CUDCliente(txtCodCli.Text, "d")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAjuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjuda.Click
        MessageBox.Show("Esse formulário é para o preenchimento dos dados de seu Cliente. Preencha corretamente. Você poderá fazer alterações nesses campos futuramente!!", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtNome_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress, txtNome.KeyPress, txtEndereco.KeyPress, txtEmail.KeyPress, txtCnpj.KeyPress, txtCidade.KeyPress, txtBairro.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

End Class