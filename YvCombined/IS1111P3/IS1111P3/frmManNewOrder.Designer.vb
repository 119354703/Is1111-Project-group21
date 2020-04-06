<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManNewOrder
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
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lstPlace = New System.Windows.Forms.ListBox()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.lstLogout = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlace.Location = New System.Drawing.Point(23, 32)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(188, 18)
        Me.lblPlace.TabIndex = 0
        Me.lblPlace.Text = "Q1: How to Place an Order"
        '
        'lstPlace
        '
        Me.lstPlace.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!)
        Me.lstPlace.FormattingEnabled = True
        Me.lstPlace.ItemHeight = 16
        Me.lstPlace.Location = New System.Drawing.Point(283, 32)
        Me.lstPlace.Name = "lstPlace"
        Me.lstPlace.Size = New System.Drawing.Size(426, 164)
        Me.lstPlace.TabIndex = 1
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogout.Location = New System.Drawing.Point(23, 222)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(237, 18)
        Me.lblLogout.TabIndex = 2
        Me.lblLogout.Text = "Q2: How to logout after Ordering."
        '
        'lstLogout
        '
        Me.lstLogout.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!)
        Me.lstLogout.FormattingEnabled = True
        Me.lstLogout.ItemHeight = 16
        Me.lstLogout.Location = New System.Drawing.Point(283, 239)
        Me.lstLogout.Name = "lstLogout"
        Me.lstLogout.Size = New System.Drawing.Size(426, 100)
        Me.lstLogout.TabIndex = 5
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Black
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(26, 315)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(97, 23)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmManNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(746, 394)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstLogout)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.lstPlace)
        Me.Controls.Add(Me.lblPlace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmManNewOrder"
        Me.Text = "Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlace As Label
    Friend WithEvents lstPlace As ListBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents lstLogout As ListBox
    Friend WithEvents btnReturn As Button
End Class
