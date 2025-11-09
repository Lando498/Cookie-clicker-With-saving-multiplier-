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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Counter = New TextBox()
        multplus = New Button()
        MultCounter = New TextBox()
        Cookie = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Counter
        ' 
        Counter.Enabled = False
        Counter.ForeColor = Color.Black
        Counter.Location = New Point(670, 60)
        Counter.Margin = New Padding(3, 4, 3, 4)
        Counter.Name = "Counter"
        Counter.Size = New Size(62, 27)
        Counter.TabIndex = 1
        ' 
        ' multplus
        ' 
        multplus.Location = New Point(599, 99)
        multplus.Margin = New Padding(3, 4, 3, 4)
        multplus.Name = "multplus"
        multplus.Size = New Size(119, 56)
        multplus.TabIndex = 3
        multplus.Text = "+1 Multiplier Cost 100 cookies"
        multplus.UseVisualStyleBackColor = True
        ' 
        ' MultCounter
        ' 
        MultCounter.Enabled = False
        MultCounter.ForeColor = Color.Black
        MultCounter.Location = New Point(670, 163)
        MultCounter.Margin = New Padding(3, 4, 3, 4)
        MultCounter.Name = "MultCounter"
        MultCounter.Size = New Size(62, 27)
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
        Cookie.Image = CType(resources.GetObject("Cookie.Image"), Image)
        Cookie.Location = New Point(-3, 28)
        Cookie.Name = "Cookie"
        Cookie.Size = New Size(596, 628)
        Cookie.TabIndex = 6
        Cookie.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(598, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 7
        Label1.Text = "Multiplier:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(600, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 8
        Label2.Text = "Cookies:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(731, 724)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cookie)
        Controls.Add(MultCounter)
        Controls.Add(multplus)
        Controls.Add(Counter)
        Margin = New Padding(3, 4, 3, 4)
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

End Class
