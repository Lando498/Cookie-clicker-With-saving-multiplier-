Imports System.IO
Public Class Form1
    Private ClickerCostPath = "ClickerCost.txt"
    Private ClickerPath = "Clickers.txt"
    Private ClickCost = 10
    Private running As Boolean = False
    Private Clickers = 0
    Private MultCostPath = "MultCost.txt"
    Private MultCost = 100
    Private Multiplier = 1
    Private Cookies = 0
    Private SavePath As String = "cookies.txt"
    Private MultPath As String = "Multiplier.txt"

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                Multiplier = 1
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

        If File.Exists(ClickerPath) Then
            Try
                Dim text As String = File.ReadAllText(ClickerPath)
                Clickers = Integer.Parse(text)
            Catch
                Clickers = 0
            End Try
            TextBox1.Text = Clickers.ToString()
        End If

        If File.Exists(ClickerCostPath) Then
            Try
                Dim text As String = File.ReadAllText(ClickerCostPath)
                ClickCost = Integer.Parse(text)
            Catch
                ClickCost = 10
            End Try
            Button1.Text = "+1 Clicker Cost " & ClickCost
        End If

        ' 🔹 Start the background cookie generator when the form loads
        If Not running Then
            running = True
            Do While running
                Await Task.Delay(1000)
                If Clickers > 0 Then
                    Cookies += Clickers * Multiplier
                    Counter.Text = Cookies.ToString()
                End If
            Loop
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
        File.WriteAllText(ClickerPath, Clickers.ToString())
        File.WriteAllText(ClickerCostPath, ClickCost.ToString())
    End Sub

    Private Sub multplus_Click(sender As Object, e As EventArgs) Handles multplus.Click
        If Cookies > MultCost Then
            Multiplier += 1
            Cookies -= MultCost
            MultCost += 100
            multplus.Text = "+1 Multiplier Cost " & MultCost
            Counter.Text = Cookies.ToString
            MultCounter.Text = Multiplier.ToString
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cookies >= ClickCost Then
            Cookies -= ClickCost
            Counter.Text = Cookies.ToString()
            Clickers += 1
            TextBox1.Text = Clickers.ToString()
            ClickCost += 20
            Button1.Text = "+1 Clicker Cost " & ClickCost
        End If
    End Sub
End Class
