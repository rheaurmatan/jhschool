Public Class FrmStLg
    Private Sub btnAddAc0_Click(sender As Object, e As EventArgs) Handles btnAddAc0.Click
        Dim myForm As New FrmStRg
        myForm.Show()
    End Sub

    Private Sub btnStLg0_Click(sender As Object, e As EventArgs) Handles btnStLg0.Click
        Dim myForm As New FrmLndngScrn
        myForm.Show()
    End Sub

    Private Sub btnStSwt0_Click(sender As Object, e As EventArgs) Handles btnStSwt0.Click
        Dim myForm As New FrmFcltyLg
        myForm.Show()
    End Sub

    Private Sub btnStCn_Click(sender As Object, e As EventArgs) Handles btnStCn.Click
        Me.Close()
    End Sub
End Class
