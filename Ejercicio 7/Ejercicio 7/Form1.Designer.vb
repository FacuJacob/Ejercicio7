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
        cmdEjecutar = New Button()
        lstVectorA = New ListBox()
        lstVectorB = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 205)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(158, 48)
        cmdEjecutar.TabIndex = 0
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lstVectorA
        ' 
        lstVectorA.FormattingEnabled = True
        lstVectorA.ItemHeight = 15
        lstVectorA.Location = New Point(12, 45)
        lstVectorA.Name = "lstVectorA"
        lstVectorA.Size = New Size(75, 154)
        lstVectorA.TabIndex = 1
        ' 
        ' lstVectorB
        ' 
        lstVectorB.FormattingEnabled = True
        lstVectorB.ItemHeight = 15
        lstVectorB.Location = New Point(92, 45)
        lstVectorB.Name = "lstVectorB"
        lstVectorB.Size = New Size(75, 154)
        lstVectorB.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 3
        Label1.Text = "Vector Inicial"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 4
        Label2.Text = "Vector Nuevo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(213, 271)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstVectorB)
        Controls.Add(lstVectorA)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lstVectorA As ListBox
    Friend WithEvents lstVectorB As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
