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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm1))
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl1.Location = New System.Drawing.Point(245, 9)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(332, 25)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Изучение двумерных массивов"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl2.Location = New System.Drawing.Point(12, 44)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(88, 20)
        Me.Lbl2.TabIndex = 1
        Me.Lbl2.Text = "Задание:"
        '
        'Lbl3
        '
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(103, 44)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(733, 67)
        Me.Lbl3.TabIndex = 2
        Me.Lbl3.Text = resources.GetString("Lbl3.Text")
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(16, 186)
        Me.Txt3.Multiline = True
        Me.Txt3.Name = "Txt3"
        Me.Txt3.ReadOnly = True
        Me.Txt3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt3.Size = New System.Drawing.Size(300, 186)
        Me.Txt3.TabIndex = 5
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(365, 186)
        Me.Txt4.Multiline = True
        Me.Txt4.Name = "Txt4"
        Me.Txt4.ReadOnly = True
        Me.Txt4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txt4.Size = New System.Drawing.Size(300, 186)
        Me.Txt4.TabIndex = 6
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl7.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl7.Location = New System.Drawing.Point(12, 163)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(108, 20)
        Me.Lbl7.TabIndex = 7
        Me.Lbl7.Text = "Массив K(,):"
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl8.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl8.Location = New System.Drawing.Point(361, 163)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(107, 20)
        Me.Lbl8.TabIndex = 8
        Me.Lbl8.Text = "Массив L(,):"
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(713, 186)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(114, 54)
        Me.Btn1.TabIndex = 9
        Me.Btn1.Text = "Выполнить"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(713, 318)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(114, 54)
        Me.Btn2.TabIndex = 11
        Me.Btn2.Text = "Выход"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Lbl4.Location = New System.Drawing.Point(12, 122)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(417, 20)
        Me.Lbl4.TabIndex = 12
        Me.Lbl4.Text = "Задайте кол-во строк(a) и столбцов(b) массива:"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl5.Location = New System.Drawing.Point(460, 122)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(28, 20)
        Me.Lbl5.TabIndex = 13
        Me.Lbl5.Text = "a="
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl6.Location = New System.Drawing.Point(586, 122)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(28, 20)
        Me.Lbl6.TabIndex = 14
        Me.Lbl6.Text = "b="
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(494, 122)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(57, 22)
        Me.Txt1.TabIndex = 15
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(620, 122)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(57, 22)
        Me.Txt2.TabIndex = 16
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 389)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm1"
        Me.Text = "Лабораторная 01.08"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Lbl7 As Label
    Friend WithEvents Lbl8 As Label
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Lbl5 As Label
    Friend WithEvents Lbl6 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
End Class
