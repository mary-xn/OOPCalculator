Imports System.Drawing.Drawing2D

Public Class Calculator

    Dim FirstNum As Decimal
    Dim SecondNum As Decimal
    Dim OperationNumber As Integer
    Dim OperationSign As String
    Dim OperatorSelector As Boolean = False

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderColor = Color.DarkGray
                btn.FlatAppearance.BorderSize = 1

            End If
        Next

        btnAllClear.FlatAppearance.MouseOverBackColor = Color.White
        btnClear.FlatAppearance.MouseOverBackColor = Color.White
        btnAdd.FlatAppearance.MouseOverBackColor = Color.White
        btnSubtract.FlatAppearance.MouseOverBackColor = Color.White
        btnMultiply.FlatAppearance.MouseOverBackColor = Color.White
        btnPercentage.FlatAppearance.MouseOverBackColor = Color.White
        btnDivide.FlatAppearance.MouseOverBackColor = Color.White
        Button17.FlatAppearance.MouseOverBackColor = Color.Red

        btn0.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn1.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn2.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn3.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn4.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn5.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn6.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn7.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn8.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn9.FlatAppearance.MouseOverBackColor = Color.Maroon
        btnPlusOrMinus.FlatAppearance.MouseOverBackColor = Color.Maroon
        btnDecimal.FlatAppearance.MouseOverBackColor = Color.Maroon



        Me.KeyPreview = True

        Dim eqBtn As Button = TryCast(Me.Controls.Find("Button17", True).FirstOrDefault(), Button)
        If eqBtn IsNot Nothing Then
            Me.AcceptButton = eqBtn

        End If


        txtbox1.ReadOnly = True
        txtbox2.ReadOnly = True
        txtbox1.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        HandleDigit("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        HandleDigit("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        HandleDigit("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        HandleDigit("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        HandleDigit("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        HandleDigit("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        HandleDigit("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        HandleDigit("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        HandleDigit("9")
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        HandleDigit("0")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If OperationNumber <> 0 Then
            PerformCalculation()
        End If
        FirstNum = CDec(txtbox1.Text)
        OperationSign = "+"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 1 '=+
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If OperationNumber <> 0 Then
            PerformCalculation()
        End If
        FirstNum = CDec(txtbox1.Text)
        OperationSign = "-"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 2 '=-
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If OperationNumber <> 0 Then
            PerformCalculation()
        End If
        FirstNum = CDec(txtbox1.Text)
        OperationSign = "×"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 3 '=*
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If OperationNumber <> 0 Then
            PerformCalculation()
        End If
        FirstNum = CDec(txtbox1.Text)
        OperationSign = "÷"
        txtbox2.Text = FirstNum & " " & OperationSign & " "
        txtbox1.Text = "0"
        OperatorSelector = True
        OperationNumber = 4 '=/
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PerformCalculation()
    End Sub

    Private Sub PerformCalculation()
        If Not Decimal.TryParse(txtbox1.Text, SecondNum) Then SecondNum = 0
        If OperationNumber <> 0 Then
            SecondNum = CDec(txtbox1.Text)

            Select Case OperationNumber
                Case 1
                    txtbox1.Text = (FirstNum + SecondNum).ToString()
                Case 2
                    txtbox1.Text = (FirstNum - SecondNum).ToString()
                Case 3
                    txtbox1.Text = (FirstNum * SecondNum).ToString()
                Case 4
                    If SecondNum = 0 Then
                        txtbox1.Text = "Error!"
                    Else
                        txtbox1.Text = (FirstNum / SecondNum).ToString()
                    End If
            End Select

            txtbox2.Text = FirstNum & " " & OperationSign & " " & SecondNum & " = "
            FirstNum = CDec(txtbox1.Text)  ' Store result for chaining
            OperatorSelector = False
            OperationNumber = 0
        End If
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnAllClear.Click
        txtbox1.Text = "0"
        txtbox2.Text = ""
    End Sub

    Private Sub txtbox2_TextChanged(sender As Object, e As EventArgs) Handles txtbox2.TextChanged

    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If Not (txtbox1.Text.Contains(".")) Then
            txtbox1.Text += "."
        End If
    End Sub

    Private Sub btnPlusOrMinus_Click(sender As Object, e As EventArgs) Handles btnPlusOrMinus.Click
        If Not txtbox1.Text = "" Then
            txtbox1.Text *= -1
        End If
    End Sub

    Private Sub btnPercentage_Click(sender As Object, e As EventArgs) Handles btnPercentage.Click
        If OperatorSelector = False Then
            FirstNum = CDec(txtbox1.Text)
            FirstNum = FirstNum / 100
            txtbox2.Text = FirstNum
            txtbox1.Text = FirstNum
        Else
            SecondNum = CDec(txtbox1.Text)
            SecondNum = (FirstNum * SecondNum) / 100
            txtbox1.Text = SecondNum
        End If

    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbox1.Text = ""
    End Sub

    Private Sub HandleDigit(digit As String)
        If txtbox1.Text = "0" OrElse txtbox1.Text = "" OrElse OperatorSelector Then
            txtbox1.Text = digit
            OperatorSelector = False
        Else
            txtbox1.Text &= digit
        End If
    End Sub

    Private Sub Calculator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Shift AndAlso e.KeyCode = Keys.D8 Then
            btnMultiply.PerformClick()
            e.SuppressKeyPress = True
            e.Handled = True
            Return
        End If

        Select Case e.KeyCode
            Case Keys.D0, Keys.NumPad0 : btn0.PerformClick()
            Case Keys.D1, Keys.NumPad1 : btn1.PerformClick()
            Case Keys.D2, Keys.NumPad2 : btn2.PerformClick()
            Case Keys.D3, Keys.NumPad3 : btn3.PerformClick()
            Case Keys.D4, Keys.NumPad4 : btn4.PerformClick()
            Case Keys.D5, Keys.NumPad5 : btn5.PerformClick()
            Case Keys.D6, Keys.NumPad6 : btn6.PerformClick()
            Case Keys.D7, Keys.NumPad7 : btn7.PerformClick()
            Case Keys.D8
                If Not e.Shift Then btn8.PerformClick()
            Case Keys.NumPad8
                btn8.PerformClick()
            Case Keys.D9, Keys.NumPad9 : btn9.PerformClick()

            Case Keys.Enter
                Button17.PerformClick()
                e.SuppressKeyPress = True
                e.Handled = True

            Case Keys.Add : btnAdd.PerformClick()
            Case Keys.Oemplus
                If e.Shift Then
                    btnAdd.PerformClick()
                Else
                    Button17.PerformClick()
                End If
            Case Keys.Subtract, Keys.OemMinus : btnSubtract.PerformClick()
            Case Keys.Multiply : btnMultiply.PerformClick()
            Case Keys.Divide, Keys.OemQuestion : btnDivide.PerformClick()
            Case Keys.Decimal : btnDecimal.PerformClick()
            Case Keys.Back
                If txtbox1.Text.Length > 1 Then
                    txtbox1.Text = txtbox1.Text.Substring(0, txtbox1.Text.Length - 1)
                Else
                    txtbox1.Text = "0"
                End If
        End Select

        e.SuppressKeyPress = True
        e.Handled = True
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        If (keyData And Keys.KeyCode) = Keys.Enter OrElse (keyData And Keys.KeyCode) = Keys.Return Then
            Try
                If Button17 IsNot Nothing AndAlso Button17.Enabled AndAlso Button17.Visible Then
                    Button17.PerformClick()
                    Return True
                End If
            Catch ex As Exception

            End Try
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function




End Class
