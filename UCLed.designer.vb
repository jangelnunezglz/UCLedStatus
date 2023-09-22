<System.ComponentModel.Designer(GetType(CDesigner))> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLed
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCLed))
        Me.pbxSupport = New System.Windows.Forms.PictureBox()
        Me.pbxOnline = New System.Windows.Forms.PictureBox()
        Me.pbxPanic = New System.Windows.Forms.PictureBox()
        Me.pbxOFF = New System.Windows.Forms.PictureBox()
        Me.pbxHelp = New System.Windows.Forms.PictureBox()
        Me.pbxLED = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxSupport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPanic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxSupport
        '
        Me.pbxSupport.Image = CType(resources.GetObject("pbxSupport.Image"), System.Drawing.Image)
        Me.pbxSupport.Location = New System.Drawing.Point(101, 36)
        Me.pbxSupport.Name = "pbxSupport"
        Me.pbxSupport.Size = New System.Drawing.Size(20, 17)
        Me.pbxSupport.TabIndex = 96
        Me.pbxSupport.TabStop = False
        Me.pbxSupport.Visible = False
        '
        'pbxOnline
        '
        Me.pbxOnline.Image = CType(resources.GetObject("pbxOnline.Image"), System.Drawing.Image)
        Me.pbxOnline.Location = New System.Drawing.Point(75, 36)
        Me.pbxOnline.Name = "pbxOnline"
        Me.pbxOnline.Size = New System.Drawing.Size(20, 17)
        Me.pbxOnline.TabIndex = 95
        Me.pbxOnline.TabStop = False
        Me.pbxOnline.Visible = False
        '
        'pbxPanic
        '
        Me.pbxPanic.Image = CType(resources.GetObject("pbxPanic.Image"), System.Drawing.Image)
        Me.pbxPanic.Location = New System.Drawing.Point(52, 36)
        Me.pbxPanic.Name = "pbxPanic"
        Me.pbxPanic.Size = New System.Drawing.Size(17, 17)
        Me.pbxPanic.TabIndex = 94
        Me.pbxPanic.TabStop = False
        Me.pbxPanic.Visible = False
        '
        'pbxOFF
        '
        Me.pbxOFF.Image = CType(resources.GetObject("pbxOFF.Image"), System.Drawing.Image)
        Me.pbxOFF.Location = New System.Drawing.Point(30, 36)
        Me.pbxOFF.Name = "pbxOFF"
        Me.pbxOFF.Size = New System.Drawing.Size(17, 17)
        Me.pbxOFF.TabIndex = 93
        Me.pbxOFF.TabStop = False
        Me.pbxOFF.Visible = False
        '
        'pbxHelp
        '
        Me.pbxHelp.Image = CType(resources.GetObject("pbxHelp.Image"), System.Drawing.Image)
        Me.pbxHelp.Location = New System.Drawing.Point(7, 36)
        Me.pbxHelp.Name = "pbxHelp"
        Me.pbxHelp.Size = New System.Drawing.Size(17, 17)
        Me.pbxHelp.TabIndex = 92
        Me.pbxHelp.TabStop = False
        Me.pbxHelp.Visible = False
        '
        'pbxLED
        '
        Me.pbxLED.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pbxLED.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxLED.Image = CType(resources.GetObject("pbxLED.Image"), System.Drawing.Image)
        Me.pbxLED.Location = New System.Drawing.Point(0, 0)
        Me.pbxLED.Name = "pbxLED"
        Me.pbxLED.Size = New System.Drawing.Size(26, 23)
        Me.pbxLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLED.TabIndex = 91
        Me.pbxLED.TabStop = False
        '
        'Timer1
        '
        '
        'UCLed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbxSupport)
        Me.Controls.Add(Me.pbxOnline)
        Me.Controls.Add(Me.pbxPanic)
        Me.Controls.Add(Me.pbxOFF)
        Me.Controls.Add(Me.pbxHelp)
        Me.Controls.Add(Me.pbxLED)
        Me.Name = "UCLed"
        Me.Size = New System.Drawing.Size(26, 23)
        CType(Me.pbxSupport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOnline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPanic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pbxSupport As System.Windows.Forms.PictureBox
    Private WithEvents pbxOnline As System.Windows.Forms.PictureBox
    Private WithEvents pbxPanic As System.Windows.Forms.PictureBox
    Private WithEvents pbxOFF As System.Windows.Forms.PictureBox
    Private WithEvents pbxHelp As System.Windows.Forms.PictureBox
    Private WithEvents pbxLED As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
