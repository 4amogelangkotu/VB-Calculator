Public Class Calculator
    Dim currentValue As Double = 0
    Dim newValue As Double = 0
    Dim operatorSelected As String = ""

    Private Sub btnDigit_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim button As Button = CType(sender, Button)
        txtDisplay.Text &= button.Text
    End Sub

    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSub.Click, btnMul.Click, btnDiv.Click
        Dim button As Button = CType(sender, Button)
        currentValue = Double.Parse(txtDisplay.Text)
        operatorSelected = button.Text
        txtDisplay.Clear()
    End Sub

    Private Sub btnEql_Click(sender As Object, e As EventArgs) Handles btnEql.Click
        newValue = Double.Parse(txtDisplay.Text)

        Select Case operatorSelected
            Case "+"
                txtDisplay.Text = (currentValue + newValue).ToString
            Case "-"
                txtDisplay.Text = (currentValue - newValue).ToString
            Case "*"
                txtDisplay.Text = (currentValue * newValue).ToString
            Case "/"
                If newValue <> 0 Then
                    txtDisplay.Text = (currentValue / newValue).ToString
                Else
                    MessageBox.Show("Cannot divide by zero!")
                    txtDisplay.Clear()
                End If
        End Select

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtDisplay.Clear()
        currentValue = 0
        newValue = 0
        operatorSelected = ""
    End Sub

End Class
