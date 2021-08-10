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
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim TITLELabel As System.Windows.Forms.Label
        Dim FIRSTNAMELabel As System.Windows.Forms.Label
        Dim LASTNAMELabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim PHONE_NUMBERLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.CUSTOMER_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SHOPDataSet = New INVENTORY_MANAGEMENT_SYSTEM.SHOPDataSet()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.FIRSTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.LASTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.PHONE_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUserName = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CUSTOMER_DETAILSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbSearch = New System.Windows.Forms.ToolStripComboBox()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.CUSTOMER_DETAILSTableAdapter = New INVENTORY_MANAGEMENT_SYSTEM.SHOPDataSetTableAdapters.CUSTOMER_DETAILSTableAdapter()
        Me.TableAdapterManager = New INVENTORY_MANAGEMENT_SYSTEM.SHOPDataSetTableAdapters.TableAdapterManager()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        TITLELabel = New System.Windows.Forms.Label()
        FIRSTNAMELabel = New System.Windows.Forms.Label()
        LASTNAMELabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        PHONE_NUMBERLabel = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CUSTOMER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUSTOMER_DETAILSBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(6, 26)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(97, 13)
        CUSTOMER_IDLabel.TabIndex = 0
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Location = New System.Drawing.Point(6, 52)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(46, 13)
        TITLELabel.TabIndex = 2
        TITLELabel.Text = "TITLE:"
        '
        'FIRSTNAMELabel
        '
        FIRSTNAMELabel.AutoSize = True
        FIRSTNAMELabel.Location = New System.Drawing.Point(6, 78)
        FIRSTNAMELabel.Name = "FIRSTNAMELabel"
        FIRSTNAMELabel.Size = New System.Drawing.Size(82, 13)
        FIRSTNAMELabel.TabIndex = 4
        FIRSTNAMELabel.Text = "FIRSTNAME:"
        '
        'LASTNAMELabel
        '
        LASTNAMELabel.AutoSize = True
        LASTNAMELabel.Location = New System.Drawing.Point(6, 104)
        LASTNAMELabel.Name = "LASTNAMELabel"
        LASTNAMELabel.Size = New System.Drawing.Size(77, 13)
        LASTNAMELabel.TabIndex = 6
        LASTNAMELabel.Text = "LASTNAME:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(6, 130)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(70, 13)
        ADDRESSLabel.TabIndex = 8
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'PHONE_NUMBERLabel
        '
        PHONE_NUMBERLabel.AutoSize = True
        PHONE_NUMBERLabel.Location = New System.Drawing.Point(6, 156)
        PHONE_NUMBERLabel.Name = "PHONE_NUMBERLabel"
        PHONE_NUMBERLabel.Size = New System.Drawing.Size(111, 13)
        PHONE_NUMBERLabel.TabIndex = 10
        PHONE_NUMBERLabel.Text = "PHONE NUMBER:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(8, 296)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1018, 208)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.btnClose)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnPrevious)
        Me.TabPage1.Controls.Add(Me.btnNext)
        Me.TabPage1.Controls.Add(Me.btnADD)
        Me.TabPage1.Controls.Add(Me.CUSTOMER_DETAILSDataGridView)
        Me.TabPage1.Controls.Add(CUSTOMER_IDLabel)
        Me.TabPage1.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.TabPage1.Controls.Add(TITLELabel)
        Me.TabPage1.Controls.Add(Me.TITLETextBox)
        Me.TabPage1.Controls.Add(FIRSTNAMELabel)
        Me.TabPage1.Controls.Add(Me.FIRSTNAMETextBox)
        Me.TabPage1.Controls.Add(LASTNAMELabel)
        Me.TabPage1.Controls.Add(Me.LASTNAMETextBox)
        Me.TabPage1.Controls.Add(ADDRESSLabel)
        Me.TabPage1.Controls.Add(Me.ADDRESSTextBox)
        Me.TabPage1.Controls.Add(PHONE_NUMBERLabel)
        Me.TabPage1.Controls.Add(Me.PHONE_NUMBERTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1010, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CUSTOMER DETAILS"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(433, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 27)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "EXIT"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(433, 78)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(81, 27)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(433, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(317, 142)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(79, 27)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(317, 78)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(79, 27)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(317, 23)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(79, 27)
        Me.btnADD.TabIndex = 3
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'CUSTOMER_DETAILSDataGridView
        '
        Me.CUSTOMER_DETAILSDataGridView.AutoGenerateColumns = False
        Me.CUSTOMER_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CUSTOMER_DETAILSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CUSTOMER_DETAILSDataGridView.DataSource = Me.CUSTOMER_DETAILSBindingSource
        Me.CUSTOMER_DETAILSDataGridView.Location = New System.Drawing.Point(9, 182)
        Me.CUSTOMER_DETAILSDataGridView.Name = "CUSTOMER_DETAILSDataGridView"
        Me.CUSTOMER_DETAILSDataGridView.Size = New System.Drawing.Size(642, 149)
        Me.CUSTOMER_DETAILSDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TITLE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TITLE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FIRSTNAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FIRSTNAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LASTNAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LASTNAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PHONE NUMBER"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PHONE NUMBER"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CUSTOMER_DETAILSBindingSource
        '
        Me.CUSTOMER_DETAILSBindingSource.DataMember = "CUSTOMER DETAILS"
        Me.CUSTOMER_DETAILSBindingSource.DataSource = Me.SHOPDataSet
        '
        'SHOPDataSet
        '
        Me.SHOPDataSet.DataSetName = "SHOPDataSet"
        Me.SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(123, 23)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 1
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "TITLE", True))
        Me.TITLETextBox.Location = New System.Drawing.Point(123, 49)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TITLETextBox.TabIndex = 3
        '
        'FIRSTNAMETextBox
        '
        Me.FIRSTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "FIRSTNAME", True))
        Me.FIRSTNAMETextBox.Location = New System.Drawing.Point(123, 75)
        Me.FIRSTNAMETextBox.Name = "FIRSTNAMETextBox"
        Me.FIRSTNAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.FIRSTNAMETextBox.TabIndex = 5
        '
        'LASTNAMETextBox
        '
        Me.LASTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "LASTNAME", True))
        Me.LASTNAMETextBox.Location = New System.Drawing.Point(123, 101)
        Me.LASTNAMETextBox.Name = "LASTNAMETextBox"
        Me.LASTNAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.LASTNAMETextBox.TabIndex = 7
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(123, 127)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ADDRESSTextBox.TabIndex = 9
        '
        'PHONE_NUMBERTextBox
        '
        Me.PHONE_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "PHONE NUMBER", True))
        Me.PHONE_NUMBERTextBox.Location = New System.Drawing.Point(123, 153)
        Me.PHONE_NUMBERTextBox.Name = "PHONE_NUMBERTextBox"
        Me.PHONE_NUMBERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PHONE_NUMBERTextBox.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1010, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PRODUCT DETAILS"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1010, 182)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PRODUCT ORDER"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1010, 182)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "PRODUCT CATALOG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbUserName)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnPassword)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1018, 617)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(202, 154)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(137, 20)
        Me.txtUserName.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Username"
        '
        'cmbUserName
        '
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.Location = New System.Drawing.Point(202, 95)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.Size = New System.Drawing.Size(137, 21)
        Me.cmbUserName.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(202, 201)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(137, 20)
        Me.txtPassword.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(349, 267)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(181, 267)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(91, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPassword
        '
        Me.btnPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.Location = New System.Drawing.Point(44, 267)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(91, 23)
        Me.btnPassword.TabIndex = 1
        Me.btnPassword.Text = "Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(57, 200)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 16)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(57, 95)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(88, 16)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LOGIN SCREEN"
        '
        'CUSTOMER_DETAILSBindingNavigator
        '
        Me.CUSTOMER_DETAILSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CUSTOMER_DETAILSBindingNavigator.BindingSource = Me.CUSTOMER_DETAILSBindingSource
        Me.CUSTOMER_DETAILSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUSTOMER_DETAILSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CUSTOMER_DETAILSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CUSTOMER_DETAILSBindingNavigatorSaveItem, Me.ToolStripLabel1, Me.cmbSearch, Me.txtSearch, Me.btnSearch})
        Me.CUSTOMER_DETAILSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CUSTOMER_DETAILSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CUSTOMER_DETAILSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CUSTOMER_DETAILSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CUSTOMER_DETAILSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CUSTOMER_DETAILSBindingNavigator.Name = "CUSTOMER_DETAILSBindingNavigator"
        Me.CUSTOMER_DETAILSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUSTOMER_DETAILSBindingNavigator.Size = New System.Drawing.Size(1352, 25)
        Me.CUSTOMER_DETAILSBindingNavigator.TabIndex = 2
        Me.CUSTOMER_DETAILSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CUSTOMER_DETAILSBindingNavigatorSaveItem
        '
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Image = CType(resources.GetObject("CUSTOMER_DETAILSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Name = "CUSTOMER_DETAILSBindingNavigatorSaveItem"
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Search"
        '
        'cmbSearch
        '
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 25)
        '
        'txtSearch
        '
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 25)
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 546)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1014, 100)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage5
        '
        Me.TabPage5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1006, 71)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "PRODUCT ORDERS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1006, 71)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "PRODUCT CATALOG"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'CUSTOMER_DETAILSTableAdapter
        '
        Me.CUSTOMER_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMER_DETAILSTableAdapter = Me.CUSTOMER_DETAILSTableAdapter
        Me.TableAdapterManager.PRODUCT_CATALOGTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_ORDERSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = INVENTORY_MANAGEMENT_SYSTEM.SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 661)
        Me.Controls.Add(Me.CUSTOMER_DETAILSBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SHOP INVENTORY"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CUSTOMER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CUSTOMER_DETAILSBindingNavigator.ResumeLayout(False)
        Me.CUSTOMER_DETAILSBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPassword As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SHOPDataSet As SHOPDataSet
    Friend WithEvents CUSTOMER_DETAILSBindingSource As BindingSource
    Friend WithEvents CUSTOMER_DETAILSTableAdapter As SHOPDataSetTableAdapters.CUSTOMER_DETAILSTableAdapter
    Friend WithEvents TableAdapterManager As SHOPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUSTOMER_DETAILSBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CUSTOMER_DETAILSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CUSTOMER_DETAILSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_IDTextBox As TextBox
    Friend WithEvents TITLETextBox As TextBox
    Friend WithEvents FIRSTNAMETextBox As TextBox
    Friend WithEvents LASTNAMETextBox As TextBox
    Friend WithEvents ADDRESSTextBox As TextBox
    Friend WithEvents PHONE_NUMBERTextBox As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents cmbUserName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmbSearch As ToolStripComboBox
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents btnSearch As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
End Class
