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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcelcius = New System.Windows.Forms.TextBox()
        Me.btnkonversi = New System.Windows.Forms.Button()
        Me.txtfahrenheit = New System.Windows.Forms.Label()
        Me.txtfahre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Celcius To Fahrenheit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Celcius"
        '
        'txtcelcius
        '
        Me.txtcelcius.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcelcius.Location = New System.Drawing.Point(184, 135)
        Me.txtcelcius.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcelcius.Multiline = True
        Me.txtcelcius.Name = "txtcelcius"
        Me.txtcelcius.Size = New System.Drawing.Size(187, 27)
        Me.txtcelcius.TabIndex = 2
        '
        'btnkonversi
        '
        Me.btnkonversi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkonversi.Location = New System.Drawing.Point(222, 176)
        Me.btnkonversi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnkonversi.Name = "btnkonversi"
        Me.btnkonversi.Size = New System.Drawing.Size(103, 32)
        Me.btnkonversi.TabIndex = 3
        Me.btnkonversi.Text = "Konversi"
        Me.btnkonversi.UseVisualStyleBackColor = True
        '
        'txtfahrenheit
        '
        Me.txtfahrenheit.AutoSize = True
        Me.txtfahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfahrenheit.Location = New System.Drawing.Point(232, 235)
        Me.txtfahrenheit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtfahrenheit.Name = "txtfahrenheit"
        Me.txtfahrenheit.Size = New System.Drawing.Size(96, 20)
        Me.txtfahrenheit.TabIndex = 4
        Me.txtfahrenheit.Text = "Fahrenheit"
        '
        'txtfahre
        '
        Me.txtfahre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfahre.Location = New System.Drawing.Point(184, 270)
        Me.txtfahre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfahre.Multiline = True
        Me.txtfahre.Name = "txtfahre"
        Me.txtfahre.Size = New System.Drawing.Size(187, 27)
        Me.txtfahre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(141, 324)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ferdy Pradana Putra || 200511032 || 20C"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 418)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfahre)
        Me.Controls.Add(Me.txtfahrenheit)
        Me.Controls.Add(Me.btnkonversi)
        Me.Controls.Add(Me.txtcelcius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Konversi Suhu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcelcius As TextBox
    Friend WithEvents btnkonversi As Button
    Friend WithEvents txtfahrenheit As Label
    Friend WithEvents txtfahre As TextBox
    Friend WithEvents Label3 As Label
End Class
