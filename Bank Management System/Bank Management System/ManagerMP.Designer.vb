<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerMP
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
        Me.UserdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ManagerBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New Bank_Management_System.bankDataSet()
        Me.ManagerBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ManagerBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbmsDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagerBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ManagerTableAdapter1 = New Bank_Management_System.bankDataSetTableAdapters.managerTableAdapter()
        CType(Me.UserdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbmsDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manager Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource5, "ManagerName", True))
        Me.Label2.Location = New System.Drawing.Point(140, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "name"
        '
        'ManagerBindingSource5
        '
        Me.ManagerBindingSource5.DataMember = "manager"
        Me.ManagerBindingSource5.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "bankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Manager ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource5, "ManagerID", True))
        Me.Label4.Location = New System.Drawing.Point(140, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "id"
        '
        'UserBindingSource1
        '
        Me.UserBindingSource1.DataMember = "user"
        Me.UserBindingSource1.DataSource = Me.DbmsDataSet2BindingSource
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(155, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "User Details:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(279, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ManagerTableAdapter1
        '
        Me.ManagerTableAdapter1.ClearBeforeFill = True
        '
        'ManagerMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(535, 363)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ManagerMP"
        Me.Text = "Manager"
        CType(Me.UserdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbmsDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserdetailsBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents ManagerBindingSource As BindingSource
    Friend WithEvents DbmsDataSet2BindingSource As BindingSource
    Friend WithEvents ManagerBindingSource1 As BindingSource
    Friend WithEvents ManagerBindingSource2 As BindingSource
    Friend WithEvents ManagerBindingSource3 As BindingSource
    Friend WithEvents UserBindingSource1 As BindingSource
    Friend WithEvents ManagerBindingSource4 As BindingSource
    Friend WithEvents UserBindingSource2 As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BankDataSet As bankDataSet
    Friend WithEvents ManagerBindingSource5 As BindingSource
    Friend WithEvents ManagerTableAdapter1 As bankDataSetTableAdapters.managerTableAdapter
End Class
