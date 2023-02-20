<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetails))
        Me.lbInName = New System.Windows.Forms.Label()
        Me.lbInBD = New System.Windows.Forms.Label()
        Me.lbInDP = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btPlay = New System.Windows.Forms.Button()
        Me.lbGT = New System.Windows.Forms.Label()
        Me.Bd = New System.Windows.Forms.DateTimePicker()
        Me.Gd = New System.Windows.Forms.ComboBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.matrics = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbInName
        '
        Me.lbInName.AutoSize = True
        Me.lbInName.Location = New System.Drawing.Point(30, 19)
        Me.lbInName.Name = "lbInName"
        Me.lbInName.Size = New System.Drawing.Size(156, 25)
        Me.lbInName.TabIndex = 0
        Me.lbInName.Text = "Enter your name : "
        '
        'lbInBD
        '
        Me.lbInBD.AutoSize = True
        Me.lbInBD.Location = New System.Drawing.Point(8, 91)
        Me.lbInBD.Name = "lbInBD"
        Me.lbInBD.Size = New System.Drawing.Size(178, 25)
        Me.lbInBD.TabIndex = 1
        Me.lbInBD.Text = "Enter your birthday : "
        '
        'lbInDP
        '
        Me.lbInDP.AutoSize = True
        Me.lbInDP.Location = New System.Drawing.Point(18, 129)
        Me.lbInDP.Name = "lbInDP"
        Me.lbInDP.Size = New System.Drawing.Size(168, 25)
        Me.lbInDP.TabIndex = 2
        Me.lbInDP.Text = "Enter your gender : "
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(217, 176)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(112, 34)
        Me.btClose.TabIndex = 3
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btPlay
        '
        Me.btPlay.Location = New System.Drawing.Point(356, 176)
        Me.btPlay.Name = "btPlay"
        Me.btPlay.Size = New System.Drawing.Size(112, 34)
        Me.btPlay.TabIndex = 4
        Me.btPlay.Text = "Play"
        Me.btPlay.UseVisualStyleBackColor = True
        '
        'lbGT
        '
        Me.lbGT.AutoSize = True
        Me.lbGT.Location = New System.Drawing.Point(3, 56)
        Me.lbGT.Name = "lbGT"
        Me.lbGT.Size = New System.Drawing.Size(183, 25)
        Me.lbGT.TabIndex = 5
        Me.lbGT.Text = "Enter your gametag : "
        '
        'Bd
        '
        Me.Bd.Location = New System.Drawing.Point(192, 90)
        Me.Bd.Name = "Bd"
        Me.Bd.Size = New System.Drawing.Size(300, 31)
        Me.Bd.TabIndex = 6
        '
        'Gd
        '
        Me.Gd.FormattingEnabled = True
        Me.Gd.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gd.Location = New System.Drawing.Point(192, 126)
        Me.Gd.Name = "Gd"
        Me.Gd.Size = New System.Drawing.Size(300, 33)
        Me.Gd.TabIndex = 7
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(192, 16)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(300, 31)
        Me.tbName.TabIndex = 8
        '
        'matrics
        '
        Me.matrics.Location = New System.Drawing.Point(192, 53)
        Me.matrics.Name = "matrics"
        Me.matrics.Size = New System.Drawing.Size(300, 31)
        Me.matrics.TabIndex = 9
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 275)
        Me.Controls.Add(Me.matrics)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Gd)
        Me.Controls.Add(Me.Bd)
        Me.Controls.Add(Me.lbGT)
        Me.Controls.Add(Me.btPlay)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.lbInDP)
        Me.Controls.Add(Me.lbInBD)
        Me.Controls.Add(Me.lbInName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetails"
        Me.Text = "Further details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbInName As Label
    Friend WithEvents lbInBD As Label
    Friend WithEvents lbInDP As Label
    Friend WithEvents btClose As Button
    Friend WithEvents btPlay As Button
    Friend WithEvents lbGT As Label
    Friend WithEvents Bd As DateTimePicker
    Friend WithEvents Gd As ComboBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents matrics As TextBox

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Close()
    End Sub

    Private Sub btDis_Click(sender As Object, e As EventArgs) Handles btPlay.Click
        frmGame.Show()
    End Sub

    Private Sub lbMat_Click(sender As Object, e As EventArgs) Handles lbGT.Click

    End Sub

    Private Sub lbInDP_Click(sender As Object, e As EventArgs) Handles lbInDP.Click

    End Sub

    Private Sub lbInBD_Click(sender As Object, e As EventArgs) Handles lbInBD.Click

    End Sub

    Private Sub lbInName_Click(sender As Object, e As EventArgs) Handles lbInName.Click

    End Sub
End Class
