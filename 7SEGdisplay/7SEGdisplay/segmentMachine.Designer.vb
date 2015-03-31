<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class segmentMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(segmentMachine))
        Me.graphicSevenSeg = New System.Windows.Forms.PictureBox()
        Me.toggleActiveLow = New System.Windows.Forms.CheckBox()
        Me.toggleHex = New System.Windows.Forms.CheckBox()
        CType(Me.graphicSevenSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graphicSevenSeg
        '
        Me.graphicSevenSeg.Image = CType(resources.GetObject("graphicSevenSeg.Image"), System.Drawing.Image)
        Me.graphicSevenSeg.Location = New System.Drawing.Point(12, 12)
        Me.graphicSevenSeg.Name = "graphicSevenSeg"
        Me.graphicSevenSeg.Size = New System.Drawing.Size(89, 119)
        Me.graphicSevenSeg.TabIndex = 0
        Me.graphicSevenSeg.TabStop = False
        '
        'toggleActiveLow
        '
        Me.toggleActiveLow.AutoSize = True
        Me.toggleActiveLow.Location = New System.Drawing.Point(12, 152)
        Me.toggleActiveLow.Name = "toggleActiveLow"
        Me.toggleActiveLow.Size = New System.Drawing.Size(101, 17)
        Me.toggleActiveLow.TabIndex = 1
        Me.toggleActiveLow.Text = "Use Active Low"
        Me.toggleActiveLow.UseVisualStyleBackColor = True
        '
        'toggleHex
        '
        Me.toggleHex.AutoSize = True
        Me.toggleHex.Cursor = System.Windows.Forms.Cursors.Default
        Me.toggleHex.Location = New System.Drawing.Point(12, 175)
        Me.toggleHex.Name = "toggleHex"
        Me.toggleHex.Size = New System.Drawing.Size(96, 17)
        Me.toggleHex.TabIndex = 2
        Me.toggleHex.Text = "Display in HEX"
        Me.toggleHex.UseVisualStyleBackColor = True
        '
        'segmentMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 261)
        Me.Controls.Add(Me.toggleHex)
        Me.Controls.Add(Me.toggleActiveLow)
        Me.Controls.Add(Me.graphicSevenSeg)
        Me.HelpButton = True
        Me.Name = "segmentMachine"
        Me.Text = "The Magical Segment Machine"
        CType(Me.graphicSevenSeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents graphicSevenSeg As System.Windows.Forms.PictureBox
    Friend WithEvents toggleActiveLow As System.Windows.Forms.CheckBox
    Friend WithEvents toggleHex As System.Windows.Forms.CheckBox

End Class
