Imports System.Data.SqlServerCe

Public Class cls_Cliente
    Private codigo As String
    Private nome As String
    Private dataCadastro As String
    Private cep As String
    Private cnpj As String
    Private rua As String
    Private numero As String
    Private bairro As String
    Private cidade As String
    Private uf As String
    Private telcel As String
    Private telres As String
    Private email As String

    Public Property acodigo()
        Get
            Return codigo
        End Get
        Set(ByVal value)
            codigo = value
        End Set
    End Property
    Public Property anome()
        Get
            Return nome
        End Get
        Set(ByVal value)
            nome = value
        End Set
    End Property
    Public Property adatacadastro
        Get
            Return dataCadastro
        End Get
        Set(ByVal value)
            dataCadastro = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property
    Public Property acep
        Get
            Return cep
        End Get
        Set(ByVal value)
            cep = value
        End Set
    End Property
    Public Property acnpj
        Get
            Return cnpj
        End Get
        Set(ByVal value)
            cnpj = value
        End Set
    End Property
    Public Property arua
        Get
            Return rua
        End Get
        Set(ByVal value)
            rua = value
        End Set
    End Property
    Public Property anumero
        Get
            Return numero
        End Get
        Set(ByVal value)
            numero = value
        End Set
    End Property
    Public Property abairro
        Get
            Return bairro
        End Get
        Set(ByVal value)
            bairro = value
        End Set
    End Property
    Public Property acidade
        Get
            Return cidade
        End Get
        Set(ByVal value)
            cidade = value
        End Set
    End Property
    Public Property auf
        Get
            Return uf
        End Get
        Set(ByVal value)
            uf = value
        End Set
    End Property
    Public Property atelcel
        Get
            Return telcel
        End Get
        Set(ByVal value)
            telcel = value
        End Set
    End Property
    Public Property atelres
        Get
            Return telres
        End Get
        Set(ByVal value)
            telres = value
        End Set
    End Property
    Public Property aemail
        Get
            Return email
        End Get
        Set(ByVal value)
            email = value
        End Set
    End Property

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

    '//STRINGS DE ATUALIZAÇÃO DO BANCO DE DADOS
    Public Function stringBanco(ByVal acodcli As Integer, ByVal CUD As String)
        If acodcli = 0 Then
            Return "INSERT INTO Cliente (nome_cli, datacad_cli, cep_cli, cnpj_cli, rua_cli, numero_cli, bairro_cli, cidade_cli, uf_cli, telcel_cli, telres_cli, email_cli, ativo_cli) VALUES ('" & anome & "','" & adatacadastro & "','" & acep & "','" & acnpj & "','" & arua & "','" & anumero & "','" & abairro & "','" & acidade & "','" & auf & "','" & atelcel & "','" & atelres & "','" & aemail & "','s')"
        ElseIf CUD = "u" Then
            Return "UPDATE Cliente SET nome_cli = '" & anome & "', datacad_cli = '" & adatacadastro & "', cep_cli = '" & acep & "', cnpj_cli = '" & acnpj & "', rua_cli = '" & arua & "', numero_cli = '" & anumero & "', bairro_cli = '" & abairro & "', cidade_cli = '" & acidade & "', uf_cli = '" & auf & "', telcel_cli = '" & atelcel & "', telres_cli = '" & atelres & "', email_cli = '" & aemail & "' WHERE cod_cli = " & acodcli
        Else
            Return "UPDATE Cliente SET ativo_cli = 'n' WHERE cod_cli = " & acodcli
        End If
    End Function

    '//ADICIONAR, EDITAR, EXCLUIR CLIENTE DO BANCO DE DADOS
    Public Sub CUDCliente(ByVal acodcli As Integer, ByVal CUD As String)
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand(stringBanco(acodcli, CUD), connection)
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
                Using Command As New SqlCeCommand("SELECT cod_cli, nome_cli, datacad_cli FROM Cliente WHERE ativo_cli = 's'", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//FAZ UM SELECT DO CLIENTE SELECIONADO E CARREGA NO FORMULÁRIO DE CADASTRO DE CLIENTE
    Public Function cadastroCompleto(ByVal vcodcli As Integer) As cls_Cliente
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dr As SqlCeDataReader = Nothing
                Using Command As New SqlCeCommand("SELECT cod_cli, nome_cli, datacad_cli, cep_cli, cnpj_cli, rua_cli, numero_cli, bairro_cli,cidade_cli, uf_cli, telcel_cli, telres_cli, email_cli FROM Cliente WHERE cod_cli = " & vcodcli, connection)
                    dr = Command.ExecuteReader
                    dr.Read()
                    acodigo = dr("cod_cli")
                    anome = dr("nome_cli")
                    acep = dr("cep_cli")
                    acnpj = dr("cnpj_cli")
                    arua = dr("rua_cli")
                    anumero = dr("numero_cli")
                    abairro = dr("bairro_cli")
                    acidade = dr("cidade_cli")
                    auf = dr("uf_cli")
                    atelcel = dr("telcel_cli")
                    atelres = dr("telres_cli")
                    aemail = dr("email_cli")
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
        Return Me
    End Function

    '//FAZ UMA BUSCA DO CLIENTE DIGITADO NO CAMPO DE PROCURA
    Public Shared Function ProduraClientes(ByVal vProcura As String) As DataTable
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT cod_cli, nome_cli, datacad_cli FROM Cliente WHERE ativo_cli = 's' AND nome_cli LIKE '%" & vProcura & "%'", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//VERIFICA O CEP DO CLIENTE QUE ESTÁ SENDO FEITO O CADASTRO
    Public Sub verificaCep(ByVal vcep As String)
        Try
            Dim ds As New DataSet
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", vcep)

            ds.ReadXml(xml)
            If ds.Tables(0).Rows(0)("resultado") Then
                arua = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")
                abairro = ds.Tables(0).Rows(0)("bairro")
                acidade = ds.Tables(0).Rows(0)("cidade")
                auf = ds.Tables(0).Rows(0)("uf")
                Return
            Else
                MessageBox.Show("Cep não localizado, tente novamente...")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro : Verifique se seu computador está conectado a internet e tente novamente!", "Erro ao encotrar Endereço do CEP!")
        End Try
    End Sub

    '//COMPLETA O CAMPO CLIENTE ANTES DE COMEÇAR A EFETUAR A COMPRA
    Function CompletaCliente()
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Dim ds As New DataSet

                ds.Tables.Add(dt)

                Dim da As New SqlCeDataAdapter("SELECT nome_cli FROM Cliente WHERE ativo_cli = 's'", connection)
                da.Fill(dt)

                Dim r As DataRow

                For Each r In dt.Rows
                    frm_Venda.txtCliente.AutoCompleteCustomSource.Add(r.Item(0).ToString)
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
            Return True
        End Using

    End Function

    '//CARREGA TODOS OS CAMPOS DO FORMULÁRIO ANTES DE JOGAR NO DATAGRID
    Public Sub carregaCamposCliente(ByVal vnome As String, ByVal vcodigo As Integer)
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Dim dt As SqlCeDataReader  '                          rua  Número()    bairro   cidade    Estado()  telres  telcel email(cnpj)
                Using Command As New SqlCeCommand("SELECT cod_cli, nome_cli, rua_cli, numero_cli, bairro_cli, cidade_cli, uf_cli, telcel_cli, telres_cli, email_cli, cnpj_cli FROM Cliente WHERE ativo_cli = 's' AND nome_cli = '" & vnome & "'", connection)
                    dt = Command.ExecuteReader()
                    dt.Read()
                    acodigo = dt("cod_cli")
                    anome = dt("nome_cli")
                    arua = dt("rua_cli")
                    anumero = dt("numero_cli")
                    abairro = dt("bairro_cli")
                    acidade = dt("cidade_cli")
                    auf = dt("uf_cli")
                    atelres = dt("telres_cli")
                    atelcel = dt("telcel_cli")
                    aemail = dt("email_cli")
                    acnpj = dt("cnpj_cli")
                End Using
            Catch ex As Exception
                MessageBox.Show("Valores Incorretos!! Digite novamente os valores acima!!" & " " & ex.Message)
                frm_Venda.txtCliente.Text = ""
                frm_Venda.txtCliente.Focus()
            End Try
        End Using
    End Sub

    '//FAZ UMA VARREDURA NO BANCO SOMANDO A QUANTIDADE TOTAL DE CLIENTES CADASTRADOS
    Public Shared Function totalCliente() As Integer
        Using connection As SqlCeConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT Count(cod_cli) FROM Cliente WHERE ativo_cli = 's'", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                Return 0
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Function

End Class
