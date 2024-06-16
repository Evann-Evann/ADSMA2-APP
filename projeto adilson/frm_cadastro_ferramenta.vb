Public Class frm_cadastro_ferramenta
    Private Sub verificar_mf()

        sql = "select * from tb_ferramentas order by mf desc"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            cont = rs.Fields(0).Value
        End If
        cont = cont + 1
        txt_mf.Text = cont
        txt_mf.Enabled = False

    End Sub

    Private Sub salvar_mf()
        sql = "insert into tb_ferramentas values ('" & txt_mf.Text & "', " &
                                                 "'" & txt_num_serie.Text & "', " &
                                                 "'" & txt_modelo.Text & "'," &
                                                 "'" & cmb_marca.Text & "'," &
                                                 "'" & cmb_tipo_ferramenta.Text & "')"
        rs = db.Execute(UCase(sql))
        MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    End Sub


    Private Sub frm_cadastro_ferramenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verificar_mf()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If validar_form() Then
            salvar_mf()
            limpar_dados()
            verificar_mf()
        End If

    End Sub

    Private Sub limpar_dados()
        txt_num_serie.Clear()
        txt_modelo.Clear()
        cmb_marca.Text = ""
        cmb_tipo_ferramenta.Text = ""
        txt_num_serie.Focus()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        limpar_dados()

        Me.Close()

    End Sub

    Private Sub frm_cadastro_ferramenta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        limpar_dados()
    End Sub

    Private Function validar_form() As Boolean
        Dim result As Boolean

        If txt_num_serie.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            txt_num_serie.Focus()
            result = False

        ElseIf txt_modelo.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            txt_modelo.Focus()
            result = False

        ElseIf cmb_marca.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            cmb_marca.Focus()
            result = False

        ElseIf cmb_tipo_ferramenta.Text = "" Then
            MsgBox("Preencha todos os campos.", vbExclamation, "Atenção")
            cmb_tipo_ferramenta.Focus()
            result = False

        Else
            result = True

        End If

        Return result

    End Function

End Class