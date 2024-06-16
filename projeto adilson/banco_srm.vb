Public Class frm_banco_srm

    Private Sub frm_banco_srm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_banco_srm()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub


    Private Sub carregar_banco_srm()
        Try
            sql = "select * from tb_srm order by srm desc"
            rs = db.Execute(sql)
            With dgv_dad
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value,
                              rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value,
                              rs.Fields(13).Value, rs.Fields(14).Value, rs.Fields(15).Value, rs.Fields(16).Value, rs.Fields(17).Value, rs.Fields(18).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub dgv_dad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dad.CellContentClick

    End Sub
End Class