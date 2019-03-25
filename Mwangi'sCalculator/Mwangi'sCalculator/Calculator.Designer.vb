<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Second_Input = New System.Windows.Forms.TextBox()
        Me.Subtract_Button = New System.Windows.Forms.Button()
        Me.Multiply_Button = New System.Windows.Forms.Button()
        Me.First_input = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Divide_Button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Result_Textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Add_Button
        '
        Me.Add_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.Location = New System.Drawing.Point(60, 81)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(91, 31)
        Me.Add_Button.TabIndex = 0
        Me.Add_Button.Text = "Add"
        Me.Add_Button.UseVisualStyleBackColor = True
        '
        'Second_Input
        '
        Me.Second_Input.Location = New System.Drawing.Point(80, 183)
        Me.Second_Input.Name = "Second_Input"
        Me.Second_Input.Size = New System.Drawing.Size(190, 20)
        Me.Second_Input.TabIndex = 2
        '
        'Subtract_Button
        '
        Me.Subtract_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtract_Button.Location = New System.Drawing.Point(60, 146)
        Me.Subtract_Button.Name = "Subtract_Button"
        Me.Subtract_Button.Size = New System.Drawing.Size(91, 31)
        Me.Subtract_Button.TabIndex = 3
        Me.Subtract_Button.Text = "Subtract "
        Me.Subtract_Button.UseVisualStyleBackColor = True
        '
        'Multiply_Button
        '
        Me.Multiply_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiply_Button.Location = New System.Drawing.Point(216, 78)
        Me.Multiply_Button.Name = "Multiply_Button"
        Me.Multiply_Button.Size = New System.Drawing.Size(91, 31)
        Me.Multiply_Button.TabIndex = 4
        Me.Multiply_Button.Text = "Multiply"
        Me.Multiply_Button.UseVisualStyleBackColor = True
        '
        'First_input
        '
        Me.First_input.Location = New System.Drawing.Point(89, 92)
        Me.First_input.Name = "First_input"
        Me.First_input.Size = New System.Drawing.Size(190, 20)
        Me.First_input.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.First_input)
        Me.GroupBox1.Controls.Add(Me.Second_Input)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 256)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Divide_Button)
        Me.GroupBox2.Controls.Add(Me.Multiply_Button)
        Me.GroupBox2.Controls.Add(Me.Subtract_Button)
        Me.GroupBox2.Controls.Add(Me.Add_Button)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 256)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operations "
        '
        'Divide_Button
        '
        Me.Divide_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divide_Button.Location = New System.Drawing.Point(216, 146)
        Me.Divide_Button.Name = "Divide_Button"
        Me.Divide_Button.Size = New System.Drawing.Size(91, 31)
        Me.Divide_Button.TabIndex = 5
        Me.Divide_Button.Text = "Divide"
        Me.Divide_Button.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox3.Controls.Add(Me.Close_Button)
        Me.GroupBox3.Controls.Add(Me.Clear_Button)
        Me.GroupBox3.Controls.Add(Me.Result_Textbox)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 323)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 187)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Results "
        '
        'Close_Button
        '
        Me.Close_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Button.Location = New System.Drawing.Point(162, 100)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(83, 32)
        Me.Close_Button.TabIndex = 5
        Me.Close_Button.Text = "Close "
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_Button.Location = New System.Drawing.Point(34, 100)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(83, 32)
        Me.Clear_Button.TabIndex = 4
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Result_Textbox
        '
        Me.Result_Textbox.Location = New System.Drawing.Point(41, 47)
        Me.Result_Textbox.Name = "Result_Textbox"
        Me.Result_Textbox.Size = New System.Drawing.Size(204, 20)
        Me.Result_Textbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter The FIrst Number "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter the Second Number "
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.Close_Button
        Me.ClientSize = New System.Drawing.Size(865, 522)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Mwangi's Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Add_Button As System.Windows.Forms.Button
    Friend WithEvents Second_Input As System.Windows.Forms.TextBox
    Friend WithEvents Subtract_Button As System.Windows.Forms.Button
    Friend WithEvents Multiply_Button As System.Windows.Forms.Button
    Friend WithEvents First_input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Divide_Button As System.Windows.Forms.Button
    Friend WithEvents Result_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
