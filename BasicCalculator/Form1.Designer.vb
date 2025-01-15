<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEql = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtDisplay.Location = New System.Drawing.Point(28, 26)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(318, 44)
        Me.txtDisplay.TabIndex = 0
        '
        'btnMul
        '
        Me.btnMul.Location = New System.Drawing.Point(271, 142)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(75, 60)
        Me.btnMul.TabIndex = 1
        Me.btnMul.Text = "*"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(190, 142)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 60)
        Me.btn9.TabIndex = 2
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(28, 142)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 60)
        Me.btn7.TabIndex = 4
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(109, 142)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 60)
        Me.btn8.TabIndex = 3
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(28, 208)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 60)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(109, 208)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 60)
        Me.btn5.TabIndex = 7
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(190, 208)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 60)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(272, 208)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(75, 60)
        Me.btnSub.TabIndex = 5
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(28, 274)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 60)
        Me.btn1.TabIndex = 12
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(109, 274)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 60)
        Me.btn2.TabIndex = 11
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(190, 274)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 60)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(271, 274)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 60)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEql
        '
        Me.btnEql.Location = New System.Drawing.Point(271, 340)
        Me.btnEql.Name = "btnEql"
        Me.btnEql.Size = New System.Drawing.Size(75, 60)
        Me.btnEql.TabIndex = 14
        Me.btnEql.Text = "="
        Me.btnEql.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(28, 340)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(237, 60)
        Me.btn0.TabIndex = 13
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(28, 76)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(237, 60)
        Me.btnClr.TabIndex = 18
        Me.btnClr.Text = "C"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(271, 76)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 60)
        Me.btnDiv.TabIndex = 17
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 428)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnEql)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btn6)
        Me.Name = "Calculator"
        Me.Text = "Basic Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnMul As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnEql As Button
End Class
