Imports System.Drawing.Printing

Public Class Form1
    ' Declare the pizzaControl instance
    Private pizzaControl As UserContro_Selection

    Private grandTotal As Double = 0.0

    ' Printer-related objects
    Private printDocument As New PrintDocument()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Instantiate and configure pizzaControl
        pizzaControl = New UserContro_Selection()
        pizzaControl.Dock = DockStyle.Fill

        ' Add it to the main panel
        pnlMain.Controls.Add(pizzaControl)

        ' Attach the AddOrderClicked event handler
        AddHandler pizzaControl.AddOrderClicked, AddressOf AddOrderToGrid


        ' Initialize totals
        lblGrandTotal.Text = "₱0.00"
        lblCash.Text = "₱0.00"
        lblChange.Text = "₱0.00"

        ' Attach PrintPage event to handle the printing logic
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
    End Sub

    ' Handle flavor button click to set the label in the user control
    Private Sub btnFlavor_Click(sender As Object, e As EventArgs) Handles btnPepperoni.Click, btnHawaiian.Click, btnMozzarella.Click, btnBacon.Click, btnClassic.Click, btnVeggie.Click, btnItalian.Click
        Dim btn As Button = CType(sender, Button)

        ' Update the label in the user control to show the selected pizza flavor
        pizzaControl.SetPizzaFlavor(btn.Text.Trim())
    End Sub

    ' Add order to the DataGridView
    Private Sub AddOrderToGrid(quantity As Integer, flavor As String, size As String, toppings As List(Of String), pizzaPrice As Double, toppingsPrice As Double)
        Dim combinedTotal = pizzaPrice + toppingsPrice

        ' Add data to the DataGridView
        dgvOrders.Rows.Add(quantity, flavor, String.Join(", ", toppings), pizzaPrice.ToString("0.00"), toppingsPrice.ToString("0.00"), combinedTotal.ToString("0.00"))

        ' Update the grand total
        grandTotal += combinedTotal
        lblGrandTotal.Text = $"₱{grandTotal:0.00}"
    End Sub

    ' Handle payment input and calculate change
    Private Sub tbCash_TextChanged(sender As Object, e As EventArgs) Handles tbCash.TextChanged
        Dim cash As Double
        If Double.TryParse(tbCash.Text, cash) Then
            Dim change = cash - grandTotal
            lblCash.Text = $"₱{cash:0.00}"
            lblChange.Text = If(change >= 0, $"₱{change:0.00}", "Insufficient Cash")
        Else
            lblCash.Text = "Invalid Input"
            lblChange.Text = "N/A"
        End If
    End Sub

    ' Reset the system
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgvOrders.Rows.Clear()
        lblGrandTotal.Text = "₱0.00"
        lblCash.Text = "₱0.00"
        lblChange.Text = "₱0.00"
        tbCash.Clear()
        grandTotal = 0
        pizzaControl.ResetInputs()
    End Sub

    ' Delete selected order
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvOrders.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvOrders.Rows(dgvOrders.Rows.Count - 1)
            Dim rowTotal As Double = Double.Parse(lastRow.Cells("CombinedTotal").Value.ToString())

            ' Remove the last row and update grand total
            dgvOrders.Rows.Remove(lastRow)
            grandTotal -= rowTotal
            lblGrandTotal.Text = $"₱{grandTotal:0.00}"
        End If
    End Sub

    ' Print receipt (directly using PrintPreviewDialog)
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        Dim previewDialog As New PrintPreviewDialog() With {
            .Document = printDocument,
            .Width = 800,
            .Height = 600
        }
        previewDialog.ShowDialog()
    End Sub

    ' Format and print the receipt
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim font As New Font("Consolas", 10)
        Dim lineHeight As Single = font.GetHeight()
        Dim x As Single = 50
        Dim y As Single = 50

        ' Header
        graphics.DrawString("PIZZA POS RECEIPT", font, Brushes.Black, x, y)
        y += lineHeight * 2
        graphics.DrawString(New String("-"c, 40), font, Brushes.Black, x, y)
        y += lineHeight

        ' Order details from DataGridView
        For Each row As DataGridViewRow In dgvOrders.Rows
            Dim quantity As String = row.Cells("Quantity").Value.ToString()
            Dim flavor As String = row.Cells("PizzaFlavor").Value.ToString()
            Dim toppings As String = row.Cells("Toppings").Value.ToString()
            Dim pizzaPrice As String = row.Cells("PizzaPrice").Value.ToString()
            Dim toppingsPrice As String = row.Cells("ToppingsPrice").Value.ToString()
            Dim combinedTotal As String = row.Cells("CombinedTotal").Value.ToString()

            graphics.DrawString($"{quantity}x {flavor}", font, Brushes.Black, x, y)
            y += lineHeight
            graphics.DrawString($"  Toppings: {toppings}", font, Brushes.Black, x, y)
            y += lineHeight
            graphics.DrawString($"  Pizza Price: ₱{pizzaPrice}", font, Brushes.Black, x, y)
            y += lineHeight
            graphics.DrawString($"  Toppings Price: ₱{toppingsPrice}", font, Brushes.Black, x, y)
            y += lineHeight
            graphics.DrawString($"  Combined Total: ₱{combinedTotal}", font, Brushes.Black, x, y)
            y += lineHeight * 2
        Next

        ' Footer
        graphics.DrawString(New String("-"c, 40), font, Brushes.Black, x, y)
        y += lineHeight
        graphics.DrawString($"Grand Total: ₱{grandTotal:0.00}", font, Brushes.Black, x, y)
        y += lineHeight
        graphics.DrawString($"Cash: {lblCash.Text}", font, Brushes.Black, x, y)
        y += lineHeight
        graphics.DrawString($"Change: {lblChange.Text}", font, Brushes.Black, x, y)
    End Sub
End Class
