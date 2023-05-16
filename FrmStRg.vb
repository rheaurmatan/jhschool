Public Class FrmStRg

    Private Sub btnRgCn1_Click(sender As Object, e As EventArgs) Handles btnRgCn1.Click
        Dim myForm As New FrmLndngScrn
        myForm.Show()
    End Sub

    Private Sub btnRgAdd0_Click(sender As Object, e As EventArgs) Handles btnRgAdd0.Click
        Dim myForm As New FrmStRg
        myForm.Show()
    End Sub

    Private Sub btnRgMd0_Click(sender As Object, e As EventArgs) Handles btnRgMd0.Click

    End Sub

    Private Sub btnStRgS_Click(sender As Object, e As EventArgs) Handles btnStRgS.Click

    End Sub

    Private Sub btnRgDel_Click(sender As Object, e As EventArgs) Handles btnRgDel.Click
        MsgBox("This registered account is deleted!")

    End Sub
End Class