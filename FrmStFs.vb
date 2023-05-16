Public Class FrmStFs

    Private Sub btnAddFee_Click(sender As Object, e As EventArgs) Handles btnAddFee.Click
        Dim myForm As New FrmStFs
        myForm.Show()
    End Sub

    Private Sub btnFeeMd_Click(sender As Object, e As EventArgs) Handles btnFeeMd.Click

    End Sub

    Private Sub btnFeeDel_Click(sender As Object, e As EventArgs) Handles btnFeeDel.Click
        MsgBox("The listed fee is deleted already!")
    End Sub

    Private Sub btnFeeCncl_Click(sender As Object, e As EventArgs) Handles btnFeeCncl.Click
        Dim myForm As New FrmLndngScrn
        myForm.Show()
    End Sub
End Class