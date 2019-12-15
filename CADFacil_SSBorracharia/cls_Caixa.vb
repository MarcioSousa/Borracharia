Imports System.Data.SqlServerCe

Public Class cls_Caixa
    Private codigoCompra As Integer
    Private codigoCliente As Integer
    Private codigoProduto As Integer
    Private qtdeProduto As Integer
    Private valorUnidProduto As Double
    Private valorTotalVenda As Double
    Private desconto As Decimal
    Private dataCompra As String
    Private tipopagam As String

    Public Property acodigocompra()
        Get
            Return codigoCompra
        End Get
        Set(ByVal value)
            codigoCompra = value
        End Set
    End Property
    Public Property acodigocliente()
        Get
            Return codigoCliente
        End Get
        Set(ByVal value)
            codigoCliente = value
        End Set
    End Property
    Public Property acodigoproduto
        Get
            Return codigoProduto
        End Get
        Set(ByVal value)
            codigoProduto = value
        End Set
    End Property
    Public Property aqtdeproduto
        Get
            Return qtdeProduto
        End Get
        Set(ByVal value)
            qtdeProduto = value
        End Set
    End Property
    Public Property avalorunidproduto
        Get
            Return valorUnidProduto
        End Get
        Set(ByVal value)
            valorUnidProduto = value
        End Set
    End Property
    Public Property avalortotalvenda
        Get
            Return valorTotalVenda
        End Get
        Set(ByVal value)
            valorTotalVenda = value
        End Set
    End Property
    Public Property adesconto
        Get
            Return desconto
        End Get
        Set(ByVal value)
            desconto = value
        End Set
    End Property
    Public Property adatacompra
        Get
            Return dataCompra
        End Get
        Set(ByVal value)
            dataCompra = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property
    Public Property atipopagam
        Get
            Return tipopagam
        End Get
        Set(ByVal value)
            tipopagam = value
        End Set
    End Property

    '//STRINGS DE ATUALIZAÇÃO DO BANCO DE DADOS
    Public Function stringBanco(ByVal acodcai As Integer, ByVal CUD As Integer)
        If CUD = 0 Then
            Return "INSERT INTO Caixa (codcom_cai, codcli_cai, codprod_cai, qtdeprod_cai, valorunid_cai, valortotal_cai, desconto_cai, datacompra_cai, ativo_cai, tipopagam) VALUES (" & acodigocompra & "," & acodigocliente & "," & acodigoproduto & "," & aqtdeproduto & ",'" & Replace(CDbl(avalorunidproduto), ",", ".") & "','" & Replace(CDbl(avalortotalvenda), ",", ".") & "'," & adesconto & ",'" & adatacompra & "','s','" & atipopagam & "')"
        ElseIf CUD = 1 Then
            Return "UPDATE Caixa SET codcom_cai = '" & acodigocompra & "', codcli_cai = '" & acodigocliente & "', codprod_cai = '" & acodigoproduto & "', qtdeprod_cai = '" & aqtdeproduto & "', valorunid_cai = '" & Replace(CDbl(avalorunidproduto), ",", ".") & "', avalortotal_cai = '" & Replace(CDbl(avalortotalvenda), ",", ".") & "', desconto_cai = '" & adesconto & "', datacompra_cai = '" & adatacompra & "', datapagam = '" & atipopagam & "' WHERE cod_cai = " & acodcai
        Else
            Return "UPDATE Caixa SET ativo_cai = 'n' WHERE cod_cai = " & acodcai
        End If
    End Function

    '//CONECTANDO AO BANCO DE DADOS
    Private Shared Function AbrindoConexaoBanco() As SqlServerCe.SqlCeConnection
        Try
            Dim conSTring As String = "Data Source= " & Application.StartupPath & "\SSBorracharia.sdf; Persist Security Info=False"
            Dim connection As SqlCeConnection = New SqlCeConnection(conString)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '//FAZ UM SELECT DISTINCT DOS CÓDIGOS DE COMPRA PARA ENCONTRAR UM NOVO CODIGO PARA COMPRA
    Public Shared Function novoCodigoCompra() As Object
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("Select Max (codcom_cai) from Caixa", connection)
                    Return Command.ExecuteScalar()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function

    '//ADICIONAR, EDITAR, EXCLUIR VENDA DO CAIXA DO BANCO DE DADOS
    Public Sub CUDCaixa(ByVal acodcai As Integer, ByVal CUD As Integer)
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand(stringBanco(acodcai, CUD), connection)
                    Command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Sub

    '//FAZ UM SELECT DOS CLIENTES E CARREGA NO DATAGRID
    Public Shared Function ReadClientes() As DataTable
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT B.nome_cli, C.nomeser_prod, A.qtdeprod_cai, A.desconto_cai, A.datacompra_cai FROM Caixa A INNER JOIN Cliente B ON A.codcli_cai = B.cod_cli INNER JOIN Produto C ON A.codprod_cai = C.cod_prod WHERE A.ativo_cai = 's'", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//FAZ UMA VARREDURA NO BANCO SOMANDO TODAS AS VENDAS DE CADA MÊS
    Public Shared Function jogaGrafico(ByVal vdataInicio As String, ByVal vdataTermino As String) As Integer
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT SUM(valortotal_cai) FROM Caixa WHERE datacompra_cai BETWEEN '" & vdataInicio & "' AND '" & vdataTermino & "'", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                Return 0
            End Try
        End Using
    End Function

    '//RETORNA O ÚLTIMO INSERT FEITO NO BANCO DE DADOS PARA IMPRIMIR NO BOLETO
    Public Shared Function ultimoInsert() As Object
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT MAX(cod_cai) FROM Caixa", connection)
                    Return Command.ExecuteScalar()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function

    '//CARREGA PRODUTO NO CAMPO CLIENTE
    Public Shared Function carregaGridHistorico(ByVal vcodigocliente As Integer) As DataTable
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT A.cod_cai, A.qtdeprod_cai, B.nomeser_prod, A.valorunid_cai, A.valortotal_cai, A.desconto_cai, A.datacompra_cai, A.tipopagam FROM Caixa A INNER JOIN Produto B ON A.codprod_cai = B.cod_prod WHERE codcli_cai = " & vcodigocliente & " AND ativo_cai = 's' ORDER BY datacompra_cai DESC", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//CARREGA COMBOBOX PAGAMENTO SOMENTE COM OS VALORES DO PAGAMENTO DESSE CLIENTE 
    Public Shared Function carregaComboPagam(ByVal vcodigocliente As Integer) As DataTable
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT DISTINCT tipopagam FROM Caixa WHERE codcli_cai = " & vcodigocliente & " AND ativo_cai = 's'", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//CARREGA PRODUTO NO CAMPO CLIENTE COM O FILTRO DE PESQUISA DESABILITADO
    Public Shared Function carregaGridHistPesquisa(ByVal vcodigocliente As Integer, ByVal datainicio As String, ByVal datatermino As String, ByVal pagamento As String) As DataTable
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT A.cod_cai, A.qtdeprod_cai, B.nomeser_prod, A.valorunid_cai, A.valortotal_cai, A.desconto_cai, A.datacompra_cai, A.tipopagam FROM Caixa A INNER JOIN Produto B ON A.codprod_cai = B.cod_prod WHERE codcli_cai = " & vcodigocliente & " AND ativo_cai = 's' AND datacompra_cai >= '" & datainicio & "' AND datacompra_cai <= '" & datatermino & "' AND tipopagam = '" & pagamento & "' ORDER BY datacompra_cai DESC", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//FAZ UMA VARREDURA NO BANCO SOMANDO A QUANTIDADE TOTAL DE VENDAS CADASTRADOS
    Public Shared Function totalCaixa() As Integer
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT Count(cod_cai) FROM Caixa WHERE ativo_cai = 's'", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                Return 0
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Function

End Class
