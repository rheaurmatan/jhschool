Public Class FrmFcltyLg
    Private Sub btnAddFclty_Click(sender As Object, e As EventArgs) Handles btnAddFclty.Click

    End Sub

    Private Sub btnFcltyLG_Click(sender As Object, e As EventArgs) Handles btnFcltyLG.Click

    End Sub

    Private Sub btnFcltyCncl_Click(sender As Object, e As EventArgs) Handles btnFcltyCncl.Click
        Me.Close()
    End Sub

    Private Sub btnFcltySwtch_Click(sender As Object, e As EventArgs) Handles btnFcltySwtch.Click
        Dim myForm As New FrmStLg
        myForm.Show()
    End Sub
End Class