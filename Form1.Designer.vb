<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        PanelBarraTitulo = New Panel()
        PictureBox1 = New PictureBox()
        BtnMaximizar = New Button()
        BtnRestaurar = New Button()
        BtnCerrar = New Button()
        BtnMinimizar = New Button()
        PanelMenu = New Panel()
        PictureBox4 = New PictureBox()
        BtnCalendario = New Button()
        PictureBox3 = New PictureBox()
        BtnUsuarios = New Button()
        PictureBox2 = New PictureBox()
        BtnClientes = New Button()
        BtnMenu = New Button()
        PanelContenedor = New Panel()
        Label1 = New Label()
        PictureInicio = New PictureBox()
        TimerOcultar = New Timer(components)
        TimerMostrar = New Timer(components)
        PanelBarraTitulo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenedor.SuspendLayout()
        CType(PictureInicio, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelBarraTitulo
        ' 
        PanelBarraTitulo.BackColor = Color.Goldenrod
        PanelBarraTitulo.Controls.Add(PictureBox1)
        PanelBarraTitulo.Controls.Add(BtnMaximizar)
        PanelBarraTitulo.Controls.Add(BtnRestaurar)
        PanelBarraTitulo.Controls.Add(BtnCerrar)
        PanelBarraTitulo.Controls.Add(BtnMinimizar)
        PanelBarraTitulo.Dock = DockStyle.Top
        PanelBarraTitulo.Location = New Point(0, 0)
        PanelBarraTitulo.Name = "PanelBarraTitulo"
        PanelBarraTitulo.Size = New Size(1150, 40)
        PanelBarraTitulo.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(7, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 36)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' BtnMaximizar
        ' 
        BtnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnMaximizar.Cursor = Cursors.Hand
        BtnMaximizar.FlatAppearance.BorderSize = 0
        BtnMaximizar.FlatStyle = FlatStyle.Flat
        BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), Image)
        BtnMaximizar.Location = New Point(1013, -2)
        BtnMaximizar.Name = "BtnMaximizar"
        BtnMaximizar.Size = New Size(58, 48)
        BtnMaximizar.TabIndex = 4
        BtnMaximizar.UseVisualStyleBackColor = True
        BtnMaximizar.Visible = False
        ' 
        ' BtnRestaurar
        ' 
        BtnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnRestaurar.Cursor = Cursors.Hand
        BtnRestaurar.FlatAppearance.BorderSize = 0
        BtnRestaurar.FlatStyle = FlatStyle.Flat
        BtnRestaurar.Image = CType(resources.GetObject("BtnRestaurar.Image"), Image)
        BtnRestaurar.Location = New Point(1013, -2)
        BtnRestaurar.Name = "BtnRestaurar"
        BtnRestaurar.Size = New Size(58, 48)
        BtnRestaurar.TabIndex = 3
        BtnRestaurar.UseVisualStyleBackColor = True
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnCerrar.Cursor = Cursors.Hand
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), Image)
        BtnCerrar.Location = New Point(1089, -2)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(58, 48)
        BtnCerrar.TabIndex = 2
        BtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' BtnMinimizar
        ' 
        BtnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnMinimizar.Cursor = Cursors.Hand
        BtnMinimizar.FlatAppearance.BorderSize = 0
        BtnMinimizar.FlatStyle = FlatStyle.Flat
        BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), Image)
        BtnMinimizar.Location = New Point(923, -2)
        BtnMinimizar.Name = "BtnMinimizar"
        BtnMinimizar.Size = New Size(58, 48)
        BtnMinimizar.TabIndex = 1
        BtnMinimizar.UseVisualStyleBackColor = True
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = SystemColors.ControlDarkDark
        PanelMenu.Controls.Add(PictureBox4)
        PanelMenu.Controls.Add(BtnCalendario)
        PanelMenu.Controls.Add(PictureBox3)
        PanelMenu.Controls.Add(BtnUsuarios)
        PanelMenu.Controls.Add(PictureBox2)
        PanelMenu.Controls.Add(BtnClientes)
        PanelMenu.Controls.Add(BtnMenu)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 40)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(220, 560)
        PanelMenu.TabIndex = 4
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Goldenrod
        PictureBox4.Location = New Point(0, 250)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(10, 60)
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' BtnCalendario
        ' 
        BtnCalendario.FlatAppearance.BorderSize = 0
        BtnCalendario.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        BtnCalendario.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        BtnCalendario.FlatStyle = FlatStyle.Flat
        BtnCalendario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCalendario.ForeColor = SystemColors.ButtonFace
        BtnCalendario.Image = CType(resources.GetObject("BtnCalendario.Image"), Image)
        BtnCalendario.ImageAlign = ContentAlignment.MiddleLeft
        BtnCalendario.Location = New Point(7, 250)
        BtnCalendario.Name = "BtnCalendario"
        BtnCalendario.Size = New Size(213, 60)
        BtnCalendario.TabIndex = 5
        BtnCalendario.Text = "Agendar"
        BtnCalendario.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Goldenrod
        PictureBox3.Location = New Point(0, 144)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(10, 60)
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.FlatAppearance.BorderSize = 0
        BtnUsuarios.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        BtnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        BtnUsuarios.FlatStyle = FlatStyle.Flat
        BtnUsuarios.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUsuarios.ForeColor = SystemColors.ButtonFace
        BtnUsuarios.Image = CType(resources.GetObject("BtnUsuarios.Image"), Image)
        BtnUsuarios.ImageAlign = ContentAlignment.MiddleLeft
        BtnUsuarios.Location = New Point(7, 144)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(213, 60)
        BtnUsuarios.TabIndex = 3
        BtnUsuarios.Text = "Usuarios"
        BtnUsuarios.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Goldenrod
        PictureBox2.Location = New Point(0, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(10, 60)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' BtnClientes
        ' 
        BtnClientes.FlatAppearance.BorderSize = 0
        BtnClientes.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        BtnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        BtnClientes.FlatStyle = FlatStyle.Flat
        BtnClientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnClientes.ForeColor = SystemColors.ButtonFace
        BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), Image)
        BtnClientes.ImageAlign = ContentAlignment.MiddleLeft
        BtnClientes.Location = New Point(7, 60)
        BtnClientes.Name = "BtnClientes"
        BtnClientes.Size = New Size(213, 60)
        BtnClientes.TabIndex = 1
        BtnClientes.Text = "Perfil"
        BtnClientes.UseVisualStyleBackColor = True
        ' 
        ' BtnMenu
        ' 
        BtnMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnMenu.Cursor = Cursors.Hand
        BtnMenu.FlatAppearance.BorderSize = 0
        BtnMenu.FlatStyle = FlatStyle.Flat
        BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), Image)
        BtnMenu.Location = New Point(162, 6)
        BtnMenu.Name = "BtnMenu"
        BtnMenu.Size = New Size(58, 48)
        BtnMenu.TabIndex = 0
        BtnMenu.UseVisualStyleBackColor = True
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.White
        PanelContenedor.BackgroundImageLayout = ImageLayout.Center
        PanelContenedor.Controls.Add(Label1)
        PanelContenedor.Controls.Add(PictureInicio)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(220, 40)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(930, 560)
        PanelContenedor.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(227, 371)
        Label1.Name = "Label1"
        Label1.Size = New Size(477, 41)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido al Sistema de Prueba"
        ' 
        ' PictureInicio
        ' 
        PictureInicio.Image = CType(resources.GetObject("PictureInicio.Image"), Image)
        PictureInicio.Location = New Point(372, 218)
        PictureInicio.Name = "PictureInicio"
        PictureInicio.Size = New Size(150, 150)
        PictureInicio.SizeMode = PictureBoxSizeMode.AutoSize
        PictureInicio.TabIndex = 0
        PictureInicio.TabStop = False
        ' 
        ' TimerOcultar
        ' 
        ' 
        ' TimerMostrar
        ' 
        ' 
        ' FormPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1150, 600)
        Controls.Add(PanelContenedor)
        Controls.Add(PanelMenu)
        Controls.Add(PanelBarraTitulo)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        Name = "FormPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Diseño Visual Basic"
        PanelBarraTitulo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelContenedor.ResumeLayout(False)
        PanelContenedor.PerformLayout()
        CType(PictureInicio, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents PictureInicio As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BtnCalendario As Button
End Class
