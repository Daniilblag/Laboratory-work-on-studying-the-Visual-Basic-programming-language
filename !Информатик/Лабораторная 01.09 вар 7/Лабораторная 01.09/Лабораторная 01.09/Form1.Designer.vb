<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm1
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
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl1.Location = New System.Drawing.Point(123, 9)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(290, 25)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Обработка строковых данных"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Lbl2.Location = New System.Drawing.Point(12, 52)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(88, 20)
        Me.Lbl2.TabIndex = 1
        Me.Lbl2.Text = "Задание:"
        '
        'Lbl3
        '
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Lbl3.Location = New System.Drawing.Point(106, 52)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(439, 58)
        Me.Lbl3.TabIndex = 2
        Me.Lbl3.Text = "Определите, можно ли из символов заданной строки составить вашу фамилию."
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl4.Location = New System.Drawing.Point(13, 120)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(121, 18)
        Me.Lbl4.TabIndex = 3
        Me.Lbl4.Text = "Задайте строку:"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(190, 119)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(312, 22)
        Me.Txt1.TabIndex = 4
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(46, 194)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(115, 46)
        Me.Btn1.TabIndex = 5
        Me.Btn1.Text = "Определить"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(370, 194)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(115, 46)
        Me.Btn3.TabIndex = 6
        Me.Btn3.Text = "Выход"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl5.Location = New System.Drawing.Point(13, 156)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(142, 18)
        Me.Lbl5.TabIndex = 7
        Me.Lbl5.Text = "Введите фамилию:"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(209, 194)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(115, 46)
        Me.Btn2.TabIndex = 8
        Me.Btn2.Text = "Очистить строки"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(190, 155)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(312, 22)
        Me.Txt2.TabIndex = 9
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(99, 260)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.ReadOnly = True
        Me.Txt3.Size = New System.Drawing.Size(403, 22)
        Me.Txt3.TabIndex = 10
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Location = New System.Drawing.Point(13, 263)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(80, 17)
        Me.Lbl6.TabIndex = 11
        Me.Lbl6.Text = "Результат:"
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 300)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm1"
        Me.Text = "Лабораторная 01.09"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Lbl5 As Label
    Friend WithEvents Btn2 As Button
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Lbl6 As Label
End Class
