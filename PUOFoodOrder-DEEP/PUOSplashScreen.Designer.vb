<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PUOSplashScreen
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
        Me.picSplashScreen = New System.Windows.Forms.PictureBox()
        Me.lblApp1 = New System.Windows.Forms.Label()
        Me.lblApp2 = New System.Windows.Forms.Label()
        Me.lblAppDesc = New System.Windows.Forms.Label()
        Me.PanelText = New System.Windows.Forms.Panel()
        CType(Me.picSplashScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelText.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSplashScreen
        '
        Me.picSplashScreen.Image = Global.PUOFoodOrder_DEEP.My.Resources.Resources.Contact_Us
        Me.picSplashScreen.Location = New System.Drawing.Point(-88, -84)
        Me.picSplashScreen.Name = "picSplashScreen"
        Me.picSplashScreen.Size = New System.Drawing.Size(292, 284)
        Me.picSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSplashScreen.TabIndex = 0
        Me.picSplashScreen.TabStop = False
        '
        'lblApp1
        '
        Me.lblApp1.AutoSize = True
        Me.lblApp1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblApp1.Location = New System.Drawing.Point(5, 5)
        Me.lblApp1.Name = "lblApp1"
        Me.lblApp1.Size = New System.Drawing.Size(59, 30)
        Me.lblApp1.TabIndex = 13
        Me.lblApp1.Text = "PUO"
        '
        'lblApp2
        '
        Me.lblApp2.AutoSize = True
        Me.lblApp2.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblApp2.Location = New System.Drawing.Point(59, 5)
        Me.lblApp2.Name = "lblApp2"
        Me.lblApp2.Size = New System.Drawing.Size(75, 30)
        Me.lblApp2.TabIndex = 14
        Me.lblApp2.Text = "Makan"
        '
        'lblAppDesc
        '
        Me.lblAppDesc.AutoSize = True
        Me.lblAppDesc.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAppDesc.Location = New System.Drawing.Point(5, 35)
        Me.lblAppDesc.Name = "lblAppDesc"
        Me.lblAppDesc.Size = New System.Drawing.Size(110, 51)
        Me.lblAppDesc.TabIndex = 15
        Me.lblAppDesc.Text = "Takyah fikir banyak" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kali bab makanan," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "beli jelah."
        '
        'PanelText
        '
        Me.PanelText.Controls.Add(Me.lblAppDesc)
        Me.PanelText.Controls.Add(Me.lblApp2)
        Me.PanelText.Controls.Add(Me.lblApp1)
        Me.PanelText.Location = New System.Drawing.Point(210, 93)
        Me.PanelText.Name = "PanelText"
        Me.PanelText.Size = New System.Drawing.Size(177, 107)
        Me.PanelText.TabIndex = 16
        '
        'PUOSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(391, 218)
        Me.Controls.Add(Me.PanelText)
        Me.Controls.Add(Me.picSplashScreen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PUOSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picSplashScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelText.ResumeLayout(False)
        Me.PanelText.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSplashScreen As PictureBox
    Friend WithEvents lblApp1 As Label
    Friend WithEvents lblApp2 As Label
    Friend WithEvents lblAppDesc As Label
    Friend WithEvents PanelText As Panel
End Class
