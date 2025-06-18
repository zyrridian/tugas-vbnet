Imports MySql.Data.MySqlClient

Module ModuleConnection
    ' Konfigurasi koneksi database
    Private Const SERVER As String = "localhost"
    Private Const PORT As String = "3306"
    Private Const DATABASE As String = "db_rental_mobil"
    Private Const USERNAME As String = "root"
    Private Const PASSWORD As String = ""
    
    ' Variable untuk menyimpan koneksi
    Private connection As MySqlConnection = Nothing
    
    ' Method untuk membuat koneksi string
    Private Function GetConnectionString() As String
        Return String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", SERVER, PORT, DATABASE, USERNAME, PASSWORD)
    End Function
    
    ' Method untuk membuka koneksi ke database
    Public Function OpenConnection() As MySqlConnection
        Try
            ' Jika koneksi belum ada atau tertutup, buat koneksi baru
            If connection Is Nothing OrElse connection.State = Data.ConnectionState.Closed Then
                connection = New MySqlConnection(GetConnectionString())
                connection.Open()
            End If
            
            Return connection
        Catch ex As Exception
            ' Tampilkan error di console (bisa diganti dengan log file)
            Console.WriteLine("Error connecting to database: " & ex.Message)
            Throw
        End Try
    End Function
    
    ' Method untuk menutup koneksi database
    Public Sub CloseConnection()
        Try
            If connection IsNot Nothing AndAlso connection.State = Data.ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            ' Tampilkan error di console (bisa diganti dengan log file)
            Console.WriteLine("Error closing database connection: " & ex.Message)
        End Try
    End Sub
    
    ' Method untuk menjalankan query SELECT dan mengembalikan DataTable
    Public Function ExecuteQuery(ByVal query As String, Optional ByVal parameters As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim result As New DataTable()
        
        Try
            Using conn As MySqlConnection = OpenConnection()
                Using cmd As New MySqlCommand(query, conn)
                    ' Tambahkan parameter jika ada
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If
                    
                    ' Jalankan query dan isi DataTable
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(result)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Tampilkan error di console (bisa diganti dengan log file)
            Console.WriteLine("Error executing query: " & ex.Message)
            Throw
        End Try
        
        Return result
    End Function
    
    ' Method untuk menjalankan query INSERT, UPDATE, DELETE
    Public Function ExecuteNonQuery(ByVal query As String, Optional ByVal parameters As Dictionary(Of String, Object) = Nothing) As Integer
        Dim rowsAffected As Integer = 0
        
        Try
            Using conn As MySqlConnection = OpenConnection()
                Using cmd As New MySqlCommand(query, conn)
                    ' Tambahkan parameter jika ada
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If
                    
                    ' Jalankan query dan dapatkan jumlah baris yang terpengaruh
                    rowsAffected = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Tampilkan error di console (bisa diganti dengan log file)
            Console.WriteLine("Error executing non-query: " & ex.Message)
            Throw
        End Try
        
        Return rowsAffected
    End Function
    
    ' Method untuk menjalankan query dan mengembalikan nilai tunggal
    Public Function ExecuteScalar(ByVal query As String, Optional ByVal parameters As Dictionary(Of String, Object) = Nothing) As Object
        Dim result As Object = Nothing
        
        Try
            Using conn As MySqlConnection = OpenConnection()
                Using cmd As New MySqlCommand(query, conn)
                    ' Tambahkan parameter jika ada
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If
                    
                    ' Jalankan query dan dapatkan nilai
                    result = cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            ' Tampilkan error di console (bisa diganti dengan log file)
            Console.WriteLine("Error executing scalar: " & ex.Message)
            Throw
        End Try
        
        Return result
    End Function
    
    ' Method untuk mendapatkan ID terakhir yang diinsert
    Public Function GetLastInsertedId() As Integer
        Dim result As Integer = 0
        
        Try
            result = CInt(ExecuteScalar("SELECT LAST_INSERT_ID()"))
        Catch ex As Exception
            ' Tampilkan error di console (bisa diganti dengan log file)
            Console.WriteLine("Error getting last inserted ID: " & ex.Message)
        End Try
        
        Return result
    End Function
End Module