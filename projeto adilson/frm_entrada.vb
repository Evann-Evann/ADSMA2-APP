Public Class frm_entrada
    Private status_ferramenta As String
    Private Sub frm_entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verificar_srm()
        ' MsgBox("horas:" & cmb_hora.Text & "!" + vbNewLine &
        '          "dia :" & cmb_data.Text & "!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "aviso")

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        limpar_dados()
        With dgv_dados
            .Rows.Clear()
        End With
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sql = "select * from tb_ferramentas where mf='" & txt_mf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            With dgv_dados

                .Rows.Clear()
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)

            End With
        Else
            MsgBox("MF não cadastrado!", vbInformation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_mf.Clear()
        End If
    End Sub

    Private Sub verificar_srm()
        sql = "select * from tb_srm order by srm desc"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            cont = rs.Fields(0).Value
        End If
        cont = cont + 1
        txt_srm.Text = cont
        txt_srm.Enabled = False
    End Sub


    Private Sub limpar_dados()
        txt_mf.Clear()
        txt_cliente.Clear()
        txt_local.Clear()
        cmb_turno.Text = ""
        cmb_linha.Text = ""
        txt_mf.Focus()
    End Sub

    Private Sub btn_entrada_Click(sender As Object, e As EventArgs) Handles btn_entrada.Click
        If validar_form() Then
            salvar_srm()
            verificar_srm()
            limpar_dados()
            With dgv_dados
                .Rows.Clear()
            End With
        End If
    End Sub
    Private Function validar_form() As Boolean
        Dim result As Boolean


        sql = "select * from tb_ferramentas where mf='" & txt_mf.Text & "'"
        rs = db.Execute(sql)
        If txt_mf.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            txt_mf.Focus()
            result = False

        ElseIf rs.EOF = True Then
            MsgBox("MF :" & txt_mf.Text & " Não Cadastrado!" + vbNewLine &
                       "Favor cadastrar antes de gerar a entrada.", vbExclamation, "Atenção")
                txt_mf.Focus()
                result = False

            ElseIf txt_cliente.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            txt_cliente.Focus()
            result = False

        ElseIf txt_local.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            txt_local.Focus()
            result = False

        ElseIf cmb_turno.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            cmb_turno.Focus()
            result = False

        ElseIf cmb_linha.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            cmb_linha.Focus()
            result = False

        Else
            result = True

        End If

        Return result

    End Function

    Private Sub salvar_srm()
        Status_ferramenta = "EM MANUTENCAO"
        vazio = ""
        Try
            sql = "insert into tb_srm values ('" & txt_srm.Text & "', " &
                                            "'" & usuario_atual_sistema & "', " &
                                            "'" & cmb_data.Text & "'," &
                                            "'" & cmb_hora.Text & "', " &
                                            "'" & cmb_turno.Text & "'," &
                                            "'" & txt_mf.Text & "', " &
                                            "'" & cmb_linha.Text & "'," &
                                            "'" & txt_local.Text & "', " &
                                            "'" & txt_cliente.Text & "'," &
                                            "'" & status_ferramenta & "', " &
                                            "'" & vazio & "'," &
                                            "'" & vazio & "', " &
                                            "'" & vazio & "'," &
                                            "'" & vazio & "', " &
                                            "'" & vazio & "'," &
                                            "'" & vazio & "', " &
                                            "'" & vazio & "', " &
                                            "'" & vazio & "', " &
                                            "'" & vazio & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try


    End Sub

    Private Sub frm_entrada_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        limpar_dados()
        With dgv_dados
            .Rows.Clear()
        End With
    End Sub

End Class