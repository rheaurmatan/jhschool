Imports Microsoft.Office.Interop
Module sample_module


    Public currentDate As DateTime = DateTime.Now
    Public strpassword = "riya"
    Public xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\..\..\dataXls\TEMPLATE\"
    Public xlsFiles As String = System.IO.Directory.GetCurrentDirectory & "\..\..\dataXls\"

    Public Sub importToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)

        xlsSheet = xlsWB.Worksheets(1)
        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                xlsSheet.Cells(x + 5, y + 1) = mydg.Rows(x).Cells(y).Value
            Next



            templatefilename = templatefilename.Replace(".xlsx", "")
            templatefilename = templatefilename.Replace(".xls", "")
            Dim myfilename As String = templatefilename & " " & currentDate.ToString("mm-dd-yy hh-mm-ss") & ".xlsx"
            MsgBox(myfilename)
            xlsSheet.Protect(strpassword)
            xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
            xlsApp.ActiveWindow.DisplayGridlines = False
            xlsWB.SaveAs(xlsFiles & myfilename)
            xlsApp.Quit()
            releaseObject(xlsApp)
            releaseObject(xlsWB)
            releaseObject(xlsSheet)
            System.Diagnostics.Process.Start("excel.exe", """" & xlsFiles & myfilename & """")
    End Sub



    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub
End Module
