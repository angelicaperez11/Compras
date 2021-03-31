Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection
    Public Sub conectar()

        Try
            con.ConnectionString = "Data Source=DESKTOP-JOBK4A5;Initial Catalog=compra2021;Integrated Security=True"
            con.Open()
            MessageBox.Show(con.State.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

End Module
