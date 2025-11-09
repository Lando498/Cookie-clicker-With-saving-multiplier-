<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Cookie = New Button()
        Counter = New TextBox()
        TextBox1 = New TextBox()
        multplus = New Button()
        TextBox2 = New TextBox()
        MultCounter = New TextBox()
        SuspendLayout()
        ' 
        ' Cookie
        ' 
        Cookie.Image = My.Resources.Resources.cookie
        Cookie.Location = New Point(11, 12)
        Cookie.Name = "Cookie"
        Cookie.Size = New Size(507, 519)
        Cookie.TabIndex = 0
        Cookie.UseVisualStyleBackColor = True
        ' 
        ' Counter
        ' 
        Counter.Location = New Point(596, 45)
        Counter.Name = "Counter"
        Counter.Size = New Size(32, 23)
        Counter.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(524, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(66, 23)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Cookies:"
        ' 
        ' multplus
        ' 
        multplus.Location = New Point(524, 74)
        multplus.Name = "multplus"
        multplus.Size = New Size(104, 42)
        multplus.TabIndex = 3
        multplus.Text = "+1 Multiplier Cost 100 cookies"
        multplus.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(524, 122)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(66, 23)
        TextBox2.TabIndex = 5
        TextBox2.Text = "Multiplier:"
        ' 
        ' MultCounter
        ' 
        MultCounter.Location = New Point(596, 122)
        MultCounter.Name = "MultCounter"
        MultCounter.Size = New Size(32, 23)
        MultCounter.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 543)
        Controls.Add(TextBox2)
        Controls.Add(MultCounter)
        Controls.Add(multplus)
        Controls.Add(TextBox1)
        Controls.Add(Counter)
        Controls.Add(Cookie)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cookie As Button
    Friend WithEvents Counter As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents multplus As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MultCounter As TextBox

End Class
