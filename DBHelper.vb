Imports MySql.Data.MySqlClient

Module DBHelper
    Private ReadOnly connectionString As String = "Server=localhost;Database=event_management;User ID=root;Password=MySQLRootPassword123;Pooling=True;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Public Sub ExecuteQuery(ByVal query As String, ByVal parameters As Dictionary(Of String, Object))
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    command.ExecuteNonQuery()
                End Using
            Catch ex As MySqlException
                Console.WriteLine("Database error: " & ex.Message)
            End Try
        End Using
    End Sub


    Public Function ExecuteScalarQuery(ByVal query As String, ByVal parameters As Dictionary(Of String, Object)) As Object
        Dim result As Object = Nothing
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    result = command.ExecuteScalar()
                End Using
            Catch ex As MySqlException
                Console.WriteLine("Database error: " & ex.Message)
            End Try
        End Using
        Return result
    End Function

    Public Function GetDataTable(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            Catch ex As MySqlException
                Console.WriteLine("Database error: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function


End Module
