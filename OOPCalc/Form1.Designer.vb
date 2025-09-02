<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btnAdd = New Button()
        btnSubtract = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btnMultiply = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btnDivide = New Button()
        btnAllClear = New Button()
        btnDecimal = New Button()
        btn0 = New Button()
        Button17 = New Button()
        txtbox1 = New TextBox()
        txtbox2 = New TextBox()
        btnPlusOrMinus = New Button()
        btnPercentage = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn1.Location = New Point(12, 364)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 65)
        btn1.TabIndex = 0
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn2.Location = New Point(93, 364)
        btn2.Name = "btn2"
        btn2.Size = New Size(75, 65)
        btn2.TabIndex = 1
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn3.Location = New Point(171, 364)
        btn3.Name = "btn3"
        btn3.Size = New Size(75, 65)
        btn3.TabIndex = 2
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btnAdd.Location = New Point(252, 364)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 65)
        btnAdd.TabIndex = 3
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btnSubtract.Location = New Point(255, 293)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(75, 65)
        btnSubtract.TabIndex = 7
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn6.Location = New Point(171, 293)
        btn6.Name = "btn6"
        btn6.Size = New Size(75, 65)
        btn6.TabIndex = 6
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn5.Location = New Point(90, 293)
        btn5.Name = "btn5"
        btn5.Size = New Size(75, 65)
        btn5.TabIndex = 5
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn4.Location = New Point(12, 293)
        btn4.Name = "btn4"
        btn4.Size = New Size(75, 65)
        btn4.TabIndex = 4
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btnMultiply.Location = New Point(252, 222)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(75, 65)
        btnMultiply.TabIndex = 11
        btnMultiply.Text = "×"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn9.Location = New Point(171, 222)
        btn9.Name = "btn9"
        btn9.Size = New Size(75, 65)
        btn9.TabIndex = 10
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn8.Location = New Point(90, 222)
        btn8.Name = "btn8"
        btn8.Size = New Size(75, 65)
        btn8.TabIndex = 9
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn7.Location = New Point(12, 222)
        btn7.Name = "btn7"
        btn7.Size = New Size(75, 65)
        btn7.TabIndex = 8
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDivide.Location = New Point(252, 151)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(75, 65)
        btnDivide.TabIndex = 15
        btnDivide.Text = "÷"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnAllClear
        ' 
        btnAllClear.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAllClear.Location = New Point(90, 151)
        btnAllClear.Name = "btnAllClear"
        btnAllClear.Size = New Size(75, 65)
        btnAllClear.TabIndex = 14
        btnAllClear.Text = "C"
        btnAllClear.UseVisualStyleBackColor = True
        ' 
        ' btnDecimal
        ' 
        btnDecimal.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btnDecimal.Location = New Point(90, 435)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(75, 65)
        btnDecimal.TabIndex = 13
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btn0.Location = New Point(12, 435)
        btn0.Name = "btn0"
        btn0.Size = New Size(75, 65)
        btn0.TabIndex = 12
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        Button17.Location = New Point(255, 435)
        Button17.Name = "Button17"
        Button17.Size = New Size(72, 65)
        Button17.TabIndex = 19
        Button17.Text = "="
        Button17.UseVisualStyleBackColor = True
        ' 
        ' txtbox1
        ' 
        txtbox1.BorderStyle = BorderStyle.None
        txtbox1.Font = New Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtbox1.HideSelection = False
        txtbox1.Location = New Point(9, 60)
        txtbox1.Multiline = True
        txtbox1.Name = "txtbox1"
        txtbox1.Size = New Size(318, 59)
        txtbox1.TabIndex = 20
        txtbox1.Text = "0"
        txtbox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtbox2
        ' 
        txtbox2.BorderStyle = BorderStyle.None
        txtbox2.Font = New Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbox2.Location = New Point(9, 30)
        txtbox2.Multiline = True
        txtbox2.Name = "txtbox2"
        txtbox2.Size = New Size(318, 33)
        txtbox2.TabIndex = 21
        txtbox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnPlusOrMinus
        ' 
        btnPlusOrMinus.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold)
        btnPlusOrMinus.Location = New Point(174, 435)
        btnPlusOrMinus.Name = "btnPlusOrMinus"
        btnPlusOrMinus.Size = New Size(75, 65)
        btnPlusOrMinus.TabIndex = 22
        btnPlusOrMinus.Text = "+/-"
        btnPlusOrMinus.UseVisualStyleBackColor = True
        ' 
        ' btnPercentage
        ' 
        btnPercentage.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPercentage.Location = New Point(171, 151)
        btnPercentage.Name = "btnPercentage"
        btnPercentage.Size = New Size(75, 65)
        btnPercentage.TabIndex = 23
        btnPercentage.Text = "%"
        btnPercentage.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(12, 151)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 65)
        btnClear.TabIndex = 24
        btnClear.Text = "CE"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(339, 537)
        Controls.Add(btnClear)
        Controls.Add(btnPercentage)
        Controls.Add(btnPlusOrMinus)
        Controls.Add(txtbox2)
        Controls.Add(txtbox1)
        Controls.Add(Button17)
        Controls.Add(btnDivide)
        Controls.Add(btnAllClear)
        Controls.Add(btnDecimal)
        Controls.Add(btn0)
        Controls.Add(btnMultiply)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnSubtract)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnAdd)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Name = "Calculator"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnAllClear As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents btnPlusOrMinus As Button
    Friend WithEvents btnPercentage As Button
    Friend WithEvents btnClear As Button

End Class
