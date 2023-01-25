<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_user
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dtg_listUser = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Button1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_New = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_saveuser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbo_type = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txt_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbl_id = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 16)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(874, 322)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.Controls.Add(Me.dtg_listUser)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(874, 319)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "List of Users"
        '
        'dtg_listUser
        '
        Me.dtg_listUser.AllowUserToAddRows = False
        Me.dtg_listUser.AllowUserToDeleteRows = False
        Me.dtg_listUser.AllowUserToResizeColumns = False
        Me.dtg_listUser.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dtg_listUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_listUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtg_listUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_listUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_listUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_listUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_listUser.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_listUser.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtg_listUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_listUser.EnableHeadersVisualStyles = False
        Me.dtg_listUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dtg_listUser.Location = New System.Drawing.Point(0, 41)
        Me.dtg_listUser.Name = "dtg_listUser"
        Me.dtg_listUser.RowHeadersVisible = False
        Me.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_listUser.Size = New System.Drawing.Size(874, 278)
        Me.dtg_listUser.TabIndex = 0
        Me.dtg_listUser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.dtg_listUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dtg_listUser.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtg_listUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtg_listUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtg_listUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtg_listUser.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtg_listUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dtg_listUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dtg_listUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtg_listUser.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg_listUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtg_listUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtg_listUser.ThemeStyle.HeaderStyle.Height = 35
        Me.dtg_listUser.ThemeStyle.ReadOnly = False
        Me.dtg_listUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dtg_listUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_listUser.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg_listUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtg_listUser.ThemeStyle.RowsStyle.Height = 22
        Me.dtg_listUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.dtg_listUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(874, 16)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 22
        Me.Guna2Panel3.Controls.Add(Me.Button1)
        Me.Guna2Panel3.Controls.Add(Me.btn_New)
        Me.Guna2Panel3.Controls.Add(Me.btn_delete)
        Me.Guna2Panel3.Controls.Add(Me.btn_update)
        Me.Guna2Panel3.Controls.Add(Me.btn_saveuser)
        Me.Guna2Panel3.Controls.Add(Me.txt_pass)
        Me.Guna2Panel3.Controls.Add(Me.txt_username)
        Me.Guna2Panel3.Controls.Add(Me.cbo_type)
        Me.Guna2Panel3.Controls.Add(Me.txt_name)
        Me.Guna2Panel3.Controls.Add(Me.lbl_id)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(35, 358)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(804, 278)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Animated = True
        Me.Button1.AutoRoundedCorners = True
        Me.Button1.BorderRadius = 20
        Me.Button1.CheckedState.Parent = Me.Button1
        Me.Button1.CustomImages.Parent = Me.Button1
        Me.Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.HoverState.Parent = Me.Button1
        Me.Button1.Location = New System.Drawing.Point(603, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.ShadowDecoration.Parent = Me.Button1
        Me.Button1.Size = New System.Drawing.Size(86, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Close"
        '
        'btn_New
        '
        Me.btn_New.Animated = True
        Me.btn_New.AutoRoundedCorners = True
        Me.btn_New.BorderRadius = 20
        Me.btn_New.CheckedState.Parent = Me.btn_New
        Me.btn_New.CustomImages.Parent = Me.btn_New
        Me.btn_New.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_New.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_New.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.ForeColor = System.Drawing.Color.White
        Me.btn_New.HoverState.Parent = Me.btn_New
        Me.btn_New.Location = New System.Drawing.Point(481, 187)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.ShadowDecoration.Parent = Me.btn_New
        Me.btn_New.Size = New System.Drawing.Size(86, 42)
        Me.btn_New.TabIndex = 8
        Me.btn_New.Text = "New"
        '
        'btn_delete
        '
        Me.btn_delete.Animated = True
        Me.btn_delete.AutoRoundedCorners = True
        Me.btn_delete.BorderRadius = 20
        Me.btn_delete.CheckedState.Parent = Me.btn_delete
        Me.btn_delete.CustomImages.Parent = Me.btn_delete
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_delete.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.HoverState.Parent = Me.btn_delete
        Me.btn_delete.Location = New System.Drawing.Point(359, 187)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(86, 42)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "Delete"
        '
        'btn_update
        '
        Me.btn_update.Animated = True
        Me.btn_update.AutoRoundedCorners = True
        Me.btn_update.BorderRadius = 20
        Me.btn_update.CheckedState.Parent = Me.btn_update
        Me.btn_update.CustomImages.Parent = Me.btn_update
        Me.btn_update.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_update.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.HoverState.Parent = Me.btn_update
        Me.btn_update.Location = New System.Drawing.Point(237, 187)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.ShadowDecoration.Parent = Me.btn_update
        Me.btn_update.Size = New System.Drawing.Size(86, 42)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "Update"
        '
        'btn_saveuser
        '
        Me.btn_saveuser.Animated = True
        Me.btn_saveuser.AutoRoundedCorners = True
        Me.btn_saveuser.BorderRadius = 20
        Me.btn_saveuser.CheckedState.Parent = Me.btn_saveuser
        Me.btn_saveuser.CustomImages.Parent = Me.btn_saveuser
        Me.btn_saveuser.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_saveuser.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_saveuser.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveuser.ForeColor = System.Drawing.Color.White
        Me.btn_saveuser.HoverState.Parent = Me.btn_saveuser
        Me.btn_saveuser.Location = New System.Drawing.Point(115, 187)
        Me.btn_saveuser.Name = "btn_saveuser"
        Me.btn_saveuser.ShadowDecoration.Parent = Me.btn_saveuser
        Me.btn_saveuser.Size = New System.Drawing.Size(86, 42)
        Me.btn_saveuser.TabIndex = 5
        Me.btn_saveuser.Text = "Save"
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_pass.ForeColor = System.Drawing.Color.Black
        Me.txt_pass.HintForeColor = System.Drawing.Color.Black
        Me.txt_pass.HintText = "Password"
        Me.txt_pass.isPassword = False
        Me.txt_pass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_pass.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_pass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_pass.LineThickness = 3
        Me.txt_pass.Location = New System.Drawing.Point(442, 45)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(273, 41)
        Me.txt_pass.TabIndex = 4
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_username.ForeColor = System.Drawing.Color.Black
        Me.txt_username.HintForeColor = System.Drawing.Color.Black
        Me.txt_username.HintText = "Username"
        Me.txt_username.isPassword = False
        Me.txt_username.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_username.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_username.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_username.LineThickness = 3
        Me.txt_username.Location = New System.Drawing.Point(84, 110)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(273, 41)
        Me.txt_username.TabIndex = 3
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbo_type
        '
        Me.cbo_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbo_type.BorderRadius = 10
        Me.cbo_type.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.ForeColor = System.Drawing.Color.Black
        Me.cbo_type.Items = New String() {"Administrator", "Staff"}
        Me.cbo_type.Location = New System.Drawing.Point(442, 110)
        Me.cbo_type.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.NomalColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbo_type.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbo_type.selectedIndex = -1
        Me.cbo_type.Size = New System.Drawing.Size(273, 41)
        Me.cbo_type.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.txt_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.HintForeColor = System.Drawing.Color.Black
        Me.txt_name.HintText = "Full name"
        Me.txt_name.isPassword = False
        Me.txt_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_name.LineThickness = 3
        Me.txt_name.Location = New System.Drawing.Point(84, 45)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(273, 41)
        Me.txt_name.TabIndex = 1
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_id
        '
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(156, 198)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(11, 15)
        Me.lbl_id.TabIndex = 10
        Me.lbl_id.Text = "id"
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 648)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_user"
        Me.Text = "frm_user"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dtg_listUser As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txt_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbo_type As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txt_username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_saveuser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_New As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lbl_id As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
