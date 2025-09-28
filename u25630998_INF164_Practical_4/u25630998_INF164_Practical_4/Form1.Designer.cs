namespace u25630998_INF164_Practical_4
{
    partial class Form1
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.chkSuperSize = new System.Windows.Forms.CheckBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoOrder1 = new System.Windows.Forms.RadioButton();
            this.rdoOrder2 = new System.Windows.Forms.RadioButton();
            this.rdoOrder3 = new System.Windows.Forms.RadioButton();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.chkDistance = new System.Windows.Forms.CheckBox();
            this.chkSuper = new System.Windows.Forms.CheckBox();
            this.chkPrice = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.grpOrderDetails.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvOrders.Location = new System.Drawing.Point(12, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1015, 150);
            this.dgvOrders.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Time";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Distance";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Super";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.dtpTime);
            this.grpOrderDetails.Controls.Add(this.btnOrder);
            this.grpOrderDetails.Controls.Add(this.cmbItem);
            this.grpOrderDetails.Controls.Add(this.chkSuperSize);
            this.grpOrderDetails.Controls.Add(this.nudDistance);
            this.grpOrderDetails.Controls.Add(this.label3);
            this.grpOrderDetails.Controls.Add(this.label2);
            this.grpOrderDetails.Controls.Add(this.label1);
            this.grpOrderDetails.Location = new System.Drawing.Point(67, 180);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(315, 327);
            this.grpOrderDetails.TabIndex = 1;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Order details";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.groupBox4);
            this.grpSearch.Controls.Add(this.groupBox3);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Location = new System.Drawing.Point(408, 180);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(339, 327);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance";
            // 
            // nudDistance
            // 
            this.nudDistance.Location = new System.Drawing.Point(94, 215);
            this.nudDistance.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(120, 22);
            this.nudDistance.TabIndex = 4;
            // 
            // chkSuperSize
            // 
            this.chkSuperSize.AutoSize = true;
            this.chkSuperSize.Location = new System.Drawing.Point(94, 262);
            this.chkSuperSize.Name = "chkSuperSize";
            this.chkSuperSize.Size = new System.Drawing.Size(94, 20);
            this.chkSuperSize.TabIndex = 5;
            this.chkSuperSize.Text = "Super Size";
            this.chkSuperSize.UseVisualStyleBackColor = true;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Items.AddRange(new object[] {
            "Sushi",
            "Burger",
            "Pizza"});
            this.cmbItem.Location = new System.Drawing.Point(93, 99);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 24);
            this.cmbItem.TabIndex = 6;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(45, 298);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(168, 298);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoOrder2);
            this.groupBox3.Controls.Add(this.rdoOrder3);
            this.groupBox3.Controls.Add(this.rdoOrder1);
            this.groupBox3.Location = new System.Drawing.Point(22, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 240);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkItem);
            this.groupBox4.Controls.Add(this.chkTime);
            this.groupBox4.Controls.Add(this.chkDistance);
            this.groupBox4.Controls.Add(this.chkSuper);
            this.groupBox4.Controls.Add(this.chkPrice);
            this.groupBox4.Location = new System.Drawing.Point(180, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 240);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Criteria";
            // 
            // rdoOrder1
            // 
            this.rdoOrder1.AutoSize = true;
            this.rdoOrder1.Location = new System.Drawing.Point(6, 38);
            this.rdoOrder1.Name = "rdoOrder1";
            this.rdoOrder1.Size = new System.Drawing.Size(72, 20);
            this.rdoOrder1.TabIndex = 9;
            this.rdoOrder1.TabStop = true;
            this.rdoOrder1.Text = "Order 1";
            this.rdoOrder1.UseVisualStyleBackColor = true;
            // 
            // rdoOrder2
            // 
            this.rdoOrder2.AutoSize = true;
            this.rdoOrder2.Location = new System.Drawing.Point(6, 108);
            this.rdoOrder2.Name = "rdoOrder2";
            this.rdoOrder2.Size = new System.Drawing.Size(72, 20);
            this.rdoOrder2.TabIndex = 10;
            this.rdoOrder2.TabStop = true;
            this.rdoOrder2.Text = "Order 2";
            this.rdoOrder2.UseVisualStyleBackColor = true;
            // 
            // rdoOrder3
            // 
            this.rdoOrder3.AutoSize = true;
            this.rdoOrder3.Location = new System.Drawing.Point(6, 159);
            this.rdoOrder3.Name = "rdoOrder3";
            this.rdoOrder3.Size = new System.Drawing.Size(72, 20);
            this.rdoOrder3.TabIndex = 11;
            this.rdoOrder3.TabStop = true;
            this.rdoOrder3.Text = "Order 3";
            this.rdoOrder3.UseVisualStyleBackColor = true;
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Location = new System.Drawing.Point(6, 38);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(54, 20);
            this.chkItem.TabIndex = 7;
            this.chkItem.Text = "Item";
            this.chkItem.UseVisualStyleBackColor = true;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(6, 71);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(60, 20);
            this.chkTime.TabIndex = 8;
            this.chkTime.Text = "Time";
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // chkDistance
            // 
            this.chkDistance.AutoSize = true;
            this.chkDistance.Location = new System.Drawing.Point(6, 108);
            this.chkDistance.Name = "chkDistance";
            this.chkDistance.Size = new System.Drawing.Size(82, 20);
            this.chkDistance.TabIndex = 9;
            this.chkDistance.Text = "Distance";
            this.chkDistance.UseVisualStyleBackColor = true;
            // 
            // chkSuper
            // 
            this.chkSuper.AutoSize = true;
            this.chkSuper.Location = new System.Drawing.Point(6, 143);
            this.chkSuper.Name = "chkSuper";
            this.chkSuper.Size = new System.Drawing.Size(65, 20);
            this.chkSuper.TabIndex = 10;
            this.chkSuper.Text = "Super";
            this.chkSuper.UseVisualStyleBackColor = true;
            // 
            // chkPrice
            // 
            this.chkPrice.AutoSize = true;
            this.chkPrice.Location = new System.Drawing.Point(6, 179);
            this.chkPrice.Name = "chkPrice";
            this.chkPrice.Size = new System.Drawing.Size(60, 20);
            this.chkPrice.TabIndex = 11;
            this.chkPrice.Text = "Price";
            this.chkPrice.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(93, 170);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(121, 22);
            this.dtpTime.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 604);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.dgvOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.CheckBox chkSuperSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.CheckBox chkDistance;
        private System.Windows.Forms.CheckBox chkSuper;
        private System.Windows.Forms.CheckBox chkPrice;
        private System.Windows.Forms.RadioButton rdoOrder2;
        private System.Windows.Forms.RadioButton rdoOrder3;
        private System.Windows.Forms.RadioButton rdoOrder1;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}

