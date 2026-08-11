Imports System.Text
Public Class Calculator
    Dim num1 As Double
    Dim num2 As Double
    Dim cmd As String
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculatorPanel.BackColor = Color.FromArgb(240, calculatorPanel.BackColor.R, calculatorPanel.BackColor.G, calculatorPanel.BackColor.B)
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        textBox.Clear()
    End Sub

    Private Sub backspaceButton_Click(sender As Object, e As EventArgs) Handles backspaceButton.Click
        If textBox.Text.Length > 0 Then
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Try
            num1 = Double.Parse(textBox.Text)
            textBox.Clear()
            cmd = "+"
        Catch ex As FormatException
            MessageBox.Show("Invalid format. Please enter a number first.")
        End Try
    End Sub

    Private Sub subtractButton_Click(sender As Object, e As EventArgs) Handles subtractButton.Click
        Try
            num1 = Double.Parse(textBox.Text)
            textBox.Clear()
            cmd = "-"
        Catch ex As FormatException
            MessageBox.Show("Invalid format. Please enter a number first.")
        End Try
    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        Try
            num1 = Double.Parse(textBox.Text)
            textBox.Clear()
            cmd = "*"
        Catch ex As FormatException
            MessageBox.Show("Invalid format. Please enter a number first.")
        End Try
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        Try
            num1 = Double.Parse(textBox.Text)
            textBox.Clear()
            cmd = "/"
        Catch ex As FormatException
            MessageBox.Show("Invalid format. Please enter a number first.")
        End Try
    End Sub

    Private Sub moduloButton_Click(sender As Object, e As EventArgs) Handles moduloButton.Click
        Try
            num1 = Double.Parse(textBox.Text)
            textBox.Clear()
            cmd = "%"
        Catch ex As FormatException
            MessageBox.Show("Invalid format. Please enter a number first.")
        End Try
    End Sub

    Private Sub zeroButton_Click(sender As Object, e As EventArgs) Handles zeroButton.Click
        textBox.Text += zeroButton.Text
    End Sub

    Private Sub oneButton_Click(sender As Object, e As EventArgs) Handles oneButton.Click
        textBox.Text += oneButton.Text
    End Sub

    Private Sub twoButton_Click(sender As Object, e As EventArgs) Handles twoButton.Click
        textBox.Text += twoButton.Text
    End Sub

    Private Sub threeButton_Click(sender As Object, e As EventArgs) Handles threeButton.Click
        textBox.Text += threeButton.Text
    End Sub

    Private Sub fourButton_Click(sender As Object, e As EventArgs) Handles fourButton.Click
        textBox.Text += fourButton.Text
    End Sub

    Private Sub fiveButton_Click(sender As Object, e As EventArgs) Handles fiveButton.Click
        textBox.Text += fiveButton.Text
    End Sub

    Private Sub sixButton_Click(sender As Object, e As EventArgs) Handles sixButton.Click
        textBox.Text += sixButton.Text
    End Sub

    Private Sub sevenButton_Click(sender As Object, e As EventArgs) Handles sevenButton.Click
        textBox.Text += sevenButton.Text
    End Sub

    Private Sub eightButton_Click(sender As Object, e As EventArgs) Handles eightButton.Click
        textBox.Text += eightButton.Text
    End Sub

    Private Sub nineButton_Click(sender As Object, e As EventArgs) Handles nineButton.Click
        textBox.Text += nineButton.Text
    End Sub

    Private Sub dotButton_Click(sender As Object, e As EventArgs) Handles dotButton.Click
        If Not textBox.Text.Contains(".") Then
            textBox.Text += dotButton.Text
        End If
    End Sub

    Private Sub equalsButton_Click(sender As Object, e As EventArgs) Handles equalsButton.Click
        If Not String.IsNullOrEmpty(textBox.Text) Then
            num2 = Double.Parse(textBox.Text)
            Dim result As Double

            Select Case cmd
                Case "+"
                    result = num1 + num2
                Case "-"
                    result = num1 - num2
                Case "*"
                    result = num1 * num2
                Case "/"
                    If num2 <> 0 Then
                        result = num1 / num2
                    Else
                        MessageBox.Show("Cannot divide by zero.")
                        Exit Sub
                    End If
                Case "%"
                    result = num1 Mod num2
            End Select

            textBox.Text = result.ToString()
        End If
    End Sub

    Private Function AddMultiplication(expression As String) As String
        Dim result As New StringBuilder()
        For i As Integer = 0 To expression.Length - 1
            Dim currentChar As Char = expression(i)
            result.Append(currentChar)
            If currentChar = ")" AndAlso i < expression.Length - 1 AndAlso Char.IsDigit(expression(i + 1)) Then
                Dim j As Integer = i
                While j >= 0 AndAlso (Char.IsDigit(expression(j)) OrElse expression(j) = "."c)
                    j -= 1
                End While
                If j >= 0 AndAlso expression(j) = "-"c Then
                    Continue For
                End If
                result.Append("*")
            End If
        Next
        Return result.ToString()
    End Function

    Private Function EvaluateExpression(expression As String) As Double
        ' Evaluate the expression using DataTable.Compute method
        Dim dataTable As New DataTable()
        Dim result As Object = dataTable.Compute(expression, "")
        Return Convert.ToDouble(result)
    End Function

    Private Sub positiveNegativeConvertButton_Click(sender As Object, e As EventArgs) Handles positiveNegativeConvertButton.Click
        If Not String.IsNullOrEmpty(textBox.Text) Then
            Dim currentValue As Double = Double.Parse(textBox.Text)
            textBox.Text = (-currentValue).ToString()
        End If
    End Sub

End Class