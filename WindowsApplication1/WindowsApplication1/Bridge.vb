Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        ' CONSTANTS
        Dim strName As String = "Tod"
        Dim strQuest As String = "Seek the grail"
        Dim strColor As String = "blue"

        'CATCH DATA FROM FORM
        Dim strNameGuess As String = Me.txtNameGuess.Text
        Dim strQuestGuess As String = Me.txtQuestGuess.Text
        Dim strColorGuess As String = Me.txtColorGuess.Text

        ' LOGICAL ARGUMENTS & RESPONSES
        If strName = strNameGuess Then
            Me.lblQ1Answer.Text = "You may pass!"
        Else
            Me.lblQ1Answer.Text = "You die!"
        End If
        If strQuest = strQuestGuess Then
            Me.lblQ2Answer.Text = "You may pass!"
        Else
            Me.lblQ2Answer.Text = "You die!"
        End If
        If strColor = strColorGuess Then
            Me.lblQ3Answer.Text = "You may pass!"
        Else
            Me.lblQ3Answer.Text = "You die!"
        End If
    End Sub
End Class




