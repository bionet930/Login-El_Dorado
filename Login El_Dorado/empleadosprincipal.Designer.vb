﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleadosprincipal
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
        Me.btnregistroempl = New System.Windows.Forms.Button()
        Me.pnlpempl = New System.Windows.Forms.Panel()
        Me.panelprincipal = New System.Windows.Forms.Panel()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpCarnet = New System.Windows.Forms.DateTimePicker()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opfdempleados = New System.Windows.Forms.OpenFileDialog()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.pnlpempl.SuspendLayout()
        Me.panelprincipal.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnregistroempl
        '
        Me.btnregistroempl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistroempl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnregistroempl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnregistroempl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistroempl.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistroempl.Location = New System.Drawing.Point(494, 32)
        Me.btnregistroempl.Name = "btnregistroempl"
        Me.btnregistroempl.Size = New System.Drawing.Size(75, 51)
        Me.btnregistroempl.TabIndex = 1
        Me.btnregistroempl.Text = "Registro de Empleados"
        Me.btnregistroempl.UseVisualStyleBackColor = True
        '
        'pnlpempl
        '
        Me.pnlpempl.Controls.Add(Me.panelprincipal)
        Me.pnlpempl.Controls.Add(Me.GroupBox1)
        Me.pnlpempl.Controls.Add(Me.btnregistroempl)
        Me.pnlpempl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlpempl.Location = New System.Drawing.Point(0, 0)
        Me.pnlpempl.Name = "pnlpempl"
        Me.pnlpempl.Size = New System.Drawing.Size(1033, 613)
        Me.pnlpempl.TabIndex = 4
        '
        'panelprincipal
        '
        Me.panelprincipal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.panelprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprincipal.Controls.Add(Me.dgvEmpleados)
        Me.panelprincipal.Controls.Add(Me.GroupBox4)
        Me.panelprincipal.Controls.Add(Me.GroupBox3)
        Me.panelprincipal.Controls.Add(Me.txtPass)
        Me.panelprincipal.Controls.Add(Me.GroupBox2)
        Me.panelprincipal.Controls.Add(Me.Label8)
        Me.panelprincipal.Controls.Add(Me.txtImagen)
        Me.panelprincipal.Controls.Add(Me.Label7)
        Me.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelprincipal.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelprincipal.Location = New System.Drawing.Point(0, 0)
        Me.panelprincipal.Name = "panelprincipal"
        Me.panelprincipal.Size = New System.Drawing.Size(1033, 613)
        Me.panelprincipal.TabIndex = 4
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(37, 344)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(616, 150)
        Me.dgvEmpleados.TabIndex = 21
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnnuevo)
        Me.GroupBox4.Controls.Add(Me.btnIngresar)
        Me.GroupBox4.Controls.Add(Me.btnEliminar)
        Me.GroupBox4.Controls.Add(Me.btnModificar)
        Me.GroupBox4.Controls.Add(Me.btnCerrar)
        Me.GroupBox4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(334, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 202)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones Empleado"
        '
        'btnIngresar
        '
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(17, 25)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(161, 29)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "&Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(17, 127)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(161, 26)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(17, 95)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(161, 26)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(17, 160)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(161, 25)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.avatar)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.btnImagen)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(558, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 208)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones Foto"
        Me.GroupBox3.Visible = False
        '
        'avatar
        '
        Me.avatar.Location = New System.Drawing.Point(54, 25)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(112, 135)
        Me.avatar.TabIndex = 12
        Me.avatar.TabStop = False
        Me.avatar.Visible = False
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(113, 166)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(101, 36)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Eliminar Imagen"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'btnImagen
        '
        Me.btnImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImagen.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagen.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.Location = New System.Drawing.Point(6, 166)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(101, 36)
        Me.btnImagen.TabIndex = 7
        Me.btnImagen.Text = "Seleccionar Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        Me.btnImagen.Visible = False
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(605, 292)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(148, 23)
        Me.txtPass.TabIndex = 27
        Me.txtPass.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpCarnet)
        Me.GroupBox2.Controls.Add(Me.dtpNacimiento)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.txtEdad)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 265)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Empleados"
        '
        'dtpCarnet
        '
        Me.dtpCarnet.AccessibleDescription = "Ingresar Fecha"
        Me.dtpCarnet.AllowDrop = True
        Me.dtpCarnet.CustomFormat = "yyyy-MM-dd"
        Me.dtpCarnet.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCarnet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCarnet.Location = New System.Drawing.Point(140, 226)
        Me.dtpCarnet.MaxDate = New Date(2098, 12, 31, 0, 0, 0, 0)
        Me.dtpCarnet.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpCarnet.Name = "dtpCarnet"
        Me.dtpCarnet.Size = New System.Drawing.Size(147, 23)
        Me.dtpCarnet.TabIndex = 31
        Me.dtpCarnet.Value = New Date(2020, 10, 11, 0, 0, 0, 0)
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.AccessibleDescription = "Ingresar Fecha"
        Me.dtpNacimiento.AllowDrop = True
        Me.dtpNacimiento.CustomFormat = "yyyy-MM-dd"
        Me.dtpNacimiento.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNacimiento.Location = New System.Drawing.Point(139, 101)
        Me.dtpNacimiento.MaxDate = New Date(2098, 12, 31, 0, 0, 0, 0)
        Me.dtpNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(147, 23)
        Me.dtpNacimiento.TabIndex = 30
        Me.dtpNacimiento.Value = New Date(2020, 10, 11, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Fecha Nac."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Vto. Carnet"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(140, 194)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(148, 23)
        Me.txtDireccion.TabIndex = 21
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(140, 166)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 23)
        Me.txtTelefono.TabIndex = 20
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(139, 135)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(66, 23)
        Me.txtEdad.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(140, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(141, 23)
        Me.txtNombre.TabIndex = 18
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(140, 45)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(141, 23)
        Me.txtId.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre y Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID-Empleados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(510, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "xxx pass"
        Me.Label8.Visible = False
        '
        'txtImagen
        '
        Me.txtImagen.Enabled = False
        Me.txtImagen.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagen.Location = New System.Drawing.Point(606, 260)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(148, 23)
        Me.txtImagen.TabIndex = 25
        Me.txtImagen.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(511, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "xxx  imagen"
        Me.Label7.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(71, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 306)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'opfdempleados
        '
        Me.opfdempleados.FileName = "OpenFileDialog1"
        '
        'btnnuevo
        '
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(17, 61)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(161, 26)
        Me.btnnuevo.TabIndex = 7
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'empleadosprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 613)
        Me.Controls.Add(Me.pnlpempl)
        Me.Name = "empleadosprincipal"
        Me.pnlpempl.ResumeLayout(False)
        Me.panelprincipal.ResumeLayout(False)
        Me.panelprincipal.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnregistroempl As System.Windows.Forms.Button
    Friend WithEvents pnlpempl As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents panelprincipal As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnImagen As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents avatar As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtImagen As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents opfdempleados As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCarnet As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
End Class
