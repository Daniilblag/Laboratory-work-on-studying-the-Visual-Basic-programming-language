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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(529, 115)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(151, 51)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Ввод строк из файла 1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl1.Location = New System.Drawing.Point(131, 9)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(483, 25)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "Обработка строковых данных и текстовые файлы"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl2.Location = New System.Drawing.Point(12, 52)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(88, 20)
        Me.Lbl2.TabIndex = 2
        Me.Lbl2.Text = "Задание:"
        '
        'Lbl3
        '
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(106, 52)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(657, 51)
        Me.Lbl3.TabIndex = 3
        Me.Lbl3.Text = "Записать в новый файл те строки исходного текстового файла, из символов которых м" &
    "ожно составить вашу фамилию."
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl4.Location = New System.Drawing.Point(12, 110)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(74, 20)
        Me.Lbl4.TabIndex = 4
        Me.Lbl4.Text = "Файл 1:"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(124, 110)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(376, 22)
        Me.Txt1.TabIndex = 5
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(124, 146)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(376, 22)
        Me.Txt2.TabIndex = 6
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl5.Location = New System.Drawing.Point(12, 146)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(74, 20)
        Me.Lbl5.TabIndex = 7
        Me.Lbl5.Text = "Файл 2:"
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl6.Location = New System.Drawing.Point(12, 182)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(92, 20)
        Me.Lbl6.TabIndex = 8
        Me.Lbl6.Text = "Фамилия:"
        '
        'Lbl7
        '
        Me.Lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl7.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl7.Location = New System.Drawing.Point(12, 253)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(97, 40)
        Me.Lbl7.TabIndex = 9
        Me.Lbl7.Text = "Исходный файл 1:"
        Me.Lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl8
        '
        Me.Lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl8.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl8.Location = New System.Drawing.Point(12, 379)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(99, 43)
        Me.Lbl8.TabIndex = 10
        Me.Lbl8.Text = "Результат файл 2:"
        Me.Lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(124, 182)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(376, 22)
        Me.Txt3.TabIndex = 11
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(124, 222)
        Me.Txt4.Multiline = True
        Me.Txt4.Name = "Txt4"
        Me.Txt4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt4.Size = New System.Drawing.Size(376, 107)
        Me.Txt4.TabIndex = 12
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(124, 347)
        Me.Txt5.Multiline = True
        Me.Txt5.Name = "Txt5"
        Me.Txt5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt5.Size = New System.Drawing.Size(376, 107)
        Me.Txt5.TabIndex = 13
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(529, 182)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(151, 53)
        Me.Btn2.TabIndex = 14
        Me.Btn2.Text = "Запись результата в файл 2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(529, 401)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(151, 53)
        Me.Btn3.TabIndex = 15
        Me.Btn3.Text = "Выход"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 481)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Frm1"
        Me.Text = "Лабораторная 01.10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Lbl5 As Label
    Friend WithEvents Lbl6 As Label
    Friend WithEvents Lbl7 As Label
    Friend WithEvents Lbl8 As Label
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
