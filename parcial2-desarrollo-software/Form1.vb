Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.VisualBasic.Logging

Public Class Form1

    Dim cuenta As Integer
    Dim nombre As String
    Dim apellido As String
    Dim sexo As String
    Dim tipo As String
    Dim saldo As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            conectar()
            Dim tipos As DataTable = GetAll("tipo")
            For Each i In tipos.Rows
                comboTipo.Items.Add(i("tipo"))
            Next
            comboTipo.SelectedIndex = 0
            txtSaldo.Text = "0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub fetch()
        Try
            cuenta = txtCuenta.Text.Trim()
            saldo = txtSaldo.Text.Trim()
        Catch ex As Exception
            cuenta = Nothing
            saldo = Nothing
        End Try
        nombre = txtNombre.Text.Trim()
        apellido = txtApellido.Text.Trim()
        If rdMasculino.Checked Then
            sexo = "M"
        Else
            sexo = "F"
        End If
        tipo = comboTipo.SelectedItem

    End Sub

    Private Sub borrar()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCuenta.Clear()
        rdFemenino.Checked = True
        comboTipo.SelectedIndex = 0
        txtSaldo.Text = "0"
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CloseConnection()
    End Sub

    Private Sub btInsertar_Click(sender As Object, e As EventArgs) Handles btInsertar.Click
        Try
            fetch()
            Dim data As New Dictionary(Of String, Object)
            data.Add("cuenta", cuenta)
            data.Add("nombre", nombre)
            data.Add("apellido", apellido)
            data.Add("sexo", sexo)
            data.Add("tipo", tipo)
            data.Add("saldo", saldo)
            Insert("cuenta", data)
            MessageBox.Show("CUENTA INSERTADA CON ÉXITO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            cuenta = txtCuenta.Text
            Dim where As New Dictionary(Of String, Object)
            where.Add("cuenta", cuenta)
            Dim data As DataRow = GetOne("cuenta", where)
            If data Is Nothing Then
                MessageBox.Show("NO SE ENCONTRÓ LA CUENTA")
                Return
            End If
            txtNombre.Text = data("nombre")
            txtApellido.Text = data("apellido")
            If data("sexo") = "M" Then
                rdMasculino.Checked = True
            Else
                rdFemenino.Checked = True
            End If
            comboTipo.SelectedItem = data("tipo")
            txtSaldo.Text = data("saldo")
            MessageBox.Show("CUENTA ENCONTRADA")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Try
            fetch()
            Dim data As New Dictionary(Of String, Object)
            data.Add("nombre", nombre)
            data.Add("apellido", apellido)
            data.Add("sexo", sexo)
            data.Add("tipo", tipo)
            data.Add("saldo", saldo)
            Dim where As New Dictionary(Of String, Object)
            where.Add("cuenta", cuenta)
            conexion.Update("cuenta", data, where)
            MessageBox.Show("CUENTA ACTUALIZADA CON ÉXITO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Try
            fetch()
            Dim where As New Dictionary(Of String, Object)
            where.Add("cuenta", cuenta)
            Delete("cuenta", where)
            MessageBox.Show("CUENTA ELIMINADA CON ÉXITO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        borrar()
    End Sub
End Class
