
Imports System.ComponentModel
Imports System.Windows

Public Class frm_cadastro_usuario
    Private Sub frm_cadastro_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
        carregar_tipo_campo()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        If validar_form() Then
            carregar_dados()
            salvar_cadastro()
            limpar_dados()
        End If
    End Sub

    Private Function validar_form() As Boolean
        Dim result As Boolean

        If txt_id.Text = "" Then
                MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            txt_id.Focus()
            result = False

        ElseIf txt_nome.Text = "" Then
                MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
                txt_nome.Focus()
                result = False

            ElseIf txt_senha.Text = "" Then
                MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
                txt_senha.Focus()
                result = False

            Else
                result = True

        End If

        Return result

    End Function

    Private Sub salvar_cadastro()
        txt_status = "ATIVO"
        Try
            sql = "Select * from tb_cadastro where id='" & txt_id.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_cadastro set nome='" & txt_nome.Text & "', " &
                                             "id='" & txt_id.Text & "', " &
                                             "senha='" & txt_senha.Text & "', " &
                                             "status='" & txt_status & "' where id='" & txt_id.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_cadastro values ('" & txt_id.Text & "', " &
                                                    "'" & txt_nome.Text & "', " &
                                                    "'" & txt_senha.Text & "'," &
                                                    "'" & txt_status & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            limpar_dados()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try


    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_id = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_cadastro where ID='" & aux_id & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_id.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_senha.Text = rs.Fields(2).Value
                        txt_id.Enabled = False
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_id = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_cadastro where ID='" & aux_id & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                                    "ID: " & aux_id & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete * from tb_cadastro where ID ='" & aux_id & "'"
                            rs = db.Execute(sql)
                            carregar_dados()
                            limpar_dados()
                        End If
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    txt_status = "ATIVO"
                    aux_id = .CurrentRow.Cells(1).Value

                    sql = "update tb_cadastro set status='" & txt_status & "' where ID='" & aux_id & "'"

                    rs = db.Execute(UCase(sql))
                    MsgBox("Conta ativa!", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "ATENÇÃO")

                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    txt_status = "BLOQUEADO"
                    aux_id = .CurrentRow.Cells(1).Value

                    sql = "update tb_cadastro set status='" & txt_status & "' where ID='" & aux_id & "'"

                    rs = db.Execute(UCase(sql))
                    MsgBox("Conta bloqueada!", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar a ação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            Sql = "select * from tb_cadastro where " & cmb_tipo.Text & " Like '" & txt_busca.Text & "%'"
            rs = db.Execute(Sql)
            With dgv_dados
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

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        limpar_dados()
        retirar_tipo_campo()
        Me.Close()
    End Sub

    Private Sub frm_cadastro_usuario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        limpar_dados()
        retirar_tipo_campo()
    End Sub

    Sub retirar_tipo_campo()
        Try
            With cmb_tipo.Items
                .Remove("ID")
                .Remove("NOME")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class