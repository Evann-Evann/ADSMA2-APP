Public Class frm_menu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If nivel_acesso = 1 Then
            btn_adm.Enabled = True
        Else
            btn_adm.Enabled = False
        End If
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        frm_cadastro_ferramenta.ShowDialog()
    End Sub

    Private Sub btn_adm_Click(sender As Object, e As EventArgs) Handles btn_adm.Click
        frm_cadastro_usuario.ShowDialog()
    End Sub

    Private Sub btn_banco_Click(sender As Object, e As EventArgs) Handles btn_banco.Click
        frm_banco_ferramentas.ShowDialog()

    End Sub

    Private Sub btn_entrada_Click(sender As Object, e As EventArgs) Handles btn_entrada.Click
        frm_entrada.ShowDialog()
    End Sub

    Private Sub btn_manutencao_Click(sender As Object, e As EventArgs) Handles btn_manutencao.Click
        frm_manutencao.ShowDialog()
    End Sub

    Private Sub btn_saida_Click(sender As Object, e As EventArgs) Handles btn_saida.Click
        frm_saida.ShowDialog()
    End Sub

    Private Sub btn_banco_srm_Click(sender As Object, e As EventArgs) Handles btn_banco_srm.Click
        frm_banco_srm.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
    End Sub
End Class
