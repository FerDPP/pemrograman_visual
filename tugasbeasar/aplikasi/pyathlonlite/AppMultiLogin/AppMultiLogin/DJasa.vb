Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class DJasa
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (jasa_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If

    End Sub

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim koja As String = txtAjok.Text
        Dim nama As String = txtNmk.Text
        Dim jk As String = txtJK.Text
        Dim najas As String = txtSajan.Text
        Dim harga As String = txtHrg.Text

        Dim postData As String = $"koja={koja}&nama={nama}&jk={jk}&najas={najas}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(jasa_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim koja As String = txtAjok.Text
        Dim nama As String = txtNmk.Text
        Dim jk As String = txtJK.Text
        Dim najas As String = txtSajan.Text
        Dim harga As String = txtHrg.Text

        Dim postData As String = $"koja={koja}&nama={nama}&jk={jk}&najas={najas}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(jasa_api & "?koja=" & txtAjok.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim koja As String = txtAjok.Text
        Dim nama As String = txtNmk.Text
        Dim jk As String = txtJK.Text
        Dim najas As String = txtSajan.Text
        Dim harga As String = txtHrg.Text

        Dim postData As String = $"koja={koja}&nama={nama}&jk={jk}&najas={najas}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(jasa_api & "?koja=" & txtAjok.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(jasa_api & "?koja=" & txtAjok.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        jasa_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        jasa_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (jasa_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Jasa) = JsonConvert.DeserializeObject(Of List(Of Jasa))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Jasa In data
                            txtAjok.Text = mydata.koja
                            txtNmk.Text = mydata.nama
                            txtJK.Text = mydata.jk
                            txtSajan.Text = mydata.najas
                            txtHrg.Text = mydata.harga
                        Next
                    End If

                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAjok.TextChanged

    End Sub

    Private Sub txtAjok_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAjok.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub DJasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()
        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(jasa_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Jasa) = JsonConvert.DeserializeObject(Of List(Of Jasa))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub GetClear()
        txtAjok.Clear()
        txtNmk.Clear()
        txtJK.Clear()
        txtSajan.Clear()
        txtHrg.Clear()
        Reloaded()
        txtAjok.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (jasa_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub
End Class
