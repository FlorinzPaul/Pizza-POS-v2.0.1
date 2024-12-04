Imports System.Drawing.Printing

Public Class UserContro_Selection
    ' Event to notify when an order is added
    Public Event AddOrderClicked(quantity As Integer, flavor As String, size As String, toppings As List(Of String), pizzaPrice As Double, toppingsPrice As Double)

    ' Set the selected pizza flavor in the label
    Public Sub SetPizzaFlavor(flavor As String)
        lblPizzaSelect.Text = $"Selected Pizza: {flavor}"
    End Sub

    ' Add Order button click
    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        ' Gather data for the order
        Dim quantity As Integer = nudPizzaQuantity.Value
        Dim size As String = If(rbSolo.Checked, "Solo", If(rbReg.Checked, "Regular", "Family size"))
        Dim toppings As New List(Of String)

        ' Collect selected toppings
        For Each cb As CheckBox In pnlToppings.Controls.OfType(Of CheckBox)()
            If cb.Checked Then
                toppings.Add(cb.Text)
            End If
        Next

        ' Calculate prices
        Dim pizzaPrice As Double = GetPizzaPrice(size) * quantity
        Dim toppingsPrice As Double = toppings.Sum(Function(t) GetToppingPrice(t))
        toppingsPrice = toppingsPrice * quantity

        ' Trigger the event to notify the main form
        RaiseEvent AddOrderClicked(quantity, lblPizzaSelect.Text.Replace("Selected Pizza: ", ""), size, toppings, pizzaPrice, toppingsPrice)
        ResetInputs()
    End Sub

    ' Get pizza price based on size
    Private Function GetPizzaPrice(size As String) As Double
        Select Case size
            Case "Solo"
                Return 85
            Case "Regular"
                Return 150
            Case "Family size"
                Return 200
            Case Else
                Return 0
        End Select
    End Function

    ' Get topping price by name
    Private Function GetToppingPrice(topping As String) As Double
        Dim toppingPrices As New Dictionary(Of String, Double) From {
            {"Bacon", 50},
            {"Ham", 50},
            {"Garlic", 30},
            {"Onion", 30},
            {"Pineapple", 40},
            {"Mushroom", 40},
            {"Extra Cheese", 35}
        }
        Return If(toppingPrices.ContainsKey(topping), toppingPrices(topping), 0)
    End Function

    ' Reset inputs to default values
    Public Sub ResetInputs()
        nudPizzaQuantity.Value = 1
        rbSolo.Checked = True
        rbDineIn.Checked = True

        ' Uncheck all toppings
        For Each cb As CheckBox In pnlToppings.Controls.OfType(Of CheckBox)()
            cb.Checked = False
        Next
    End Sub
End Class