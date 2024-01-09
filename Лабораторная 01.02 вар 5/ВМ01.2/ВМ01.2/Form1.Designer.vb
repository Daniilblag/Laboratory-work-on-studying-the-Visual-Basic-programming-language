<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl1.Location = New System.Drawing.Point(91, 9)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(391, 27)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Метод Ньютона (метод касательных)"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(12, 113)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(167, 22)
        Me.Lbl3.TabIndex = 1
        Me.Lbl3.Text = "Исходные данные:"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl4.Location = New System.Drawing.Point(53, 145)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(197, 19)
        Me.Lbl4.TabIndex = 2
        Me.Lbl4.Text = "f(x) = 4*(x*2+1)*log(x)–1"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(108, 172)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(142, 22)
        Me.Txt1.TabIndex = 5
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(108, 200)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(142, 22)
        Me.Txt2.TabIndex = 6
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(108, 228)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(142, 22)
        Me.Txt3.TabIndex = 7
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl5.Location = New System.Drawing.Point(53, 173)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(30, 19)
        Me.Lbl5.TabIndex = 8
        Me.Lbl5.Text = "a ="
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl6.Location = New System.Drawing.Point(53, 201)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(31, 19)
        Me.Lbl6.TabIndex = 9
        Me.Lbl6.Text = "b ="
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl7.Location = New System.Drawing.Point(53, 229)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(31, 19)
        Me.Lbl7.TabIndex = 10
        Me.Lbl7.Text = "e ="
        '
        'Btn1
        '
        Me.Btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn1.Location = New System.Drawing.Point(431, 145)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(122, 52)
        Me.Btn1.TabIndex = 11
        Me.Btn1.Text = "Вычислить"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn2.Location = New System.Drawing.Point(431, 318)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(122, 52)
        Me.Btn2.TabIndex = 12
        Me.Btn2.Text = "Очистить поля"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn3.Location = New System.Drawing.Point(431, 398)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(122, 52)
        Me.Btn3.TabIndex = 13
        Me.Btn3.Text = "Выход"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl8.Location = New System.Drawing.Point(12, 266)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(96, 22)
        Me.Lbl8.TabIndex = 14
        Me.Lbl8.Text = "Результат:"
        '
        'Txt4
        '
        Me.Txt4.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Txt4.Location = New System.Drawing.Point(57, 296)
        Me.Txt4.Multiline = True
        Me.Txt4.Name = "Txt4"
        Me.Txt4.ReadOnly = True
        Me.Txt4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt4.Size = New System.Drawing.Size(310, 191)
        Me.Txt4.TabIndex = 16
        Me.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl2
        '
        Me.Lbl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(16, 50)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(579, 53)
        Me.Lbl2.TabIndex = 17
        Me.Lbl2.Text = "      Данный метод вычисляет приближённое значение функции f(x) на отрезке [a, b]" &
    " с задананой точностью e. (n - кол-во итерации)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 499)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Метод Ньютона"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Lbl5 As Label
    Friend WithEvents Lbl6 As Label
    Friend WithEvents Lbl7 As Label
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Lbl8 As Label
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Lbl2 As Label
End Class
