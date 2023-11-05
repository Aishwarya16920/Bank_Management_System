<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserMP
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.UserBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New Bank_Management_System.bankDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserTableAdapter1 = New Bank_Management_System.bankDataSetTableAdapters.userTableAdapter()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(162, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Transfer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bank Balance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Account Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource6, "Name", True))
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UserBindingSource6, "Name", True))
        Me.Label4.Location = New System.Drawing.Point(279, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "name"
        '
        'UserBindingSource6
        '
        Me.UserBindingSource6.DataMember = "user"
        Me.UserBindingSource6.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "bankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource6, "AccountNumber", True))
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UserBindingSource6, "AccountNumber", True))
        Me.Label6.Location = New System.Drawing.Point(279, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "account number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource6, "BankBalance", True))
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UserBindingSource6, "BankBalance", True))
        Me.Label7.Location = New System.Drawing.Point(279, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "bank balance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource6, "AccountType", True))
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UserBindingSource6, "AccountType", True))
        Me.Label8.Location = New System.Drawing.Point(279, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "account type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(179, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 27)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Your Account Details"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(283, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'UserTableAdapter1
        '
        Me.UserTableAdapter1.ClearBeforeFill = True
        '
        'UserMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(531, 359)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UserMP"
        Me.Text = "User"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserBindingSource1 As BindingSource
    Friend WithEvents UserBindingSource2 As BindingSource
    Friend WithEvents UserBindingSource3 As BindingSource
    Friend WithEvents UserBindingSource4 As BindingSource
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents UserBindingSource5 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BankDataSet As bankDataSet
    Friend WithEvents UserBindingSource6 As BindingSource
    Friend WithEvents UserTableAdapter1 As bankDataSetTableAdapters.userTableAdapter
End Class
