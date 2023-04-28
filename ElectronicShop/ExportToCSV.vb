Imports System.Text
Imports System.IO

Module ExportToCSV

    Public Sub Export(ByVal dgv As DataGridView, ByVal path As String)
        Dim csv As String = ""
        For Each column As DataGridViewColumn In dgv.Columns
            csv += column.HeaderText + ","
        Next
        csv = csv.TrimEnd(","c) + vbCr & vbLf
        For Each row As DataGridViewRow In dgv.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing Then
                    csv += cell.Value.ToString().Replace(",", ";") + ","
                End If
            Next
            csv = csv.TrimEnd(","c) + vbCr & vbLf
        Next
        File.WriteAllText(path, csv, Encoding.UTF8)
        MsgBox("Data exported successfully.")
    End Sub

End Module
