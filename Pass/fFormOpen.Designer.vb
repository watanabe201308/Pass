<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFormOpen
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
        Me.objButtonOpen = New System.Windows.Forms.Button
        Me.objTextBoxCommonPass = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'objButtonOpen
        '
        Me.objButtonOpen.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objButtonOpen.Location = New System.Drawing.Point(163, 70)
        Me.objButtonOpen.Name = "objButtonOpen"
        Me.objButtonOpen.Size = New System.Drawing.Size(75, 37)
        Me.objButtonOpen.TabIndex = 1
        Me.objButtonOpen.Text = "ログイン"
        Me.objButtonOpen.UseVisualStyleBackColor = True
        '
        'objTextBoxCommonPass
        '
        Me.objTextBoxCommonPass.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objTextBoxCommonPass.Location = New System.Drawing.Point(90, 42)
        Me.objTextBoxCommonPass.Name = "objTextBoxCommonPass"
        Me.objTextBoxCommonPass.Size = New System.Drawing.Size(221, 22)
        Me.objTextBoxCommonPass.TabIndex = 0
        Me.objTextBoxCommonPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "初回起動時に入力したパスワードを入力してください。"
        '
        'fFormOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 119)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.objTextBoxCommonPass)
        Me.Controls.Add(Me.objButtonOpen)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fFormOpen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pass: パスワードを入力してください。"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents objButtonOpen As System.Windows.Forms.Button
    Friend WithEvents objTextBoxCommonPass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
