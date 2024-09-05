<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAutor
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
        lblAgregarAutor = New Label()
        btnAnadir = New Button()
        btnCancelar = New Button()
        Label1 = New Label()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        Label2 = New Label()
        txtSeudo = New TextBox()
        Label3 = New Label()
        txtNac = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblAgregarAutor
        ' 
        lblAgregarAutor.AutoSize = True
        lblAgregarAutor.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAgregarAutor.Location = New Point(95, 32)
        lblAgregarAutor.Name = "lblAgregarAutor"
        lblAgregarAutor.Size = New Size(155, 30)
        lblAgregarAutor.TabIndex = 13
        lblAgregarAutor.Text = "Agregar Autor"
        ' 
        ' btnAnadir
        ' 
        btnAnadir.Location = New Point(84, 372)
        btnAnadir.Name = "btnAnadir"
        btnAnadir.Size = New Size(75, 23)
        btnAnadir.TabIndex = 15
        btnAnadir.Text = "Agregar"
        btnAnadir.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(208, 372)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 14
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 16
        Label1.Text = "Nombre:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(183, 109)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 17
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(183, 165)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 18
        Label2.Text = "Apellido:"
        ' 
        ' txtSeudo
        ' 
        txtSeudo.Location = New Point(183, 223)
        txtSeudo.Name = "txtSeudo"
        txtSeudo.Size = New Size(100, 23)
        txtSeudo.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 20
        Label3.Text = "Seudónimo:"
        ' 
        ' txtNac
        ' 
        txtNac.Location = New Point(183, 282)
        txtNac.Name = "txtNac"
        txtNac.Size = New Size(100, 23)
        txtNac.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(73, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 22
        Label4.Text = "Nacionalidad:"
        ' 
        ' AgregarAutor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(366, 444)
        Controls.Add(txtNac)
        Controls.Add(Label4)
        Controls.Add(txtSeudo)
        Controls.Add(Label3)
        Controls.Add(txtApellido)
        Controls.Add(Label2)
        Controls.Add(txtNombre)
        Controls.Add(Label1)
        Controls.Add(btnAnadir)
        Controls.Add(btnCancelar)
        Controls.Add(lblAgregarAutor)
        Name = "AgregarAutor"
        Text = "AgregarAutor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAgregarAutor As Label
    Friend WithEvents btnAnadir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSeudo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNac As TextBox
    Friend WithEvents Label4 As Label
End Class
