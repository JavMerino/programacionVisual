<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPrincipal
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
        btnRegPrest = New Button()
        btnPrestVigent = New Button()
        btnGestLibros = New Button()
        Label2 = New Label()
        btnHistorial = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(121, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 30)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenido"
        ' 
        ' btnRegPrest
        ' 
        btnRegPrest.Location = New Point(16, 83)
        btnRegPrest.Name = "btnRegPrest"
        btnRegPrest.Size = New Size(153, 194)
        btnRegPrest.TabIndex = 1
        btnRegPrest.Text = "Registrar Prestamo"
        btnRegPrest.UseVisualStyleBackColor = True
        ' 
        ' btnPrestVigent
        ' 
        btnPrestVigent.Location = New Point(194, 83)
        btnPrestVigent.Name = "btnPrestVigent"
        btnPrestVigent.Size = New Size(154, 194)
        btnPrestVigent.TabIndex = 2
        btnPrestVigent.Text = "Prestamos Vigentes"
        btnPrestVigent.UseVisualStyleBackColor = True
        ' 
        ' btnGestLibros
        ' 
        btnGestLibros.Location = New Point(16, 293)
        btnGestLibros.Name = "btnGestLibros"
        btnGestLibros.Size = New Size(154, 194)
        btnGestLibros.TabIndex = 3
        btnGestLibros.Text = "Gestion Libros"
        btnGestLibros.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 17)
        Label2.TabIndex = 4
        ' 
        ' btnHistorial
        ' 
        btnHistorial.Location = New Point(194, 293)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(154, 194)
        btnHistorial.TabIndex = 5
        btnHistorial.Text = "Historial"
        btnHistorial.UseVisualStyleBackColor = True
        ' 
        ' menuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(374, 509)
        Controls.Add(btnHistorial)
        Controls.Add(Label2)
        Controls.Add(btnGestLibros)
        Controls.Add(btnPrestVigent)
        Controls.Add(btnRegPrest)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        Name = "menuPrincipal"
        Text = "menuPrincipal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnGestLibros As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnPrestVigent As Button
    Friend WithEvents btnRegPrest As Button
End Class
