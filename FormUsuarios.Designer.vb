<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Label1 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        BtnGuardar = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(365, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 38)
        Label1.TabIndex = 1
        Label1.Text = "USUARIOS"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(19, 107)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(881, 251)
        Panel1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(501, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 13
        Label5.Text = "Password:"
        ' 
        ' TextBox4
        ' 
        TextBox4.AccessibleDescription = ""
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(499, 196)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(360, 34)
        TextBox4.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(500, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 11
        Label6.Text = "Correo:"
        ' 
        ' TextBox5
        ' 
        TextBox5.AccessibleDescription = ""
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(498, 117)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(360, 34)
        TextBox5.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(499, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 20)
        Label7.TabIndex = 9
        Label7.Text = "Nombre:"
        ' 
        ' TextBox6
        ' 
        TextBox6.AccessibleDescription = ""
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox6.Location = New Point(497, 41)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(360, 34)
        TextBox6.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 7
        Label4.Text = "Password:"
        ' 
        ' TextBox3
        ' 
        TextBox3.AccessibleDescription = ""
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(28, 196)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(360, 34)
        TextBox3.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 5
        Label3.Text = "Correo:"
        ' 
        ' TextBox2
        ' 
        TextBox2.AccessibleDescription = ""
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(27, 117)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(360, 34)
        TextBox2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nombre:"
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleDescription = ""
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(26, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(360, 34)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(693, 395)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 40)
        Button1.TabIndex = 5
        Button1.Text = "CANCELAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = Color.Goldenrod
        BtnGuardar.FlatAppearance.BorderSize = 0
        BtnGuardar.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        BtnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        BtnGuardar.FlatStyle = FlatStyle.Flat
        BtnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnGuardar.ForeColor = SystemColors.ButtonHighlight
        BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BtnGuardar.Location = New Point(493, 395)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(184, 40)
        BtnGuardar.TabIndex = 4
        BtnGuardar.Text = "ACEPTAR"
        BtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' FormUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 513)
        Controls.Add(Button1)
        Controls.Add(BtnGuardar)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "FormUsuarios"
        Text = "Usuarios"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnGuardar As Button
End Class
