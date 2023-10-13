Imports System.Net.Http
Imports System.Text

Class MainWindow

    Private ReadOnly _baseUri As String

    Public Sub New(baseUri As String)
        _baseUri = baseUri
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Try
            MessageBox.Show("Esto es una prueba de una cambio para git.")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Async Function CallWebServiceAsync(jsonData As String) As Task(Of String)
        Using client As New HttpClient()
            client.BaseAddress = New Uri(_baseUri)
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync("ruta_del_servicio", content)
            If response.IsSuccessStatusCode Then
                Dim responseContent = Await response.Content.ReadAsStringAsync()
                Return responseContent
            Else
                Console.WriteLine("Error en la solicitud: " & response.StatusCode.ToString())
                Return Nothing
            End If
        End Using
        MessageBox.Show("Prueba")
    End Function
End Class
