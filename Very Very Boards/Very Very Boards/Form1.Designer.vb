<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.SBLabel = New System.Windows.Forms.Label()
        Me.SBwBLabel = New System.Windows.Forms.Label()
        Me.InputPanel = New System.Windows.Forms.Panel()
        Me.sumLabel = New System.Windows.Forms.Label()
        Me.totalSBwBbox = New System.Windows.Forms.TextBox()
        Me.totalSBbox = New System.Windows.Forms.TextBox()
        Me.sumButton = New System.Windows.Forms.Button()
        Me.totalBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.clearAllButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.DisplayBox = New System.Windows.Forms.RichTextBox()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.sbBox = New System.Windows.Forms.TextBox()
        Me.sbwbBox = New System.Windows.Forms.TextBox()
        Me.rentalLabel = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.sbTotalLabel = New System.Windows.Forms.Label()
        Me.sbwbTotalLabel = New System.Windows.Forms.Label()
        Me.dailyTotalLabel = New System.Windows.Forms.Label()
        Me.avgPCusLabel = New System.Windows.Forms.Label()
        Me.sbTotalBox = New System.Windows.Forms.TextBox()
        Me.sbwbTotalBox = New System.Windows.Forms.TextBox()
        Me.dailyTotalBox = New System.Windows.Forms.TextBox()
        Me.avgPCusBox = New System.Windows.Forms.TextBox()
        Me.InputPanel.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Font = New System.Drawing.Font("STHupo", 42.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.TitleLabel.Location = New System.Drawing.Point(253, 21)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(634, 58)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Very Very Boards Rental"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 83)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(88, 13)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Customer Name: "
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(11, 118)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(89, 13)
        Me.IDLabel.TabIndex = 3
        Me.IDLabel.Text = "DL / ID Number: "
        '
        'SBLabel
        '
        Me.SBLabel.AutoSize = True
        Me.SBLabel.Location = New System.Drawing.Point(11, 156)
        Me.SBLabel.Name = "SBLabel"
        Me.SBLabel.Size = New System.Drawing.Size(82, 13)
        Me.SBLabel.TabIndex = 4
        Me.SBLabel.Text = "Snowboards #: "
        '
        'SBwBLabel
        '
        Me.SBwBLabel.AutoSize = True
        Me.SBwBLabel.Location = New System.Drawing.Point(12, 190)
        Me.SBwBLabel.Name = "SBwBLabel"
        Me.SBwBLabel.Size = New System.Drawing.Size(128, 13)
        Me.SBwBLabel.TabIndex = 5
        Me.SBwBLabel.Text = "Snowboards w/ Boots #: "
        '
        'InputPanel
        '
        Me.InputPanel.Controls.Add(Me.avgPCusBox)
        Me.InputPanel.Controls.Add(Me.dailyTotalBox)
        Me.InputPanel.Controls.Add(Me.sbwbTotalBox)
        Me.InputPanel.Controls.Add(Me.sbTotalBox)
        Me.InputPanel.Controls.Add(Me.avgPCusLabel)
        Me.InputPanel.Controls.Add(Me.dailyTotalLabel)
        Me.InputPanel.Controls.Add(Me.sbwbTotalLabel)
        Me.InputPanel.Controls.Add(Me.sbTotalLabel)
        Me.InputPanel.Controls.Add(Me.sumLabel)
        Me.InputPanel.Controls.Add(Me.totalSBwBbox)
        Me.InputPanel.Controls.Add(Me.totalSBbox)
        Me.InputPanel.Controls.Add(Me.sumButton)
        Me.InputPanel.Controls.Add(Me.totalBox)
        Me.InputPanel.Controls.Add(Me.TotalLabel)
        Me.InputPanel.Controls.Add(Me.clearAllButton)
        Me.InputPanel.Controls.Add(Me.clearButton)
        Me.InputPanel.Controls.Add(Me.calcButton)
        Me.InputPanel.Controls.Add(Me.DisplayBox)
        Me.InputPanel.Controls.Add(Me.nameBox)
        Me.InputPanel.Controls.Add(Me.idBox)
        Me.InputPanel.Controls.Add(Me.sbBox)
        Me.InputPanel.Controls.Add(Me.sbwbBox)
        Me.InputPanel.Controls.Add(Me.rentalLabel)
        Me.InputPanel.Controls.Add(Me.SBwBLabel)
        Me.InputPanel.Controls.Add(Me.SBLabel)
        Me.InputPanel.Controls.Add(Me.IDLabel)
        Me.InputPanel.Controls.Add(Me.NameLabel)
        Me.InputPanel.Location = New System.Drawing.Point(89, 98)
        Me.InputPanel.Name = "InputPanel"
        Me.InputPanel.Size = New System.Drawing.Size(1034, 432)
        Me.InputPanel.TabIndex = 6
        '
        'sumLabel
        '
        Me.sumLabel.AutoSize = True
        Me.sumLabel.Font = New System.Drawing.Font("STHupo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sumLabel.ForeColor = System.Drawing.Color.Orange
        Me.sumLabel.Location = New System.Drawing.Point(818, 29)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(141, 33)
        Me.sumLabel.TabIndex = 19
        Me.sumLabel.Text = "Summary"
        '
        'totalSBwBbox
        '
        Me.totalSBwBbox.Location = New System.Drawing.Point(202, 187)
        Me.totalSBwBbox.Name = "totalSBwBbox"
        Me.totalSBwBbox.ReadOnly = True
        Me.totalSBwBbox.Size = New System.Drawing.Size(76, 20)
        Me.totalSBwBbox.TabIndex = 12
        '
        'totalSBbox
        '
        Me.totalSBbox.Location = New System.Drawing.Point(202, 153)
        Me.totalSBbox.Name = "totalSBbox"
        Me.totalSBbox.ReadOnly = True
        Me.totalSBbox.Size = New System.Drawing.Size(76, 20)
        Me.totalSBbox.TabIndex = 11
        '
        'sumButton
        '
        Me.sumButton.Location = New System.Drawing.Point(660, 282)
        Me.sumButton.Name = "sumButton"
        Me.sumButton.Size = New System.Drawing.Size(75, 23)
        Me.sumButton.TabIndex = 18
        Me.sumButton.Text = "Summary"
        Me.sumButton.UseVisualStyleBackColor = True
        '
        'totalBox
        '
        Me.totalBox.Location = New System.Drawing.Point(146, 222)
        Me.totalBox.Name = "totalBox"
        Me.totalBox.ReadOnly = True
        Me.totalBox.Size = New System.Drawing.Size(89, 20)
        Me.totalBox.TabIndex = 13
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(12, 222)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(61, 13)
        Me.TotalLabel.TabIndex = 6
        Me.TotalLabel.Text = "Total Cost: "
        '
        'clearAllButton
        '
        Me.clearAllButton.Location = New System.Drawing.Point(305, 282)
        Me.clearAllButton.Name = "clearAllButton"
        Me.clearAllButton.Size = New System.Drawing.Size(75, 23)
        Me.clearAllButton.TabIndex = 17
        Me.clearAllButton.Text = "Clear All"
        Me.clearAllButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(111, 274)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 15
        Me.clearButton.Text = "Clear Entry"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(15, 274)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 14
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'DisplayBox
        '
        Me.DisplayBox.Location = New System.Drawing.Point(305, 80)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.ReadOnly = True
        Me.DisplayBox.Size = New System.Drawing.Size(430, 196)
        Me.DisplayBox.TabIndex = 16
        Me.DisplayBox.Text = ""
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(146, 83)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(132, 20)
        Me.nameBox.TabIndex = 7
        '
        'idBox
        '
        Me.idBox.Location = New System.Drawing.Point(146, 118)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(132, 20)
        Me.idBox.TabIndex = 8
        '
        'sbBox
        '
        Me.sbBox.Location = New System.Drawing.Point(146, 153)
        Me.sbBox.Name = "sbBox"
        Me.sbBox.Size = New System.Drawing.Size(50, 20)
        Me.sbBox.TabIndex = 9
        '
        'sbwbBox
        '
        Me.sbwbBox.Location = New System.Drawing.Point(146, 187)
        Me.sbwbBox.Name = "sbwbBox"
        Me.sbwbBox.Size = New System.Drawing.Size(50, 20)
        Me.sbwbBox.TabIndex = 10
        '
        'rentalLabel
        '
        Me.rentalLabel.AutoSize = True
        Me.rentalLabel.Font = New System.Drawing.Font("STHupo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rentalLabel.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rentalLabel.Location = New System.Drawing.Point(62, 29)
        Me.rentalLabel.Name = "rentalLabel"
        Me.rentalLabel.Size = New System.Drawing.Size(173, 33)
        Me.rentalLabel.TabIndex = 1
        Me.rentalLabel.Text = "Rental Info"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(1132, 556)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 19
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'sbTotalLabel
        '
        Me.sbTotalLabel.AutoSize = True
        Me.sbTotalLabel.Location = New System.Drawing.Point(755, 90)
        Me.sbTotalLabel.Name = "sbTotalLabel"
        Me.sbTotalLabel.Size = New System.Drawing.Size(96, 13)
        Me.sbTotalLabel.TabIndex = 20
        Me.sbTotalLabel.Text = "Snowboards Total:"
        '
        'sbwbTotalLabel
        '
        Me.sbwbTotalLabel.AutoSize = True
        Me.sbwbTotalLabel.Location = New System.Drawing.Point(755, 125)
        Me.sbwbTotalLabel.Name = "sbwbTotalLabel"
        Me.sbwbTotalLabel.Size = New System.Drawing.Size(141, 13)
        Me.sbwbTotalLabel.TabIndex = 21
        Me.sbwbTotalLabel.Text = "Snowboards w/ boots Total:"
        '
        'dailyTotalLabel
        '
        Me.dailyTotalLabel.AutoSize = True
        Me.dailyTotalLabel.Location = New System.Drawing.Point(755, 163)
        Me.dailyTotalLabel.Name = "dailyTotalLabel"
        Me.dailyTotalLabel.Size = New System.Drawing.Size(60, 13)
        Me.dailyTotalLabel.TabIndex = 22
        Me.dailyTotalLabel.Text = "Daily Total:"
        '
        'avgPCusLabel
        '
        Me.avgPCusLabel.AutoSize = True
        Me.avgPCusLabel.Location = New System.Drawing.Point(755, 197)
        Me.avgPCusLabel.Name = "avgPCusLabel"
        Me.avgPCusLabel.Size = New System.Drawing.Size(116, 13)
        Me.avgPCusLabel.TabIndex = 23
        Me.avgPCusLabel.Text = "Average Per Customer:"
        '
        'sbTotalBox
        '
        Me.sbTotalBox.Location = New System.Drawing.Point(920, 86)
        Me.sbTotalBox.Name = "sbTotalBox"
        Me.sbTotalBox.ReadOnly = True
        Me.sbTotalBox.Size = New System.Drawing.Size(100, 20)
        Me.sbTotalBox.TabIndex = 24
        '
        'sbwbTotalBox
        '
        Me.sbwbTotalBox.Location = New System.Drawing.Point(920, 122)
        Me.sbwbTotalBox.Name = "sbwbTotalBox"
        Me.sbwbTotalBox.ReadOnly = True
        Me.sbwbTotalBox.Size = New System.Drawing.Size(100, 20)
        Me.sbwbTotalBox.TabIndex = 25
        '
        'dailyTotalBox
        '
        Me.dailyTotalBox.Location = New System.Drawing.Point(920, 160)
        Me.dailyTotalBox.Name = "dailyTotalBox"
        Me.dailyTotalBox.ReadOnly = True
        Me.dailyTotalBox.Size = New System.Drawing.Size(100, 20)
        Me.dailyTotalBox.TabIndex = 26
        '
        'avgPCusBox
        '
        Me.avgPCusBox.Location = New System.Drawing.Point(920, 194)
        Me.avgPCusBox.Name = "avgPCusBox"
        Me.avgPCusBox.ReadOnly = True
        Me.avgPCusBox.Size = New System.Drawing.Size(100, 20)
        Me.avgPCusBox.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1219, 609)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.InputPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.InputPanel.ResumeLayout(False)
        Me.InputPanel.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents IDLabel As Label
    Friend WithEvents SBLabel As Label
    Friend WithEvents SBwBLabel As Label
    Friend WithEvents InputPanel As Panel
    Friend WithEvents rentalLabel As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents nameBox As TextBox
    Friend WithEvents idBox As TextBox
    Friend WithEvents sbBox As TextBox
    Friend WithEvents sbwbBox As TextBox
    Friend WithEvents totalBox As TextBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents clearAllButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents DisplayBox As RichTextBox
    Friend WithEvents exitButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents sumButton As Button
    Friend WithEvents totalSBwBbox As TextBox
    Friend WithEvents totalSBbox As TextBox
    Friend WithEvents sumLabel As Label
    Friend WithEvents dailyTotalLabel As Label
    Friend WithEvents sbwbTotalLabel As Label
    Friend WithEvents sbTotalLabel As Label
    Friend WithEvents avgPCusBox As TextBox
    Friend WithEvents dailyTotalBox As TextBox
    Friend WithEvents sbwbTotalBox As TextBox
    Friend WithEvents sbTotalBox As TextBox
    Friend WithEvents avgPCusLabel As Label
End Class
