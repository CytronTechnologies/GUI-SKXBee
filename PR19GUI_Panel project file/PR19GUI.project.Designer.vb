<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR19GUI
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
        Me.BaudRate_msg = New System.Windows.Forms.TextBox
        Me.ComPortDisp = New System.Windows.Forms.TextBox
        Me.Button_Cancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button_Connect = New System.Windows.Forms.Button
        Me.Button_Search = New System.Windows.Forms.Button
        Me.ComPortBox = New System.Windows.Forms.ComboBox
        Me.Button_forward = New System.Windows.Forms.Button
        Me.Button_left = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button_stop = New System.Windows.Forms.Button
        Me.Button_backward = New System.Windows.Forms.Button
        Me.Button_right = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button_Anticlock = New System.Windows.Forms.Button
        Me.Button_clock = New System.Windows.Forms.Button
        Me.Button_stop_rotate = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.RESET_button = New System.Windows.Forms.Button
        Me.rec_display = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaudRate_msg
        '
        Me.BaudRate_msg.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BaudRate_msg.Location = New System.Drawing.Point(82, 136)
        Me.BaudRate_msg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BaudRate_msg.Name = "BaudRate_msg"
        Me.BaudRate_msg.ReadOnly = True
        Me.BaudRate_msg.Size = New System.Drawing.Size(77, 22)
        Me.BaudRate_msg.TabIndex = 6
        '
        'ComPortDisp
        '
        Me.ComPortDisp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComPortDisp.Location = New System.Drawing.Point(5, 100)
        Me.ComPortDisp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComPortDisp.Name = "ComPortDisp"
        Me.ComPortDisp.ReadOnly = True
        Me.ComPortDisp.Size = New System.Drawing.Size(155, 22)
        Me.ComPortDisp.TabIndex = 4
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Location = New System.Drawing.Point(88, 59)
        Me.Button_Cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(73, 26)
        Me.Button_Cancel.TabIndex = 3
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BaudRate_msg)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ComPortDisp)
        Me.GroupBox1.Controls.Add(Me.Button_Cancel)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Controls.Add(Me.Button_Search)
        Me.GroupBox1.Controls.Add(Me.ComPortBox)
        Me.GroupBox1.Location = New System.Drawing.Point(525, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(168, 177)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COM PORT"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 17)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "BaudRate"
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(6, 59)
        Me.Button_Connect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(76, 27)
        Me.Button_Connect.TabIndex = 2
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(89, 21)
        Me.Button_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(73, 25)
        Me.Button_Search.TabIndex = 1
        Me.Button_Search.Text = "Search"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'ComPortBox
        '
        Me.ComPortBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ComPortBox.FormattingEnabled = True
        Me.ComPortBox.Location = New System.Drawing.Point(5, 21)
        Me.ComPortBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComPortBox.Name = "ComPortBox"
        Me.ComPortBox.Size = New System.Drawing.Size(77, 24)
        Me.ComPortBox.TabIndex = 0
        '
        'Button_forward
        '
        Me.Button_forward.Location = New System.Drawing.Point(89, 21)
        Me.Button_forward.Name = "Button_forward"
        Me.Button_forward.Size = New System.Drawing.Size(88, 26)
        Me.Button_forward.TabIndex = 6
        Me.Button_forward.Text = "Forward"
        Me.Button_forward.UseVisualStyleBackColor = True
        '
        'Button_left
        '
        Me.Button_left.Location = New System.Drawing.Point(20, 79)
        Me.Button_left.Name = "Button_left"
        Me.Button_left.Size = New System.Drawing.Size(59, 27)
        Me.Button_left.TabIndex = 7
        Me.Button_left.Text = "Left"
        Me.Button_left.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button_stop)
        Me.GroupBox2.Controls.Add(Me.Button_backward)
        Me.GroupBox2.Controls.Add(Me.Button_right)
        Me.GroupBox2.Controls.Add(Me.Button_left)
        Me.GroupBox2.Controls.Add(Me.Button_forward)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 177)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flexibot_Direction_Control"
        '
        'Button_stop
        '
        Me.Button_stop.Location = New System.Drawing.Point(110, 78)
        Me.Button_stop.Name = "Button_stop"
        Me.Button_stop.Size = New System.Drawing.Size(50, 28)
        Me.Button_stop.TabIndex = 10
        Me.Button_stop.Text = "Stop"
        Me.Button_stop.UseVisualStyleBackColor = True
        '
        'Button_backward
        '
        Me.Button_backward.Location = New System.Drawing.Point(89, 136)
        Me.Button_backward.Name = "Button_backward"
        Me.Button_backward.Size = New System.Drawing.Size(88, 29)
        Me.Button_backward.TabIndex = 9
        Me.Button_backward.Text = "Backward"
        Me.Button_backward.UseVisualStyleBackColor = True
        '
        'Button_right
        '
        Me.Button_right.Location = New System.Drawing.Point(190, 79)
        Me.Button_right.Name = "Button_right"
        Me.Button_right.Size = New System.Drawing.Size(63, 27)
        Me.Button_right.TabIndex = 8
        Me.Button_right.Text = "Right"
        Me.Button_right.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Image = Global.PR19_GUI_project.My.Resources.Resources._4_direction
        Me.PictureBox1.Location = New System.Drawing.Point(71, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button_Anticlock)
        Me.GroupBox3.Controls.Add(Me.Button_clock)
        Me.GroupBox3.Controls.Add(Me.Button_stop_rotate)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(314, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(195, 177)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Flexibot_Rotate"
        '
        'Button_Anticlock
        '
        Me.Button_Anticlock.Location = New System.Drawing.Point(22, 119)
        Me.Button_Anticlock.Name = "Button_Anticlock"
        Me.Button_Anticlock.Size = New System.Drawing.Size(112, 29)
        Me.Button_Anticlock.TabIndex = 0
        Me.Button_Anticlock.Text = "Anticlockwise"
        Me.Button_Anticlock.UseVisualStyleBackColor = True
        '
        'Button_clock
        '
        Me.Button_clock.Location = New System.Drawing.Point(22, 36)
        Me.Button_clock.Name = "Button_clock"
        Me.Button_clock.Size = New System.Drawing.Size(112, 28)
        Me.Button_clock.TabIndex = 2
        Me.Button_clock.Text = "Clockwise"
        Me.Button_clock.UseVisualStyleBackColor = True
        '
        'Button_stop_rotate
        '
        Me.Button_stop_rotate.Location = New System.Drawing.Point(22, 77)
        Me.Button_stop_rotate.Name = "Button_stop_rotate"
        Me.Button_stop_rotate.Size = New System.Drawing.Size(112, 29)
        Me.Button_stop_rotate.TabIndex = 1
        Me.Button_stop_rotate.Text = "Stop_rotate"
        Me.Button_stop_rotate.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PR19_GUI_project.My.Resources.Resources.anti1
        Me.PictureBox2.Location = New System.Drawing.Point(131, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PR19_GUI_project.My.Resources.Resources.clock1
        Me.PictureBox3.Location = New System.Drawing.Point(131, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'RESET_button
        '
        Me.RESET_button.Location = New System.Drawing.Point(531, 202)
        Me.RESET_button.Name = "RESET_button"
        Me.RESET_button.Size = New System.Drawing.Size(75, 23)
        Me.RESET_button.TabIndex = 15
        Me.RESET_button.Text = "RESET"
        Me.RESET_button.UseVisualStyleBackColor = True
        '
        'rec_display
        '
        Me.rec_display.Location = New System.Drawing.Point(231, 203)
        Me.rec_display.Name = "rec_display"
        Me.rec_display.ReadOnly = True
        Me.rec_display.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.rec_display.Size = New System.Drawing.Size(201, 26)
        Me.rec_display.TabIndex = 16
        Me.rec_display.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(103, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Receive message:"
        '
        'PR19GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 235)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rec_display)
        Me.Controls.Add(Me.RESET_button)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PR19GUI"
        Me.Text = "PR19_GUI_Panel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BaudRate_msg As System.Windows.Forms.TextBox
    Friend WithEvents ComPortDisp As System.Windows.Forms.TextBox
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents Button_Search As System.Windows.Forms.Button
    Friend WithEvents ComPortBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button_forward As System.Windows.Forms.Button
    Friend WithEvents Button_left As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_backward As System.Windows.Forms.Button
    Friend WithEvents Button_right As System.Windows.Forms.Button
    Friend WithEvents Button_stop As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_clock As System.Windows.Forms.Button
    Friend WithEvents Button_stop_rotate As System.Windows.Forms.Button
    Friend WithEvents Button_Anticlock As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents RESET_button As System.Windows.Forms.Button
    Friend WithEvents rec_display As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
