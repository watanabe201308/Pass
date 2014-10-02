<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFormSaveCommonPass
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.objTextBoxCommonPass = New System.Windows.Forms.TextBox
        Me.objButtonSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'objTextBoxCommonPass
        '
        Me.objTextBoxCommonPass.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objTextBoxCommonPass.Location = New System.Drawing.Point(121, 68)
        Me.objTextBoxCommonPass.Name = "objTextBoxCommonPass"
        Me.objTextBoxCommonPass.Size = New System.Drawing.Size(221, 22)
        Me.objTextBoxCommonPass.TabIndex = 0
        Me.objTextBoxCommonPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'objButtonSave
        '
        Me.objButtonSave.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objButtonSave.Location = New System.Drawing.Point(194, 96)
        Me.objButtonSave.Name = "objButtonSave"
        Me.objButtonSave.Size = New System.Drawing.Size(75, 37)
        Me.objButtonSave.TabIndex = 1
        Me.objButtonSave.Text = "保存"
        Me.objButtonSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "この画面は、初回起動時のみ表示されます。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(446, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ここで保存したパスワードを忘れると、このアプリを起動できなくなります。"
        '
        'fFormSaveCommonPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 143)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.objTextBoxCommonPass)
        Me.Controls.Add(Me.objButtonSave)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fFormSaveCommonPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pass: 保存するパスワードを入力してください。"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents objTextBoxCommonPass As System.Windows.Forms.TextBox
    Friend WithEvents objButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
