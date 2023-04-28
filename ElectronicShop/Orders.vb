Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Orders
    Private Sub returnHome_Click(sender As Object, e As EventArgs) Handles returnHome.Click

    End Sub

    Private Sub allOrders_Click(sender As Object, e As EventArgs) Handles allOrders.Click, Label5.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand
        Dim myreader As MySqlDataReader


        strSQL = "SELECT order_date FROM orders"

        mycmd.CommandText = strSQL
        mycmd.Connection = myconn
        myreader = mycmd.ExecuteReader()

        Dim dt As New DataTable
        dt.Load(myreader)


        strSQL = "SELECT products.prod_name " &
         "FROM products " &
         "INNER JOIN product_orders ON products.id = product_orders.prod_id " &
         "INNER JOIN orders ON orders.id = product_orders.order_id"


        mycmd.CommandText = strSQL
        mycmd.Connection = myconn
        myreader = mycmd.ExecuteReader()

        Dim dt1 As New DataTable
        dt1.Load(myreader)


        strSQL = "SELECT order_amount FROM orders"

        mycmd.CommandText = strSQL
        mycmd.Connection = myconn
        myreader = mycmd.ExecuteReader()

        Dim dt2 As New DataTable
        dt2.Load(myreader)


        strSQL = "SELECT clients.name " &
                 "FROM clients " &
                 "INNER JOIN orders ON orders.customer_id = clients.id"

        mycmd.CommandText = strSQL
        mycmd.Connection = myconn
        myreader = mycmd.ExecuteReader()

        Dim dt3 As New DataTable
        dt3.Load(myreader)


        DataGridView1.Columns.Add("Order Date", "Order Date")
        DataGridView1.Columns.Add("Order Prod", "Order Prod")
        DataGridView1.Columns.Add("Order Amount", "Order Amount")
        DataGridView1.Columns.Add("Customer Name", "Customer Name")


        For i As Integer = 0 To dt.Rows.Count - 1
            Dim row As DataRow = dt.Rows(i)

            Dim orderDate As String = row("order_date").ToString()
            Dim orderProd As String = dt1.Rows(i)("prod_name").ToString()
            Dim orderAmount As Decimal = Convert.ToDecimal(dt2.Rows(i)("order_amount"))
            Dim customerName As String = dt3.Rows(i)("name").ToString()

            DataGridView1.Rows.Add(orderDate, orderProd, orderAmount, customerName)
        Next


        DataGridView1.Columns("Order Date").Width = 130
        DataGridView1.Columns("Order Prod").Width = 260
        DataGridView1.Columns("Order Amount").Width = 190
        DataGridView1.Columns("Customer Name").Width = 280


    End Sub

    Private Sub printBTn_Click(sender As Object, e As EventArgs) Handles printBTn.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog1.FileName

            Export(DataGridView1, fileName)
        End If
    End Sub




End Class