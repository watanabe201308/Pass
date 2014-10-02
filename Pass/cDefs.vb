Public Class cDefs

    Public Class cConstant

        Public Const strSettingFileName As String = "settings.xml"
        Public Const strCryptPassword = "1234"
        Public Const strDbFileName As String = "db.xml"
        Public Const strVersion As String = "2013.03.05.001"

    End Class

    Public Class cUnConstant

        Public Shared Function getAppPath() As String
            getAppPath = Application.StartupPath + "\"
        End Function

    End Class

End Class
