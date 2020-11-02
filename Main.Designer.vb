<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxRName = New System.Windows.Forms.TextBox()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonCreateChild = New System.Windows.Forms.Button()
        Me.TextBoxChild = New System.Windows.Forms.TextBox()
        Me.TextBoxChildValue = New System.Windows.Forms.TextBox()
        Me.TextBoxRead = New System.Windows.Forms.TextBox()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.TextBoxReadChild = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxRName
        '
        Me.TextBoxRName.Location = New System.Drawing.Point(24, 23)
        Me.TextBoxRName.Name = "TextBoxRName"
        Me.TextBoxRName.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxRName.TabIndex = 0
        Me.TextBoxRName.Text = "Please Enter Registry Name"
        Me.TextBoxRName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(208, 21)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(115, 23)
        Me.ButtonCreate.TabIndex = 1
        Me.ButtonCreate.Text = "Create New Entry"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonCreateChild
        '
        Me.ButtonCreateChild.Location = New System.Drawing.Point(208, 79)
        Me.ButtonCreateChild.Name = "ButtonCreateChild"
        Me.ButtonCreateChild.Size = New System.Drawing.Size(115, 23)
        Me.ButtonCreateChild.TabIndex = 2
        Me.ButtonCreateChild.Text = "Create Child"
        Me.ButtonCreateChild.UseVisualStyleBackColor = True
        '
        'TextBoxChild
        '
        Me.TextBoxChild.Location = New System.Drawing.Point(24, 67)
        Me.TextBoxChild.Name = "TextBoxChild"
        Me.TextBoxChild.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxChild.TabIndex = 3
        Me.TextBoxChild.Text = "Please Enter Child Name"
        Me.TextBoxChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxChildValue
        '
        Me.TextBoxChildValue.Location = New System.Drawing.Point(24, 93)
        Me.TextBoxChildValue.Name = "TextBoxChildValue"
        Me.TextBoxChildValue.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxChildValue.TabIndex = 4
        Me.TextBoxChildValue.Text = "Please Enter Child Value"
        Me.TextBoxChildValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRead
        '
        Me.TextBoxRead.Location = New System.Drawing.Point(24, 188)
        Me.TextBoxRead.Name = "TextBoxRead"
        Me.TextBoxRead.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxRead.TabIndex = 5
        Me.TextBoxRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(208, 171)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(115, 23)
        Me.ButtonRead.TabIndex = 6
        Me.ButtonRead.Text = "Read Registry"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'TextBoxReadChild
        '
        Me.TextBoxReadChild.Location = New System.Drawing.Point(24, 162)
        Me.TextBoxReadChild.Name = "TextBoxReadChild"
        Me.TextBoxReadChild.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxReadChild.TabIndex = 7
        Me.TextBoxReadChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 261)
        Me.Controls.Add(Me.TextBoxReadChild)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.TextBoxRead)
        Me.Controls.Add(Me.TextBoxChildValue)
        Me.Controls.Add(Me.TextBoxChild)
        Me.Controls.Add(Me.ButtonCreateChild)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.TextBoxRName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "Windows Registry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxRName As TextBox
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonCreateChild As Button
    Friend WithEvents TextBoxChild As TextBox
    Friend WithEvents TextBoxChildValue As TextBox
    Friend WithEvents TextBoxRead As TextBox
    Friend WithEvents ButtonRead As Button
    Friend WithEvents TextBoxReadChild As TextBox
End Class
