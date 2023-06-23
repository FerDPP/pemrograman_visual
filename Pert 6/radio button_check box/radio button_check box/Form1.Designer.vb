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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbanak = New System.Windows.Forms.RadioButton()
        Me.rbdewasa = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbnonmember = New System.Windows.Forms.CheckBox()
        Me.cbmember = New System.Windows.Forms.CheckBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Pemesanan Tiket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(419, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Wisata Kolam Renang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Tiket Masuk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 189)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Anak - anak = 15.000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(171, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dewasa = 20.000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 145)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tiket Masuk"
        '
        'rbanak
        '
        Me.rbanak.AutoSize = True
        Me.rbanak.Location = New System.Drawing.Point(451, 183)
        Me.rbanak.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbanak.Name = "rbanak"
        Me.rbanak.Size = New System.Drawing.Size(100, 19)
        Me.rbanak.TabIndex = 6
        Me.rbanak.TabStop = True
        Me.rbanak.Text = "Anak - Anak"
        Me.rbanak.UseVisualStyleBackColor = True
        '
        'rbdewasa
        '
        Me.rbdewasa.AutoSize = True
        Me.rbdewasa.Location = New System.Drawing.Point(453, 222)
        Me.rbdewasa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbdewasa.Name = "rbdewasa"
        Me.rbdewasa.Size = New System.Drawing.Size(76, 19)
        Me.rbdewasa.TabIndex = 7
        Me.rbdewasa.TabStop = True
        Me.rbdewasa.Text = "Dewasa"
        Me.rbdewasa.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(787, 145)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Member"
        '
        'cbnonmember
        '
        Me.cbnonmember.AutoSize = True
        Me.cbnonmember.Location = New System.Drawing.Point(781, 183)
        Me.cbnonmember.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbnonmember.Name = "cbnonmember"
        Me.cbnonmember.Size = New System.Drawing.Size(109, 19)
        Me.cbnonmember.TabIndex = 9
        Me.cbnonmember.Text = "Non Member"
        Me.cbnonmember.UseVisualStyleBackColor = True
        '
        'cbmember
        '
        Me.cbmember.AutoSize = True
        Me.cbmember.Location = New System.Drawing.Point(781, 222)
        Me.cbmember.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbmember.Name = "cbmember"
        Me.cbmember.Size = New System.Drawing.Size(153, 19)
        Me.cbmember.TabIndex = 10
        Me.cbmember.Text = "Member (Disc 10%)"
        Me.cbmember.UseVisualStyleBackColor = True
        '
        'btnhitung
        '
        Me.btnhitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.Location = New System.Drawing.Point(438, 287)
        Me.btnhitung.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(180, 34)
        Me.btnhitung.TabIndex = 11
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(415, 362)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(224, 21)
        Me.txttotal.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(485, 336)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(382, 399)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(283, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Ferdy Pradana Putra 200511032 20C"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(1099, 470)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.cbmember)
        Me.Controls.Add(Me.cbnonmember)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbdewasa)
        Me.Controls.Add(Me.rbanak)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "App Tiket Kolam Renang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbanak As RadioButton
    Friend WithEvents rbdewasa As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents cbnonmember As CheckBox
    Friend WithEvents cbmember As CheckBox
    Friend WithEvents btnhitung As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
