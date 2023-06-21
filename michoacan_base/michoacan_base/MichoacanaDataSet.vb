Partial Class MichoacanaDataSet
    Partial Public Class ProductoDataTable
        Private Sub ProductoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Num_vend1Column.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace MichoacanaDataSetTableAdapters
    Partial Public Class detallefacturaTableAdapter
    End Class

    Partial Public Class ProductoTableAdapter
    End Class

    Partial Public Class detalleticketTableAdapter
    End Class
End Namespace
