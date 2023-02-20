<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.tbUN = New System.Windows.Forms.TextBox()
        Me.tbPW = New System.Windows.Forms.TextBox()
        Me.UN = New System.Windows.Forms.Label()
        Me.PW = New System.Windows.Forms.Label()
        Me.btLI = New System.Windows.Forms.Button()
        Me.btHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUN
        '
        Me.tbUN.Location = New System.Drawing.Point(133, 33)
        Me.tbUN.Name = "tbUN"
        Me.tbUN.Size = New System.Drawing.Size(281, 31)
        Me.tbUN.TabIndex = 0
        '
        'tbPW
        '
        Me.tbPW.Location = New System.Drawing.Point(133, 85)
        Me.tbPW.Name = "tbPW"
        Me.tbPW.Size = New System.Drawing.Size(281, 31)
        Me.tbPW.TabIndex = 1
        '
        'UN
        '
        Me.UN.AutoSize = True
        Me.UN.Location = New System.Drawing.Point(22, 36)
        Me.UN.Name = "UN"
        Me.UN.Size = New System.Drawing.Size(105, 25)
        Me.UN.TabIndex = 2
        Me.UN.Text = " Username :"
        '
        'PW
        '
        Me.PW.AutoSize = True
        Me.PW.Location = New System.Drawing.Point(31, 88)
        Me.PW.Name = "PW"
        Me.PW.Size = New System.Drawing.Size(96, 25)
        Me.PW.TabIndex = 3
        Me.PW.Text = "Password :"
        '
        'btLI
        '
        Me.btLI.Location = New System.Drawing.Point(149, 147)
        Me.btLI.Name = "btLI"
        Me.btLI.Size = New System.Drawing.Size(116, 45)
        Me.btLI.TabIndex = 4
        Me.btLI.Text = "Log In"
        Me.btLI.UseVisualStyleBackColor = True
        '
        'btHelp
        '
        Me.btHelp.Location = New System.Drawing.Point(271, 147)
        Me.btHelp.Name = "btHelp"
        Me.btHelp.Size = New System.Drawing.Size(116, 45)
        Me.btHelp.TabIndex = 5
        Me.btHelp.Text = "Help"
        Me.btHelp.UseVisualStyleBackColor = True
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(463, 223)
        Me.Controls.Add(Me.btHelp)
        Me.Controls.Add(Me.btLI)
        Me.Controls.Add(Me.PW)
        Me.Controls.Add(Me.UN)
        Me.Controls.Add(Me.tbPW)
        Me.Controls.Add(Me.tbUN)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogin"
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUN As TextBox
    Friend WithEvents tbPW As TextBox
    Friend WithEvents UN As Label
    Friend WithEvents PW As Label
    Friend WithEvents btLI As Button
    Friend WithEvents btHelp As Button
End Class
