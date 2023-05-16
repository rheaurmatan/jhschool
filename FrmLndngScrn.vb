Public Class FrmLndngScrn
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim myForm As New FrmLndngScrn
        myForm.Show()
    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Dim myForm As New FrmGrds
        myForm.Show()
    End Sub

    Private Sub btnFees_Click(sender As Object, e As EventArgs) Handles btnFees.Click
        Dim myForm As New FrmStFs
        myForm.Show()
    End Sub

    Private Sub btnSignO_Click(sender As Object, e As EventArgs) Handles btnSignO.Click
        Dim myForm As New FrmStLg
        myForm.Show()
    End Sub

    Private Sub btnSwitch0_Click(sender As Object, e As EventArgs) Handles btnSwitch0.Click
        Dim myForm As New FrmFcltyLg
        myForm.Show()
    End Sub

    Private Sub btnBackupdb_Click(sender As Object, e As EventArgs) Handles btnBackupdb.Click

    End Sub
End Class