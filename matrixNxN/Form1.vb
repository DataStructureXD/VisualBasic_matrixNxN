Public Class Form1
    Dim filas, columnas As Byte

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnDiagonalPrincipal_Click(sender As Object, e As EventArgs) Handles btnDiagonalPrincipal.Click
        Try
            filas = Val(txtFilas.Text)
            columnas = Val(txtColumnas.Text)


            DGV1.ColumnCount = columnas
            DGV1.RowCount = filas

            DGV1.ColumnHeadersVisible = False
            DGV1.RowHeadersVisible = False

            DGV1(0, 3).Value = 15
            DGV1(1, 2).Value = 15
            DGV1(2, 1).Value = 15
            DGV1(3, 0).Value = 15

        Catch ex As Exception
            MsgBox("Error, Al introducir datos")

        End Try

        




    End Sub

    Private Sub btnSecundaria_Click(sender As Object, e As EventArgs) Handles btnSecundaria.Click
        filas = Val(txtFilas.Text)
        columnas = Val(txtColumnas.Text)

        Try

        DGV1.ColumnCount = columnas
        DGV1.RowCount = filas

        DGV1.ColumnHeadersVisible = False
        DGV1.RowHeadersVisible = False

        DGV1(0, 0).Value = 28
        DGV1(1, 1).Value = 28
        DGV1(2, 2).Value = 28
            DGV1(3, 3).Value = 28
        Catch ex As Exception
            MsgBox("Error, Al introducir datos")

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DGV1.Rows.Clear()

    End Sub
End Class
