namespace PharmacyManagement
{
    partial class Medicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputMedName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputSprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputExpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.inputCompany = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvMedicine = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.lblMedId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Stock";
            // 
            // inputBprice
            // 
            this.inputBprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBprice.ForeColor = System.Drawing.Color.Maroon;
            this.inputBprice.HintForeColor = System.Drawing.Color.Gray;
            this.inputBprice.HintText = "Enter buying price";
            this.inputBprice.isPassword = false;
            this.inputBprice.LineFocusedColor = System.Drawing.Color.Maroon;
            this.inputBprice.LineIdleColor = System.Drawing.Color.Transparent;
            this.inputBprice.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.inputBprice.LineThickness = 3;
            this.inputBprice.Location = new System.Drawing.Point(368, 123);
            this.inputBprice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputBprice.Name = "inputBprice";
            this.inputBprice.Size = new System.Drawing.Size(249, 57);
            this.inputBprice.TabIndex = 0;
            this.inputBprice.Text = "Buying Price";
            this.inputBprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputMedName
            // 
            this.inputMedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputMedName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMedName.ForeColor = System.Drawing.Color.Maroon;
            this.inputMedName.HintForeColor = System.Drawing.Color.Gray;
            this.inputMedName.HintText = "Enter medicine name";
            this.inputMedName.isPassword = false;
            this.inputMedName.LineFocusedColor = System.Drawing.Color.Maroon;
            this.inputMedName.LineIdleColor = System.Drawing.Color.Transparent;
            this.inputMedName.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.inputMedName.LineThickness = 3;
            this.inputMedName.Location = new System.Drawing.Point(41, 123);
            this.inputMedName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputMedName.Name = "inputMedName";
            this.inputMedName.Size = new System.Drawing.Size(249, 57);
            this.inputMedName.TabIndex = 0;
            this.inputMedName.Text = "Medicine Name";
            this.inputMedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputSprice
            // 
            this.inputSprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSprice.ForeColor = System.Drawing.Color.Maroon;
            this.inputSprice.HintForeColor = System.Drawing.Color.Gray;
            this.inputSprice.HintText = "Enter selling price";
            this.inputSprice.isPassword = false;
            this.inputSprice.LineFocusedColor = System.Drawing.Color.Maroon;
            this.inputSprice.LineIdleColor = System.Drawing.Color.Transparent;
            this.inputSprice.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.inputSprice.LineThickness = 3;
            this.inputSprice.Location = new System.Drawing.Point(368, 215);
            this.inputSprice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputSprice.Name = "inputSprice";
            this.inputSprice.Size = new System.Drawing.Size(249, 57);
            this.inputSprice.TabIndex = 0;
            this.inputSprice.Text = "Selling Price";
            this.inputSprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputQty
            // 
            this.inputQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputQty.ForeColor = System.Drawing.Color.Maroon;
            this.inputQty.HintForeColor = System.Drawing.Color.Gray;
            this.inputQty.HintText = "Enter quantity";
            this.inputQty.isPassword = false;
            this.inputQty.LineFocusedColor = System.Drawing.Color.Maroon;
            this.inputQty.LineIdleColor = System.Drawing.Color.Transparent;
            this.inputQty.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.inputQty.LineThickness = 3;
            this.inputQty.Location = new System.Drawing.Point(368, 322);
            this.inputQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputQty.Name = "inputQty";
            this.inputQty.Size = new System.Drawing.Size(249, 57);
            this.inputQty.TabIndex = 0;
            this.inputQty.Text = "Quantity";
            this.inputQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputExpDate
            // 
            this.inputExpDate.CheckedState.Parent = this.inputExpDate;
            this.inputExpDate.FillColor = System.Drawing.Color.Maroon;
            this.inputExpDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputExpDate.ForeColor = System.Drawing.Color.White;
            this.inputExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inputExpDate.HoverState.Parent = this.inputExpDate;
            this.inputExpDate.Location = new System.Drawing.Point(41, 230);
            this.inputExpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.inputExpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.inputExpDate.Name = "inputExpDate";
            this.inputExpDate.ShadowDecoration.Parent = this.inputExpDate;
            this.inputExpDate.Size = new System.Drawing.Size(249, 51);
            this.inputExpDate.TabIndex = 2;
            this.inputExpDate.Value = new System.DateTime(2021, 7, 16, 13, 9, 5, 8);
            // 
            // inputCompany
            // 
            this.inputCompany.BackColor = System.Drawing.Color.Transparent;
            this.inputCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inputCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputCompany.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputCompany.FocusedState.Parent = this.inputCompany;
            this.inputCompany.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputCompany.ForeColor = System.Drawing.Color.Maroon;
            this.inputCompany.HoverState.Parent = this.inputCompany;
            this.inputCompany.ItemHeight = 30;
            this.inputCompany.Items.AddRange(new object[] {
            "Select Company",
            "INDIAMED",
            "KARANTAKAMED",
            "SPC SRILANKA",
            "BLRMED",
            "MYCOMP",
            "MYMED LTD"});
            this.inputCompany.ItemsAppearance.Parent = this.inputCompany;
            this.inputCompany.Location = new System.Drawing.Point(41, 345);
            this.inputCompany.Name = "inputCompany";
            this.inputCompany.ShadowDecoration.Parent = this.inputCompany;
            this.inputCompany.Size = new System.Drawing.Size(249, 36);
            this.inputCompany.StartIndex = 0;
            this.inputCompany.TabIndex = 3;
            // 
            // dgvMedicine
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicine.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMedicine.ColumnHeadersHeight = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicine.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMedicine.EnableHeadersVisualStyles = false;
            this.dgvMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicine.Location = new System.Drawing.Point(650, 48);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.RowHeadersVisible = false;
            this.dgvMedicine.RowHeadersWidth = 51;
            this.dgvMedicine.RowTemplate.Height = 24;
            this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicine.Size = new System.Drawing.Size(889, 713);
            this.dgvMedicine.TabIndex = 4;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicine.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMedicine.ThemeStyle.ReadOnly = false;
            this.dgvMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicine.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicine_CellContentClick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Maroon;
            this.btnLogin.FocusedColor = System.Drawing.Color.Maroon;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(85, 494);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.DarkRed;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(174, 55);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "ADD";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(371, 494);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(174, 55);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(85, 579);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.DarkRed;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(174, 55);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnBack.Location = new System.Drawing.Point(371, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedColor = System.Drawing.Color.DarkRed;
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(174, 55);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
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
            this.guna2Button4.Location = new System.Drawing.Point(228, 673);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.DarkRed;
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(174, 55);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "EXIT";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // lblMedId
            // 
            this.lblMedId.AutoSize = true;
            this.lblMedId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedId.ForeColor = System.Drawing.Color.Maroon;
            this.lblMedId.Location = new System.Drawing.Point(45, 424);
            this.lblMedId.Name = "lblMedId";
            this.lblMedId.Size = new System.Drawing.Size(115, 25);
            this.lblMedId.TabIndex = 7;
            this.lblMedId.Text = "Medicine ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1567, 31);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(1526, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 36);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(40, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Expire date of medicine";
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 786);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMedId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inputCompany);
            this.Controls.Add(this.inputExpDate);
            this.Controls.Add(this.inputMedName);
            this.Controls.Add(this.inputQty);
            this.Controls.Add(this.inputSprice);
            this.Controls.Add(this.inputBprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputBprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputMedName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputSprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputQty;
        private Guna.UI2.WinForms.Guna2DateTimePicker inputExpDate;
        private Guna.UI2.WinForms.Guna2ComboBox inputCompany;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicine;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label lblMedId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}