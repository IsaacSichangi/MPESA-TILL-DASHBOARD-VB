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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.account_amount = New System.Windows.Forms.Label()
        Me.accountbalance_title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dailyrevenue = New System.Windows.Forms.Label()
        Me.dailyrevenue_title = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.monthlyrevenue_title = New System.Windows.Forms.Label()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.phonenumber = New System.Windows.Forms.TextBox()
        Me.searchphonenumber_btn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.yearlyrevenue = New System.Windows.Forms.Label()
        Me.yearlyrevenue_title = New System.Windows.Forms.Label()
        Me.searchphone_gbx = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.from_date = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.to_date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchtransactions_btn = New System.Windows.Forms.Button()
        Me.transactions_listview = New System.Windows.Forms.ListView()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.searchphone_gbx.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1116, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSourceToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DataSourceToolStripMenuItem
        '
        Me.DataSourceToolStripMenuItem.Name = "DataSourceToolStripMenuItem"
        Me.DataSourceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataSourceToolStripMenuItem.Text = "Data Source"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthlyToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'MonthlyToolStripMenuItem
        '
        Me.MonthlyToolStripMenuItem.Name = "MonthlyToolStripMenuItem"
        Me.MonthlyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MonthlyToolStripMenuItem.Text = "Generate"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutorialsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TutorialsToolStripMenuItem
        '
        Me.TutorialsToolStripMenuItem.Name = "TutorialsToolStripMenuItem"
        Me.TutorialsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TutorialsToolStripMenuItem.Text = "Tutorials"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.account_amount)
        Me.Panel1.Controls.Add(Me.accountbalance_title)
        Me.Panel1.Location = New System.Drawing.Point(37, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 96)
        Me.Panel1.TabIndex = 1
        '
        'account_amount
        '
        Me.account_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_amount.ForeColor = System.Drawing.Color.White
        Me.account_amount.Location = New System.Drawing.Point(3, 34)
        Me.account_amount.Name = "account_amount"
        Me.account_amount.Size = New System.Drawing.Size(213, 49)
        Me.account_amount.TabIndex = 9
        Me.account_amount.Text = "Ksh 0"
        Me.account_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'accountbalance_title
        '
        Me.accountbalance_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.accountbalance_title.ForeColor = System.Drawing.Color.White
        Me.accountbalance_title.Location = New System.Drawing.Point(44, 13)
        Me.accountbalance_title.Name = "accountbalance_title"
        Me.accountbalance_title.Size = New System.Drawing.Size(124, 13)
        Me.accountbalance_title.TabIndex = 9
        Me.accountbalance_title.Text = "ACCOUNT BALANCE"
        Me.accountbalance_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.dailyrevenue)
        Me.Panel2.Controls.Add(Me.dailyrevenue_title)
        Me.Panel2.Location = New System.Drawing.Point(317, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 96)
        Me.Panel2.TabIndex = 2
        '
        'dailyrevenue
        '
        Me.dailyrevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailyrevenue.ForeColor = System.Drawing.Color.White
        Me.dailyrevenue.Location = New System.Drawing.Point(2, 34)
        Me.dailyrevenue.Name = "dailyrevenue"
        Me.dailyrevenue.Size = New System.Drawing.Size(213, 49)
        Me.dailyrevenue.TabIndex = 11
        Me.dailyrevenue.Text = "Ksh 0"
        Me.dailyrevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dailyrevenue_title
        '
        Me.dailyrevenue_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.dailyrevenue_title.ForeColor = System.Drawing.Color.White
        Me.dailyrevenue_title.Location = New System.Drawing.Point(3, 13)
        Me.dailyrevenue_title.Name = "dailyrevenue_title"
        Me.dailyrevenue_title.Size = New System.Drawing.Size(210, 21)
        Me.dailyrevenue_title.TabIndex = 10
        Me.dailyrevenue_title.Text = "DAILY REVENUE"
        Me.dailyrevenue_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.monthlyrevenue_title)
        Me.Panel3.Location = New System.Drawing.Point(583, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(235, 96)
        Me.Panel3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 49)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ksh 0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'monthlyrevenue_title
        '
        Me.monthlyrevenue_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.monthlyrevenue_title.ForeColor = System.Drawing.Color.White
        Me.monthlyrevenue_title.Location = New System.Drawing.Point(3, 13)
        Me.monthlyrevenue_title.Name = "monthlyrevenue_title"
        Me.monthlyrevenue_title.Size = New System.Drawing.Size(229, 13)
        Me.monthlyrevenue_title.TabIndex = 10
        Me.monthlyrevenue_title.Text = "MONTHLY REVENUE"
        Me.monthlyrevenue_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(851, 207)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(226, 34)
        Me.refresh_btn.TabIndex = 5
        Me.refresh_btn.Text = "REFRESH"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'phonenumber
        '
        Me.phonenumber.Location = New System.Drawing.Point(9, 28)
        Me.phonenumber.MaxLength = 10
        Me.phonenumber.Name = "phonenumber"
        Me.phonenumber.Size = New System.Drawing.Size(163, 20)
        Me.phonenumber.TabIndex = 7
        '
        'searchphonenumber_btn
        '
        Me.searchphonenumber_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchphonenumber_btn.Location = New System.Drawing.Point(15, 66)
        Me.searchphonenumber_btn.Name = "searchphonenumber_btn"
        Me.searchphonenumber_btn.Size = New System.Drawing.Size(102, 30)
        Me.searchphonenumber_btn.TabIndex = 8
        Me.searchphonenumber_btn.Text = "SEARCH"
        Me.searchphonenumber_btn.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Controls.Add(Me.yearlyrevenue)
        Me.Panel4.Controls.Add(Me.yearlyrevenue_title)
        Me.Panel4.Location = New System.Drawing.Point(864, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 96)
        Me.Panel4.TabIndex = 9
        '
        'yearlyrevenue
        '
        Me.yearlyrevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearlyrevenue.ForeColor = System.Drawing.Color.White
        Me.yearlyrevenue.Location = New System.Drawing.Point(2, 34)
        Me.yearlyrevenue.Name = "yearlyrevenue"
        Me.yearlyrevenue.Size = New System.Drawing.Size(213, 49)
        Me.yearlyrevenue.TabIndex = 11
        Me.yearlyrevenue.Text = "Ksh 0"
        Me.yearlyrevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'yearlyrevenue_title
        '
        Me.yearlyrevenue_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.yearlyrevenue_title.ForeColor = System.Drawing.Color.White
        Me.yearlyrevenue_title.Location = New System.Drawing.Point(3, 13)
        Me.yearlyrevenue_title.Name = "yearlyrevenue_title"
        Me.yearlyrevenue_title.Size = New System.Drawing.Size(210, 13)
        Me.yearlyrevenue_title.TabIndex = 10
        Me.yearlyrevenue_title.Text = "YEARLY REVENUE"
        Me.yearlyrevenue_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchphone_gbx
        '
        Me.searchphone_gbx.Controls.Add(Me.phonenumber)
        Me.searchphone_gbx.Controls.Add(Me.searchphonenumber_btn)
        Me.searchphone_gbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchphone_gbx.Location = New System.Drawing.Point(851, 267)
        Me.searchphone_gbx.Name = "searchphone_gbx"
        Me.searchphone_gbx.Size = New System.Drawing.Size(226, 118)
        Me.searchphone_gbx.TabIndex = 10
        Me.searchphone_gbx.TabStop = False
        Me.searchphone_gbx.Text = "SEARCH PHONENUMBER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.searchtransactions_btn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.to_date)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.from_date)
        Me.GroupBox1.Location = New System.Drawing.Point(851, 416)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 181)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH TRANSACTIONS"
        '
        'from_date
        '
        Me.from_date.Location = New System.Drawing.Point(15, 45)
        Me.from_date.Name = "from_date"
        Me.from_date.Size = New System.Drawing.Size(200, 20)
        Me.from_date.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FROM"
        '
        'to_date
        '
        Me.to_date.Location = New System.Drawing.Point(15, 105)
        Me.to_date.Name = "to_date"
        Me.to_date.Size = New System.Drawing.Size(200, 20)
        Me.to_date.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TO"
        '
        'searchtransactions_btn
        '
        Me.searchtransactions_btn.Location = New System.Drawing.Point(15, 143)
        Me.searchtransactions_btn.Name = "searchtransactions_btn"
        Me.searchtransactions_btn.Size = New System.Drawing.Size(102, 29)
        Me.searchtransactions_btn.TabIndex = 4
        Me.searchtransactions_btn.Text = "SEARCH"
        Me.searchtransactions_btn.UseVisualStyleBackColor = True
        '
        'transactions_listview
        '
        Me.transactions_listview.FullRowSelect = True
        Me.transactions_listview.GridLines = True
        Me.transactions_listview.Location = New System.Drawing.Point(37, 183)
        Me.transactions_listview.Name = "transactions_listview"
        Me.transactions_listview.Size = New System.Drawing.Size(781, 414)
        Me.transactions_listview.TabIndex = 12
        Me.transactions_listview.UseCompatibleStateImageBehavior = False
        Me.transactions_listview.View = System.Windows.Forms.View.Details
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 668)
        Me.Controls.Add(Me.transactions_listview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.searchphone_gbx)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "MPESA TILL DASHBOARD"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.searchphone_gbx.ResumeLayout(False)
        Me.searchphone_gbx.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutorialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents refresh_btn As System.Windows.Forms.Button
    Friend WithEvents phonenumber As System.Windows.Forms.TextBox
    Friend WithEvents searchphonenumber_btn As System.Windows.Forms.Button
    Friend WithEvents accountbalance_title As System.Windows.Forms.Label
    Friend WithEvents account_amount As System.Windows.Forms.Label
    Friend WithEvents dailyrevenue As System.Windows.Forms.Label
    Friend WithEvents dailyrevenue_title As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents monthlyrevenue_title As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents yearlyrevenue As System.Windows.Forms.Label
    Friend WithEvents yearlyrevenue_title As System.Windows.Forms.Label
    Friend WithEvents searchphone_gbx As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents from_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents searchtransactions_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents to_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents transactions_listview As System.Windows.Forms.ListView

End Class
