<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        lblTitulo = New Label()
        lblUsuario = New Label()
        txtUsuario = New TextBox()
        lblContraseña = New Label()
        txtContraseña = New TextBox()
        lblCarrera = New Label()
        cmbCarrera = New ComboBox()
        btnLoguin = New Button()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(120, 30)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(144, 30)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Iniciar Sesión"
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsuario.Location = New Point(65, 108)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(67, 20)
        lblUsuario.TabIndex = 1
        lblUsuario.Text = "Usuario:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(140, 97)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(250, 35)
        txtUsuario.TabIndex = 2
        ' 
        ' lblContraseña
        ' 
        lblContraseña.AutoSize = True
        lblContraseña.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContraseña.Location = New Point(40, 150)
        lblContraseña.Name = "lblContraseña"
        lblContraseña.Size = New Size(92, 20)
        lblContraseña.TabIndex = 3
        lblContraseña.Text = "Contraseña:"
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(140, 147)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(250, 35)
        txtContraseña.TabIndex = 4
        ' 
        ' lblCarrera
        ' 
        lblCarrera.AutoSize = True
        lblCarrera.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCarrera.Location = New Point(68, 200)
        lblCarrera.Name = "lblCarrera"
        lblCarrera.Size = New Size(64, 20)
        lblCarrera.TabIndex = 5
        lblCarrera.Text = "Carrera:"
        ' 
        ' cmbCarrera
        ' 
        cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCarrera.FormattingEnabled = True
        cmbCarrera.Location = New Point(140, 194)
        cmbCarrera.Name = "cmbCarrera"
        cmbCarrera.Size = New Size(250, 38)
        cmbCarrera.TabIndex = 6
        ' 
        ' btnLoguin
        ' 
        btnLoguin.BackColor = Color.DarkGoldenrod
        btnLoguin.FlatStyle = FlatStyle.Flat
        btnLoguin.ForeColor = SystemColors.ControlText
        btnLoguin.Location = New Point(140, 280)
        btnLoguin.Name = "btnLoguin"
        btnLoguin.Size = New Size(120, 40)
        btnLoguin.TabIndex = 7
        btnLoguin.Text = "Ingresar"
        btnLoguin.UseVisualStyleBackColor = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 361)
        Controls.Add(btnLoguin)
        Controls.Add(cmbCarrera)
        Controls.Add(lblCarrera)
        Controls.Add(txtContraseña)
        Controls.Add(lblContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(lblUsuario)
        Controls.Add(lblTitulo)
        Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(6, 6, 6, 6)
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "🔐 Iniciar Sesión"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblCarrera As Label
    Friend WithEvents cmbCarrera As ComboBox
    Friend WithEvents btnLoguin As Button
End Class
