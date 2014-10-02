Public Class objFormEditMetadata

#Region "Private Variables"

    Private objSettingList As New List(Of cSetting)
    Private intSaveSelectedListIndex As Integer = 0
    Private blnIsSaved As Boolean = False
    Private blnIsCorrectLogined As Boolean = False

#End Region

#Region "objFormEditMetadata EventHandler"

    Private Sub objFormEditMetadata_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If blnIsSaved = False Then
            If blnIsCorrectLogined Then
                If showMessage("Question", _
                               "データが保存されていませんが、終了してもよろしいですか？" + vbCrLf + _
                               "保存する場合は、[ファイル]-[終了] をクリックしてください。") <> Windows.Forms.DialogResult.Yes Then
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

    Private Sub objFormEditMetadata_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call doSetVersionToFormTitle(Me)

        Dim strFile As String = cDefs.cConstant.strSettingFileName

        Call doCheckExistsSettingFile(strFile)

        Call doClearListBoxAndLoadFromSettingList()

        objSettingList = doLoadFromXmlDb()

        If objSettingList.Count = 0 Then

            Call doAddNewSetting()

        End If

        Call doClearListBoxAndLoadFromSettingList()

        objListBox.SelectedIndex = 0

    End Sub

#End Region

#Region "objToolStripMenuItem EventHandler"

    Private Sub objToolStripMenuItemAddNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles objToolStripMenuItemAddNew.Click

        Call doAddNewSetting()

        Call doClearListBoxAndLoadFromSettingList()

    End Sub

    Private Sub objToolStripMenuItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objToolStripMenuItemDelete.Click

        Dim objSetting As cSetting = getSelectedSettingFromList()

        If showMessage("Question", "「" + objSetting.strName + "」 を削除します。よろしいですか？") = Windows.Forms.DialogResult.Yes Then

            If Not isNothing(objSetting) Then
                objSettingList.Remove(objSetting)
            End If

            intSaveSelectedListIndex = 0
            objListBox.SelectedIndex = 0

        End If

        Call doClearListBoxAndLoadFromSettingList()

    End Sub

    Private Sub objToolStripMenuItemExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles objToolStripMenuItemExit.Click

        Me.ValidateChildren()

        Call doSaveToXmlDb(objSettingList)

        blnIsSaved = True

        Me.Close()

    End Sub

#End Region

#Region "objListBox EventHandler"

    Private Sub objListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objListBox.SelectedIndexChanged

        If objListBox.SelectedIndex <> -1 Then
            intSaveSelectedListIndex = objListBox.SelectedIndex
        End If

        Call doSyncFormFronVariables()

    End Sub

#End Region

#Region "objTextBox EventHandler"

    Private Sub objTextBoxName_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objTextBoxName.Validated

        getSelectedSettingFromList().strName = objTextBoxName.Text

        Call doClearListBoxAndLoadFromSettingList()

    End Sub

    Private Sub objTextBoxName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles objTextBoxName.Validating

        If isExistsNameInSettingList(objTextBoxName.Text) Then

            showMessage("Info", "入力された名称は、すでに存在します。")

            e.Cancel = True

        End If

    End Sub

    Private Sub objTextBoxURL_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBoxURL.Validated

        getSelectedSettingFromList().strURL = objTextBoxURL.Text

        Call doClearListBoxAndLoadFromSettingList()

    End Sub

    Private Sub objTextBoxUserID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBoxUserID.Validated

        getSelectedSettingFromList().strUserID = objTextBoxUserID.Text

        Call doClearListBoxAndLoadFromSettingList()

    End Sub

    Private Sub objTextBoxPassword_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBoxPassword.Validated

        getSelectedSettingFromList().strPassword = objTextBoxPassword.Text

        Call doClearListBoxAndLoadFromSettingList()

    End Sub

    Private Sub objTextBoxMemo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBoxMemo.Validated

        getSelectedSettingFromList().strMemo = objTextBoxMemo.Text

        Call doClearListBoxAndLoadFromSettingList()

    End Sub

#End Region

#Region "Private Methods"

    Private Sub doAddNewSetting()

        Dim objSetting As New cSetting()

        objSetting.strName = "新規設定" + LeftZeroPadding((objSettingList.Count + 1).ToString, 3)

        Call objSettingList.Add(objSetting)

    End Sub

    Private Function isExistsNameInSettingList(ByVal strName As String) As Boolean

        Dim blnReturn As Boolean = False

        For Each objSetting As cSetting In objSettingList

            If objSetting.strName = strName Then

                If getSelectedSettingFromList().strName <> strName Then
                    blnReturn = True
                End If

            End If

        Next

        isExistsNameInSettingList = blnReturn

    End Function

    Private Function getSelectedListBoxValue() As String

        getSelectedListBoxValue = objListBox.Items(intSaveSelectedListIndex)

    End Function

    Private Function getSelectedSettingFromList() As cSetting

        Dim objReturn As New cSetting

        For Each objSetting As cSetting In objSettingList

            If objSetting.strName = getSelectedListBoxValue() Then
                objReturn = objSetting
                Exit For
            End If

        Next

        getSelectedSettingFromList = objReturn

    End Function

    Private Sub doSyncFormFronVariables()

        Dim objSetting As cSetting = getSelectedSettingFromList()

        objTextBoxName.Text = objSetting.strName
        objTextBoxURL.Text = objSetting.strURL
        objTextBoxUserID.Text = objSetting.strUserID
        objTextBoxPassword.Text = objSetting.strPassword
        objTextBoxMemo.Text = objSetting.strMemo

        intSaveSelectedListIndex = objListBox.SelectedIndex

    End Sub

    Private Sub doClearListBoxAndLoadFromSettingList()

        objListBox.Items.Clear()

        For Each objSetting As cSetting In objSettingList
            objListBox.Items.Add(objSetting.strName)
        Next

    End Sub

    Private Sub doCheckExistsSettingFile(ByVal strFile As String)

        If Not isExistsFile(strFile) Then

            Dim objForm As New fFormSaveCommonPass
            objForm.ShowDialog(Me)

            If objForm.intDialogResult <> Windows.Forms.DialogResult.OK Then

                Me.Close()

                Exit Sub

            End If

            doSaveInitialSettingXml(objForm.objSetting)

            blnIsCorrectLogined = True

        Else

            Call doCheckCommonPass()

        End If

    End Sub

    Private Sub doCheckCommonPass()

        Dim objForm As New fFormOpen
        objForm.ShowDialog(Me)

        If objForm.intDialogResult <> Windows.Forms.DialogResult.OK Then

            Me.Close()

            Exit Sub

        End If

        If Not isCorrectCommonPass(objForm.objSetting.strCommonPassword) Then

            showMessage("Info", "パスワードが一致しません。")

            Me.Close()

            Exit Sub

        End If

        blnIsCorrectLogined = True

    End Sub

#End Region

End Class