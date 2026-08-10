<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHorario
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
        SplitContainer1 = New SplitContainer()
        dgvHorario = New DataGridView()
        Hora = New DataGridViewTextBoxColumn()
        Lunes = New DataGridViewTextBoxColumn()
        Martes = New DataGridViewTextBoxColumn()
        Miércoles = New DataGridViewTextBoxColumn()
        Jueves = New DataGridViewTextBoxColumn()
        Viernes = New DataGridViewTextBoxColumn()
        Sábado = New DataGridViewTextBoxColumn()
        lstMaterias = New ListBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(dgvHorario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(dgvHorario)
        SplitContainer1.Panel1MinSize = 600
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lstMaterias)
        SplitContainer1.Panel2MinSize = 200
        SplitContainer1.Size = New Size(884, 561)
        SplitContainer1.SplitterDistance = 600
        SplitContainer1.TabIndex = 0
        ' 
        ' dgvHorario
        ' 
        dgvHorario.AllowUserToAddRows = False
        dgvHorario.AllowUserToDeleteRows = False
        dgvHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHorario.Columns.AddRange(New DataGridViewColumn() {Hora, Lunes, Martes, Miércoles, Jueves, Viernes, Sábado})
        dgvHorario.Dock = DockStyle.Fill
        dgvHorario.Location = New Point(0, 0)
        dgvHorario.Name = "dgvHorario"
        dgvHorario.ReadOnly = True
        dgvHorario.RowHeadersVisible = False
        dgvHorario.Size = New Size(600, 561)
        dgvHorario.TabIndex = 0
        ' 
        ' Hora
        ' 
        Hora.HeaderText = "Hora"
        Hora.Name = "Hora"
        Hora.ReadOnly = True
        Hora.Width = 90
        ' 
        ' Lunes
        ' 
        Lunes.HeaderText = "Lunes"
        Lunes.Name = "Lunes"
        Lunes.ReadOnly = True
        ' 
        ' Martes
        ' 
        Martes.HeaderText = "Martes"
        Martes.Name = "Martes"
        Martes.ReadOnly = True
        ' 
        ' Miércoles
        ' 
        Miércoles.HeaderText = "Miércoles"
        Miércoles.Name = "Miércoles"
        Miércoles.ReadOnly = True
        ' 
        ' Jueves
        ' 
        Jueves.HeaderText = "Jueves"
        Jueves.Name = "Jueves"
        Jueves.ReadOnly = True
        ' 
        ' Viernes
        ' 
        Viernes.HeaderText = "Viernes"
        Viernes.Name = "Viernes"
        Viernes.ReadOnly = True
        ' 
        ' Sábado
        ' 
        Sábado.HeaderText = "Sábado"
        Sábado.Name = "Sábado"
        Sábado.ReadOnly = True
        ' 
        ' lstMaterias
        ' 
        lstMaterias.Dock = DockStyle.Fill
        lstMaterias.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstMaterias.FormattingEnabled = True
        lstMaterias.Location = New Point(0, 0)
        lstMaterias.Name = "lstMaterias"
        lstMaterias.Size = New Size(280, 561)
        lstMaterias.TabIndex = 0
        ' 
        ' FormHorario
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(SplitContainer1)
        Name = "FormHorario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Diseñador de Horarios"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(dgvHorario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvHorario As DataGridView
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Lunes As DataGridViewTextBoxColumn
    Friend WithEvents Martes As DataGridViewTextBoxColumn
    Friend WithEvents Miércoles As DataGridViewTextBoxColumn
    Friend WithEvents Jueves As DataGridViewTextBoxColumn
    Friend WithEvents Viernes As DataGridViewTextBoxColumn
    Friend WithEvents Sábado As DataGridViewTextBoxColumn
    Friend WithEvents lstMaterias As ListBox
End Class
