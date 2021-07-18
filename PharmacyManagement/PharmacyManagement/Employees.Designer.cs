namespace PharmacyManagement
{
    partial class Employees
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.empName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empSalary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.empGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.empBday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.empRole = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployees.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmployees.Location = new System.Drawing.Point(42, 30);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(217, 40);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "Employees";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmpId.Location = new System.Drawing.Point(225, 129);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(34, 25);
            this.lblEmpId.TabIndex = 8;
            this.lblEmpId.Text = "00";
            // 
            // empName
            // 
            this.empName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.Maroon;
            this.empName.HintForeColor = System.Drawing.Color.Gray;
            this.empName.HintText = "Enter medicine name";
            this.empName.isPassword = false;
            this.empName.LineFocusedColor = System.Drawing.Color.Maroon;
            this.empName.LineIdleColor = System.Drawing.Color.Transparent;
            this.empName.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.empName.LineThickness = 3;
            this.empName.Location = new System.Drawing.Point(78, 206);
            this.empName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(249, 57);
            this.empName.TabIndex = 0;
            this.empName.Text = "Employee Name";
            this.empName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empAddress
            // 
            this.empAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddress.ForeColor = System.Drawing.Color.Maroon;
            this.empAddress.HintForeColor = System.Drawing.Color.Gray;
            this.empAddress.HintText = "Enter medicine name";
            this.empAddress.isPassword = false;
            this.empAddress.LineFocusedColor = System.Drawing.Color.Maroon;
            this.empAddress.LineIdleColor = System.Drawing.Color.Transparent;
            this.empAddress.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.empAddress.LineThickness = 3;
            this.empAddress.Location = new System.Drawing.Point(78, 305);
            this.empAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empAddress.Name = "empAddress";
            this.empAddress.Size = new System.Drawing.Size(249, 57);
            this.empAddress.TabIndex = 1;
            this.empAddress.Text = "Employee Address";
            this.empAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empPhone
            // 
            this.empPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone.ForeColor = System.Drawing.Color.Maroon;
            this.empPhone.HintForeColor = System.Drawing.Color.Gray;
            this.empPhone.HintText = "Enter medicine name";
            this.empPhone.isPassword = false;
            this.empPhone.LineFocusedColor = System.Drawing.Color.Maroon;
            this.empPhone.LineIdleColor = System.Drawing.Color.Transparent;
            this.empPhone.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.empPhone.LineThickness = 3;
            this.empPhone.Location = new System.Drawing.Point(911, 108);
            this.empPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(249, 57);
            this.empPhone.TabIndex = 5;
            this.empPhone.Text = "Employee Phone No";
            this.empPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empEmail
            // 
            this.empEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEmail.ForeColor = System.Drawing.Color.Maroon;
            this.empEmail.HintForeColor = System.Drawing.Color.Gray;
            this.empEmail.HintText = "Enter medicine name";
            this.empEmail.isPassword = false;
            this.empEmail.LineFocusedColor = System.Drawing.Color.Maroon;
            this.empEmail.LineIdleColor = System.Drawing.Color.Transparent;
            this.empEmail.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.empEmail.LineThickness = 3;
            this.empEmail.Location = new System.Drawing.Point(494, 108);
            this.empEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(249, 57);
            this.empEmail.TabIndex = 2;
            this.empEmail.Text = "Employee E-mail";
            this.empEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empSalary
            // 
            this.empSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSalary.ForeColor = System.Drawing.Color.Maroon;
            this.empSalary.HintForeColor = System.Drawing.Color.Gray;
            this.empSalary.HintText = "Enter medicine name";
            this.empSalary.isPassword = false;
            this.empSalary.LineFocusedColor = System.Drawing.Color.Maroon;
            this.empSalary.LineIdleColor = System.Drawing.Color.Transparent;
            this.empSalary.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.empSalary.LineThickness = 3;
            this.empSalary.Location = new System.Drawing.Point(911, 305);
            this.empSalary.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(249, 57);
            this.empSalary.TabIndex = 7;
            this.empSalary.Text = "Employee Salary";
            this.empSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(73, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Employee ID :";
            // 
            // empGender
            // 
            this.empGender.BackColor = System.Drawing.Color.Transparent;
            this.empGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.empGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empGender.FocusedState.Parent = this.empGender;
            this.empGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.empGender.ForeColor = System.Drawing.Color.Maroon;
            this.empGender.HoverState.Parent = this.empGender;
            this.empGender.ItemHeight = 30;
            this.empGender.Items.AddRange(new object[] {
            "Select Gender",
            "Male",
            "Female"});
            this.empGender.ItemsAppearance.Parent = this.empGender;
            this.empGender.Location = new System.Drawing.Point(494, 331);
            this.empGender.Name = "empGender";
            this.empGender.ShadowDecoration.Parent = this.empGender;
            this.empGender.Size = new System.Drawing.Size(249, 36);
            this.empGender.StartIndex = 0;
            this.empGender.TabIndex = 4;
            // 
            // empBday
            // 
            this.empBday.CheckedState.Parent = this.empBday;
            this.empBday.FillColor = System.Drawing.Color.Maroon;
            this.empBday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBday.ForeColor = System.Drawing.Color.White;
            this.empBday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.empBday.HoverState.Parent = this.empBday;
            this.empBday.Location = new System.Drawing.Point(494, 216);
            this.empBday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.empBday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.empBday.Name = "empBday";
            this.empBday.ShadowDecoration.Parent = this.empBday;
            this.empBday.Size = new System.Drawing.Size(249, 51);
            this.empBday.TabIndex = 3;
            this.empBday.Value = new System.DateTime(2021, 7, 16, 13, 9, 5, 8);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(491, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Employee\'s birth day";
            // 
            // empRole
            // 
            this.empRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRole.ForeColor = System.Drawing.Color.Maroon;
            this.empRole.HintForeColor = System.Drawing.Color.Gray;
            this.empRole.HintText = "Enter medicine name";
            this.empRole.isPassword = false;
            this.empRole.LineFocusedColor = System.Drawing.Color.Maroon;
            this.empRole.LineIdleColor = System.Drawing.Color.Transparent;
            this.empRole.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.empRole.LineThickness = 3;
            this.empRole.Location = new System.Drawing.Point(911, 206);
            this.empRole.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empRole.Name = "empRole";
            this.empRole.Size = new System.Drawing.Size(249, 57);
            this.empRole.TabIndex = 6;
            this.empRole.Text = "Employee Role";
            this.empRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvEmployee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployee.Location = new System.Drawing.Point(49, 409);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1177, 350);
            this.dgvEmployee.TabIndex = 19;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmployee.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvEmployee.ThemeStyle.ReadOnly = false;
            this.dgvEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmployee.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(1319, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(174, 55);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button4.FocusedColor = System.Drawing.Color.Maroon;
            this.guna2Button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(1319, 605);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.DarkRed;
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(174, 55);
            this.guna2Button4.TabIndex = 21;
            this.guna2Button4.Text = "EXIT";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 15;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Maroon;
            this.btnBack.FocusedColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(1319, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedColor = System.Drawing.Color.DarkRed;
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(174, 55);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Maroon;
            this.btnDelete.FocusedColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(1319, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.DarkRed;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(174, 55);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Maroon;
            this.btnAdd.FocusedColor = System.Drawing.Color.Maroon;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1319, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.DarkRed;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(174, 55);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1567, 31);
            this.panel1.TabIndex = 25;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1567, 786);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.empRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empBday);
            this.Controls.Add(this.empGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empSalary);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.empPhone);
            this.Controls.Add(this.empAddress);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.lblEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblEmpId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empSalary;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox empGender;
        private Guna.UI2.WinForms.Guna2DateTimePicker empBday;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empRole;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployee;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel panel1;
    }
}