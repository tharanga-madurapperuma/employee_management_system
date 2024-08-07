namespace EmployeeManagementSystem
{
    partial class jobRole
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.selectJobRole = new Siticone.UI.WinForms.SiticoneComboBox();
            this.basicSalary = new Siticone.UI.WinForms.SiticoneLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.EPF = new Siticone.UI.WinForms.SiticoneLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.ETF = new Siticone.UI.WinForms.SiticoneLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.OT = new Siticone.UI.WinForms.SiticoneLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.NET = new Siticone.UI.WinForms.SiticoneLabel();
            this.jobRoleEditDataButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.jobRoleOkButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.salaryPanel = new Siticone.UI.WinForms.SiticonePanel();
            this.salaryUpdatePanel = new Siticone.UI.WinForms.SiticonePanel();
            this.OTInput = new Siticone.UI.WinForms.SiticoneTextBox();
            this.ETFInput = new Siticone.UI.WinForms.SiticoneTextBox();
            this.EPFInput = new Siticone.UI.WinForms.SiticoneTextBox();
            this.basicSalaryInput = new Siticone.UI.WinForms.SiticoneTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.salaryPanel.SuspendLayout();
            this.salaryUpdatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(97, 150);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(174, 22);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Select the job role";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(74, 17);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Basic Salary";
            // 
            // selectJobRole
            // 
            this.selectJobRole.BackColor = System.Drawing.Color.DimGray;
            this.selectJobRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectJobRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectJobRole.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectJobRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.selectJobRole.FormattingEnabled = true;
            this.selectJobRole.HoveredState.Parent = this.selectJobRole;
            this.selectJobRole.ItemHeight = 30;
            this.selectJobRole.Items.AddRange(new object[] {
            "Intern",
            "Junoir Developer",
            "Software Devoloper",
            "Senior Developer",
            "Technical Lead",
            "QA Engineer",
            "UI/UX Designer",
            "Project Manager",
            "Business Analyst",
            "DevOps Engineer",
            "System Administrator",
            "CTO"});
            this.selectJobRole.ItemsAppearance.Parent = this.selectJobRole;
            this.selectJobRole.Location = new System.Drawing.Point(101, 191);
            this.selectJobRole.Name = "selectJobRole";
            this.selectJobRole.ShadowDecoration.Parent = this.selectJobRole;
            this.selectJobRole.Size = new System.Drawing.Size(242, 36);
            this.selectJobRole.TabIndex = 0;
            this.selectJobRole.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox1_SelectedIndexChanged);
            // 
            // basicSalary
            // 
            this.basicSalary.BackColor = System.Drawing.Color.Transparent;
            this.basicSalary.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicSalary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.basicSalary.Location = new System.Drawing.Point(103, 51);
            this.basicSalary.Name = "basicSalary";
            this.basicSalary.Size = new System.Drawing.Size(114, 22);
            this.basicSalary.TabIndex = 2;
            this.basicSalary.Text = "siticoneLabel1";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(74, 110);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "EPF";
            // 
            // EPF
            // 
            this.EPF.BackColor = System.Drawing.Color.Transparent;
            this.EPF.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EPF.Location = new System.Drawing.Point(103, 144);
            this.EPF.Name = "EPF";
            this.EPF.Size = new System.Drawing.Size(114, 22);
            this.EPF.TabIndex = 2;
            this.EPF.Text = "siticoneLabel1";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(538, 110);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(38, 20);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "ETF";
            // 
            // ETF
            // 
            this.ETF.BackColor = System.Drawing.Color.Transparent;
            this.ETF.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ETF.Location = new System.Drawing.Point(567, 144);
            this.ETF.Name = "ETF";
            this.ETF.Size = new System.Drawing.Size(114, 22);
            this.ETF.TabIndex = 2;
            this.ETF.Text = "siticoneLabel1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(74, 207);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(149, 20);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Overtime Per Hour";
            // 
            // OT
            // 
            this.OT.BackColor = System.Drawing.Color.Transparent;
            this.OT.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OT.Location = new System.Drawing.Point(103, 241);
            this.OT.Name = "OT";
            this.OT.Size = new System.Drawing.Size(114, 22);
            this.OT.TabIndex = 2;
            this.OT.Text = "siticoneLabel1";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(538, 207);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(173, 20);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Net Salary without OT";
            // 
            // NET
            // 
            this.NET.BackColor = System.Drawing.Color.Transparent;
            this.NET.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NET.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NET.Location = new System.Drawing.Point(567, 241);
            this.NET.Name = "NET";
            this.NET.Size = new System.Drawing.Size(114, 22);
            this.NET.TabIndex = 2;
            this.NET.Text = "siticoneLabel1";
            // 
            // jobRoleEditDataButton
            // 
            this.jobRoleEditDataButton.CheckedState.Parent = this.jobRoleEditDataButton;
            this.jobRoleEditDataButton.CustomImages.Parent = this.jobRoleEditDataButton;
            this.jobRoleEditDataButton.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobRoleEditDataButton.ForeColor = System.Drawing.Color.White;
            this.jobRoleEditDataButton.HoveredState.Parent = this.jobRoleEditDataButton;
            this.jobRoleEditDataButton.Location = new System.Drawing.Point(725, 597);
            this.jobRoleEditDataButton.Name = "jobRoleEditDataButton";
            this.jobRoleEditDataButton.ShadowDecoration.Parent = this.jobRoleEditDataButton;
            this.jobRoleEditDataButton.Size = new System.Drawing.Size(158, 45);
            this.jobRoleEditDataButton.TabIndex = 3;
            this.jobRoleEditDataButton.Text = "Edit Data";
            this.jobRoleEditDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // jobRoleOkButton
            // 
            this.jobRoleOkButton.CheckedState.Parent = this.jobRoleOkButton;
            this.jobRoleOkButton.CustomImages.Parent = this.jobRoleOkButton;
            this.jobRoleOkButton.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobRoleOkButton.ForeColor = System.Drawing.Color.White;
            this.jobRoleOkButton.HoveredState.Parent = this.jobRoleOkButton;
            this.jobRoleOkButton.Location = new System.Drawing.Point(928, 597);
            this.jobRoleOkButton.Name = "jobRoleOkButton";
            this.jobRoleOkButton.ShadowDecoration.Parent = this.jobRoleOkButton;
            this.jobRoleOkButton.Size = new System.Drawing.Size(98, 45);
            this.jobRoleOkButton.TabIndex = 3;
            this.jobRoleOkButton.Text = "OK";
            this.jobRoleOkButton.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Roboto Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel7.Location = new System.Drawing.Point(361, 44);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(386, 34);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "EMPLOYEE SALARY DETAILS";
            // 
            // salaryPanel
            // 
            this.salaryPanel.Controls.Add(this.NET);
            this.salaryPanel.Controls.Add(this.ETF);
            this.salaryPanel.Controls.Add(this.gunaLabel6);
            this.salaryPanel.Controls.Add(this.gunaLabel4);
            this.salaryPanel.Controls.Add(this.OT);
            this.salaryPanel.Controls.Add(this.EPF);
            this.salaryPanel.Controls.Add(this.gunaLabel5);
            this.salaryPanel.Controls.Add(this.gunaLabel3);
            this.salaryPanel.Controls.Add(this.basicSalary);
            this.salaryPanel.Controls.Add(this.gunaLabel2);
            this.salaryPanel.Location = new System.Drawing.Point(101, 262);
            this.salaryPanel.Name = "salaryPanel";
            this.salaryPanel.ShadowDecoration.Parent = this.salaryPanel;
            this.salaryPanel.Size = new System.Drawing.Size(925, 309);
            this.salaryPanel.TabIndex = 4;
            // 
            // salaryUpdatePanel
            // 
            this.salaryUpdatePanel.Controls.Add(this.OTInput);
            this.salaryUpdatePanel.Controls.Add(this.ETFInput);
            this.salaryUpdatePanel.Controls.Add(this.EPFInput);
            this.salaryUpdatePanel.Controls.Add(this.basicSalaryInput);
            this.salaryUpdatePanel.Controls.Add(this.gunaLabel9);
            this.salaryUpdatePanel.Controls.Add(this.gunaLabel10);
            this.salaryUpdatePanel.Controls.Add(this.gunaLabel11);
            this.salaryUpdatePanel.Controls.Add(this.gunaLabel12);
            this.salaryUpdatePanel.Location = new System.Drawing.Point(101, 262);
            this.salaryUpdatePanel.Name = "salaryUpdatePanel";
            this.salaryUpdatePanel.ShadowDecoration.Parent = this.salaryUpdatePanel;
            this.salaryUpdatePanel.Size = new System.Drawing.Size(925, 309);
            this.salaryUpdatePanel.TabIndex = 4;
            // 
            // OTInput
            // 
            this.OTInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OTInput.DefaultText = "";
            this.OTInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OTInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OTInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OTInput.DisabledState.Parent = this.OTInput;
            this.OTInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OTInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OTInput.FocusedState.Parent = this.OTInput;
            this.OTInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OTInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OTInput.HoveredState.Parent = this.OTInput;
            this.OTInput.Location = new System.Drawing.Point(78, 236);
            this.OTInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OTInput.Name = "OTInput";
            this.OTInput.PasswordChar = '\0';
            this.OTInput.PlaceholderText = "";
            this.OTInput.SelectedText = "";
            this.OTInput.ShadowDecoration.Parent = this.OTInput;
            this.OTInput.Size = new System.Drawing.Size(267, 34);
            this.OTInput.TabIndex = 2;
            // 
            // ETFInput
            // 
            this.ETFInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ETFInput.DefaultText = "";
            this.ETFInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ETFInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ETFInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ETFInput.DisabledState.Parent = this.ETFInput;
            this.ETFInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ETFInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ETFInput.FocusedState.Parent = this.ETFInput;
            this.ETFInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ETFInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ETFInput.HoveredState.Parent = this.ETFInput;
            this.ETFInput.Location = new System.Drawing.Point(542, 139);
            this.ETFInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ETFInput.Name = "ETFInput";
            this.ETFInput.PasswordChar = '\0';
            this.ETFInput.PlaceholderText = "";
            this.ETFInput.SelectedText = "";
            this.ETFInput.ShadowDecoration.Parent = this.ETFInput;
            this.ETFInput.Size = new System.Drawing.Size(267, 34);
            this.ETFInput.TabIndex = 2;
            // 
            // EPFInput
            // 
            this.EPFInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EPFInput.DefaultText = "";
            this.EPFInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EPFInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EPFInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EPFInput.DisabledState.Parent = this.EPFInput;
            this.EPFInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EPFInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EPFInput.FocusedState.Parent = this.EPFInput;
            this.EPFInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EPFInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EPFInput.HoveredState.Parent = this.EPFInput;
            this.EPFInput.Location = new System.Drawing.Point(78, 138);
            this.EPFInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EPFInput.Name = "EPFInput";
            this.EPFInput.PasswordChar = '\0';
            this.EPFInput.PlaceholderText = "";
            this.EPFInput.SelectedText = "";
            this.EPFInput.ShadowDecoration.Parent = this.EPFInput;
            this.EPFInput.Size = new System.Drawing.Size(267, 34);
            this.EPFInput.TabIndex = 2;
            // 
            // basicSalaryInput
            // 
            this.basicSalaryInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.basicSalaryInput.DefaultText = "";
            this.basicSalaryInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.basicSalaryInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.basicSalaryInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.basicSalaryInput.DisabledState.Parent = this.basicSalaryInput;
            this.basicSalaryInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.basicSalaryInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.basicSalaryInput.FocusedState.Parent = this.basicSalaryInput;
            this.basicSalaryInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.basicSalaryInput.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.basicSalaryInput.HoveredState.Parent = this.basicSalaryInput;
            this.basicSalaryInput.Location = new System.Drawing.Point(78, 50);
            this.basicSalaryInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.basicSalaryInput.Name = "basicSalaryInput";
            this.basicSalaryInput.PasswordChar = '\0';
            this.basicSalaryInput.PlaceholderText = "";
            this.basicSalaryInput.SelectedText = "";
            this.basicSalaryInput.ShadowDecoration.Parent = this.basicSalaryInput;
            this.basicSalaryInput.Size = new System.Drawing.Size(267, 34);
            this.basicSalaryInput.TabIndex = 2;
            this.basicSalaryInput.TextChanged += new System.EventHandler(this.SalaryInputChange);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(538, 110);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(38, 20);
            this.gunaLabel9.TabIndex = 1;
            this.gunaLabel9.Text = "ETF";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(74, 207);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(149, 20);
            this.gunaLabel10.TabIndex = 1;
            this.gunaLabel10.Text = "Overtime Per Hour";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(74, 110);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel11.TabIndex = 1;
            this.gunaLabel11.Text = "EPF";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.Location = new System.Drawing.Point(74, 17);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(101, 20);
            this.gunaLabel12.TabIndex = 1;
            this.gunaLabel12.Text = "Basic Salary";
            // 
            // jobRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salaryUpdatePanel);
            this.Controls.Add(this.salaryPanel);
            this.Controls.Add(this.jobRoleOkButton);
            this.Controls.Add(this.jobRoleEditDataButton);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.selectJobRole);
            this.Name = "jobRole";
            this.Size = new System.Drawing.Size(1167, 695);
            this.Load += new System.EventHandler(this.jobRole_Load);
            this.salaryPanel.ResumeLayout(false);
            this.salaryPanel.PerformLayout();
            this.salaryUpdatePanel.ResumeLayout(false);
            this.salaryUpdatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Siticone.UI.WinForms.SiticoneComboBox selectJobRole;
        private Siticone.UI.WinForms.SiticoneLabel basicSalary;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Siticone.UI.WinForms.SiticoneLabel EPF;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Siticone.UI.WinForms.SiticoneLabel ETF;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Siticone.UI.WinForms.SiticoneLabel OT;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Siticone.UI.WinForms.SiticoneLabel NET;
        private Siticone.UI.WinForms.SiticoneRoundedButton jobRoleEditDataButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton jobRoleOkButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Siticone.UI.WinForms.SiticonePanel salaryPanel;
        private Siticone.UI.WinForms.SiticonePanel salaryUpdatePanel;
        private Siticone.UI.WinForms.SiticoneTextBox OTInput;
        private Siticone.UI.WinForms.SiticoneTextBox ETFInput;
        private Siticone.UI.WinForms.SiticoneTextBox EPFInput;
        private Siticone.UI.WinForms.SiticoneTextBox basicSalaryInput;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
    }
}
