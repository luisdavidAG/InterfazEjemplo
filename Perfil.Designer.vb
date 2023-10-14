<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerfil
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormPerfil))
        Label1 = New Label()
        TextBox1 = New TextBox()
        BtnGuardar = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(406, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 38)
        Label1.TabIndex = 0
        Label1.Text = "PERFIL"
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleDescription = ""
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(323, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Ingresa tu usuario"
        TextBox1.Size = New Size(263, 34)
        TextBox1.TabIndex = 1
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
        BtnGuardar.Location = New Point(323, 224)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(263, 44)
        BtnGuardar.TabIndex = 2
        BtnGuardar.Text = "ACEPTAR"
        BtnGuardar.UseVisualStyleBackColor = False
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
        Button1.Location = New Point(323, 285)
        Button1.Name = "Button1"
        Button1.Size = New Size(263, 44)
        Button1.TabIndex = 3
        Button1.Text = "CANCELAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.AccessibleDescription = ""
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(323, 171)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Ingresa tu contraseña"
        TextBox2.Size = New Size(263, 34)
        TextBox2.TabIndex = 6
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(369, 344)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(178, 20)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "¿Olvidaste tu contraseña?"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkColor = Color.DimGray
        LinkLabel2.Location = New Point(406, 378)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(104, 20)
        LinkLabel2.TabIndex = 8
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Crea tu cuenta"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(269, 111)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(269, 171)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' FormPerfil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 560)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(BtnGuardar)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPerfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "Perfil"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
