Imports System.Net.Security

Public Class frm_banco_ferramentas

    Private Sub carregar_ferramentas()
        Try
            sql = "select * from tb_ferramentas order by mf desc"
            rs = db.Execute(sql)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing)
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub carregar_tipo_campo()
        Try
            With cmb_tipo.Items
                .Add("MF")
                .Add("NUMERO DE SERIE")
            End With
            cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub frm_banco_ferramentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_ferramentas()
        carregar_tipo_campo()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        cmb_tipo.Items.Clear()
        Me.Close()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            If cmb_tipo.Text = "NUMERO DE SERIE" Then

                sql = "select * from tb_ferramentas where num_serie Like '" & txt_busca.Text & "%'"
                rs = db.Execute(sql)
                With dgv_dados
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                        rs.MoveNext()
                    Loop
                End With

            Else
                sql = "select * from tb_ferramentas where " & cmb_tipo.Text & " Like '" & txt_busca.Text & "%'"
                rs = db.Execute(sql)
                With dgv_dados
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing)
                        rs.MoveNext()
                    Loop
                End With
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            If .CurrentRow.Cells(5).Selected = True And usuario_atual_sistema = "adm" Then
                aux_mf = .CurrentRow.Cells(0).Value
                sql = "select * from tb_ferramentas where mf='" & aux_mf & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                            "MF: " & aux_mf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_ferramentas where mf ='" & aux_mf & "'"
                        rs = db.Execute(sql)
                        carregar_ferramentas()
                    End If
                End If
            ElseIf .CurrentRow.Cells(5).Selected = True And Not usuario_atual_sistema = "adm" Then
                MsgBox("somente o ADM pode excluir uma ferramenta do banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If
        End With
    End Sub
End Class