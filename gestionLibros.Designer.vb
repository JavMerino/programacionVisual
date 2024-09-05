<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionLibros
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
        lblGestionLibros = New Label()
        lblBuscar = New Label()
        txtBuscar = New TextBox()
        btnAgregarLibro = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        lblFiltrar = New Label()
        cbFiltro = New ComboBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        dgvLibros = New DataGridView()
        StatusStrip1.SuspendLayout()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblGestionLibros
        ' 
        lblGestionLibros.AutoSize = True
        lblGestionLibros.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGestionLibros.Location = New Point(38, 21)
        lblGestionLibros.Name = "lblGestionLibros"
        lblGestionLibros.Size = New Size(184, 30)
        lblGestionLibros.TabIndex = 1
        lblGestionLibros.Text = "Gestión de Libros"
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(42, 95)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(45, 15)
        lblBuscar.TabIndex = 5
        lblBuscar.Text = "Buscar:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(93, 92)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(116, 23)
        txtBuscar.TabIndex = 4
        ' 
        ' btnAgregarLibro
        ' 
        btnAgregarLibro.Location = New Point(570, 100)
        btnAgregarLibro.Name = "btnAgregarLibro"
        btnAgregarLibro.Size = New Size(110, 23)
        btnAgregarLibro.TabIndex = 6
        btnAgregarLibro.Text = "Agregar libro"
        btnAgregarLibro.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 562)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(714, 22)
        StatusStrip1.TabIndex = 7
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(86, 17)
        ToolStripStatusLabel1.Text = "Total de libros: "
        ' 
        ' lblFiltrar
        ' 
        lblFiltrar.AutoSize = True
        lblFiltrar.Location = New Point(255, 95)
        lblFiltrar.Name = "lblFiltrar"
        lblFiltrar.Size = New Size(58, 15)
        lblFiltrar.TabIndex = 8
        lblFiltrar.Text = "Filtrar por"
        ' 
        ' cbFiltro
        ' 
        cbFiltro.FormattingEnabled = True
        cbFiltro.Location = New Point(332, 92)
        cbFiltro.Name = "cbFiltro"
        cbFiltro.Size = New Size(121, 23)
        cbFiltro.TabIndex = 9
        ' 
        ' dgvLibros
        ' 
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(42, 166)
        dgvLibros.Name = "dgvLibros"
        dgvLibros.Size = New Size(638, 356)
        dgvLibros.TabIndex = 10
        ' 
        ' gestionLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(714, 584)
        Controls.Add(dgvLibros)
        Controls.Add(cbFiltro)
        Controls.Add(lblFiltrar)
        Controls.Add(StatusStrip1)
        Controls.Add(btnAgregarLibro)
        Controls.Add(lblBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(lblGestionLibros)
        Name = "gestionLibros"
        Text = "gestionLibros"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGestionLibros As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnAgregarLibro As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblFiltrar As Label
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvLibros As DataGridView
End Class
