<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(386, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Resolver"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(457, 190)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Valor de y"
        TextBox2.Size = New Size(89, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(272, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 15)
        Label1.TabIndex = 5
        Label1.Text = "E ="
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(397, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 15)
        Label2.TabIndex = 6
        Label2.Text = "+"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(418, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 15)
        Label3.TabIndex = 7
        Label3.Text = "__________________________"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(431, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 15)
        Label4.TabIndex = 8
        Label4.Text = "2g"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(552, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 9
        Label5.Text = "2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(531, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(13, 15)
        Label6.TabIndex = 10
        Label6.Text = "2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(272, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(305, 15)
        Label7.TabIndex = 11
        Label7.Text = "Introduzca los valores para resolver la siguiente ecuacion"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(365, 282)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 15)
        Label8.TabIndex = 12
        Label8.Text = "E ="
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(440, 152)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Valor q"
        TextBox3.Size = New Size(89, 23)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(302, 169)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Valor de y"
        TextBox1.Size = New Size(89, 23)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(395, 279)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Resultado"
        TextBox4.Size = New Size(89, 23)
        TextBox4.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(TextBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Asignacion No.2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox

End Class
