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
        Me.components = New System.ComponentModel.Container()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ТабельныйНомерDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДолжностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГодРожденияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОкладDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФамилияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СОТРУДНИКИBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Сотрудники1DataSet1 = New Проект_05._06.Сотрудники1DataSet1()
        Me.СОТРУДНИКИTableAdapter = New Проект_05._06.Сотрудники1DataSet1TableAdapters.СОТРУДНИКИTableAdapter()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СОТРУДНИКИBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Сотрудники1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(645, 383)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(117, 43)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Выполнить"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(645, 438)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(117, 43)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "Выход"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ТабельныйНомерDataGridViewTextBoxColumn, Me.ДолжностьDataGridViewTextBoxColumn, Me.ГодРожденияDataGridViewTextBoxColumn, Me.ОкладDataGridViewTextBoxColumn, Me.ФамилияDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.СОТРУДНИКИBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(750, 327)
        Me.DataGridView1.TabIndex = 2
        '
        'ТабельныйНомерDataGridViewTextBoxColumn
        '
        Me.ТабельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер"
        Me.ТабельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер"
        Me.ТабельныйНомерDataGridViewTextBoxColumn.Name = "ТабельныйНомерDataGridViewTextBoxColumn"
        '
        'ДолжностьDataGridViewTextBoxColumn
        '
        Me.ДолжностьDataGridViewTextBoxColumn.DataPropertyName = "Должность"
        Me.ДолжностьDataGridViewTextBoxColumn.HeaderText = "Должность"
        Me.ДолжностьDataGridViewTextBoxColumn.Name = "ДолжностьDataGridViewTextBoxColumn"
        '
        'ГодРожденияDataGridViewTextBoxColumn
        '
        Me.ГодРожденияDataGridViewTextBoxColumn.DataPropertyName = "Год рождения"
        Me.ГодРожденияDataGridViewTextBoxColumn.HeaderText = "Год рождения"
        Me.ГодРожденияDataGridViewTextBoxColumn.Name = "ГодРожденияDataGridViewTextBoxColumn"
        '
        'ОкладDataGridViewTextBoxColumn
        '
        Me.ОкладDataGridViewTextBoxColumn.DataPropertyName = "Оклад"
        Me.ОкладDataGridViewTextBoxColumn.HeaderText = "Оклад"
        Me.ОкладDataGridViewTextBoxColumn.Name = "ОкладDataGridViewTextBoxColumn"
        '
        'ФамилияDataGridViewTextBoxColumn
        '
        Me.ФамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия"
        Me.ФамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия"
        Me.ФамилияDataGridViewTextBoxColumn.Name = "ФамилияDataGridViewTextBoxColumn"
        '
        'СОТРУДНИКИBindingSource
        '
        Me.СОТРУДНИКИBindingSource.DataMember = "СОТРУДНИКИ"
        Me.СОТРУДНИКИBindingSource.DataSource = Me.Сотрудники1DataSet1
        '
        'Сотрудники1DataSet1
        '
        Me.Сотрудники1DataSet1.DataSetName = "Сотрудники1DataSet1"
        Me.Сотрудники1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СОТРУДНИКИTableAdapter
        '
        Me.СОТРУДНИКИTableAdapter.ClearBeforeFill = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(253, 9)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(266, 29)
        Me.Lbl1.TabIndex = 3
        Me.Lbl1.Text = "Таблица сотрудников"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(12, 383)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(477, 20)
        Me.Lbl2.TabIndex = 4
        Me.Lbl2.Text = "Самые молодые сотрудники с максимальным окладом:"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(16, 407)
        Me.Txt1.Multiline = True
        Me.Txt1.Name = "Txt1"
        Me.Txt1.ReadOnly = True
        Me.Txt1.Size = New System.Drawing.Size(473, 74)
        Me.Txt1.TabIndex = 5
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 488)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Frm1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СОТРУДНИКИBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Сотрудники1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Сотрудники1DataSet1 As Сотрудники1DataSet1
    Friend WithEvents СОТРУДНИКИBindingSource As BindingSource
    Friend WithEvents СОТРУДНИКИTableAdapter As Сотрудники1DataSet1TableAdapters.СОТРУДНИКИTableAdapter
    Friend WithEvents ТабельныйНомерDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДолжностьDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГодРожденияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОкладDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ФамилияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Txt1 As TextBox
End Class
