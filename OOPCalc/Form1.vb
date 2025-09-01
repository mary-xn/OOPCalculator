Public Class Form1

    Dim FirstNum As Decimal
    Dim SecondNum As Decimal
    Dim OperationNumber As Integer
    Dim OperationSign As String
    Dim OperatorSelector As Boolean = False

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "1"
        Else
            txtbox1.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "2"
        Else
            txtbox1.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "3"
        Else
            txtbox1.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "4"
        Else
            txtbox1.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "5"
        Else
            txtbox1.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "6"
        Else
            txtbox1.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "7"
        Else
            txtbox1.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "8"
        Else
            txtbox1.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "9"
        Else
            txtbox1.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtbox1.Text <> "0" Then
            txtbox1.Text += "0"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FirstNum = txtbox1.Text
        OperationSign = "+"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 1 '=+
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        FirstNum = txtbox1.Text
        OperationSign = "-"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 2 '=-
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        FirstNum = txtbox1.Text
        OperationSign = "*"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 3 '=*
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        FirstNum = txtbox1.Text
        OperationSign = "/"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 4 '=/
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If OperatorSelector = True Then
            SecondNum = txtbox1.Text

            If OperationNumber = 1 Then
                txtbox1.Text = FirstNum + SecondNum
            ElseIf OperationNumber = 2 Then
                txtbox1.Text = FirstNum - SecondNum
            ElseIf OperationNumber = 3 Then
                txtbox1.Text = FirstNum * SecondNum
            Else
                If SecondNum = 0 Then
                    txtbox1.Text = "Error!"
                Else
                    txtbox1.Text = FirstNum / SecondNum
                End If
            End If
            txtbox2.Text = FirstNum & " " & OperationSign & " " & SecondNum & " = "
            OperatorSelector = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbox1.Text = "0"
        txtbox2.Text = ""
    End Sub

    Private Sub txtbox2_TextChanged(sender As Object, e As EventArgs) Handles txtbox2.TextChanged

    End Sub

End Class
