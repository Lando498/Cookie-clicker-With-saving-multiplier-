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
        Counter = New TextBox()
        multplus = New Button()
        MultCounter = New TextBox()
        Cookie = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Counter
        ' 
        Counter.Enabled = False
        Counter.ForeColor = Color.Black
        Counter.Location = New Point(586, 45)
        Counter.Name = "Counter"
        Counter.Size = New Size(55, 23)
        Counter.TabIndex = 1
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
        ' MultCounter
        ' 
        MultCounter.Enabled = False
        MultCounter.ForeColor = Color.Black
        MultCounter.Location = New Point(586, 122)
        MultCounter.Name = "MultCounter"
        MultCounter.Size = New Size(55, 23)
        MultCounter.TabIndex = 4
        ' 
        ' Cookie
        ' 
        Cookie.BackColor = Color.Transparent
        Cookie.FlatAppearance.BorderSize = 0
        Cookie.FlatAppearance.MouseDownBackColor = Color.Transparent
        Cookie.FlatAppearance.MouseOverBackColor = Color.Transparent
        Cookie.FlatStyle = FlatStyle.Flat
        Cookie.ForeColor = Color.Transparent
        Cookie.Image = My.Resources.Resources.PerfectCookie_removebg_preview
        Cookie.Location = New Point(-3, 21)
        Cookie.Margin = New Padding(3, 2, 3, 2)
        Cookie.Name = "Cookie"
        Cookie.Size = New Size(522, 471)
        Cookie.TabIndex = 6
        Cookie.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(523, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 7
        Label1.Text = "Multiplier:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(525, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 8
        Label2.Text = "Cookies:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(523, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 42)
        Button1.TabIndex = 10
        Button1.Text = "+1 Clicker Cost 10 cookies"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(523, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 12
        Label3.Text = "Clickers:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(586, 205)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(55, 23)
        TextBox1.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._320px_BgBlue
        ClientSize = New Size(640, 543)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cookie)
        Controls.Add(MultCounter)
        Controls.Add(multplus)
        Controls.Add(Counter)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Counter As TextBox
    Friend WithEvents multplus As Button
    Friend WithEvents MultCounter As TextBox
    Friend WithEvents Cookie As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox

End Class
