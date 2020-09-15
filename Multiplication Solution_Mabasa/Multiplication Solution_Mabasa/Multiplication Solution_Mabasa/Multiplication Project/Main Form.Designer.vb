<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(97, 23)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(42, 27)
        Me.txtNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Multiplication table:"
        '
        'lblTable
        '
        Me.lblTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTable.Location = New System.Drawing.Point(32, 98)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(113, 192)
        Me.lblTable.TabIndex = 6
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(176, 23)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(111, 33)
        Me.btnForNext.TabIndex = 2
        Me.btnForNext.Text = "&For...Next"
        Me.btnForNext.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(176, 62)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(111, 33)
        Me.btnDoLoop.TabIndex = 3
        Me.btnDoLoop.Text = "&Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 324)
        Me.Controls.Add(Me.btnDoLoop)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiplication Table"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents btnForNext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDoLoop As Button
End Class
