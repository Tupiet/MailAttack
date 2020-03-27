<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MyName = New System.Windows.Forms.TextBox()
        Me.EmailAccount = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DestinataryEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumberOfMails = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BodyMail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SubjectMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.MyName)
        Me.GroupBox1.Controls.Add(Me.EmailAccount)
        Me.GroupBox1.Controls.Add(Me.PasswordText)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "DE:"
        '
        'MyName
        '
        Me.MyName.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyName.Location = New System.Drawing.Point(80, 41)
        Me.MyName.Name = "MyName"
        Me.MyName.Size = New System.Drawing.Size(373, 29)
        Me.MyName.TabIndex = 1
        '
        'EmailAccount
        '
        Me.EmailAccount.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAccount.Location = New System.Drawing.Point(80, 80)
        Me.EmailAccount.Name = "EmailAccount"
        Me.EmailAccount.Size = New System.Drawing.Size(373, 29)
        Me.EmailAccount.TabIndex = 1
        '
        'PasswordText
        '
        Me.PasswordText.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordText.Location = New System.Drawing.Point(573, 77)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(285, 29)
        Me.PasswordText.TabIndex = 1
        Me.PasswordText.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(476, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'DestinataryEmail
        '
        Me.DestinataryEmail.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinataryEmail.Location = New System.Drawing.Point(80, 33)
        Me.DestinataryEmail.Name = "DestinataryEmail"
        Me.DestinataryEmail.Size = New System.Drawing.Size(380, 29)
        Me.DestinataryEmail.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox2.Controls.Add(Me.NumberOfMails)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BodyMail)
        Me.GroupBox2.Controls.Add(Me.DestinataryEmail)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.SubjectMail)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 328)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'NumberOfMails
        '
        Me.NumberOfMails.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfMails.Location = New System.Drawing.Point(617, 34)
        Me.NumberOfMails.Name = "NumberOfMails"
        Me.NumberOfMails.Size = New System.Drawing.Size(37, 29)
        Me.NumberOfMails.TabIndex = 7
        Me.NumberOfMails.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(476, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Número de veces:"
        '
        'BodyMail
        '
        Me.BodyMail.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyMail.Location = New System.Drawing.Point(80, 122)
        Me.BodyMail.Multiline = True
        Me.BodyMail.Name = "BodyMail"
        Me.BodyMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.BodyMail.Size = New System.Drawing.Size(612, 182)
        Me.BodyMail.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "PARA:"
        '
        'SubjectMail
        '
        Me.SubjectMail.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectMail.Location = New System.Drawing.Point(80, 79)
        Me.SubjectMail.Name = "SubjectMail"
        Me.SubjectMail.Size = New System.Drawing.Size(380, 29)
        Me.SubjectMail.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(7, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cuerpo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(7, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Asunto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Avenir Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(729, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 145)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(889, 497)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(905, 536)
        Me.MinimumSize = New System.Drawing.Size(905, 536)
        Me.Name = "Form1"
        Me.Text = "Envia correu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DestinataryEmail As TextBox
    Friend WithEvents MyName As TextBox
    Friend WithEvents EmailAccount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents SubjectMail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BodyMail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NumberOfMails As TextBox
    Friend WithEvents Label9 As Label
End Class
