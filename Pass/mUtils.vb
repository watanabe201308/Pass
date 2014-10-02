Imports System.IO

Module mUtils

    Public Const strMessageTitle As String = "Pass Ver1"

#Region "判定"

    Public Function isExistsFile(ByVal strFileWithPath As String) As Boolean

        Return File.Exists(strFileWithPath)

    End Function

    Public Function isNothingOrEmptyString(ByVal strValue As String) As Boolean

        If strValue = "" Or strValue Is Nothing Then
            isNothingOrEmptyString = True
        Else
            isNothingOrEmptyString = False
        End If

    End Function

    Public Function isNothing(ByVal objObject As Object) As Boolean

        If objObject Is Nothing Then
            isNothing = True
        Else
            isNothing = False
        End If

    End Function

#End Region

#Region "ポップアップメッセージ"

    Public Function showMessage(ByVal strType As String, ByVal strMessage As String) As DialogResult

        Select Case strType

            Case "Info"
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case "Question"
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button2)

            Case "withCancel"
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, _
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button3)

            Case Else
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, MessageBoxButtons.OK)

        End Select

    End Function

#End Region

#Region "その他"

    Public Function RepeatChar(ByVal strChar As String, ByVal intCount As Integer) As String

        Dim strReturn As String = ""

        For intIndex As Integer = 0 To intCount - 1
            strReturn = strReturn + strChar
        Next

        RepeatChar = strReturn

    End Function

    Public Function LeftZeroPadding(ByVal strString As String, ByVal intLength As Integer) As String

        LeftZeroPadding = Right(RepeatChar("0", 3) + strString, 3)

    End Function

    Public Sub doSetVersionToFormTitle(ByVal objMe As Form)

        objMe.Text = objMe.Text + cDefs.cConstant.strVersion

    End Sub

#End Region

End Module
