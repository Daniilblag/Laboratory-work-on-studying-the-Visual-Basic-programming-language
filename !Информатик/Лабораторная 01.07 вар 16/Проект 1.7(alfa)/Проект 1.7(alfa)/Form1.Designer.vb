<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt4
        '
        Me.txt4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt4.Location = New System.Drawing.Point(166, 182)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(650, 22)
        Me.txt4.TabIndex = 42
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Location = New System.Drawing.Point(711, 123)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(24, 17)
        Me.lbl7.TabIndex = 41
        Me.lbl7.Text = "b="
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(550, 123)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(24, 17)
        Me.lbl6.TabIndex = 40
        Me.lbl6.Text = "a="
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(741, 120)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 22)
        Me.txt3.TabIndex = 39
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(580, 120)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 22)
        Me.txt2.TabIndex = 38
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl5.Location = New System.Drawing.Point(577, 100)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(214, 17)
        Me.lbl5.TabIndex = 37
        Me.lbl5.Text = "Интервал значении массива X:"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(219, 120)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 22)
        Me.txt1.TabIndex = 36
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl4.Location = New System.Drawing.Point(177, 100)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(202, 17)
        Me.lbl4.TabIndex = 35
        Me.lbl4.Text = "Кол-во элементов массива X:"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl12.Location = New System.Drawing.Point(52, 302)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(108, 17)
        Me.lbl12.TabIndex = 34
        Me.lbl12.Text = "Произведение:"
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(166, 299)
        Me.txt6.Name = "txt6"
        Me.txt6.ReadOnly = True
        Me.txt6.Size = New System.Drawing.Size(119, 22)
        Me.txt6.TabIndex = 33
        '
        'btn1
        '
        Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn1.Location = New System.Drawing.Point(824, 315)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(126, 41)
        Me.btn1.TabIndex = 32
        Me.btn1.Text = "Конец задания"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'cmb2
        '
        Me.cmb2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Items.AddRange(New Object() {"Произведение элементов массива, расположенных между максимальным и минимальным эл" &
                "ементами"})
        Me.cmb2.Location = New System.Drawing.Point(166, 243)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(784, 24)
        Me.cmb2.TabIndex = 31
        '
        'lbl10
        '
        Me.lbl10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl10.Location = New System.Drawing.Point(162, 216)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(248, 24)
        Me.lbl10.TabIndex = 30
        Me.lbl10.Text = "Преобразование массива:"
        '
        'lbl8
        '
        Me.lbl8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl8.Location = New System.Drawing.Point(162, 155)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(205, 24)
        Me.lbl8.TabIndex = 28
        Me.lbl8.Text = "Заполнение массива:"
        '
        'lbl11
        '
        Me.lbl11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl11.AutoSize = True
        Me.lbl11.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl11.Location = New System.Drawing.Point(15, 276)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(145, 17)
        Me.lbl11.TabIndex = 26
        Me.lbl11.Text = "Полученный массив:"
        '
        'lbl9
        '
        Me.lbl9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl9.AutoSize = True
        Me.lbl9.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl9.Location = New System.Drawing.Point(10, 185)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(150, 17)
        Me.lbl9.TabIndex = 25
        Me.lbl9.Text = "Исходный массив X():"
        '
        'lbl3
        '
        Me.lbl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl3.Location = New System.Drawing.Point(91, 54)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(892, 46)
        Me.lbl3.TabIndex = 24
        Me.lbl3.Text = resources.GetString("lbl3.Text")
        '
        'lbl2
        '
        Me.lbl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl2.AutoSize = True
        Me.lbl2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl2.Location = New System.Drawing.Point(16, 54)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(69, 17)
        Me.lbl2.TabIndex = 23
        Me.lbl2.Text = "Задание:"
        '
        'lbl1
        '
        Me.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl1.Location = New System.Drawing.Point(321, 14)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(319, 25)
        Me.lbl1.TabIndex = 22
        Me.lbl1.Text = "Изучение одномерных массивов"
        '
        'txt5
        '
        Me.txt5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt5.Location = New System.Drawing.Point(167, 271)
        Me.txt5.Name = "txt5"
        Me.txt5.ReadOnly = True
        Me.txt5.Size = New System.Drawing.Size(783, 22)
        Me.txt5.TabIndex = 43
        '
        'btn2
        '
        Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn2.Location = New System.Drawing.Point(822, 176)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(128, 40)
        Me.btn2.TabIndex = 44
        Me.btn2.Text = "Сгенерировать"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 368)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.cmb2)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "frm1"
        Me.Text = "Лабораторная 1.7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents txt6 As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents cmb2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents btn2 As System.Windows.Forms.Button

End Class
