Public Class fFormOpen

    Public objSetting As New cValueObjects.Setting
    Public intDialogResult As Integer = DialogResult.Cancel

    Private Sub objButtonOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objButtonOpen.Click

        Me.intDialogResult = DialogResult.OK

        Me.Close()

    End Sub

    Private Sub fFormOpen_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If Me.intDialogResult = DialogResult.Cancel Then
            e.Cancel = False
            Exit Sub
        End If

        If isNothingOrEmptyString(objTextBoxCommonPass.Text) = True Then
            showMessage("Info", "パスワードを入力してください。")
            e.Cancel = True
            Exit Sub
        End If

        Me.objSetting.strCommonPassword = objTextBoxCommonPass.Text

    End Sub

    Private Sub fFormOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call doSetVersionToFormTitle(Me)

    End Sub

End Class
