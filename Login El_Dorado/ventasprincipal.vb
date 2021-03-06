﻿Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Imports System.Data
Imports System.Data.DataRow
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports iTextSharp



Public Class ventasprincipal

    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adt As MySqlDataAdapter
    Public ds As DataSet

    Dim conexion As New MySqlConnection()
    Dim comando As New MySqlCommand()

    Dim consulta As ConexionPablo = New ConexionPablo()

    Dim posicion As Integer

    'Llenar combobox
    Sub llenarCliente()

        cmbClientes.DataSource = consulta.mostrarEnTabla("select * from tblclientes;")
        cmbClientes.DisplayMember = "Id Cliente"
        cmbClientes.ValueMember = "id_Cliente"

    End Sub

    Sub llenarEmpleado()

        cmbEmpleados.DataSource = consulta.mostrarEnTabla("select * from tblempleados;")
        cmbEmpleados.DisplayMember = "Id Empleado"
        cmbEmpleados.ValueMember = "id_Empleado"
    End Sub

    Private Sub ventasprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        consulta.establecerConexion()
        llenarCliente()
        llenarEmpleado()

        ' borra todos los datos de la tabla detalle venta para una nueva venta
        consulta.consultaSinRetorno("TRUNCATE TABLE DETALLEVENTA;")
        nudCantidad.Value = 0

        btnEliminar.Enabled = False
        btnimprimirfac.Enabled = False
        btnIngresarProducto.Enabled = False
        'btnCerrar.Enabled = False
        btnFinalizarVenta.Enabled = False
        cmbClientes.Enabled = False
        txtIdmercaderia.Enabled = False
        nudCantidad.Enabled = False



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        dgvVentas.DataSource = consulta.mostrarEnTabla("Select * from detalleventa;")

      
    End Sub

    Private Sub txtIdmercaderia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdmercaderia.TextChanged


        'Try
        '    dgvVentas.DataSource = consulta.mostrarEnTabla("Select id_Mercaderia,NombreMerc,Descuento,PrecioVenta from tblmercaderia where id_Mercaderia = " & txtIdmercaderia.Text & ";")
        '    lblNombre.Text = dgvVentas.CurrentRow.Cells.Item(1).Value.ToString
        '    lblPrecio.Text = dgvVentas.CurrentRow.Cells.Item(3).Value.ToString
        '    If lblNombre.Text = "" Then
        '        MsgBox("Debe ingresar algun dato. ")
        '        lblNombre.Text = "*"






        '    End If

        'Catch ex As Exception
        '    MsgBox("Debe ingresar algun dato. " & ex.Message)



        'End Try

        If Not txtIdmercaderia.Text.Equals("") Then
            consulta.consultaConRetorno("Select NombreMerc from tblmercaderia where id_Mercaderia = " & txtIdmercaderia.Text & " and EstadoMerc=1;")
            Dim nombre As String = consulta.valorReturn

            consulta.consultaConRetorno("Select PrecioVenta from tblmercaderia where id_Mercaderia = " & txtIdmercaderia.Text & ";")
            Dim precioVenta As Integer = Val(consulta.valorReturn)

            dgvVentas.DataSource = consulta.mostrarEnTabla("Select id_Mercaderia,NombreMerc,Descuento,PrecioVenta from tblmercaderia where id_Mercaderia = " & txtIdmercaderia.Text & " and EstadoMerc=1;")
            lblNombre.Text = nombre
            lblPrecio.Text = precioVenta
        End If





        nudCantidad.Enabled = True
        btnIngresarProducto.Enabled = True

    End Sub

    Private Sub btnIngresarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.Click

        'resta del stock
        'insertar en la tabla detalleventa toda la informacio
        'despues conectar el datagrid a la tabla detalle venta
        'actualizar datos de la tabla

        Dim con As Integer = 1
        Dim fecha As DateTime = Now()
        Dim strf As String


        consulta.consultaSinRetorno("UPDATE `tblmercaderia` SET `Stock`= Stock - '" & nudCantidad.Value & "';")
        

        strf = Format(fecha, "yyy-MM-dd") 'Se da formato a la fecha



        consulta.consultaSinRetorno("INSERT INTO `eldorado`.`detalleventa` (`id_Mercaderia`, `id_Empleado`, `fecha`, `CantidadMerc`, `PrecioVenta`, `id_Cliente`, `NombreMerc`) VALUES ('" & txtIdmercaderia.Text &
                                    "','" & cmbEmpleados.Text &
                                    "','" & strf.ToString &
                                    "','" & nudCantidad.Value &
                                    "', '" & Label8.Text &
                                    "','" & cmbClientes.Text &
                                    "','" & lblNombre.Text & "');")

        If consulta.resultado = 1 Then
            dgvFactura.DataSource = consulta.mostrarEnTabla("Select id_Mercaderia,NombreMerc, CantidadMerc, PrecioVenta  from detalleventa;")
            con = con + 1
        End If



        Dim Total As Single
        Dim Col As Integer = Me.dgvFactura.CurrentCell.ColumnIndex

        For Each row As DataGridViewRow In Me.dgvFactura.Rows
            Total += Val(row.Cells(3).Value)
        Next
        Me.txtTotal.Text = Total.ToString



        'dgvStock.DataSource = consulta.mostrarEnTabla("Select Stock from tblmercaderia where `id_Mercaderia`= '" & txtIdmercaderia.Text & "' ;")

        Dim stock As String
        stock = consulta.consultaConRetorno("Select Stock from tblmercaderia where `id_Mercaderia`= '" & txtIdmercaderia.Text & "' ;")
        Label10.Text = stock

        txtIdmercaderia.Text = ""
        nudCantidad.Value = 0
        btnFinalizarVenta.Enabled = True
        lblPrecio.Text = ""
        lblNombre.Text = ""



       
        
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        'borra el articulo de la tabla detalleventa



        'actualiza la tabla

        If dgvFactura.SelectedCells.Count <> 0 Then




            Dim si As Byte

            si = MsgBox("Desea Eliminar registro?", MsgBoxStyle.YesNo, "Eliminar")


            If si = 6 Then
                consulta.consultaSinRetorno("DELETE FROM DETALLEVENTA WHERE id_Detalle= '" & dgvFactura.CurrentRow.Index.ToString & "'")

                Dim loFila As DataGridViewRow = Me.dgvFactura.CurrentRow()
                dgvFactura.Rows.Remove(loFila)

                MsgBox("Se elimino registro", MsgBoxStyle.OkOnly, "Rgsitro Eliminado")


                Dim Total As Single

                '*************** borrar del total

                For Each row As DataGridViewRow In Me.dgvFactura.Rows
                    Total = ((Total) - (Val(row.Cells(3).Value)))

                Next
                Total = Total * (-1)
                Me.txtTotal.Text = Total.ToString


                '*************** agregar al stock tomando como cantidad a devolver nudCantidad

                Dim cont As String
                Dim resultado As Integer

                cont = consulta.consultaConRetorno("SELECT `Stock` FROM `tblmercaderia` WHERE `id_Mercaderia` = '" & txtIdmercaderia.Text & "'")
                resultado = Val(cont) + nudCantidad.Value


                consulta.consultaSinRetorno(" UPDATE `tblmercaderia` SET `Stock`= '" & resultado & "' where `id_Mercaderia` = '" & txtIdmercaderia.Text & "' ;")


                Dim stock As String
                stock = consulta.consultaConRetorno("Select Stock from tblmercaderia where `id_Mercaderia`= '" & txtIdmercaderia.Text & "' ;")
                Label10.Text = stock


            Else
                MsgBox("No Existen mas productos en el carrito", MsgBoxStyle.Critical, AcceptButton)

            End If
        End If




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizarVenta.Click

        Dim Total As Single
        Dim Col As Integer = Me.dgvFactura.CurrentCell.ColumnIndex

        Dim con As Integer = 1
        Dim fecha As DateTime = Now()
        Dim strf As String


        'borrar del stock

        strf = Format(fecha, "yyy-MM-dd") 'Se da formato a la fecha


        For Each row As DataGridViewRow In Me.dgvFactura.Rows
            Total += Val(row.Cells(3).Value)
        Next
        Me.txtTotal.Text = Total.ToString


        'mensaje para emitir facturas 
        'insertar los datos en la tabla ventas  **pronto**

        consulta.consultaSinRetorno("INSERT INTO `tblventas`(`Id_Ventas`, `id_Empleado`, `fecha`, `PrecioCosto`, `PrecioVenta`, `CantidadMerc`, `id_Cliente`, `EstadoVent`) VALUES ( null,'" & cmbEmpleados.Text & "','" & strf.ToString & "', null ,'" & txtTotal.Text & "', '" & dgvFactura.Item(2, 0).Value() & "' ,'" & cmbClientes.Text & "',null)")


        If consulta.resultado = 1 Then
            MsgBox("Ingresado correctamente", vbOKOnly + vbDefaultButton2, "Mensaje")
            con = con + 1
        End If

        btnEliminar.Enabled = False
        btnIngresarProducto.Enabled = False
        btnimprimirfac.Enabled = True
        txtIdmercaderia.Enabled = False
        nudCantidad.Enabled = False



    End Sub

    Private Sub nudCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCantidad.ValueChanged

        btnEliminar.Enabled = True
        btnimprimirfac.Enabled = False
        btnIngresarProducto.Enabled = True
        btnCerrar.Enabled = True
        btnFinalizarVenta.Enabled = False


        Label8.Text = Val(lblPrecio.Text) * nudCantidad.Value

        'dgvStock.DataSource = consulta.mostrarEnTabla("Select Stock from tblmercaderia where `id_Mercaderia`= '" & txtIdmercaderia.Text & "' ;")

        Dim stock As String
        stock = consulta.consultaConRetorno("Select Stock from tblmercaderia where `id_Mercaderia`= '" & txtIdmercaderia.Text & "' ;")
        Label10.Text = stock




    End Sub

  
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        conexion.Close()
        panelsupprincipal.Show()
    End Sub

    Private Sub btnimprimirfac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirfac.Click
        

        'Imprimir_Factura.Show()
        verificar_venta.Show()



    End Sub

    Private Sub cmbEmpleados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpleados.SelectedIndexChanged

        lblempleado.Text = consulta.consultaConRetorno("Select NombreEmpl from tblempleados where `id_Empleado`= '" & cmbEmpleados.Text & "' ;")

    End Sub

    Private Sub cmbEmpleados_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpleados.SelectionChangeCommitted

        cmbClientes.Enabled = True
        'cmbEmpleados.Enabled = False


    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClientes.SelectedIndexChanged
        'cmbClientes.Enabled = False
        txtIdmercaderia.Enabled = True
        lblcliente.Text = consulta.consultaConRetorno("Select NombreCli from tblclientes where `id_Cliente`= '" & cmbClientes.Text & "' ;")
    End Sub

    Private Sub lblempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblempleado.Click

    End Sub
End Class