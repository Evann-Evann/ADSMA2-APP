Public Class frm_manutencao
    Private cont_manu, situacao_manu, cliente, status_situ As String


    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        limpar_dados()
        With dgv_dados
            .Rows.Clear()
        End With
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sql = "select * from tb_srm where srm='" & txt_srm.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            cont_manu = rs.Fields(5).Value
            cliente = rs.Fields(8).Value
            situacao_manu = rs.Fields(9).Value
            sql = "select * from tb_ferramentas where mf='" & cont_manu & "'"
            rs = db.Execute(sql)
            With dgv_dados

                .Rows.Clear()
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, cliente, situacao_manu)

            End With
        Else
            MsgBox("SRM não existe!", vbInformation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_srm.Clear()
        End If
    End Sub

    Private Sub limpar_dados()
        txt_srm.Clear()
        txt_problema.Clear()
        txt_servico.Clear()
        cmb_turno.Text = ""
        cmb_situacao.Text = ""
        txt_srm.Focus()
    End Sub
    Private Function validar_form() As Boolean
        Dim result As Boolean

        sql = "select * from tb_srm where srm='" & txt_srm.Text & "'"
        rs = db.Execute(sql)
        If txt_srm.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            result = False

        ElseIf rs.EOF = True Then
            MsgBox("SRM :" & txt_srm.Text & " NÃO ENCONTRADO!" + vbNewLine &
                       "Favor escolher um SRM existente.", vbExclamation, "Atenção")
            result = False


        ElseIf txt_problema.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            result = False

        ElseIf txt_servico.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            result = False

        ElseIf cmb_turno.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            result = False


        ElseIf cmb_situacao.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            result = False

        Else
            result = True

        End If

        Return result

    End Function


    Private Sub btn_salvar_Click_1(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If validar_form() Then
            buscar_info_up()
            vazio = ""
            sql = "select * from tb_srm where srm='" & txt_srm.Text & "'"
            rs = db.Execute(sql)

            If status_situ = "FERRAMENTA RETIRADA" Then
                MsgBox("Não é possível realizar uma alteração/manutenção" + vbNewLine &
                   "numa ferramenta que já foi retirada.", +vbInformation, "ATENÇÃO")

            Else
                If rs.EOF = False Then
                    sql = "update tb_srm set situacao_ferramenta='" & cmb_situacao.Text & "', " &
                         "data_manutencao='" & cmb_data.Text & "', " &
                        "hora_inicio_manutencao='" & cmb_hora_inicio.Text & "', " &
                         "hora_termino_manutencao='" & cmb_hora_termino.Text & "', " &
                         "turno_manutencao='" & cmb_turno.Text & "', " &
                          "problema='" & txt_problema.Text & "', " &
                        "servico='" & txt_servico.Text & "', " &
                       "manutentor_responsavel='" & usuario_atual_sistema & "' where SRM='" & txt_srm.Text & "'"


                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                limpar_dados()
                With dgv_dados
                    .Rows.Clear()
                End With
            End If
        End If
    End Sub

    Private Sub frm_manutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

    End Sub

    Private Sub frm_manutencao_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        limpar_dados()
        With dgv_dados
            .Rows.Clear()
        End With
    End Sub
    Private Sub buscar_info_up()
        sql = "select * from tb_srm where srm='" & txt_srm.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            usuario_entrada = rs.Fields(1).Value
            dia_entrada = rs.Fields(2).Value
            hora_entrada = rs.Fields(3).Value
            turno_entrada = rs.Fields(4).Value
            mf = rs.Fields(5).Value
            linha = rs.Fields(6).Value
            local = rs.Fields(7).Value
            cliente_entrada = rs.Fields(8).Value
            status_situ = rs.Fields(9).Value
        End If
    End Sub
End Class