namespace PharmacyManagement
{
    partial class Billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.lblBilling = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.medSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStocks = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.dgvBilling = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.newQtyInput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.BackColor = System.Drawing.Color.Transparent;
            this.lblBilling.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.ForeColor = System.Drawing.Color.Maroon;
            this.lblBilling.Location = new System.Drawing.Point(48, 43);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(239, 40);
            this.lblBilling.TabIndex = 3;
            this.lblBilling.Text = "Billing Form";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 31);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // medSelect
            // 
            this.medSelect.BackColor = System.Drawing.Color.Transparent;
            this.medSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.medSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medSelect.FocusedState.Parent = this.medSelect;
            this.medSelect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.medSelect.ForeColor = System.Drawing.Color.Maroon;
            this.medSelect.HoverState.Parent = this.medSelect;
            this.medSelect.ItemHeight = 30;
            this.medSelect.Items.AddRange(new object[] {
            "Select Medicine"});
            this.medSelect.ItemsAppearance.Parent = this.medSelect;
            this.medSelect.Location = new System.Drawing.Point(136, 148);
            this.medSelect.Name = "medSelect";
            this.medSelect.ShadowDecoration.Parent = this.medSelect;
            this.medSelect.Size = new System.Drawing.Size(249, 36);
            this.medSelect.StartIndex = 0;
            this.medSelect.TabIndex = 5;
            this.medSelect.SelectedIndexChanged += new System.EventHandler(this.medSelect_SelectedIndexChanged);
            this.medSelect.SelectionChangeCommitted += new System.EventHandler(this.medSelect_SelectionChangeCommitted);
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStocks.ForeColor = System.Drawing.Color.Maroon;
            this.lblStocks.Location = new System.Drawing.Point(138, 247);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(67, 25);
            this.lblStocks.TabIndex = 17;
            this.lblStocks.Text = "00000";
            this.lblStocks.Visible = false;
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
            this.btnClose.Location = new System.Drawing.Point(1502, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 36);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderRadius = 15;
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.DisabledState.Parent = this.btnBill;
            this.btnBill.FillColor = System.Drawing.Color.Maroon;
            this.btnBill.FocusedColor = System.Drawing.Color.Maroon;
            this.btnBill.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.Location = new System.Drawing.Point(161, 502);
            this.btnBill.Name = "btnBill";
            this.btnBill.PressedColor = System.Drawing.Color.DarkRed;
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(212, 65);
            this.btnBill.TabIndex = 27;
            this.btnBill.Text = "ADD TO BILL";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // dgvBilling
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvBilling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilling.BackgroundColor = System.Drawing.Color.White;
            this.dgvBilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBilling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBilling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvBilling.ColumnHeadersHeight = 40;
            this.dgvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedID,
            this.MedName,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBilling.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvBilling.EnableHeadersVisualStyles = false;
            this.dgvBilling.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBilling.Location = new System.Drawing.Point(563, 51);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersVisible = false;
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.RowTemplate.Height = 24;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilling.Size = new System.Drawing.Size(940, 578);
            this.dgvBilling.TabIndex = 28;
            this.dgvBilling.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBilling.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBilling.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBilling.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBilling.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBilling.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBilling.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBilling.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBilling.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBilling.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBilling.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBilling.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBilling.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvBilling.ThemeStyle.ReadOnly = false;
            this.dgvBilling.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBilling.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBilling.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBilling.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBilling.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBilling.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBilling.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MedID
            // 
            this.MedID.HeaderText = "MedID";
            this.MedID.MinimumWidth = 6;
            this.MedID.Name = "MedID";
            // 
            // MedName
            // 
            this.MedName.HeaderText = "MedName";
            this.MedName.MinimumWidth = 6;
            this.MedName.Name = "MedName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalAmount.Location = new System.Drawing.Point(48, 620);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(237, 40);
            this.lblTotalAmount.TabIndex = 29;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 15;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.DisabledState.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.Maroon;
            this.btnPrint.FocusedColor = System.Drawing.Color.Maroon;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(654, 649);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PressedColor = System.Drawing.Color.DarkRed;
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(212, 65);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // newQtyInput
            // 
            this.newQtyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newQtyInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQtyInput.ForeColor = System.Drawing.Color.Maroon;
            this.newQtyInput.HintForeColor = System.Drawing.Color.Gray;
            this.newQtyInput.HintText = "";
            this.newQtyInput.isPassword = false;
            this.newQtyInput.LineFocusedColor = System.Drawing.Color.Maroon;
            this.newQtyInput.LineIdleColor = System.Drawing.Color.Transparent;
            this.newQtyInput.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.newQtyInput.LineThickness = 3;
            this.newQtyInput.Location = new System.Drawing.Point(143, 320);
            this.newQtyInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.newQtyInput.Name = "newQtyInput";
            this.newQtyInput.Size = new System.Drawing.Size(249, 57);
            this.newQtyInput.TabIndex = 31;
            this.newQtyInput.Text = "Quantity";
            this.newQtyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputQty
            // 
            this.inputQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputQty.ForeColor = System.Drawing.Color.Maroon;
            this.inputQty.HintForeColor = System.Drawing.Color.Gray;
            this.inputQty.HintText = "Enter medicine name";
            this.inputQty.isPassword = false;
            this.inputQty.LineFocusedColor = System.Drawing.Color.Maroon;
            this.inputQty.LineIdleColor = System.Drawing.Color.Transparent;
            this.inputQty.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.inputQty.LineThickness = 3;
            this.inputQty.Location = new System.Drawing.Point(143, 409);
            this.inputQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputQty.Name = "inputQty";
            this.inputQty.Size = new System.Drawing.Size(249, 57);
            this.inputQty.TabIndex = 19;
            this.inputQty.Text = "Re enter quantity";
            this.inputQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.guna2Button4.Location = new System.Drawing.Point(918, 649);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.DarkRed;
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(227, 65);
            this.guna2Button4.TabIndex = 32;
            this.guna2Button4.Text = "BACK";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Maroon;
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(1197, 649);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(227, 65);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "EXIT";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 739);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.newQtyInput);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvBilling);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.inputQty);
            this.Controls.Add(this.lblStocks);
            this.Controls.Add(this.medSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBilling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox medSelect;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lblTotalAmount;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newQtyInput;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputQty;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}