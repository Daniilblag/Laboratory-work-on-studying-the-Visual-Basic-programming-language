<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl7.Location = New System.Drawing.Point(157, 182)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(249, 20)
        Me.Lbl7.TabIndex = 38
        Me.Lbl7.Text = "Количество каждой работы:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 57)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Виды работ:"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Location = New System.Drawing.Point(163, 23)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(263, 20)
        Me.Lbl5.TabIndex = 0
        Me.Lbl5.Text = "1        2        3        4        5        6"
        '
        'Lbl4
        '
        Me.Lbl4.ForeColor = System.Drawing.Color.Crimson
        Me.Lbl4.Location = New System.Drawing.Point(237, 60)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(159, 59)
        Me.Lbl4.TabIndex = 36
        Me.Lbl4.Text = "4)Штукатурные(7000р) 5)Молярные(5500р) 6)Плиточные(10000р)"
        '
        'Lbl3
        '
        Me.Lbl3.ForeColor = System.Drawing.Color.Crimson
        Me.Lbl3.Location = New System.Drawing.Point(38, 60)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(176, 59)
        Me.Lbl3.TabIndex = 35
        Me.Lbl3.Text = "1)Демонтажные(6000р) 2)Строительные(11000р) 3)Столярные(5000р)"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl2.ForeColor = System.Drawing.Color.Crimson
        Me.Lbl2.Location = New System.Drawing.Point(17, 38)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(410, 20)
        Me.Lbl2.TabIndex = 34
        Me.Lbl2.Text = "Виды работы (в списке указываются номером):"
        '
        'Txt2
        '
        Me.Txt2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txt2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Txt2.Location = New System.Drawing.Point(155, 205)
        Me.Txt2.Multiline = True
        Me.Txt2.Name = "Txt2"
        Me.Txt2.ReadOnly = True
        Me.Txt2.Size = New System.Drawing.Size(326, 304)
        Me.Txt2.TabIndex = 33
        '
        'Txt1
        '
        Me.Txt1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txt1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Txt1.Location = New System.Drawing.Point(17, 205)
        Me.Txt1.Multiline = True
        Me.Txt1.Name = "Txt1"
        Me.Txt1.ReadOnly = True
        Me.Txt1.Size = New System.Drawing.Size(117, 304)
        Me.Txt1.TabIndex = 32
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl6.Location = New System.Drawing.Point(17, 182)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(103, 20)
        Me.Lbl6.TabIndex = 31
        Me.Lbl6.Text = "Заказчики:"
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl1.Location = New System.Drawing.Point(87, 9)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(595, 25)
        Me.Lbl1.TabIndex = 30
        Me.Lbl1.Text = "Списки заказчиков, вид работ, их количество и общая сумма. "
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl8.Location = New System.Drawing.Point(496, 182)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(127, 20)
        Me.Lbl8.TabIndex = 39
        Me.Lbl8.Text = "Общая сумма:"
        '
        'Txt3
        '
        Me.Txt3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txt3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Txt3.Location = New System.Drawing.Point(500, 205)
        Me.Txt3.Multiline = True
        Me.Txt3.Name = "Txt3"
        Me.Txt3.ReadOnly = True
        Me.Txt3.Size = New System.Drawing.Size(123, 304)
        Me.Txt3.TabIndex = 40
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(641, 60)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(139, 56)
        Me.Btn1.TabIndex = 41
        Me.Btn1.Text = "Выполнить"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(641, 391)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(139, 56)
        Me.Btn2.TabIndex = 42
        Me.Btn2.Text = "Повторить"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(641, 453)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(139, 56)
        Me.Btn3.TabIndex = 43
        Me.Btn3.Text = "Выход"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(641, 128)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(139, 56)
        Me.Btn4.TabIndex = 44
        Me.Btn4.Text = "Вернуться"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 521)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl1)
        Me.Name = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lbl5 As Label
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Lbl6 As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl8 As Label
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn4 As Button
End Class
