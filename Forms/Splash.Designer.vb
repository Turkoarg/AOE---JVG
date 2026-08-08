<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        lblVersion = New Label()
        progressBar = New ProgressBar()
        lblProgress = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(428, 44)
        Label1.TabIndex = 0
        Label1.Text = "Asistente Organizador Estudiantil  - AEO"
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVersion.Location = New Point(168, 337)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(195, 15)
        lblVersion.TabIndex = 1
        lblVersion.Text = "Versión 0.03 - BETA - Agosto 2026"
        ' 
        ' progressBar
        ' 
        progressBar.Location = New Point(26, 160)
        progressBar.Name = "progressBar"
        progressBar.Size = New Size(402, 30)
        progressBar.Style = ProgressBarStyle.Continuous
        progressBar.TabIndex = 2
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgress.Location = New Point(207, 193)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(26, 17)
        lblProgress.TabIndex = 3
        lblProgress.Text = "0%"
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(484, 361)
        ControlBox = False
        Controls.Add(lblProgress)
        Controls.Add(progressBar)
        Controls.Add(lblVersion)
        Controls.Add(Label1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents lblProgress As Label

End Class
