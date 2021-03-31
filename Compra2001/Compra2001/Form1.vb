Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        mostrardatos()

    End Sub
    Sub mostrardatos()
        Dim Dt As New DataTable
        Dim Da As New SqlDataAdapter("select * from compras", con)
        Da.Fill(Dt)
        DataGridView1.DataSource = Dt
    End Sub

    Private Sub cmdinsetar_Click(sender As Object, e As EventArgs) Handles cmdinsetar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into compras (Código_Cliente, Producto) values (@Código_Cliente, @Producto)"
            cmd.Parameters.AddWithValue("@Código_Cliente", txtcod_client.Text)
            cmd.Parameters.AddWithValue("@Producto", txtproducto.Text)
            cmd.ExecuteNonQuery()
            Dim filas As Integer
            If filas > 0 Then
                MessageBox.Show("los datos se han guardado con exito", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub cmdactualizar_Click(sender As Object, e As EventArgs) Handles cmdactualizar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "update compras set código_cliente= '" & txtcod_client.Text & "', Producto= '" & txtproducto.Text & "' where código_Producto = '" & txtcod_prod.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("datos guardados")
            mostrardatos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Evento rowheadermouseclick

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        If DataGridView1.RowCount > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                txtcod_prod.Text = DataGridView1.SelectedRows(0).Cells("código_Producto").Value
                txtcod_client.Text = DataGridView1.SelectedRows(0).Cells("código_Cliente").Value
                txtproducto.Text = DataGridView1.SelectedRows(0).Cells("Producto").Value
            End If
        End If
    End Sub

    Private Sub cmdlimpiar_Click(sender As Object, e As EventArgs) Handles cmdlimpiar.Click
        txtcod_prod.Clear()
        txtcod_client.Clear()
        txtproducto.Clear()
    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "delete from compras where código_producto = '" & txtcod_prod.Text & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("datos eliminados")
        mostrardatos()
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub
End Class
