<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fahrenheit"
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(158, 159)
        Me.txtFahrenheit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(110, 23)
        Me.txtFahrenheit.TabIndex = 1
        '
        'txtCelcius
        '
        Me.txtCelcius.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(161, 119)
        Me.txtCelcius.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(110, 23)
        Me.txtCelcius.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Celcius"
        '
        'txtReamur
        '
        Me.txtReamur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(158, 202)
        Me.txtReamur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(110, 23)
        Me.txtReamur.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reamur"
        '
        'txtKelvin
        '
        Me.txtKelvin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelvin.Location = New System.Drawing.Point(158, 34)
        Me.txtKelvin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(110, 23)
        Me.txtKelvin.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kelvin"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(166, 75)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 269)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ferdy Pradana Putra || 200511032 || TIF 20 C"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 360)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
