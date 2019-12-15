Public Class frm_Grafico

    Private Sub frm_HistoricoVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'B.nome_cli, C.nomeser_prod, A.qtdeprod_cai, A.valorunid_cai, A.valortotal_cai, A.desconto_cai, A.datacompra_cai
        dgvVenda.DataSource = cls_Caixa.ReadClientes()
        dgvVenda.Columns(0).HeaderText = "Cliente"
        dgvVenda.Columns(0).Width = 250
        dgvVenda.Columns(1).HeaderText = "Prod/Serv"
        dgvVenda.Columns(1).Width = 150
        dgvVenda.Columns(2).HeaderText = "Qtde"
        dgvVenda.Columns(2).Width = 50
        dgvVenda.Columns(3).HeaderText = "%"
        dgvVenda.Columns(3).Width = 30
        dgvVenda.Columns(4).HeaderText = "Data"
        dgvVenda.Columns(4).Width = 80
        carrega_graficos()
    End Sub

    Private Sub frm_HistoricoVenda_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub carrega_graficos()
        Dim vData As Date = Today
        Dim vInicio As String
        Dim vTermino As String

        vData = "01/" & Month(vData) & " / " & Year(vData)
        vData = vData.AddMonths(-7)

        For t = 0 To 7
            If vData.Month = 1 Then
                vInicio = "01/01/" & Year(vData)
                vTermino = "01/31/ " & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("JAN", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("JAN", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Janeiro", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 2 Then
                vInicio = "02/01/" & Year(vData)
                vTermino = "02/28/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("FEV", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("FEV", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Fevereiro", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 3 Then
                vInicio = "03/01/" & Year(vData)
                vTermino = "03/31/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("MAR", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("MAR", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Março", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 4 Then
                vInicio = "04/01/" & Year(vData)
                vTermino = "04/30/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("ABR", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("ABR", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Abril", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 5 Then
                vInicio = "05/01/" & Year(vData)
                vTermino = "05/31/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("MAI", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("MAI", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Maio", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 6 Then
                vInicio = "06/01/" & Year(vData)
                vTermino = "06/30/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("JUN", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("JUN", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Junho", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 7 Then
                vInicio = "07/01/" & Year(vData)
                vTermino = "07/31/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("JUL", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("JUL", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Julho", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 8 Then
                vInicio = "08/01/" & Year(vData)
                vTermino = "08/31/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("AGO", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("AGO", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Agosto", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 9 Then
                vInicio = "09/01/" & Year(vData)
                vTermino = "09/30/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("SET", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("SET", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Setembro", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 10 Then
                vInicio = "10/01/" & Year(vData)
                vTermino = "10/31/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("OUT", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("OUT", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Outubro", cls_Caixa.jogaGrafico(vInicio, vTermino))
            ElseIf vData.Month = 11 Then
                vInicio = "11/01/" & Year(vData)
                vTermino = "11/30/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("NOV", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("NOV", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Novembro", cls_Caixa.jogaGrafico(vInicio, vTermino))
            Else
                vInicio = "12/01/" & Year(vData)
                vTermino = "12/31/" & Year(vData)
                chrColuna.Series("Vendas").Points.AddXY("DEZ", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrLinha.Series("Total Venda").Points.AddXY("DEZ", cls_Caixa.jogaGrafico(vInicio, vTermino))
                chrPizza.Series("MESES").Points.AddXY("Dezembro", cls_Caixa.jogaGrafico(vInicio, vTermino))
            End If
            vData = vData.AddMonths(1)
        Next

        chrPizza.ChartAreas(0).Area3DStyle.Enable3D = True

        'chrPizza.Series("MESES").Points.AddXY("Janeiro", 20.0)
        'chrPizza.Series("MESES").Points.AddXY("Fevereiro", 20.02)
        'chrPizza.Series("MESES").Points.AddXY("Março", 41)
        'chrPizza.Series("MESES").Points.AddXY("Abril", 80)
        'chrPizza.Series("MESES").Points.AddXY("Maio", 40)
        'chrPizza.Series("MESES").Points.AddXY("Junho", 71)
        'chrPizza.Series("MESES").Points.AddXY("Julho", 10)
        'chrPizza.Series("MESES").Points.AddXY("Agosto", 5)
        'chrPizza.Series("MESES").Points.AddXY("Setembro", 30)
        'chrPizza.Series("MESES").Points.AddXY("Outubro", 15)
        'chrPizza.Series("MESES").Points.AddXY("Novembro", 55)
        'chrPizza.Series("MESES").Points.AddXY("Dezembro", 32)



        'chrLinha.Series("MESES").Points.AddXY("JAN", 20)
        'chrLinha.Series("MESES").Points.AddXY("FEV", 23)
        'chrLinha.Series("MESES").Points.AddXY("MAR", 52)
        'chrLinha.Series("MESES").Points.AddXY("ABR", 10)
        'chrLinha.Series("MESES").Points.AddXY("MAI", 33)
        'chrLinha.Series("MESES").Points.AddXY("JUN", 9)
        'chrLinha.Series("MESES").Points.AddXY("JUL", 50)
        'chrLinha.Series("MESES").Points.AddXY("AGO", 7)
        'chrLinha.Series("MESES").Points.AddXY("SET", 18)
        'Chart3.Series("MESES").Points.AddXY("OUT", 41)
        'Chart3.Series("MESES").Points.AddXY("NOV", 38)
        'Chart3.Series("MESES").Points.AddXY("DEZ", 12)
    End Sub

    Private Sub btnPizza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPizza.Click
        chrPizza.Visible = True
        chrColuna.Visible = False
        chrLinha.Visible = False
    End Sub


    Private Sub btnLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinha.Click
        chrPizza.Visible = False
        chrColuna.Visible = False
        chrLinha.Visible = True
    End Sub

    Private Sub btnColuna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColuna.Click
        chrPizza.Visible = False
        chrColuna.Visible = True
        chrLinha.Visible = False
    End Sub
End Class