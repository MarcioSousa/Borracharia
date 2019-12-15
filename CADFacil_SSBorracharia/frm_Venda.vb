Imports System.Data.SqlServerCe
Imports System.Drawing.Printing

Public Class frm_Venda
    Dim vpassou = False
    Dim Conexao As New cls_ProdSer
    Dim vCliente As New cls_Cliente

    Private PrintPageSettings As New PageSettings
    Private StringToPrint As String
    Private PrintFont As New Font("Consolas", 12)
    Private PrintFont2 As New Font("Consolas", 7.5)
    Dim sLeitura As String = ""
    Dim adatainicio As String
    Dim adatafim As String

    Dim vRua As String = ""
    Dim vNumero As String = ""
    Dim vBairro As String = ""
    Dim vCidade As String = ""
    Dim vEstado As String = ""
    Dim vTelRes As String = ""
    Dim vTelCel As String = ""
    Dim vEmail As String = ""
    Dim vCnpj As String = ""
    Dim vPedido As Integer

    Private Sub verifica_campos()
        If txtCodProd.Text = "" Then
            MessageBox.Show("Digite o codigo do produto que esteja vendendo!!", "Aviso de Cadastro de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vpassou = True
            txtCodProd.Focus()
        ElseIf txtProdSer.Text = "" Then
            MessageBox.Show("Digite o nome do produto que esteja vendendo no comércio!!", "Aviso de Cadastro de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vpassou = True
            txtProdSer.Focus()
        ElseIf txtQtde.Text = "" Then
            MessageBox.Show("Digite a quantidade de produto(s) vendidos!!", "Aviso de Cadastro de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vpassou = True
            txtQtde.Focus()
        Else
            vpassou = False
        End If
    End Sub

    Private Sub limpaCampos()
        txtCodProd.Text = ""
        txtProdSer.Text = ""
        txtQtde.Text = ""
        txtValor.Text = ""
        txtCodProd.Focus()
    End Sub

    Private Sub imprime_nota()
        Dim qEspaco As Integer
        Dim qCaracters As Integer
        Dim qResult As Integer
        Dim sleitura As String

        Dim vQtdeRegist As Integer = dgvVenda.Rows.Count - 1
        Dim vQtdeColuna As Integer = dgvVenda.Columns.Count - 1

        Dim vPagamento As Decimal
        Dim vTotal As Decimal

        Try
            vPedido = cls_Caixa.ultimoInsert
            '====================================================================================================
            '===============================================SLEITURA=============================================
            sleitura = "                                                       PEDIDO Nº: " & vPedido & "     " & Date.Now & vbCrLf
            sleitura = sleitura & vbCrLf
            sleitura = sleitura & "                                                                                Avenida das Rosas, 222" & vbCrLf
            sleitura = sleitura & "                                                   SS Borracharia             Jd. das Rosas - Itu - SP" & vbCrLf
            sleitura = sleitura & "                                                   Pneus Remold e usados                 Cep:13309-520" & vbCrLf
            sleitura = sleitura & "                                                   Vulcanização Lateral      Contato: (11) 9 7136-5403" & vbCrLf
            sleitura = sleitura & "------------------------------------------------------------------------------------------------------" & vbCrLf
            sleitura = sleitura & "Nome do Cliente: " & txtCliente.Text & vbCrLf
            If vRua <> "" Then
                sleitura = sleitura & "Rua/Av.: " & vRua & ", " & vNumero & vbCrLf
                sleitura = sleitura & "Bairro: " & vBairro & ", Cidade: " & vCidade & ", UF: " & vEstado & vbCrLf
                sleitura = sleitura & "Contatos: " & vTelRes & ", " & vTelCel & ", Email: " & vEmail & vbCrLf
                sleitura = sleitura & "Cnpj: " & vCnpj & vbCrLf
            End If
            sleitura = sleitura & "------------------------------------------------------------------------------------------------------" & vbCrLf
            '''''''''''''''''''''''10 + 1'''''''''''6 + 1'''''''''38 + 1''''''''''''''''''''''''''14 + 1'''''''''''''14 + 1'''''''''''''14 + 1''''''''''''''102
            sleitura = sleitura & "QUANTIDADE   " & "                  DESCRIÇÃO                        " & "PREÇO UNID.           " & "TOTAL                 " & vbCrLf
            sleitura = sleitura & "======================================================================================================" & vbCrLf

            For b = 0 To vQtdeRegist
                For t = 0 To vQtdeColuna
                    If t = 1 Or t = 2 Or t = 3 Or t = 4 Then
                        sleitura = sleitura & dgvVenda.Rows(b).Cells(t).Value
                        If t = 1 Then
                            qEspaco = 12
                            qCaracters = dgvVenda.Rows(b).Cells(t).Value.ToString.Length
                            qResult = qEspaco - qCaracters
                            sleitura = sleitura & Space(qResult)
                        ElseIf t = 2 Then
                            qEspaco = 50
                            qCaracters = (dgvVenda.Rows(b).Cells(t).Value.ToString.Length)
                            qResult = qEspaco - qCaracters
                            sleitura = sleitura & Space(qResult)
                        ElseIf t = 3 Then
                            qEspaco = 20
                            qCaracters = (dgvVenda.Rows(b).Cells(t).Value.ToString.Length)
                            qResult = qEspaco - qCaracters
                            sleitura = sleitura & Space(qResult)
                        Else
                            qEspaco = 20
                            qCaracters = (dgvVenda.Rows(b).Cells(t).Value.ToString.Length)
                            qResult = qEspaco - qCaracters
                            sleitura = sleitura & Space(qResult)
                        End If
                    End If
                Next
                sleitura = sleitura & vbCrLf
            Next

            sleitura = sleitura & "------------------------------------------------------------------------------------------------------" & vbCrLf
            vPagamento = txtTotalCompra.Text
            vTotal = txtTotal.Text

            sleitura = sleitura & Space(30) & " DESCONTO: " & txtDesconto.Text & "%   |TOTAL VENDA: " & String.Format("{0:C}", vPagamento) & "   |TOTAL: " & String.Format("{0:C}", vTotal) & vbCrLf & vbCrLf
            sleitura = sleitura & "Ass: ________________________________________________"

            'Especifica as configurações da página atual
            PrintDocument1.DefaultPageSettings = PrintPageSettings

            'Especifica o documento para a caixa de diálogo de impressão e exibe 
            StringToPrint = sleitura
            PrintDialog1.Document = PrintDocument1
            Dim result As DialogResult = PrintDialog1.ShowDialog()

            'Se clicar em OK, imprime o documento para impressora
            If result = Windows.Forms.DialogResult.OK Then
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            'Exibe mensagem de erro
            MessageBox.Show("Erro ao imprimir Nota do Cliente" & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frm_Venda_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
        frm_Principal.carregass()
    End Sub

    Private Sub frm_Venda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Conexao.CompletaTextProSer()
            vCliente.CompletaCliente()
            lblPedido.Text = cls_Caixa.novoCodigoCompra().ToString
            If lblPedido.Text.Trim = "" Then
                lblPedido.Text = 1
            Else
                lblPedido.Text = lblPedido.Text + 1
            End If
        Catch ex As Exception
            MessageBox.Show("Erro na leitura do formulário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub txtProdSer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdSer.LostFocus
        Try
            If txtProdSer.Text <> "" Then
                Conexao.carregaCamposProduto(txtProdSer.Text, 0)
                txtCodProd.Text = Conexao.acodigoprod
                txtValor.Text = String.Format("{0:f2}", Conexao.aprecovendaprod)
                txtQtde.Focus()
            End If
        Catch ex As Exception
            txtCodProd.Focus()
        End Try
    End Sub

    Private Sub txtCodProd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.LostFocus
        Try
            If txtCodProd.Text <> "" Then
                Conexao.carregaCamposProduto("", txtCodProd.Text)
                txtProdSer.Text = Conexao.anomeprodser
                txtValor.Text = String.Format("{0:f2}", Conexao.aprecovendaprod)
                txtQtde.Focus()
            End If
        Catch ex As Exception
            txtCodProd.Focus()
        End Try
    End Sub

    Private Sub btnConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirma.Click
        verifica_campos()
        Try
            If vpassou = False Then
                dgvVenda.Rows.Add(txtCodProd.Text, txtQtde.Text, txtProdSer.Text, String.Format("{0:C}", CDec(txtValor.Text)), String.Format("{0:C}", CDec(txtValor.Text) * txtQtde.Text), txtValor.Text, txtValor.Text * txtQtde.Text)
                txtTotalCompra.Text = String.Format("{0:F2}", CDec(txtTotalCompra.Text) + (CDec(txtValor.Text) * txtQtde.Text))
                txtTotal.Text = txtTotalCompra.Text
                limpaCampos()
            Else
                vpassou = False
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao Confirmar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtCodProd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress, txtCodProd.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodCli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        limpaCampos()
    End Sub

    Private Sub ConfirmaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmaCliente.Click

        Try
            If txtCliente.Text <> "" Then
                vCliente.carregaCamposCliente(txtCliente.Text, 0)
                If vCliente.acodigo <> Nothing Then
                    lblCodCli.Text = vCliente.acodigo
                    vRua = vCliente.arua
                    vNumero = vCliente.anumero
                    vBairro = vCliente.abairro
                    vCidade = vCliente.acidade
                    vEstado = vCliente.auf
                    vTelRes = vCliente.atelres
                    vTelCel = vCliente.atelcel
                    vEmail = vCliente.aemail
                    vCnpj = vCliente.acnpj
                    txtCliente.Enabled = False
                    btnConfirmaCliente.Enabled = False
                    Panel1.Enabled = True
                    txtCodProd.Focus()
                End If
            Else
                txtCliente.Text = "Cliente Anônimo"
                lblCodCli.Text = 0
                txtCliente.Enabled = False
                btnConfirmaCliente.Enabled = False
                Panel1.Enabled = True
                txtCodProd.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub txtDesconto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesconto.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDesconto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.LostFocus
        txtTotal.Text = String.Format("{0:F2}", (txtTotalCompra.Text - (txtTotalCompra.Text * txtDesconto.Text) / 100))
    End Sub

    Private Sub btnCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaixa.Click
        Try
            If cbxPagamento.Text <> "" Then
                If dgvVenda.Rows.Count <> 0 Then
                    Dim aVenda As New cls_Caixa
                    Dim aProduto As New cls_ProdSer
                    Dim vstrProduto As Object
                    Dim vqtdeProduto As Integer = 0

                    For t = 0 To dgvVenda.Rows.Count - 1
                        aVenda.acodigocompra = lblPedido.Text
                        aVenda.acodigocliente = lblCodCli.Text
                        aVenda.acodigoproduto = dgvVenda.Rows(t).Cells(0).Value
                        aVenda.aqtdeproduto = dgvVenda.Rows(t).Cells(1).Value
                        aVenda.avalorunidproduto = dgvVenda.Rows(t).Cells(5).Value
                        aVenda.avalortotalvenda = dgvVenda.Rows(t).Cells(6).Value
                        aVenda.adesconto = txtDesconto.Text
                        aVenda.adatacompra = Today.Date
                        aVenda.atipopagam = cbxPagamento.Text
                        aVenda.CUDCaixa(0, 0)
                        vstrProduto = cls_ProdSer.ReadQtdeProduto(dgvVenda.Rows(t).Cells(0).Value)

                        If vstrProduto.ToString <> "" Then
                            vqtdeProduto = CInt(vstrProduto) - dgvVenda.Rows(t).Cells(1).Value
                            aProduto.aqtdeestocar = vqtdeProduto
                            aProduto.CUDProdSer(dgvVenda.Rows(t).Cells(0).Value, 7)
                        End If

                    Next

                    If MessageBox.Show("Deseja Imprimir Nota Fiscal?", "Imprimindo Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        imprime_nota()
                        If MessageBox.Show("Deseja imprimir segunda via?", "Imprimindo Venda!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            imprime_nota()
                        End If
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("Nenhum produto vendido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Selecione a forma de pagamento do Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao confirmar compra, compra cancelada! Entre em contato com o técnico para verificar o erro!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim numChars As Integer
        Dim numLines As Integer
        Dim stringForPage As String
        Dim strFormat As New StringFormat

        Dim rectDraw As New Rectangle(e.MarginBounds.Left, 60, e.MarginBounds.Width, e.MarginBounds.Height)

        Dim Rect As New Rectangle(100, 60, 500, 120)
        e.Graphics.DrawImage(pbxLogo.Image, Rect)

        Try
            If rectDraw.Width = 969 Then
                'Define a área para determinar quanto texto cabe em uma página
                'Diminui a altura por uma linha para assegurar que o texto não seja cortado
                Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))

                'Ao desenhar strings longas, quebra entre palavras
                strFormat.Trimming = StringTrimming.Word


                'Calcula quantos caracteres e linhas podem caber com base em sizeMeasure
                e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)

                'Calcula a string que caberá em uma página
                stringForPage = StringToPrint.Substring(0, numChars)

                'Imprime a string na página atual
                e.Graphics.DrawString(stringForPage, PrintFont, Brushes.Black, rectDraw, strFormat)

                'Se houver mais texto, indica que há mais páginas
                If numChars < StringToPrint.Length Then
                    'Subtrai texto da string que foi impressa
                    StringToPrint = StringToPrint.Substring(numChars)
                    e.HasMorePages = True
                Else
                    e.HasMorePages = False
                    'Todo o texto foi impresso, então restaura string
                    StringToPrint = sLeitura
                End If
            Else
                'Define a área para determinar quanto texto cabe em uma página
                'Diminui a altura por uma linha para assegurar que o texto não seja cortado
                Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont2.GetHeight(e.Graphics))

                'Ao desenhar strings longas, quebra entre palavras
                strFormat.Trimming = StringTrimming.Word


                'Calcula quantos caracteres e linhas podem caber com base em sizeMeasure
                e.Graphics.MeasureString(StringToPrint, PrintFont2, sizeMeasure, strFormat, numChars, numLines)

                'Calcula a string que caberá em uma página
                stringForPage = StringToPrint.Substring(0, numChars)

                'Imprime a string na página atual
                e.Graphics.DrawString(stringForPage, PrintFont2, Brushes.Black, rectDraw, strFormat)

                'Se houver mais texto, indica que há mais páginas
                If numChars < StringToPrint.Length Then
                    'Subtrai texto da string que foi impressa
                    StringToPrint = StringToPrint.Substring(numChars)
                    e.HasMorePages = True
                Else
                    e.HasMorePages = False
                    'Todo o texto foi impresso, então restaura string
                    StringToPrint = sLeitura
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao Iniciar Impressão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class