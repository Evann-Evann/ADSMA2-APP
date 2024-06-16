Module Module1
    Public direciona_banco = Application.StartupPath & "\Banco\cadastro.mdb"
    Public diretorio As String
    Public sql, aux_id, aux_mf, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public txt_status As String
    Public cont As Integer
    Public nivel_acesso As Integer
    Public usuario_atual_sistema As String
    Public vazio As String
    Public usuario_entrada, dia_entrada, hora_entrada, turno_entrada, mf, linha, local, cliente_entrada As String
    Sub conecta_banco_access()
        'String de conexão ADO
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & direciona_banco)
            MsgBox("Conexão efetuada com o banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro de Conexão!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub carregar_dados()
        Try
            sql = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(sql)
            With frm_cadastro_usuario.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub limpar_dados()
        Try
            With frm_cadastro_usuario
                .txt_id.Clear()
                .txt_nome.Clear()
                .txt_senha.Clear()
                .txt_id.Enabled = True
                .txt_id.Focus()

            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_campo()
        Try
            With frm_cadastro_usuario.cmb_tipo.Items
                .Add("ID")
                .Add("NOME")
            End With
            frm_cadastro_usuario.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
