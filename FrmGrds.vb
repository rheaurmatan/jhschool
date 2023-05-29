Public Class FrmGrds
    Private Sub btnLGrd_Click(sender As Object, e As EventArgs) Handles btnLGrd.Click
         Dim cname As String = "C:\Users\Admin\Desktop\stud_grades.csv"
        Dim reader As New StreamReader(cname, Encoding.Default)
        Dim sline As String = ""
        Dim colsexpected As Integer = 10
        Dim r As Integer = 0
        sline = reader.ReadLine
        Do
            sline = reader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            DataGridView1.Rows.Add()
            For i As Integer = 0 To 10
                DataGridView1.Rows(r).Cells(i).Value = words(i)
            Next
            r = r + 1
        Loop
        reader.Close()

    End Sub

    Private Sub btnGrdMd_Click(sender As Object, e As EventArgs) Handles btnGrdMd.Click

    End Sub

    Private Sub btnGrdCncl_Click(sender As Object, e As EventArgs) Handles btnGrdCncl.Click
        Dim myForm As New FrmLndngScrn
        myForm.Show()
    End Sub
        
        Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
          Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim applixcl As Excel.Application
        Dim wrkbk As Excel.Workbook
        Dim sheet As Excel.Worksheet

        applixcl = CreateObject("Excel.Application")
        applixcl.Visible = True
        wrkbk = applixcl.Workbooks.Add
        sheet = wrkbk.ActiveSheet
        sheet.Cells(1, 6).Value = "jhschool"
        applixcl.Quit()
    End Sub
End Class
