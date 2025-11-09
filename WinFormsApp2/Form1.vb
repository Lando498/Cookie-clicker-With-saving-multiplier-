Imports System.IO
Public Class Form1
    Private MultCostPath = "MultCost.txt"
    Private MultCost = 100
    Private Multiplier = 0
    Private Cookies = 0
    Private SavePath As String = "cookies.txt"
    Private MultPath As String = "Multiplier.txt"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load cookies
        If File.Exists(SavePath) Then
            Try
                Dim text As String = File.ReadAllText(SavePath)
                Cookies = Integer.Parse(text)
            Catch
                Cookies = 0
            End Try
            Counter.Text = Cookies.ToString()
        End If

        ' Load multiplier
        If File.Exists(MultPath) Then
            Try
                Dim text As String = File.ReadAllText(MultPath)
                Multiplier = Integer.Parse(text)
            Catch
                Multiplier = 0
            End Try
            MultCounter.Text = Multiplier.ToString()
        End If

        If File.Exists(MultCostPath) Then
            Try
                Dim text As String = File.ReadAllText(MultCostPath)
                MultCost = Integer.Parse(text)
            Catch
                MultCost = 100
            End Try
            multplus.Text = "+1 Multiplier Cost " & MultCost
        End If
    End Sub
    Private Sub Cookie_Click(sender As Object, e As EventArgs) Handles Cookie.Click
        Cookies += Multiplier
        Counter.Text = Cookies.ToString()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        File.WriteAllText(SavePath, Cookies.ToString())
        File.WriteAllText(MultPath, Multiplier.ToString())
        File.WriteAllText(MultCostPath, MultCost.ToString())
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub multplus_Click(sender As Object, e As EventArgs) Handles multplus.Click
        If Cookies > 100 Then
            Multiplier += 1
            Cookies -= MultCost
            MultCost += 200
            multplus.Text = "+1 Multiplier Cost " & MultCost
            Counter.Text = Cookies.ToString()
            MultCounter.Text = Multiplier.ToString()
        End If
    End Sub
End Class
