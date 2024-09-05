<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class regPrestamo
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
        Label1 = New Label()
        Label2 = New Label()
        txtCU = New TextBox()
        lblNombre = New Label()
        Label5 = New Label()
        txtPrestamo = New TextBox()
        Label6 = New Label()
        txtLimite = New TextBox()
        Label7 = New Label()
        btnRegistrar = New Button()
        btnNuevo = New Button()
        Label3 = New Label()
        cboxCant = New ComboBox()
        txtLibro = New TextBox()
        btnBuscarLector = New Button()
        btnBuscarLibro = New Button()
        lblTitulo1 = New Label()
        lblTitulo2 = New Label()
        lblTitulo3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 30)
        Label1.TabIndex = 0
        Label1.Text = "Registro de Prestamos de Libros"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(74, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 1
        Label2.Text = "Codigo"
        ' 
        ' txtCU
        ' 
        txtCU.BackColor = SystemColors.Window
        txtCU.Location = New Point(154, 72)
        txtCU.Name = "txtCU"
        txtCU.Size = New Size(236, 25)
        txtCU.TabIndex = 2
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(62, 123)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(134, 20)
        lblNombre.TabIndex = 3
        lblNombre.Text = "Nombre y Apellidos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(31, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 20)
        Label5.TabIndex = 5
        Label5.Text = "Fecha Prestamo"
        ' 
        ' txtPrestamo
        ' 
        txtPrestamo.Location = New Point(154, 170)
        txtPrestamo.Name = "txtPrestamo"
        txtPrestamo.Size = New Size(236, 25)
        txtPrestamo.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(43, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 20)
        Label6.TabIndex = 7
        Label6.Text = "Fecha Limite"
        ' 
        ' txtLimite
        ' 
        txtLimite.Location = New Point(154, 207)
        txtLimite.Name = "txtLimite"
        txtLimite.Size = New Size(236, 25)
        txtLimite.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(74, 316)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 20)
        Label7.TabIndex = 9
        Label7.Text = "Libro"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(264, 496)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(106, 35)
        btnRegistrar.TabIndex = 11
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(62, 496)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(106, 35)
        btnNuevo.TabIndex = 12
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(62, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 13
        Label3.Text = "Cantidad"
        ' 
        ' cboxCant
        ' 
        cboxCant.FormattingEnabled = True
        cboxCant.Location = New Point(154, 267)
        cboxCant.Name = "cboxCant"
        cboxCant.Size = New Size(52, 25)
        cboxCant.TabIndex = 14
        ' 
        ' txtLibro
        ' 
        txtLibro.BackColor = SystemColors.Window
        txtLibro.Location = New Point(154, 311)
        txtLibro.Name = "txtLibro"
        txtLibro.Size = New Size(236, 25)
        txtLibro.TabIndex = 15
        ' 
        ' btnBuscarLector
        ' 
        btnBuscarLector.Location = New Point(315, 103)
        btnBuscarLector.Name = "btnBuscarLector"
        btnBuscarLector.Size = New Size(75, 23)
        btnBuscarLector.TabIndex = 16
        btnBuscarLector.Text = "Buscar"
        btnBuscarLector.UseVisualStyleBackColor = True
        ' 
        ' btnBuscarLibro
        ' 
        btnBuscarLibro.Location = New Point(315, 342)
        btnBuscarLibro.Name = "btnBuscarLibro"
        btnBuscarLibro.Size = New Size(75, 23)
        btnBuscarLibro.TabIndex = 17
        btnBuscarLibro.Text = "Buscar"
        btnBuscarLibro.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo1
        ' 
        lblTitulo1.AutoSize = True
        lblTitulo1.Location = New Point(125, 387)
        lblTitulo1.Name = "lblTitulo1"
        lblTitulo1.Size = New Size(43, 17)
        lblTitulo1.TabIndex = 18
        lblTitulo1.Text = "-------"
        ' 
        ' lblTitulo2
        ' 
        lblTitulo2.AutoSize = True
        lblTitulo2.Location = New Point(125, 420)
        lblTitulo2.Name = "lblTitulo2"
        lblTitulo2.Size = New Size(43, 17)
        lblTitulo2.TabIndex = 19
        lblTitulo2.Text = "-------"
        ' 
        ' lblTitulo3
        ' 
        lblTitulo3.AutoSize = True
        lblTitulo3.Location = New Point(125, 456)
        lblTitulo3.Name = "lblTitulo3"
        lblTitulo3.Size = New Size(43, 17)
        lblTitulo3.TabIndex = 20
        lblTitulo3.Text = "-------"
        ' 
        ' regPrestamo
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(406, 546)
        Controls.Add(lblTitulo3)
        Controls.Add(lblTitulo2)
        Controls.Add(lblTitulo1)
        Controls.Add(btnBuscarLibro)
        Controls.Add(btnBuscarLector)
        Controls.Add(txtLibro)
        Controls.Add(cboxCant)
        Controls.Add(Label3)
        Controls.Add(btnNuevo)
        Controls.Add(btnRegistrar)
        Controls.Add(Label7)
        Controls.Add(txtLimite)
        Controls.Add(Label6)
        Controls.Add(txtPrestamo)
        Controls.Add(Label5)
        Controls.Add(lblNombre)
        Controls.Add(txtCU)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "regPrestamo"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCU As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrestamo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLimite As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxCant As ComboBox
    Friend WithEvents txtLibro As TextBox
    Friend WithEvents btnBuscarLector As Button
    Friend WithEvents btnBuscarLibro As Button
    Friend WithEvents lblTitulo1 As Label
    Friend WithEvents lblTitulo2 As Label
    Friend WithEvents lblTitulo3 As Label

End Class
