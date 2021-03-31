<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcod_prod = New System.Windows.Forms.TextBox()
        Me.txtcod_client = New System.Windows.Forms.TextBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.cmdinsetar = New System.Windows.Forms.Button()
        Me.cmdactualizar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdlimpiar = New System.Windows.Forms.Button()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.código_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.código_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formulario compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código_Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código_Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Producto"
        '
        'txtcod_prod
        '
        Me.txtcod_prod.Location = New System.Drawing.Point(207, 85)
        Me.txtcod_prod.Name = "txtcod_prod"
        Me.txtcod_prod.Size = New System.Drawing.Size(142, 22)
        Me.txtcod_prod.TabIndex = 4
        '
        'txtcod_client
        '
        Me.txtcod_client.Location = New System.Drawing.Point(207, 127)
        Me.txtcod_client.Name = "txtcod_client"
        Me.txtcod_client.Size = New System.Drawing.Size(142, 22)
        Me.txtcod_client.TabIndex = 5
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(147, 167)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(202, 22)
        Me.txtproducto.TabIndex = 6
        '
        'cmdinsetar
        '
        Me.cmdinsetar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdinsetar.Location = New System.Drawing.Point(30, 221)
        Me.cmdinsetar.Name = "cmdinsetar"
        Me.cmdinsetar.Size = New System.Drawing.Size(97, 35)
        Me.cmdinsetar.TabIndex = 7
        Me.cmdinsetar.Text = "Insertar"
        Me.cmdinsetar.UseVisualStyleBackColor = True
        '
        'cmdactualizar
        '
        Me.cmdactualizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdactualizar.Location = New System.Drawing.Point(147, 221)
        Me.cmdactualizar.Name = "cmdactualizar"
        Me.cmdactualizar.Size = New System.Drawing.Size(116, 35)
        Me.cmdactualizar.TabIndex = 8
        Me.cmdactualizar.Text = "Actualizar"
        Me.cmdactualizar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdeliminar.Location = New System.Drawing.Point(279, 221)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(103, 35)
        Me.cmdeliminar.TabIndex = 9
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdlimpiar
        '
        Me.cmdlimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlimpiar.Location = New System.Drawing.Point(403, 221)
        Me.cmdlimpiar.Name = "cmdlimpiar"
        Me.cmdlimpiar.Size = New System.Drawing.Size(93, 35)
        Me.cmdlimpiar.TabIndex = 10
        Me.cmdlimpiar.Text = "Limpiar"
        Me.cmdlimpiar.UseVisualStyleBackColor = True
        '
        'cmdsalir
        '
        Me.cmdsalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsalir.Location = New System.Drawing.Point(516, 221)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(76, 35)
        Me.cmdsalir.TabIndex = 11
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.código_Producto, Me.código_Cliente, Me.Producto})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 281)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(562, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'código_Producto
        '
        Me.código_Producto.DataPropertyName = "código_Producto"
        Me.código_Producto.HeaderText = "código_Producto"
        Me.código_Producto.Name = "código_Producto"
        Me.código_Producto.ReadOnly = True
        Me.código_Producto.Width = 150
        '
        'código_Cliente
        '
        Me.código_Cliente.DataPropertyName = "código_Cliente"
        Me.código_Cliente.HeaderText = "código_Cliente"
        Me.código_Cliente.Name = "código_Cliente"
        Me.código_Cliente.ReadOnly = True
        Me.código_Cliente.Width = 150
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 484)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdlimpiar)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdactualizar)
        Me.Controls.Add(Me.cmdinsetar)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.txtcod_client)
        Me.Controls.Add(Me.txtcod_prod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Compra "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcod_prod As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_client As System.Windows.Forms.TextBox
    Friend WithEvents txtproducto As System.Windows.Forms.TextBox
    Friend WithEvents cmdinsetar As System.Windows.Forms.Button
    Friend WithEvents cmdactualizar As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdlimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdsalir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents código_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents código_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
