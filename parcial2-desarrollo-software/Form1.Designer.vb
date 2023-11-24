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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdFemenino = New System.Windows.Forms.RadioButton()
        Me.rdMasculino = New System.Windows.Forms.RadioButton()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.comboTipo)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'comboTipo
        '
        Me.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Location = New System.Drawing.Point(115, 179)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(257, 21)
        Me.comboTipo.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdFemenino)
        Me.GroupBox2.Controls.Add(Me.rdMasculino)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 55)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo:"
        '
        'rdFemenino
        '
        Me.rdFemenino.AutoSize = True
        Me.rdFemenino.Checked = True
        Me.rdFemenino.Location = New System.Drawing.Point(6, 19)
        Me.rdFemenino.Name = "rdFemenino"
        Me.rdFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rdFemenino.TabIndex = 3
        Me.rdFemenino.TabStop = True
        Me.rdFemenino.Text = "Femenino"
        Me.rdFemenino.UseVisualStyleBackColor = True
        '
        'rdMasculino
        '
        Me.rdMasculino.AutoSize = True
        Me.rdMasculino.Location = New System.Drawing.Point(110, 19)
        Me.rdMasculino.Name = "rdMasculino"
        Me.rdMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdMasculino.TabIndex = 4
        Me.rdMasculino.Text = "Masculino"
        Me.rdMasculino.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(115, 205)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(257, 20)
        Me.txtSaldo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Saldo: (numero)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(127, 92)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(245, 20)
        Me.txtApellido.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(127, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(245, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(127, 40)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(245, 20)
        Me.txtCuenta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta: (numero)"
        '
        'btInsertar
        '
        Me.btInsertar.Location = New System.Drawing.Point(13, 279)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btInsertar.TabIndex = 7
        Me.btInsertar.Text = "Insertar"
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(127, 279)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 8
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Location = New System.Drawing.Point(237, 278)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btBorrar.TabIndex = 9
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(343, 279)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 10
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(325, 11)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 374)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdFemenino As RadioButton
    Friend WithEvents rdMasculino As RadioButton
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btInsertar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents btnLimpiar As Button
End Class
