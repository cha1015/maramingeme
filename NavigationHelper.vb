﻿Public Class NavigationHelper
    Private Shared BackHistory As New Stack(Of System.Windows.Forms.Form)()
    Private Shared ForwardHistory As New Stack(Of System.Windows.Forms.Form)()
    Private Shared LastForm As System.Windows.Forms.Form ' To keep track of the last form

    Public Shared Sub GoNext(currentForm As System.Windows.Forms.Form, nextForm As System.Windows.Forms.Form, btnNext As Button, btnBack As Button)
        If nextForm IsNot Nothing Then
            BackHistory.Push(currentForm) ' Store current form for back navigation
            LastForm = nextForm ' Store the last form
            nextForm.Show()
            currentForm.Hide()

            ' Clear forward history when moving forward
            ForwardHistory.Clear()

            UpdateButtonStates(btnNext, btnBack)
        End If
    End Sub

    Public Shared Sub GoBack(currentForm As System.Windows.Forms.Form, btnNext As Button, btnBack As Button)
        If BackHistory.Count > 0 Then
            Dim previousForm As System.Windows.Forms.Form = BackHistory.Pop()
            ForwardHistory.Push(currentForm) ' Save current form in forward history
            previousForm.Show()
            currentForm.Hide()
        End If
    End Sub

    Public Shared Sub GoNextAgain(currentForm As System.Windows.Forms.Form, btnNext As Button, btnBack As Button)
        If LastForm IsNot Nothing Then
            BackHistory.Push(currentForm) ' Store current form for back navigation
            LastForm.Show()
            currentForm.Hide()

            ' Clear forward history when using the next again
            ForwardHistory.Clear()

            UpdateButtonStates(btnNext, btnBack)
        End If
    End Sub

    Private Shared Sub UpdateButtonStates(btnNext As Button, btnBack As Button)
        btnBack.Enabled = BackHistory.Count > 0
        btnNext.Enabled = LastForm IsNot Nothing ' Enable next if there is a last form
    End Sub
End Class