




Public Class Form1
    Dim rowIndex As Integer
    Dim table As New System.Data.DataTable("table")
    Dim thongbao1, tieude1, thongbao2, tieude2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        thongbao1 = "Đã nối xong...Bạn có muốn đến nơi lưu nó không?"
        tieude1 = "Thông báo: "
        thongbao2 = "Chưa chọn tệp để nối hoặc tất cả tệp bị lỗi"
        tieude2 = " tệp bị lỗi không thể nối"
        With table
            table.Columns.Add("Tên tệp", Type.GetType("System.String"))
            table.Columns.Add("Đường dẫn", Type.GetType("System.String"))
        End With
        DataGridView1.DataSource = table
        DataGridView1.Columns(0).Width = 250
        DataGridView1.Columns(1).Width = 515
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange
        txtLuu.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        CheckBox1.Checked = False
    End Sub


    Private Sub BT_Thoat_Click(sender As Object, e As EventArgs) Handles BT_Thoat.Click
        Me.Close()
    End Sub

    Private Sub BT_Them_Click(sender As Object, e As EventArgs) Handles BT_Them.Click
        Dim filename As String
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        OpenFileDialog1.Filter = "All files (*.*)|*.*|Pdf file (*.pdf)|*.pdf|Word file (*.docx; *.doc)|*.doc;*.docx|Excel file (*.xls; *.xlsx)|*.xls;*.xlsx|PowerPoint file (*.ppt; *.pptx)|*.ppt;*.pptx|Img file (*.png;*.jpg;*.bmp;*.jpeg)|*.png;*.jpg;*.bmp;*.jpeg"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            For Each filename In OpenFileDialog1.FileNames
                With table.Rows
                    .Add(System.IO.Path.GetFileName(filename), filename)
                End With
            Next
            DataGridView1.DataSource = table
        End If
    End Sub

    Private Sub BT_Bo_Click(sender As Object, e As EventArgs) Handles BT_Bo.Click
        On Error Resume Next
        ' DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedCells(0).OwningRow.Index)
    End Sub

    Private Sub BT_Len_Click(sender As Object, e As EventArgs) Handles BT_Len.Click
        On Error GoTo exit1
        Dim scrollrowindex As Integer = DataGridView1.FirstDisplayedScrollingRowIndex
        ' get the index of selected row
        rowIndex = DataGridView1.SelectedCells(0).OwningRow.Index
        'create a new row
        Dim row As DataRow
        row = table.NewRow()
        ' add data to the row 
        row(0) = DataGridView1.Rows(rowIndex).Cells(0).Value
        row(1) = DataGridView1.Rows(rowIndex).Cells(1).Value
        If rowIndex > 0 Then
            ' remove the selected row
            table.Rows.RemoveAt(rowIndex)
            ' insert the new row at a new position
            table.Rows.InsertAt(row, rowIndex - 1)
            DataGridView1.ClearSelection()
            DataGridView1.Rows(rowIndex - 1).Selected = True
            DataGridView1.FirstDisplayedScrollingRowIndex = ((rowIndex - 1) \ 12) * 12   'di chuyen thanh scroll
        End If
exit1:
    End Sub

    Private Sub BT_Xuong_Click(sender As Object, e As EventArgs) Handles BT_Xuong.Click
        On Error GoTo exitt
        Dim scrollrowindex As Integer = DataGridView1.FirstDisplayedScrollingRowIndex
        ' get the index of selected row
        rowIndex = DataGridView1.SelectedCells(0).OwningRow.Index
        'create a new row
        Dim row As DataRow
        row = table.NewRow()
        ' add data to the row 
        row(0) = DataGridView1.Rows(rowIndex).Cells(0).Value
        row(1) = DataGridView1.Rows(rowIndex).Cells(1).Value
        If rowIndex < DataGridView1.Rows.Count - 2 Then
            ' remove the selected row
            table.Rows.RemoveAt(rowIndex)
            ' insert the new row at a new position
            table.Rows.InsertAt(row, rowIndex + 1)
            DataGridView1.ClearSelection()
            DataGridView1.Rows(rowIndex + 1).Selected = True
            DataGridView1.FirstDisplayedScrollingRowIndex = ((rowIndex + 1) \ 12) * 12     'di chuyen thanh scroll
        End If
