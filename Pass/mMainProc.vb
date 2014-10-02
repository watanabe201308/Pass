Imports System.Xml
Imports System.IO

Module mMainProc

    ''' <summary>
    ''' 設定ファイル(settings.xml)を新規に作成する
    ''' </summary>
    ''' <param name="objSetting"></param>
    ''' <remarks></remarks>
    Public Sub doSaveInitialSettingXml(ByVal objSetting As cValueObjects.Setting)

        Dim objXmlDoc As XmlDocument = New XmlDocument()

        Call objXmlDoc.AppendChild( _
            objXmlDoc.CreateXmlDeclaration("1.0", "Shift-JIS", String.Empty))

        Dim objXmlNode As XmlNode = objXmlDoc.CreateElement("Settings")
        Dim objXmlNodeCommonPass As XmlNode = objXmlDoc.CreateElement("CommonPassword")

        objXmlNodeCommonPass.InnerText = _
            cCrypt.EncryptString( _
                objSetting.strCommonPassword, _
                cDefs.cConstant.strCryptPassword)

        objXmlNode.AppendChild(objXmlNodeCommonPass)

        Call objXmlDoc.AppendChild(objXmlNode)

        Call objXmlDoc.Save(cDefs.cConstant.strSettingFileName)

        Call showMessage("Info", cDefs.cConstant.strSettingFileName + " を作成しました。")

    End Sub

    ''' <summary>
    ''' 渡されたパスワードが正しい共通パスワードかどうかを判定する
    ''' </summary>
    ''' <param name="strFormCommonPass"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isCorrectCommonPass(ByVal strFormCommonPass As String) As Boolean

        If strFormCommonPass = getCommonPassFromSettingXml() Then
            isCorrectCommonPass = True
        Else
            isCorrectCommonPass = False
        End If

    End Function

    ''' <summary>
    ''' 設定ファイル(settings.xml)から共通パスワードを取得する
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getCommonPassFromSettingXml() As String

        Dim objXmlDoc As XmlDocument = New XmlDocument()

        Call objXmlDoc.Load(cDefs.cConstant.strSettingFileName)

        Dim strCommonPassXml As String = _
            objXmlDoc.SelectSingleNode("Settings/CommonPassword").InnerText

        getCommonPassFromSettingXml = _
            cCrypt.DecryptString( _
                strCommonPassXml, _
                cDefs.cConstant.strCryptPassword)

    End Function

    ''' <summary>
    ''' Xml(db.xml) から objList に設定データを読み込む
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function doLoadFromXmlDb() As List(Of cSetting)

        Dim objList As New List(Of cSetting)

        Dim objXmlDoc As XmlDocument = New XmlDocument()

        If Not isExistsFile(cDefs.cConstant.strDbFileName) Then
            doLoadFromXmlDb = objList
            Exit Function
        End If

        Call objXmlDoc.Load(cDefs.cConstant.strDbFileName)

        Dim objSettings As XmlNodeList = _
            objXmlDoc.SelectNodes("/Settings/Setting")

        For Each objSettingXml As XmlNode In objSettings

            Dim objSetting As New cSetting

            objSetting.strName = objSettingXml.SelectSingleNode("Name").InnerText
            objSetting.strType = objSettingXml.SelectSingleNode("Type").InnerText
            objSetting.strURL = objSettingXml.SelectSingleNode("URL").InnerText
            objSetting.strUserID = objSettingXml.SelectSingleNode("UserID").InnerText
            objSetting.strPassword = _
                cCrypt.DecryptString( _
                    objSettingXml.SelectSingleNode("Password").InnerText, _
                    cDefs.cConstant.strCryptPassword)
            objSetting.strMemo = objSettingXml.SelectSingleNode("Memo").InnerText

            objList.Add(objSetting)

        Next

        doLoadFromXmlDb = objList

    End Function

    ''' <summary>
    ''' objList から Xml(db.xml) に設定データを保存する
    ''' </summary>
    ''' <param name="objList"></param>
    ''' <remarks></remarks>
    Public Sub doSaveToXmlDb(ByVal objList As List(Of cSetting))

        Dim objXmlDoc As XmlDocument = New XmlDocument()

        Call objXmlDoc.AppendChild( _
            objXmlDoc.CreateXmlDeclaration("1.0", "Shift-JIS", String.Empty))

        Dim objXmlNode As XmlNode = objXmlDoc.CreateElement("Settings")

        For Each objSetting As cSetting In objList

            Dim objXmlNodeSetting As XmlNode = objXmlDoc.CreateElement("Setting")

            Dim objXmlNodeName As XmlNode = objXmlDoc.CreateElement("Name")
            Dim objXmlNodeType As XmlNode = objXmlDoc.CreateElement("Type")
            Dim objXmlNodeURL As XmlNode = objXmlDoc.CreateElement("URL")
            Dim objXmlNodeUserID As XmlNode = objXmlDoc.CreateElement("UserID")
            Dim objXmlNodePassword As XmlNode = objXmlDoc.CreateElement("Password")
            Dim objXmlNodeMemo As XmlNode = objXmlDoc.CreateElement("Memo")

            objXmlNodeName.InnerText = objSetting.strName
            objXmlNodeType.InnerText = objSetting.strType
            objXmlNodeURL.InnerText = objSetting.strURL
            objXmlNodeUserID.InnerText = objSetting.strUserID
            objXmlNodePassword.InnerText = _
                cCrypt.EncryptString( _
                    objSetting.strPassword, _
                    cDefs.cConstant.strCryptPassword)
            objXmlNodeMemo.InnerText = objSetting.strMemo

            objXmlNodeSetting.AppendChild(objXmlNodeName)
            objXmlNodeSetting.AppendChild(objXmlNodeType)
            objXmlNodeSetting.AppendChild(objXmlNodeURL)
            objXmlNodeSetting.AppendChild(objXmlNodeUserID)
            objXmlNodeSetting.AppendChild(objXmlNodePassword)
            objXmlNodeSetting.AppendChild(objXmlNodeMemo)

            objXmlNode.AppendChild(objXmlNodeSetting)

        Next

        Call objXmlDoc.AppendChild(objXmlNode)

        Call objXmlDoc.Save(cDefs.cConstant.strDbFileName)

        Call showMessage("Info", cDefs.cConstant.strDbFileName + " に保存しました。")

    End Sub

End Module
