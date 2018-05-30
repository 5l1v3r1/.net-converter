Imports CodeConvert
Imports FastColoredTextBoxNS
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


Public Class Form1

    Private Sub SavecsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavecsToolStripMenuItem.Click

        If Not (TXTC.Text = Nothing) Then

            Dim Sv As New SaveFileDialog

            Sv.Filter = "Files C# (*.cs)|*.cs"

            If (Sv.ShowDialog = DialogResult.OK) Then

                Dim fileName As String = Sv.FileName

                If Not File.Exists(fileName) Then

                    Dim text As String = Me.TXTC.Text

                    File.WriteAllText(fileName, [text])

                End If

            End If

        Else

            MsgBox("Rien à sauvegarder", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub SavevbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavevbToolStripMenuItem.Click
        If Not (TXTVB.Text = Nothing) Then

            Dim Sv As New SaveFileDialog

            Sv.Filter = "Fichiers VB.NET (*.vb)|*.vb"

            If (Sv.ShowDialog = DialogResult.OK) Then

                Dim fileName As String = Sv.FileName

                If Not File.Exists(fileName) Then

                    Dim text As String = Me.TXTVB.Text

                    File.WriteAllText(fileName, [text])

                End If

            End If

        Else

            MsgBox("Rien à sauvegarder", MsgBoxStyle.Exclamation)

        End If
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXTC.Clear()
        TXTVB.Clear()
    End Sub

    Private Sub CCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CCodeToolStripMenuItem.Click
        Dim open As New OpenFileDialog

        open.Filter = "Codes C# (*.cs)|*.cs"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            TXTC.Text = File.ReadAllText(open.FileName)

        End If
    End Sub

    Private Sub VBNETCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VBNETCodeToolStripMenuItem.Click
        Dim open As New OpenFileDialog

        open.Filter = "Codes VB.NET (*.vb)|*.vb"

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then

            TXTVB.Text = File.ReadAllText(open.FileName)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        '_______________________________________C#==>VB.NET__________________________________________________
        If Me.csR.Checked Then
            If Not TXTC.Text = Nothing Then
                Try
                    Me.TXTVB.Text = ConversionLoader.ConvertCSharpToVB(Me.TXTC.Text) 'Converting From C# To VB.NET
                Catch ex As Exception
                    MsgBox("ERREUR :" & ex.Message)
                End Try
            Else
                Interaction.MsgBox("Aucun code à convertir", MsgBoxStyle.Critical, Nothing)
            End If


            '_______________________________________VB.NET==>C#__________________________________________________

        ElseIf Me.vbR.Checked Then
            If Not TXTVB.Text = Nothing Then
                Try
                    Me.TXTC.Text = ConversionLoader.ConvertVBToCSharp(Me.TXTVB.Text) 'Converting From VB.NET To C#
                Catch ex2 As Exception
                    MsgBox("ERREUR :" & ex2.Message)
                End Try
            Else
                Interaction.MsgBox("Aucun code à convertir", MsgBoxStyle.Critical, Nothing)
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Developper par Eren Arslan" & Chr(13) & "==================" & Chr(13) & "@Eawhitehat", MsgBoxStyle.Information)
    End Sub
End Class