exitt:
    End Sub

    Private Sub BT_Gop_Click(sender As Object, e As EventArgs) Handles BT_Gop.Click
        On Error GoTo err3
        Dim i, LOI As Integer
        Dim duongdan, morong As String
        Dim pdf As New PdfSharp.Pdf.PdfDocument
        Dim pdfFIX As New PdfSharp.Pdf.PdfDocument
        Dim TIME As String = Replace(Now.ToLongTimeString, ":", "_")
        ProgressBar1.Value = 0
        If DataGridView1.Rows(0).Cells(0).Value = "" Then GoTo err3
        For i = 0 To DataGridView1.RowCount - 2

            duongdan = DataGridView1(1, i).Value.ToString
            morong = System.IO.Path.GetExtension(duongdan).ToLower
            '       If morong = ".pdf" Then
            'PDF_PDF(duongdan, pdf)
            '      ElseIf morong = ".png" Or morong = ".jpg" Then
            '     IMG_PDF(duongdan, pdf)
            '      ElseIf morong = ".doc" Or morong = ".docx" Then
            '      WORD_PDF(duongdan, pdf)
            '      ElseIf morong = ".xls" Or morong = ".xlsx" Then
            '     EXCEL_PDF(duongdan, pdf)
            '     Else
            '    PP_PDF(duongdan, pdf)
            '    End If

            Select Case morong
                Case ".bmp", ".jpg", ".jpeg", ".png"
                    IMG_PDF(duongdan, pdf, i, LOI)
                Case ".xls", ".xlsx"
                    EXCEL_PDF(duongdan, pdf, i, LOI)
                Case ".pdf"
                    PDF_PDF(duongdan, pdf, i, LOI)
                Case ".doc", ".docx"
                    WORD_PDF(duongdan, pdf, i, LOI)
                Case ".ppt", ".pptx"
                    PP_PDF(duongdan, pdf, i, LOI)
                Case Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    LOI += 1
            End Select

            ProgressBar1.Value = (i + 1) / (DataGridView1.RowCount - 1) * 100
        Next
        If CheckBox1.Checked = True Then
            pdf.Save(txtLuu.Text & "\temp.pdf")
            pdf.Close()
            FIX_PDF(txtLuu.Text & "\temp.pdf", pdfFIX)
            pdfFIX.Save(txtLuu.Text & "\ALL_" & TIME & ".pdf")
            System.IO.File.Delete(txtLuu.Text & "\temp.pdf")
            pdfFIX.Close()
        Else
            pdf.Save(txtLuu.Text & "\ALL_" & TIME & ".pdf")
            pdf.Close()
        End If
        If LOI = 0 Then
            If MsgBox(thongbao1, MsgBoxStyle.OkCancel, tieude1) = MsgBoxResult.Ok Then Process.Start("explorer.exe", txtLuu.Text)
        Else
            If MsgBox(thongbao1, MsgBoxStyle.OkCancel, tieude1 & LOI & tieude2) = MsgBoxResult.Ok Then Process.Start("explorer.exe", txtLuu.Text)
        End If
        Exit Sub
        'err2:
        ' DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
err3:   MsgBox(thongbao2, MsgBoxStyle.Information, tieude1)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_Luu.Click
        If dlgFolderSelect.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtLuu.Text = dlgFolderSelect.SelectedPath
        End If
    End Sub

    Private Sub lbanh_Click(sender As Object, e As EventArgs) Handles lbanh.Click
        On Error Resume Next
        lbanh.ForeColor = Color.Blue
        lbvn.ForeColor = Color.Black
        lbdanhsach.Text = "List of Word, Excel, PowerPoint, Image, Pdf files need to merge (same type or mixer) "
        BT_Them.Text = "Add..."
        BT_Bo.Text = "Remove"
        BT_Len.Text = "Move Up"
        BT_Xuong.Text = "Move Down"
        BT_Xoa.Text = "Clear list"
        BT_Gop.Text = "Merge"
        BT_Thoat.Text = "Exit"
        BT_Luu.Text = "Browse..."
        thongbao1 = "Successful...Do you want to open save directory?"
        tieude1 = "Information: "
        thongbao2 = "Null list or all files crashed."
        tieude2 = " crash file(s) can not merge."
        DataGridView1.Columns(0).HeaderText = "File Name"
        DataGridView1.Columns(1).HeaderText = "File Path"
        CheckBox1.Text = "Fix page size"
    End Sub

    Private Sub lbvn_Click(sender As Object, e As EventArgs) Handles lbvn.Click
        On Error Resume Next
        lbanh.ForeColor = Color.Black
        lbvn.ForeColor = Color.Blue
        lbdanhsach.Text = "Danh sách các tệp cần nối như Word, Excel, PowerPoint, Image, Pdf (riêng từng loại hoặc hỗn hợp)"
        BT_Them.Text = "Thêm..."
        BT_Bo.Text = "Bỏ bớt"
        BT_Len.Text = "Di chuyển lên"
        BT_Xuong.Text = "Di chuyển xuống"
        BT_Xoa.Text = "Xoá danh sách"
        BT_Gop.Text = "Gộp"
        BT_Thoat.Text = "Thoát"
        BT_Luu.Text = "Chọn đường dẫn để lưu"
        thongbao1 = "Đã nối xong...Bạn có muốn đến nơi lưu nó không?"
        tieude1 = "Thông báo: "
        thongbao2 = "Chưa chọn tệp để nối hoặc tất cả tệp bị lỗi."
        tieude2 = " tệp bị lỗi không thể nối"
        DataGridView1.Columns(0).HeaderText = "Tên tệp"
        DataGridView1.Columns(1).HeaderText = "Đường dẫn"
        CheckBox1.Text = "Sửa kích thước trang"
    End Sub

    Private Sub BT_Xoa_Click(sender As Object, e As EventArgs) Handles BT_Xoa.Click
        On Error Resume Next
        table.Clear()
        DataGridView1.DataSource = table
    End Sub
End Class
