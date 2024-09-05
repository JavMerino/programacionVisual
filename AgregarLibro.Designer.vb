<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarLibro
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTitulo = New TextBox()
        nudCantidad = New NumericUpDown()
        cbEstado = New ComboBox()
        cbEditorial = New ComboBox()
        cbCategoria = New ComboBox()
        btnCancelar = New Button()
        btnAgregar = New Button()
        lblAgregarLibro = New Label()
        lblAutor = New Label()
        txtAutor = New TextBox()
        btnAgregarAutor = New Button()
        lbAutores = New ListBox()
        CType(nudCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(57, 96)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(40, 15)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Título:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 1
        Label1.Text = "Cantidad:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 2
        Label2.Text = "Estado:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 3
        Label3.Text = "Categoría:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 4
        Label4.Text = "Editorial:"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(146, 93)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(130, 23)
        txtTitulo.TabIndex = 5
        ' 
        ' nudCantidad
        ' 
        nudCantidad.Location = New Point(146, 137)
        nudCantidad.Name = "nudCantidad"
        nudCantidad.Size = New Size(130, 23)
        nudCantidad.TabIndex = 6
        ' 
        ' cbEstado
        ' 
        cbEstado.FormattingEnabled = True
        cbEstado.Location = New Point(146, 181)
        cbEstado.Name = "cbEstado"
        cbEstado.Size = New Size(130, 23)
        cbEstado.TabIndex = 7
        ' 
        ' cbEditorial
        ' 
        cbEditorial.FormattingEnabled = True
        cbEditorial.Location = New Point(146, 277)
        cbEditorial.Name = "cbEditorial"
        cbEditorial.Size = New Size(130, 23)
        cbEditorial.TabIndex = 8
        ' 
        ' cbCategoria
        ' 
        cbCategoria.FormattingEnabled = True
        cbCategoria.Location = New Point(146, 229)
        cbCategoria.Name = "cbCategoria"
        cbCategoria.Size = New Size(130, 23)
        cbCategoria.TabIndex = 9
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(226, 490)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 10
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(102, 490)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 23)
        btnAgregar.TabIndex = 11
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' lblAgregarLibro
        ' 
        lblAgregarLibro.AutoSize = True
        lblAgregarLibro.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAgregarLibro.Location = New Point(140, 22)
        lblAgregarLibro.Name = "lblAgregarLibro"
        lblAgregarLibro.Size = New Size(149, 30)
        lblAgregarLibro.TabIndex = 12
        lblAgregarLibro.Text = "Agregar Libro"
        ' 
        ' lblAutor
        ' 
        lblAutor.AutoSize = True
        lblAutor.Location = New Point(57, 329)
        lblAutor.Name = "lblAutor"
        lblAutor.Size = New Size(40, 15)
        lblAutor.TabIndex = 13
        lblAutor.Text = "Autor:"
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(146, 326)
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(130, 23)
        txtAutor.TabIndex = 14
        ' 
        ' btnAgregarAutor
        ' 
        btnAgregarAutor.Location = New Point(307, 326)
        btnAgregarAutor.Name = "btnAgregarAutor"
        btnAgregarAutor.Size = New Size(95, 23)
        btnAgregarAutor.TabIndex = 15
        btnAgregarAutor.Text = "Agregar autor"
        btnAgregarAutor.UseVisualStyleBackColor = True
        ' 
        ' lbAutores
        ' 
        lbAutores.FormattingEnabled = True
        lbAutores.ItemHeight = 15
        lbAutores.Location = New Point(146, 355)
        lbAutores.Name = "lbAutores"
        lbAutores.Size = New Size(130, 94)
        lbAutores.TabIndex = 16
        ' 
        ' AgregarLibro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(512, 567)
        Controls.Add(lbAutores)
        Controls.Add(btnAgregarAutor)
        Controls.Add(txtAutor)
        Controls.Add(lblAutor)
        Controls.Add(lblAgregarLibro)
        Controls.Add(btnAgregar)
        Controls.Add(btnCancelar)
        Controls.Add(cbCategoria)
        Controls.Add(cbEditorial)
        Controls.Add(cbEstado)
        Controls.Add(nudCantidad)
        Controls.Add(txtTitulo)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTitulo)
        Name = "AgregarLibro"
        Text = "AgregarLibro"
        CType(nudCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents cbEditorial As ComboBox
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblAgregarLibro As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents btnAgregarAutor As Button
    Friend WithEvents lbAutores As ListBox
End Class
