Imports System.Data.SqlClient

Module conexion

    'Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moise\source\repos\parcial2-desarrollo-software\parcial2-desarrollo-software\Database1.mdf;Integrated Security=True"
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)
    Sub conectar()
        Try
            connection.Open()
            Console.WriteLine("Conexión exitosa.")
        Catch ex As Exception
            Console.WriteLine("No se pudo conectar a la base de datos. Error: " & ex.Message)
        End Try
    End Sub

    Function GetAll(tableName As String) As DataTable
        Dim command As New SqlCommand($"SELECT * FROM {tableName}", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

    Sub Insert(tableName As String, data As Dictionary(Of String, Object))
        Dim columns As String = String.Join(", ", data.Keys)
        Dim placeholders As String = String.Join(", ", data.Keys.Select(Function(k) "@" & k))
        Dim command As New SqlCommand($"INSERT INTO {tableName} ({columns}) VALUES ({placeholders})", connection)

        For Each item In data
            command.Parameters.AddWithValue("@" & item.Key, item.Value)
        Next

        command.ExecuteNonQuery()
    End Sub

    Sub Update(tableName As String, data As Dictionary(Of String, Object), where As Dictionary(Of String, Object))
        Dim setClause As String = String.Join(", ", data.Keys.Select(Function(k) k & " = @" & k))
        Dim whereClause As String = String.Join(" AND ", where.Keys.Select(Function(k) k & " = @" & k))
        Dim command As New SqlCommand($"UPDATE {tableName} SET {setClause} WHERE {whereClause}", connection)

        For Each item In data
            command.Parameters.AddWithValue("@" & item.Key, item.Value)
        Next

        For Each item In where
            command.Parameters.AddWithValue("@" & item.Key, item.Value)
        Next

        command.ExecuteNonQuery()
    End Sub

    Sub Delete(tableName As String, where As Dictionary(Of String, Object))
        Dim whereClause As String = String.Join(" AND ", where.Keys.Select(Function(k) k & " = @" & k))
        Dim command As New SqlCommand($"DELETE FROM {tableName} WHERE {whereClause}", connection)

        For Each item In where
            command.Parameters.AddWithValue("@" & item.Key, item.Value)
        Next

        command.ExecuteNonQuery()
    End Sub

    Function GetOne(tableName As String, where As Dictionary(Of String, Object)) As DataRow
        Dim whereClause As String = String.Join(" AND ", where.Keys.Select(Function(k) k & " = @" & k))
        Dim command As New SqlCommand($"SELECT * FROM {tableName} WHERE {whereClause}", connection)

        For Each item In where
            command.Parameters.AddWithValue("@" & item.Key, item.Value)
        Next

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return table.Rows(0)
        Else
            Return Nothing
        End If
    End Function


    Sub CloseConnection()
        Try
            connection.Close()
            Console.WriteLine("Conexión cerrada exitosamente.")
        Catch ex As Exception
            Console.WriteLine("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Module
