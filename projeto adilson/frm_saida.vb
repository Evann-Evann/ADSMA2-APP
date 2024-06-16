Public Class frm_saida
    Private cliente_entrada, status_fer, status_final As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sql = "select * from tb_srm where srm='" & txt_srm.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            cliente_entrada = rs.Fields(8).Value
            status_fer = rs.Fields(9).Value
            rs = db.Execute(sql)
            With dgv_dados

                .Rows.Clear()
                .Rows.Add(rs.Fields(5).Value, rs.Fields(9).Value, rs.Fields(17).Value, rs.Fields(8).Value)

            End With
        Else
            MsgBox("SRM não existe!", vbInformation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_srm.Clear()
            cliente_entrada = ""
        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        limpar_dados()
        With dgv_dados
            .Rows.Clear()
        End With
        Me.Close()
    End Sub
    Private Sub limpar_dados()
        txt_srm.Clear()
        txt_cliente.Clear()
        txt_srm.Focus()
    End Sub

    Private Sub btn_omesmo_Click(sender As Object, e As EventArgs) Handles btn_omesmo.Click
        If Not cliente_entrada = "" Then
            txt_cliente.Text = cliente_entrada
        End If
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


        ElseIf txt_cliente.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            result = False

        Else
            result = True

        End If

        Return result

    End Function

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click

        If status_fer = "FERRAMENTA REPARADA" Then
            If validar_form() Then
                salvar_saida()
                limpar_dados()
                With dgv_dados
                    .Rows.Clear()
                End With
            End If
        Else
            MsgBox("Ferramenta precisa estar com a situação reparada " + vbNewLine &
                   "Para poder ser retirada.", +vbInformation, "ATENÇÃO")


        End If
    End Sub

    Private Sub frm_saida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub salvar_saida()
        sql = "select * from tb_srm where srm='" & txt_srm.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            status_final = "FERRAMENTA RETIRADA"
            sql = "update tb_srm set cliente_saida='" & txt_cliente.Text & "', " &
                "situacao_ferramenta='" & status_final & "', " &
               "data_saida='" & cmb_data.Text & "' where SRM='" & txt_srm.Text & "'"


            rs = db.Execute(UCase(sql))
            MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
        limpar_dados()
        With dgv_dados
            .Rows.Clear()
        End With
    End Sub

    Private Sub frm_saida_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        limpar_dados()
        With dgv_dados
            .Rows.Clear()
        End With
    End Sub
End Class