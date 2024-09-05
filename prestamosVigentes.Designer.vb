<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prestamosVigentes
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        dgvPrestVigent = New DataGridView()
        txtFiltro = New TextBox()
        Label2 = New Label()
        btnEntregar = New Button()
        btnNotificar = New Button()
        ConexionBindingSource = New BindingSource(components)
        CType(dgvPrestVigent, ComponentModel.ISupportInitialize).BeginInit()
        CType(ConexionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 17)
        Label1.TabIndex = 0
        Label1.Text = "Prestamos Vigentes"
        ' 
        ' dgvPrestVigent
        ' 
        dgvPrestVigent.AllowUserToAddRows = False
        dgvPrestVigent.AllowUserToDeleteRows = False
        dgvPrestVigent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrestVigent.Location = New Point(75, 136)
        dgvPrestVigent.Name = "dgvPrestVigent"
        dgvPrestVigent.ReadOnly = True
        dgvPrestVigent.Size = New Size(441, 150)
        dgvPrestVigent.TabIndex = 1
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(110, 78)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(205, 25)
        txtFiltro.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 17)
        Label2.TabIndex = 3
        Label2.Text = "Buscar"
        ' 
        ' btnEntregar
        ' 
        btnEntregar.BackColor = SystemColors.Control
        btnEntregar.Location = New Point(400, 329)
        btnEntregar.Name = "btnEntregar"
        btnEntregar.Size = New Size(96, 37)
        btnEntregar.TabIndex = 4
        btnEntregar.Text = "Entregado"
        btnEntregar.UseVisualStyleBackColor = False
        ' 
        ' btnNotificar
        ' 
        btnNotificar.Location = New Point(274, 329)
        btnNotificar.Name = "btnNotificar"
        btnNotificar.Size = New Size(87, 37)
        btnNotificar.TabIndex = 5
        btnNotificar.Text = "Notificar"
        btnNotificar.UseVisualStyleBackColor = True
        ' 
        ' ConexionBindingSource
        ' 
        ConexionBindingSource.DataSource = GetType(Conexion)
        ' 
        ' prestamosVigentes
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(542, 377)
        Controls.Add(btnNotificar)
        Controls.Add(btnEntregar)
        Controls.Add(Label2)
        Controls.Add(txtFiltro)
        Controls.Add(dgvPrestVigent)
        Controls.Add(Label1)
        Name = "prestamosVigentes"
        Text = "prestamosVigentes"
        CType(dgvPrestVigent, ComponentModel.ISupportInitialize).EndInit()
        CType(ConexionBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPrestVigent As DataGridView
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEntregar As Button
    Friend WithEvents btnNotificar As Button
    Friend WithEvents ConexionBindingSource As BindingSource
End Class
