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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpGroupDetails = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblNoOfChildren = New System.Windows.Forms.Label()
        Me.lblMaritalStatus = New System.Windows.Forms.Label()
        Me.lblYearsWorked = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtNoOfChildren = New System.Windows.Forms.TextBox()
        Me.txtYearsWorked = New System.Windows.Forms.TextBox()
        Me.cboMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.grpAllowances = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLongServeBonus = New System.Windows.Forms.Label()
        Me.lblFamilyAllowance = New System.Windows.Forms.Label()
        Me.lblTotalAllowances = New System.Windows.Forms.Label()
        Me.txtLongServeBonus = New System.Windows.Forms.TextBox()
        Me.txtFamilyAllowance = New System.Windows.Forms.TextBox()
        Me.txtTotalAllowances = New System.Windows.Forms.TextBox()
        Me.grpSalarySummary = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStartingSalary = New System.Windows.Forms.Label()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.lblNetSalary = New System.Windows.Forms.Label()
        Me.lblGrossSalary = New System.Windows.Forms.Label()
        Me.txtStartingSalary = New System.Windows.Forms.TextBox()
        Me.txtBasicSalary = New System.Windows.Forms.TextBox()
        Me.txtGrossSalary = New System.Windows.Forms.TextBox()
        Me.txtNetSalary = New System.Windows.Forms.TextBox()
        Me.grpDeduction = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPaye = New System.Windows.Forms.Label()
        Me.lblNssf = New System.Windows.Forms.Label()
        Me.lblTotalDeduction = New System.Windows.Forms.Label()
        Me.txtPaye = New System.Windows.Forms.TextBox()
        Me.txtNssf = New System.Windows.Forms.TextBox()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.lblCompute = New System.Windows.Forms.Button()
        Me.lblClose = New System.Windows.Forms.Button()
        Me.grpGroupDetails.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpAllowances.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpSalarySummary.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpDeduction.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpGroupDetails
        '
        Me.grpGroupDetails.Controls.Add(Me.TableLayoutPanel1)
        Me.grpGroupDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpGroupDetails.Name = "grpGroupDetails"
        Me.grpGroupDetails.Size = New System.Drawing.Size(299, 140)
        Me.grpGroupDetails.TabIndex = 0
        Me.grpGroupDetails.TabStop = False
        Me.grpGroupDetails.Text = "PERSONAL DETAILS"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmployeeName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNoOfChildren, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMaritalStatus, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYearsWorked, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmployeeName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNoOfChildren, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtYearsWorked, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboMaritalStatus, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(287, 107)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(3, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(82, 13)
        Me.lblEmployeeName.TabIndex = 0
        Me.lblEmployeeName.Text = "Employee name"
        '
        'lblNoOfChildren
        '
        Me.lblNoOfChildren.AutoSize = True
        Me.lblNoOfChildren.Location = New System.Drawing.Point(3, 26)
        Me.lblNoOfChildren.Name = "lblNoOfChildren"
        Me.lblNoOfChildren.Size = New System.Drawing.Size(73, 13)
        Me.lblNoOfChildren.TabIndex = 2
        Me.lblNoOfChildren.Text = "No of children"
        '
        'lblMaritalStatus
        '
        Me.lblMaritalStatus.AutoSize = True
        Me.lblMaritalStatus.Location = New System.Drawing.Point(3, 78)
        Me.lblMaritalStatus.Name = "lblMaritalStatus"
        Me.lblMaritalStatus.Size = New System.Drawing.Size(69, 13)
        Me.lblMaritalStatus.TabIndex = 3
        Me.lblMaritalStatus.Text = "Marital status"
        '
        'lblYearsWorked
        '
        Me.lblYearsWorked.AutoSize = True
        Me.lblYearsWorked.Location = New System.Drawing.Point(3, 51)
        Me.lblYearsWorked.Name = "lblYearsWorked"
        Me.lblYearsWorked.Size = New System.Drawing.Size(72, 13)
        Me.lblYearsWorked.TabIndex = 1
        Me.lblYearsWorked.Text = "Years worked"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(146, 3)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(138, 20)
        Me.txtEmployeeName.TabIndex = 4
        '
        'txtNoOfChildren
        '
        Me.txtNoOfChildren.Location = New System.Drawing.Point(146, 29)
        Me.txtNoOfChildren.Name = "txtNoOfChildren"
        Me.txtNoOfChildren.Size = New System.Drawing.Size(138, 20)
        Me.txtNoOfChildren.TabIndex = 5
        '
        'txtYearsWorked
        '
        Me.txtYearsWorked.Location = New System.Drawing.Point(146, 54)
        Me.txtYearsWorked.Name = "txtYearsWorked"
        Me.txtYearsWorked.Size = New System.Drawing.Size(138, 20)
        Me.txtYearsWorked.TabIndex = 6
        '
        'cboMaritalStatus
        '
        Me.cboMaritalStatus.FormattingEnabled = True
        Me.cboMaritalStatus.Items.AddRange(New Object() {"Married", "Single", "Divorced", "Widowed"})
        Me.cboMaritalStatus.Location = New System.Drawing.Point(146, 81)
        Me.cboMaritalStatus.Name = "cboMaritalStatus"
        Me.cboMaritalStatus.Size = New System.Drawing.Size(138, 21)
        Me.cboMaritalStatus.TabIndex = 7
        '
        'grpAllowances
        '
        Me.grpAllowances.Controls.Add(Me.TableLayoutPanel2)
        Me.grpAllowances.Location = New System.Drawing.Point(335, 12)
        Me.grpAllowances.Name = "grpAllowances"
        Me.grpAllowances.Size = New System.Drawing.Size(251, 140)
        Me.grpAllowances.TabIndex = 0
        Me.grpAllowances.TabStop = False
        Me.grpAllowances.Text = "ALLOWANCES"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.09623!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.90377!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblLongServeBonus, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFamilyAllowance, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTotalAllowances, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtLongServeBonus, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFamilyAllowance, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTotalAllowances, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(239, 74)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lblLongServeBonus
        '
        Me.lblLongServeBonus.AutoSize = True
        Me.lblLongServeBonus.Location = New System.Drawing.Point(3, 0)
        Me.lblLongServeBonus.Name = "lblLongServeBonus"
        Me.lblLongServeBonus.Size = New System.Drawing.Size(92, 13)
        Me.lblLongServeBonus.TabIndex = 0
        Me.lblLongServeBonus.Text = "Long serve bonus"
        '
        'lblFamilyAllowance
        '
        Me.lblFamilyAllowance.AutoSize = True
        Me.lblFamilyAllowance.Location = New System.Drawing.Point(3, 24)
        Me.lblFamilyAllowance.Name = "lblFamilyAllowance"
        Me.lblFamilyAllowance.Size = New System.Drawing.Size(87, 13)
        Me.lblFamilyAllowance.TabIndex = 2
        Me.lblFamilyAllowance.Text = "Family allowance"
        '
        'lblTotalAllowances
        '
        Me.lblTotalAllowances.AutoSize = True
        Me.lblTotalAllowances.Location = New System.Drawing.Point(3, 48)
        Me.lblTotalAllowances.Name = "lblTotalAllowances"
        Me.lblTotalAllowances.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalAllowances.TabIndex = 1
        Me.lblTotalAllowances.Text = "Total allowances"
        '
        'txtLongServeBonus
        '
        Me.txtLongServeBonus.Location = New System.Drawing.Point(105, 3)
        Me.txtLongServeBonus.Name = "txtLongServeBonus"
        Me.txtLongServeBonus.Size = New System.Drawing.Size(131, 20)
        Me.txtLongServeBonus.TabIndex = 3
        '
        'txtFamilyAllowance
        '
        Me.txtFamilyAllowance.Location = New System.Drawing.Point(105, 27)
        Me.txtFamilyAllowance.Name = "txtFamilyAllowance"
        Me.txtFamilyAllowance.Size = New System.Drawing.Size(131, 20)
        Me.txtFamilyAllowance.TabIndex = 4
        '
        'txtTotalAllowances
        '
        Me.txtTotalAllowances.Location = New System.Drawing.Point(105, 51)
        Me.txtTotalAllowances.Name = "txtTotalAllowances"
        Me.txtTotalAllowances.Size = New System.Drawing.Size(131, 20)
        Me.txtTotalAllowances.TabIndex = 5
        '
        'grpSalarySummary
        '
        Me.grpSalarySummary.Controls.Add(Me.TableLayoutPanel3)
        Me.grpSalarySummary.Location = New System.Drawing.Point(12, 158)
        Me.grpSalarySummary.Name = "grpSalarySummary"
        Me.grpSalarySummary.Size = New System.Drawing.Size(299, 160)
        Me.grpSalarySummary.TabIndex = 0
        Me.grpSalarySummary.TabStop = False
        Me.grpSalarySummary.Text = "SALARY SUMMARY"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblStartingSalary, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblBasicSalary, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblNetSalary, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblGrossSalary, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtStartingSalary, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtBasicSalary, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtGrossSalary, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtNetSalary, 1, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(287, 112)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblStartingSalary
        '
        Me.lblStartingSalary.AutoSize = True
        Me.lblStartingSalary.Location = New System.Drawing.Point(3, 0)
        Me.lblStartingSalary.Name = "lblStartingSalary"
        Me.lblStartingSalary.Size = New System.Drawing.Size(73, 13)
        Me.lblStartingSalary.TabIndex = 0
        Me.lblStartingSalary.Text = "Starting salary"
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Location = New System.Drawing.Point(3, 27)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(63, 13)
        Me.lblBasicSalary.TabIndex = 2
        Me.lblBasicSalary.Text = "Basic salary"
        '
        'lblNetSalary
        '
        Me.lblNetSalary.AutoSize = True
        Me.lblNetSalary.Location = New System.Drawing.Point(3, 85)
        Me.lblNetSalary.Name = "lblNetSalary"
        Me.lblNetSalary.Size = New System.Drawing.Size(54, 13)
        Me.lblNetSalary.TabIndex = 3
        Me.lblNetSalary.Text = "Net salary"
        '
        'lblGrossSalary
        '
        Me.lblGrossSalary.AutoSize = True
        Me.lblGrossSalary.Location = New System.Drawing.Point(3, 56)
        Me.lblGrossSalary.Name = "lblGrossSalary"
        Me.lblGrossSalary.Size = New System.Drawing.Size(64, 13)
        Me.lblGrossSalary.TabIndex = 1
        Me.lblGrossSalary.Text = "Gross salary"
        '
        'txtStartingSalary
        '
        Me.txtStartingSalary.Location = New System.Drawing.Point(146, 3)
        Me.txtStartingSalary.Name = "txtStartingSalary"
        Me.txtStartingSalary.Size = New System.Drawing.Size(138, 20)
        Me.txtStartingSalary.TabIndex = 4
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.Location = New System.Drawing.Point(146, 30)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(138, 20)
        Me.txtBasicSalary.TabIndex = 5
        '
        'txtGrossSalary
        '
        Me.txtGrossSalary.Location = New System.Drawing.Point(146, 59)
        Me.txtGrossSalary.Name = "txtGrossSalary"
        Me.txtGrossSalary.Size = New System.Drawing.Size(138, 20)
        Me.txtGrossSalary.TabIndex = 6
        '
        'txtNetSalary
        '
        Me.txtNetSalary.Location = New System.Drawing.Point(146, 88)
        Me.txtNetSalary.Name = "txtNetSalary"
        Me.txtNetSalary.Size = New System.Drawing.Size(138, 20)
        Me.txtNetSalary.TabIndex = 7
        '
        'grpDeduction
        '
        Me.grpDeduction.Controls.Add(Me.TableLayoutPanel4)
        Me.grpDeduction.Location = New System.Drawing.Point(335, 158)
        Me.grpDeduction.Name = "grpDeduction"
        Me.grpDeduction.Size = New System.Drawing.Size(251, 117)
        Me.grpDeduction.TabIndex = 0
        Me.grpDeduction.TabStop = False
        Me.grpDeduction.Text = "DEDUCTION"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.82008!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.17992!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblPaye, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblNssf, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblTotalDeduction, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtPaye, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtNssf, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTotalDeduction, 1, 2)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(239, 79)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'lblPaye
        '
        Me.lblPaye.AutoSize = True
        Me.lblPaye.Location = New System.Drawing.Point(3, 0)
        Me.lblPaye.Name = "lblPaye"
        Me.lblPaye.Size = New System.Drawing.Size(44, 13)
        Me.lblPaye.TabIndex = 0
        Me.lblPaye.Text = "P.A.Y.E"
        '
        'lblNssf
        '
        Me.lblNssf.AutoSize = True
        Me.lblNssf.Location = New System.Drawing.Point(3, 24)
        Me.lblNssf.Name = "lblNssf"
        Me.lblNssf.Size = New System.Drawing.Size(35, 13)
        Me.lblNssf.TabIndex = 2
        Me.lblNssf.Text = "NSSF"
        '
        'lblTotalDeduction
        '
        Me.lblTotalDeduction.AutoSize = True
        Me.lblTotalDeduction.Location = New System.Drawing.Point(3, 48)
        Me.lblTotalDeduction.Name = "lblTotalDeduction"
        Me.lblTotalDeduction.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalDeduction.TabIndex = 1
        Me.lblTotalDeduction.Text = "Total deduction"
        '
        'txtPaye
        '
        Me.txtPaye.Location = New System.Drawing.Point(90, 3)
        Me.txtPaye.Name = "txtPaye"
        Me.txtPaye.Size = New System.Drawing.Size(146, 20)
        Me.txtPaye.TabIndex = 3
        '
        'txtNssf
        '
        Me.txtNssf.Location = New System.Drawing.Point(90, 27)
        Me.txtNssf.Name = "txtNssf"
        Me.txtNssf.Size = New System.Drawing.Size(146, 20)
        Me.txtNssf.TabIndex = 4
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.Location = New System.Drawing.Point(90, 51)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.Size = New System.Drawing.Size(146, 20)
        Me.txtTotalDeduction.TabIndex = 5
        '
        'lblCompute
        '
        Me.lblCompute.Location = New System.Drawing.Point(335, 281)
        Me.lblCompute.Name = "lblCompute"
        Me.lblCompute.Size = New System.Drawing.Size(117, 37)
        Me.lblCompute.TabIndex = 1
        Me.lblCompute.Text = "Compute"
        Me.lblCompute.UseVisualStyleBackColor = True
        '
        'lblClose
        '
        Me.lblClose.Location = New System.Drawing.Point(474, 281)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(112, 37)
        Me.lblClose.TabIndex = 2
        Me.lblClose.Text = "Close"
        Me.lblClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 332)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblCompute)
        Me.Controls.Add(Me.grpAllowances)
        Me.Controls.Add(Me.grpSalarySummary)
        Me.Controls.Add(Me.grpDeduction)
        Me.Controls.Add(Me.grpGroupDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PINNACLE PAY ROLL"
        Me.grpGroupDetails.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpAllowances.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.grpSalarySummary.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.grpDeduction.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpGroupDetails As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblNoOfChildren As Label
    Friend WithEvents lblMaritalStatus As Label
    Friend WithEvents lblYearsWorked As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtNoOfChildren As TextBox
    Friend WithEvents txtYearsWorked As TextBox
    Friend WithEvents cboMaritalStatus As ComboBox
    Friend WithEvents grpAllowances As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblLongServeBonus As Label
    Friend WithEvents lblFamilyAllowance As Label
    Friend WithEvents lblTotalAllowances As Label
    Friend WithEvents txtLongServeBonus As TextBox
    Friend WithEvents txtFamilyAllowance As TextBox
    Friend WithEvents txtTotalAllowances As TextBox
    Friend WithEvents grpSalarySummary As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblStartingSalary As Label
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents lblNetSalary As Label
    Friend WithEvents lblGrossSalary As Label
    Friend WithEvents txtStartingSalary As TextBox
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtGrossSalary As TextBox
    Friend WithEvents txtNetSalary As TextBox
    Friend WithEvents grpDeduction As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblPaye As Label
    Friend WithEvents lblNssf As Label
    Friend WithEvents lblTotalDeduction As Label
    Friend WithEvents txtPaye As TextBox
    Friend WithEvents txtNssf As TextBox
    Friend WithEvents txtTotalDeduction As TextBox
    Friend WithEvents lblCompute As Button
    Friend WithEvents lblClose As Button
End Class
