<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New Bank_Management_System.bankDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BankDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSetBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter1 = New Bank_Management_System.bankDataSetTableAdapters.userTableAdapter()
        Me.UserBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSetBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 241)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 295)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 346)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Balance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 390)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Account Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 266)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "Name", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(220, 239)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 30)
        Me.TextBox1.TabIndex = 6
        '
        'UserBindingSource1
        '
        Me.UserBindingSource1.DataMember = "user"
        Me.UserBindingSource1.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "bankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "AccountType", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox4.Location = New System.Drawing.Point(220, 386)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(205, 30)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "BankBalance", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox3.Location = New System.Drawing.Point(220, 342)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(205, 30)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "AccountNumber", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(220, 292)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(205, 30)
        Me.TextBox2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(515, 231)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.AccountNumberDataGridViewTextBoxColumn, Me.BankBalanceDataGridViewTextBoxColumn, Me.AccountTypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(53, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(591, 193)
        Me.DataGridView1.TabIndex = 11
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'AccountNumberDataGridViewTextBoxColumn
        '
        Me.AccountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber"
        Me.AccountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber"
        Me.AccountNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AccountNumberDataGridViewTextBoxColumn.Name = "AccountNumberDataGridViewTextBoxColumn"
        Me.AccountNumberDataGridViewTextBoxColumn.Width = 125
        '
        'BankBalanceDataGridViewTextBoxColumn
        '
        Me.BankBalanceDataGridViewTextBoxColumn.DataPropertyName = "BankBalance"
        Me.BankBalanceDataGridViewTextBoxColumn.HeaderText = "BankBalance"
        Me.BankBalanceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BankBalanceDataGridViewTextBoxColumn.Name = "BankBalanceDataGridViewTextBoxColumn"
        Me.BankBalanceDataGridViewTextBoxColumn.Width = 125
        '
        'AccountTypeDataGridViewTextBoxColumn
        '
        Me.AccountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType"
        Me.AccountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType"
        Me.AccountTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AccountTypeDataGridViewTextBoxColumn.Name = "AccountTypeDataGridViewTextBoxColumn"
        Me.AccountTypeDataGridViewTextBoxColumn.Width = 125
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(515, 286)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 34)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(515, 335)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 39)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(515, 388)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 39)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BankDataSetBindingSource3
        '
        Me.BankDataSetBindingSource3.DataSource = Me.BankDataSet
        Me.BankDataSetBindingSource3.Position = 0
        '
        'UserTableAdapter1
        '
        Me.UserTableAdapter1.ClearBeforeFill = True
        '
        'UserBindingSource2
        '
        Me.UserBindingSource2.DataMember = "user"
        Me.UserBindingSource2.DataSource = Me.BankDataSetBindingSource3
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(708, 442)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add"
        Me.Text = "User Details"
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSetBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BankDataSetBindingSource As BindingSource
    Friend WithEvents BankDataSetBindingSource1 As BindingSource
    Friend WithEvents BankDataSetBindingSource2 As BindingSource
    Friend WithEvents BankDataSetBindingSource3 As BindingSource
    Friend WithEvents BankDataSet As bankDataSet
    Friend WithEvents UserBindingSource1 As BindingSource
    Friend WithEvents UserTableAdapter1 As bankDataSetTableAdapters.userTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BankBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserBindingSource2 As BindingSource
End Class
