Imports MySql.Data.MySqlClient
Module DbConnection
    Public Function mySqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=db_bikerental;sslMode=non")
    End Function
    Public con As MySqlConnection = mySqldb()
End Module
