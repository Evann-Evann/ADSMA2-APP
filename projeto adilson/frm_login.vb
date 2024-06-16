Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class frm_login
    Private Sub Form1Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
    End Sub

    Private Function validar_dados_login() As Boolean
        Dim result As Boolean
        If txt_id.Text = "" Then
            MsgBox("Preencha o email!", vbExclamation, "AVISO")
            txt_senha.Clear()
            txt_id.Focus()
            result = False
        ElseIf txt_senha.Text = "" Then
            MsgBox("Preencha a senha!", vbExclamation, "AVISO")
            txt_senha.Focus()
            result = False
        Else
            result = True
        End If

        Return result

    End Function
    Private Sub validar_login()
        sql = "select * from tb_cadastro where id='" & txt_id.Text & "' and senha='" & txt_senha.Text & "'"
        rs = db.Execute(sql)

        If txt_id.Text = "adm" And txt_senha.Text = "adm" Then
            MsgBox("Conexão efetuada com sucesso!", vbInformation, "Aviso")
            nivel_acesso = 1
            usuario_atual_sistema = txt_id.Text
            txt_id.Clear()
            txt_senha.Clear()
            frm_menu.ShowDialog()


        ElseIf rs.EOF = True Then
            MsgBox("Usuário ou senha inválidos.", vbExclamation, "Atenção")
            txt_id.Clear()
            txt_senha.Clear()
            txt_id.Focus()
        Else
            txt_status = rs.Fields(3).Value
            If txt_status = "ATIVO" Then
                MsgBox("Conexão efetuada com sucesso!", vbInformation, "Aviso")
                nivel_acesso = 2
                usuario_atual_sistema = rs.Fields(1).Value
                txt_id.Clear()
                txt_senha.Clear()
                frm_menu.ShowDialog()

            Else
                MsgBox("Conta bloqueada", vbExclamation, "Aviso")

            End If
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If validar_dados_login() Then
            validar_login()
        End If
    End Sub

End Class
