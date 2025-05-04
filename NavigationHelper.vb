Public Class NavigationHelper
    Private Shared BackHistory As New Stack(Of Form)
    Private Shared ForwardHistory As New Stack(Of Form)

    Public Shared Sub GoNext(currentForm As Form, nextForm As Form, btnNext As Button, btnBack As Button)

        If nextForm IsNot Nothing Then
            BackHistory.Push(currentForm) ' Store current form for back navigation
            nextForm.Show()
            currentForm.Hide()

            ' Clear forward history when moving forward
            ForwardHistory.Clear()

            UpdateButtonStates(btnNext, btnBack)
        End If
    End Sub


    Public Shared Sub GoBack(currentForm As Form, btnNext As Button, btnBack As Button)
        If BackHistory.Count > 0 Then
            Dim previousForm As Form = BackHistory.Pop()
            ForwardHistory.Push(currentForm) ' Save current form in forward history
            previousForm.Show()
            currentForm.Hide()
        End If

        UpdateButtonStates(btnNext, btnBack)
    End Sub

    Private Shared Sub UpdateButtonStates(btnNext As Button, btnBack As Button)
        btnBack.Enabled = BackHistory.Count > 0
        btnNext.Enabled = ForwardHistory.Count > 0
    End Sub
End Class
