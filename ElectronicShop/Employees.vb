Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Employees
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim openFileDialog1 As New OpenFileDialog()


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub


    Private Sub UploadData_Click(sender As Object, e As EventArgs) Handles UploadData.Click
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            Dim fileStream As New StreamReader(filePath)
            Dim data As String = fileStream.ReadToEnd()
            fileStream.Close()
            Dim lines() As String = data.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            Dim dt As New DataTable()
            Dim header() As String = lines(0).Split(",")
            For Each h In header
                dt.Columns.Add(h)
            Next
            For i As Integer = 1 To lines.Length - 1
                Dim row() As String = lines(i).Split(",")
                dt.Rows.Add(row)
            Next
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub BackupData_Click(sender As Object, e As EventArgs) Handles BackupData.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sourceFilePath As String = openFileDialog1.FileName
            Dim destFilePath As String = saveFileDialog1.FileName
            File.Copy(sourceFilePath, destFilePath)
        End If
    End Sub

End Class