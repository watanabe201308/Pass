<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class objFormEditMetadata
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
        Me.objSplitContainer = New System.Windows.Forms.SplitContainer
        Me.objListBox = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.objTextBoxMemo = New System.Windows.Forms.TextBox
        Me.objTextBoxName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.objTextBoxPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.objTextBoxUserID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.objTextBoxURL = New System.Windows.Forms.TextBox
        Me.objMenuStrip = New System.Windows.Forms.MenuStrip
        Me.objToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemAddNew = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.objToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem
        Me.objSplitContainer.Panel1.SuspendLayout()
        Me.objSplitContainer.Panel2.SuspendLayout()
        Me.objSplitContainer.SuspendLayout()
        Me.objMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'objSplitContainer
        '
        Me.objSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objSplitContainer.Location = New System.Drawing.Point(12, 29)
        Me.objSplitContainer.Name = "objSplitContainer"
        '
        'objSplitContainer.Panel1
        '
        Me.objSplitContainer.Panel1.Controls.Add(Me.objListBox)
        '
        'objSplitContainer.Panel2
        '
        Me.objSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.objSplitContainer.Panel2.Controls.Add(Me.Label6)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objTextBoxMemo)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objTextBoxName)
        Me.objSplitContainer.Panel2.Controls.Add(Me.Label5)
        Me.objSplitContainer.Panel2.Controls.Add(Me.Label4)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objTextBoxPassword)
        Me.objSplitContainer.Panel2.Controls.Add(Me.Label3)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objTextBoxUserID)
        Me.objSplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.objSplitContainer.Panel2.Controls.Add(Me.objTextBoxURL)
        Me.objSplitContainer.Size = New System.Drawing.Size(839, 494)
        Me.objSplitContainer.SplitterDistance = 236
        Me.objSplitContainer.TabIndex = 17
        '
        'objListBox
        '
        Me.objListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objListBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objListBox.FormattingEnabled = True
        Me.objListBox.ItemHeight = 16
        Me.objListBox.Location = New System.Drawing.Point(3, 3)
        Me.objListBox.Name = "objListBox"
        Me.objListBox.Size = New System.Drawing.Size(230, 484)
        Me.objListBox.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "メモ:"
        '
        'objTextBoxMemo
        '
        Me.objTextBoxMemo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objTextBoxMemo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objTextBoxMemo.Location = New System.Drawing.Point(116, 119)
        Me.objTextBoxMemo.Multiline = True
        Me.objTextBoxMemo.Name = "objTextBoxMemo"
        Me.objTextBoxMemo.Size = New System.Drawing.Size(480, 368)
        Me.objTextBoxMemo.TabIndex = 5
        '
        'objTextBoxName
        '
        Me.objTextBoxName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objTextBoxName.Location = New System.Drawing.Point(116, 3)
        Me.objTextBoxName.Name = "objTextBoxName"
        Me.objTextBoxName.Size = New System.Drawing.Size(236, 23)
        Me.objTextBoxName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "設定の名前:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "パスワード:"
        '
        'objTextBoxPassword
        '
        Me.objTextBoxPassword.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objTextBoxPassword.Location = New System.Drawing.Point(116, 90)
        Me.objTextBoxPassword.Name = "objTextBoxPassword"
        Me.objTextBoxPassword.Size = New System.Drawing.Size(124, 23)
        Me.objTextBoxPassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ユーザーID:"
        '
        'objTextBoxUserID
        '
        Me.objTextBoxUserID.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objTextBoxUserID.Location = New System.Drawing.Point(116, 61)
        Me.objTextBoxUserID.Name = "objTextBoxUserID"
        Me.objTextBoxUserID.Size = New System.Drawing.Size(124, 23)
        Me.objTextBoxUserID.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "URL:"
        '
        'objTextBoxURL
        '
        Me.objTextBoxURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objTextBoxURL.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.objTextBoxURL.Location = New System.Drawing.Point(116, 32)
        Me.objTextBoxURL.Name = "objTextBoxURL"
        Me.objTextBoxURL.Size = New System.Drawing.Size(480, 23)
        Me.objTextBoxURL.TabIndex = 2
        '
        'objMenuStrip
        '
        Me.objMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objToolStripMenuItemFile})
        Me.objMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.objMenuStrip.Name = "objMenuStrip"
        Me.objMenuStrip.Size = New System.Drawing.Size(863, 26)
        Me.objMenuStrip.TabIndex = 18
        Me.objMenuStrip.Text = "MenuStrip1"
        '
        'objToolStripMenuItemFile
        '
        Me.objToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objToolStripMenuItemAddNew, Me.objToolStripMenuItemDelete, Me.objToolStripMenuItemExit})
        Me.objToolStripMenuItemFile.Name = "objToolStripMenuItemFile"
        Me.objToolStripMenuItemFile.Size = New System.Drawing.Size(68, 22)
        Me.objToolStripMenuItemFile.Text = "ファイル"
        '
        'objToolStripMenuItemAddNew
        '
        Me.objToolStripMenuItemAddNew.Name = "objToolStripMenuItemAddNew"
        Me.objToolStripMenuItemAddNew.Size = New System.Drawing.Size(124, 22)
        Me.objToolStripMenuItemAddNew.Text = "新規追加"
        '
        'objToolStripMenuItemDelete
        '
        Me.objToolStripMenuItemDelete.Name = "objToolStripMenuItemDelete"
        Me.objToolStripMenuItemDelete.Size = New System.Drawing.Size(124, 22)
        Me.objToolStripMenuItemDelete.Text = "削除"
        '
        'objToolStripMenuItemExit
        '
        Me.objToolStripMenuItemExit.Name = "objToolStripMenuItemExit"
        Me.objToolStripMenuItemExit.Size = New System.Drawing.Size(124, 22)
        Me.objToolStripMenuItemExit.Text = "終了"
        '
        'objFormEditMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 535)
        Me.Controls.Add(Me.objSplitContainer)
        Me.Controls.Add(Me.objMenuStrip)
        Me.MainMenuStrip = Me.objMenuStrip
        Me.Name = "objFormEditMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "メタデータエディタ"
        Me.objSplitContainer.Panel1.ResumeLayout(False)
        Me.objSplitContainer.Panel2.ResumeLayout(False)
        Me.objSplitContainer.Panel2.PerformLayout()
        Me.objSplitContainer.ResumeLayout(False)
        Me.objMenuStrip.ResumeLayout(False)
        Me.objMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents objSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents objListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents objTextBoxMemo As System.Windows.Forms.TextBox
    Friend WithEvents objTextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents objTextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents objTextBoxUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents objTextBoxURL As System.Windows.Forms.TextBox
    Friend WithEvents objMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents objToolStripMenuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemAddNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objToolStripMenuItemDelete As System.Windows.Forms.ToolStripMenuItem
End Class
