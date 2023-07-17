Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form2
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nrp As String = txtPRN.Text
        Dim nama As String = txtNmk.Text
        Dim jk As String = txtJK.Text
        Dim tgl_lahir As String = txtTla.Text
        Dim alamat As String = txtAlt.Text
        Dim kota As String = txtKot.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api, "POST", byteArray)

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
        Dim nrp As String = txtPRN.Text
        Dim nama As String = txtNmk.Text
        Dim jk As String = txtJK.Text
        Dim tgl_lahir As String = txtTla.Text
        Dim alamat As String = txtAlt.Text
        Dim kota As String = txtKot.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nrp=" & txtPRN.Text, "PUT", byteArray)

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
        Dim nrp As String = txtPRN.Text
        Dim nama As String = txtNmk.Text
        Dim jk As String = txtJK.Text
        Dim tgl_lahir As String = txtTla.Text
        Dim alamat As String = txtAlt.Text
        Dim kota As String = txtKot.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nrp=" & txtPRN.Text, "DELETE", byteArray)

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
            Dim response As HttpResponseMessage = client.GetAsync(pasien_api & "?nrp=" & txtPRN.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        pasien_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        pasien_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (pasien_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Pasien) = JsonConvert.DeserializeObject(Of List(Of Pasien))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Pasien In data
                            txtPRN.Text = mydata.nrp
                            txtNmk.Text = mydata.nama
                            txtJK.Text = mydata.jk
                            txtTla.Text = mydata.tgl_lahir
                            txtAlt.Text = mydata.alamat
                            txtKot.Text = mydata.kota
                        Next
                    End If

                End Try




            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (pasien_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If


        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (pasien_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub
    Private Sub GetClear()
        txtPRN.Clear()
        txtNmk.Clear()
        txtJK.Clear()
        txtTla.Clear()
        txtAlt.Clear()
        txtKot.Clear()
        Reloaded()
        txtPRN.Focus()
    End Sub

    Private Sub txtSpl_TextChanged(sender As Object, e As EventArgs) Handles txtTla.TextChanged

    End Sub

    Private Sub txtJK_TextChanged(sender As Object, e As EventArgs) Handles txtJK.TextChanged

    End Sub

    Private Sub txtNmk_TextChanged(sender As Object, e As EventArgs) Handles txtNmk.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtPin_TextChanged(sender As Object, e As EventArgs) Handles txtPRN.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAlt.TextChanged

    End Sub

    Private Sub txtPRN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPRN.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()
        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(pasien_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Pasien) = JsonConvert.DeserializeObject(Of List(Of Pasien))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtKot_TextChanged(sender As Object, e As EventArgs) Handles txtKot.TextChanged

    End Sub
End Class