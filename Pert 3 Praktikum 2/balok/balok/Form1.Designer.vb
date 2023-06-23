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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpanjang = New System.Windows.Forms.TextBox()
        Me.txtlebar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttinggi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtluaspermukaan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvolume = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang"
        '
        'txtpanjang
        '
        Me.txtpanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpanjang.Location = New System.Drawing.Point(183, 47)
        Me.txtpanjang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpanjang.Name = "txtpanjang"
        Me.txtpanjang.Size = New System.Drawing.Size(108, 26)
        Me.txtpanjang.TabIndex = 2
        '
        'txtlebar
        '
        Me.txtlebar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlebar.Location = New System.Drawing.Point(183, 77)
        Me.txtlebar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtlebar.Name = "txtlebar"
        Me.txtlebar.Size = New System.Drawing.Size(108, 26)
        Me.txtlebar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lebar"
        '
        'txttinggi
        '
        Me.txttinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinggi.Location = New System.Drawing.Point(183, 106)
        Me.txttinggi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttinggi.Name = "txttinggi"
        Me.txttinggi.Size = New System.Drawing.Size(108, 26)
        Me.txttinggi.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tinggi"
        '
        'txtluaspermukaan
        '
        Me.txtluaspermukaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtluaspermukaan.Location = New System.Drawing.Point(183, 223)
        Me.txtluaspermukaan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtluaspermukaan.Name = "txtluaspermukaan"
        Me.txtluaspermukaan.Size = New System.Drawing.Size(108, 26)
        Me.txtluaspermukaan.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Luas Permukaan"
        '
        'txtvolume
        '
        Me.txtvolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvolume.Location = New System.Drawing.Point(183, 194)
        Me.txtvolume.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtvolume.Name = "txtvolume"
        Me.txtvolume.Size = New System.Drawing.Size(108, 26)
        Me.txtvolume.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Volume"
        '
        'btnhitung
        '
        Me.btnhitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.Location = New System.Drawing.Point(192, 141)
        Me.btnhitung.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(85, 41)
        Me.btnhitung.TabIndex = 11
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(35, 280)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ferdy Pradana Putra || 200511032 || 20C"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 332)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txtluaspermukaan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtvolume)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttinggi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlebar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpanjang)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Balok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpanjang As TextBox
    Friend WithEvents txtlebar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttinggi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtluaspermukaan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtvolume As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnhitung As Button
    Friend WithEvents Label7 As Label
End Class
