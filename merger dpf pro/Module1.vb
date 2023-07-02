'Imports System.Data
Imports System.Xml
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports PdfSharp
Imports PdfSharp.Drawing
Imports System.IO
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.PowerPoint


Module Module1
    Sub IMG_PDF(ByVal duongdan As String, ByRef pdf As PdfSharp.Pdf.PdfDocument, ByVal i As Integer, ByRef LOI As Integer)   'chuyển ẢNH sang PDF
        On Error GoTo err
        Dim page As PdfSharp.Pdf.PdfPage
        Dim GR As PdfSharp.Drawing.XGraphics
        '   page = pdf.AddPage()
        'Create XImage object from file.
        Using xImg = PdfSharp.Drawing.XImage.FromFile(duongdan)
            page = pdf.AddPage()
            If Form1.CheckBox1.Checked = False Then
                If xImg.PixelHeight < xImg.PixelWidth Then
                    page.Height = (841 / xImg.PixelWidth) * xImg.PixelHeight
                    page.Width = 841
                Else
                    page.Height = (595 / xImg.PixelWidth) * xImg.PixelHeight
                    page.Width = 595
                End If
            Else
                '    page.Width = xImg.PixelWidth
                '   page.Height = xImg.PixelHeight
                page.Height = (595 / xImg.PixelWidth) * xImg.PixelHeight
                page.Width = 595
            End If
            'Draw current image file to page.
            GR = PdfSharp.Drawing.XGraphics.FromPdfPage(page)
            GR.DrawImage(xImg, 0, 0, page.Width, page.Height)
        End Using
        Exit Sub
err:    Form1.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
        LOI += 1
    End Sub
    Public Sub FIX_PDF(ByVal duongdan As String, ByRef pdf As PdfSharp.Pdf.PdfDocument)

        Dim page As PdfSharp.Pdf.PdfPage
        Dim GR As PdfSharp.Drawing.XGraphics
        pdf.PageLayout = PdfPageLayout.SinglePage

        Using pdfform As XPdfForm = XPdfForm.FromFile(duongdan)
            For i = 1 To pdfform.PageCount
                page = pdf.AddPage()
                pdfform.PageNumber = i
                '   If pdfform.PixelHeight < pdfform.PixelWidth Then
                '    page.Orientation = PageOrientation.Landscape


                '   page.Height = (841 / pdfform.PixelWidth) * pdfform.PixelHeight
                'page.Width = 841
                '  Else
                ' page.Orientation = PageOrientation.Portrait
                page.Height = (595 / pdfform.PixelWidth) * pdfform.PixelHeight
                page.Width = 595
                '          End If
                '    page.Width = xImg.PixelWidth
                '   page.Height = xImg.PixelHeight

                'Draw current image file to page.
                GR = PdfSharp.Drawing.XGraphics.FromPdfPage(page)
                GR.DrawImage(pdfform, 0, 0, page.Width, page.Height)
            Next
        End Using
    End Sub
    Public Sub PDF_PDF(ByVal duongdan As String, ByRef pdf As PdfSharp.Pdf.PdfDocument, ByVal i As Integer, ByRef LOI As Integer)
        On Error GoTo err
        Using InputDocument As PdfSharp.Pdf.PdfDocument = PdfSharp.Pdf.IO.PdfReader.Open(duongdan, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import)
            For Each page As PdfSharp.Pdf.PdfPage In InputDocument.Pages
                pdf.AddPage(page)
            Next
        End Using
        Exit Sub
err:    Form1.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
        LOI += 1
    End Sub

    Public Sub WORD_PDF(ByVal duongdan As String, ByRef pdf As PdfSharp.Pdf.PdfDocument, ByVal i As Integer, ByRef LOI As Integer)
        On Error GoTo err
        Dim morong As String = System.IO.Path.GetDirectoryName(duongdan)
        Dim appWord As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()
        Dim wordDocument As Microsoft.Office.Interop.Word.Document = appWord.Documents.Open(duongdan, [ReadOnly]:=True)
        appWord.DisplayAlerts = False
        wordDocument.ExportAsFixedFormat(morong & "\temp.pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF)
        '   appWord.ActiveDocument.Save()
        appWord.ActiveDocument.Close()
        appWord.Quit()

        Using InputDocument As PdfSharp.Pdf.PdfDocument = PdfSharp.Pdf.IO.PdfReader.Open(morong & "\temp.pdf", PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import)
            For Each page As PdfSharp.Pdf.PdfPage In InputDocument.Pages
                pdf.AddPage(page)
            Next
            System.IO.File.Delete(morong & "\temp.pdf")
        End Using
        Exit Sub
err:    Form1.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
        LOI += 1
    End Sub
    Public Sub EXCEL_PDF(ByVal duongdan As String, ByRef pdf As PdfSharp.Pdf.PdfDocument, ByVal i As Integer, ByRef LOI As Integer)
        On Error GoTo err
        Dim morong As String = System.IO.Path.GetDirectoryName(duongdan)
        Dim appExcel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        Dim excelDocument As Microsoft.Office.Interop.Excel.Workbook = appExcel.Workbooks.Open(duongdan, [ReadOnly]:=True)
        appExcel.DisplayAlerts = False
        excelDocument.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, morong & "\temp.pdf")
        excelDocument.Close()
        appExcel.Quit()

        Using InputDocument As PdfSharp.Pdf.PdfDocument = PdfSharp.Pdf.IO.PdfReader.Open(morong & "\temp.pdf", PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import)
            For Each page As PdfSharp.Pdf.PdfPage In InputDocument.Pages
                pdf.AddPage(page)
            Next
            System.IO.File.Delete(morong & "\temp.pdf")
        End Using
        Exit Sub
err:    Form1.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
        LOI += 1
    End Sub
    Public Sub PP_PDF(ByVal duongdan As String, ByRef pdf As PdfSharp.Pdf.PdfDocument, ByVal i As Integer, ByRef LOI As Integer)
        On Error GoTo err
        Dim morong As String = System.IO.Path.GetDirectoryName(duongdan)
        Dim appPP As Microsoft.Office.Interop.PowerPoint.Application = New Microsoft.Office.Interop.PowerPoint.Application()
        Dim PPDocument As Microsoft.Office.Interop.PowerPoint.Presentation = appPP.Presentations.Open(duongdan, [ReadOnly]:=True)
        appPP.DisplayAlerts = False
        PPDocument.ExportAsFixedFormat(morong & "\temp.pdf", Microsoft.Office.Interop.PowerPoint.PpFixedFormatType.ppFixedFormatTypePDF)
        PPDocument.Close()
        appPP.Quit()

        Using InputDocument As PdfSharp.Pdf.PdfDocument = PdfSharp.Pdf.IO.PdfReader.Open(morong & "\temp.pdf", PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import)
            For Each page As PdfSharp.Pdf.PdfPage In InputDocument.Pages
                pdf.AddPage(page)
            Next
            System.IO.File.Delete(morong & "\temp.pdf")
        End Using
        Exit Sub
err:    Form1.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
        LOI += 1
    End Sub

End Module
