namespace u25678966_INF164_Practical_5
{
    partial class frmCellularExpress
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
            this.grpCaptureContractInfo = new System.Windows.Forms.GroupBox();
            this.grpAllContractRecords = new System.Windows.Forms.GroupBox();
            this.lblMDLR = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.lblCapturedD = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.dtpCDate = new System.Windows.Forms.DateTimePicker();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.dgvContractRecords = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExtendC = new System.Windows.Forms.Button();
            this.btnCancelC = new System.Windows.Forms.Button();
            this.grpCaptureContractInfo.SuspendLayout();
            this.grpAllContractRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCaptureContractInfo
            // 
            this.grpCaptureContractInfo.Controls.Add(this.btnAdd);
            this.grpCaptureContractInfo.Controls.Add(this.nudMonths);
            this.grpCaptureContractInfo.Controls.Add(this.dtpCDate);
            this.grpCaptureContractInfo.Controls.Add(this.txtDName);
            this.grpCaptureContractInfo.Controls.Add(this.txtSurname);
            this.grpCaptureContractInfo.Controls.Add(this.txtName);
            this.grpCaptureContractInfo.Controls.Add(this.lblDuration);
            this.grpCaptureContractInfo.Controls.Add(this.lblCapturedD);
            this.grpCaptureContractInfo.Controls.Add(this.lblDName);
            this.grpCaptureContractInfo.Controls.Add(this.lblSurname);
            this.grpCaptureContractInfo.Controls.Add(this.lblName);
            this.grpCaptureContractInfo.Location = new System.Drawing.Point(12, 83);
            this.grpCaptureContractInfo.Name = "grpCaptureContractInfo";
            this.grpCaptureContractInfo.Size = new System.Drawing.Size(389, 305);
            this.grpCaptureContractInfo.TabIndex = 0;
            this.grpCaptureContractInfo.TabStop = false;
            this.grpCaptureContractInfo.Text = "Capture Contract Info";
            // 
            // grpAllContractRecords
            // 
            this.grpAllContractRecords.Controls.Add(this.btnCancelC);
            this.grpAllContractRecords.Controls.Add(this.btnExtendC);
            this.grpAllContractRecords.Controls.Add(this.btnUpdate);
            this.grpAllContractRecords.Controls.Add(this.dgvContractRecords);
            this.grpAllContractRecords.Location = new System.Drawing.Point(407, 83);
            this.grpAllContractRecords.Name = "grpAllContractRecords";
            this.grpAllContractRecords.Size = new System.Drawing.Size(751, 305);
            this.grpAllContractRecords.TabIndex = 1;
            this.grpAllContractRecords.TabStop = false;
            this.grpAllContractRecords.Text = "All Contract Records";
            // 
            // lblMDLR
            // 
            this.lblMDLR.AutoSize = true;
            this.lblMDLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDLR.Location = new System.Drawing.Point(335, 29);
            this.lblMDLR.Name = "lblMDLR";
            this.lblMDLR.Size = new System.Drawing.Size(377, 29);
            this.lblMDLR.TabIndex = 2;
            this.lblMDLR.Text = "Mobile Device Leasing Records:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 65);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Location = new System.Drawing.Point(15, 103);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(93, 16);
            this.lblDName.TabIndex = 2;
            this.lblDName.Text = "Device Name:";
            // 
            // lblCapturedD
            // 
            this.lblCapturedD.AutoSize = true;
            this.lblCapturedD.Location = new System.Drawing.Point(15, 141);
            this.lblCapturedD.Name = "lblCapturedD";
            this.lblCapturedD.Size = new System.Drawing.Size(97, 16);
            this.lblCapturedD.TabIndex = 3;
            this.lblCapturedD.Text = "Captured Date:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(15, 180);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(114, 16);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration (Months):";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(153, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(230, 22);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(153, 103);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(230, 22);
            this.txtDName.TabIndex = 7;
            this.txtDName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dtpCDate
            // 
            this.dtpCDate.Location = new System.Drawing.Point(153, 141);
            this.dtpCDate.Name = "dtpCDate";
            this.dtpCDate.Size = new System.Drawing.Size(230, 22);
            this.dtpCDate.TabIndex = 8;
            this.dtpCDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(153, 180);
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(230, 22);
            this.nudMonths.TabIndex = 9;
            this.nudMonths.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dgvContractRecords
            // 
            this.dgvContractRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractRecords.Location = new System.Drawing.Point(6, 27);
            this.dgvContractRecords.Name = "dgvContractRecords";
            this.dgvContractRecords.RowHeadersWidth = 51;
            this.dgvContractRecords.RowTemplate.Height = 24;
            this.dgvContractRecords.Size = new System.Drawing.Size(737, 175);
            this.dgvContractRecords.TabIndex = 0;
            this.dgvContractRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractRecords_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExtendC
            // 
            this.btnExtendC.Location = new System.Drawing.Point(131, 217);
            this.btnExtendC.Name = "btnExtendC";
            this.btnExtendC.Size = new System.Drawing.Size(109, 23);
            this.btnExtendC.TabIndex = 2;
            this.btnExtendC.Text = "Extend Contract";
            this.btnExtendC.UseVisualStyleBackColor = true;
            this.btnExtendC.Click += new System.EventHandler(this.btnExtendC_Click);
            // 
            // btnCancelC
            // 
            this.btnCancelC.Location = new System.Drawing.Point(255, 217);
            this.btnCancelC.Name = "btnCancelC";
            this.btnCancelC.Size = new System.Drawing.Size(109, 23);
            this.btnCancelC.TabIndex = 3;
            this.btnCancelC.Text = "Cancel Contract";
            this.btnCancelC.UseVisualStyleBackColor = true;
            this.btnCancelC.Click += new System.EventHandler(this.btnCancelC_Click);
            // 
            // frmCellularExpress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 400);
            this.Controls.Add(this.lblMDLR);
            this.Controls.Add(this.grpAllContractRecords);
            this.Controls.Add(this.grpCaptureContractInfo);
            this.Name = "frmCellularExpress";
            this.Text = "Cellular Express";
            this.grpCaptureContractInfo.ResumeLayout(false);
            this.grpCaptureContractInfo.PerformLayout();
            this.grpAllContractRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCaptureContractInfo;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpAllContractRecords;
        private System.Windows.Forms.Label lblMDLR;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCapturedD;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.NumericUpDown nudMonths;
        private System.Windows.Forms.DateTimePicker dtpCDate;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvContractRecords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelC;
        private System.Windows.Forms.Button btnExtendC;
        private System.Windows.Forms.Button btnUpdate;
    }
}

