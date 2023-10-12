Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Try

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
