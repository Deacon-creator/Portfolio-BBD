namespace u25678966_INF164_Practical_5
{
    partial class frmUpdateDetails
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
            this.grpUpdateContractInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nudUMonths = new System.Windows.Forms.NumericUpDown();
            this.dtpUCDate = new System.Windows.Forms.DateTimePicker();
            this.txtUDName = new System.Windows.Forms.TextBox();
            this.txtUSurname = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCapturedD = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpUpdateContractInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUpdateContractInfo
            // 
            this.grpUpdateContractInfo.Controls.Add(this.btnUpdate);
            this.grpUpdateContractInfo.Controls.Add(this.nudUMonths);
            this.grpUpdateContractInfo.Controls.Add(this.dtpUCDate);
            this.grpUpdateContractInfo.Controls.Add(this.txtUDName);
            this.grpUpdateContractInfo.Controls.Add(this.txtUSurname);
            this.grpUpdateContractInfo.Controls.Add(this.txtUName);
            this.grpUpdateContractInfo.Controls.Add(this.lblDuration);
            this.grpUpdateContractInfo.Controls.Add(this.lblCapturedD);
            this.grpUpdateContractInfo.Controls.Add(this.lblDName);
            this.grpUpdateContractInfo.Controls.Add(this.lblSurname);
            this.grpUpdateContractInfo.Controls.Add(this.lblName);
            this.grpUpdateContractInfo.Location = new System.Drawing.Point(12, 12);
            this.grpUpdateContractInfo.Name = "grpUpdateContractInfo";
            this.grpUpdateContractInfo.Size = new System.Drawing.Size(389, 305);
            this.grpUpdateContractInfo.TabIndex = 1;
            this.grpUpdateContractInfo.TabStop = false;
            this.grpUpdateContractInfo.Text = "Update Contract Info";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(274, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUAdd_Click_1);
            // 
            // nudUMonths
            // 
            this.nudUMonths.Location = new System.Drawing.Point(153, 180);
            this.nudUMonths.Name = "nudUMonths";
            this.nudUMonths.Size = new System.Drawing.Size(230, 22);
            this.nudUMonths.TabIndex = 9;
            // 
            // dtpUCDate
            // 
            this.dtpUCDate.Location = new System.Drawing.Point(153, 141);
            this.dtpUCDate.Name = "dtpUCDate";
            this.dtpUCDate.Size = new System.Drawing.Size(230, 22);
            this.dtpUCDate.TabIndex = 8;
            // 
            // txtUDName
            // 
            this.txtUDName.Location = new System.Drawing.Point(153, 103);
            this.txtUDName.Name = "txtUDName";
            this.txtUDName.Size = new System.Drawing.Size(230, 22);
            this.txtUDName.TabIndex = 7;
            // 
            // txtUSurname
            // 
            this.txtUSurname.Location = new System.Drawing.Point(153, 65);
            this.txtUSurname.Name = "txtUSurname";
            this.txtUSurname.Size = new System.Drawing.Size(230, 22);
            this.txtUSurname.TabIndex = 6;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(153, 27);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(230, 22);
            this.txtUName.TabIndex = 5;
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
            // lblCapturedD
            // 
            this.lblCapturedD.AutoSize = true;
            this.lblCapturedD.Location = new System.Drawing.Point(15, 141);
            this.lblCapturedD.Name = "lblCapturedD";
            this.lblCapturedD.Size = new System.Drawing.Size(97, 16);
            this.lblCapturedD.TabIndex = 3;
            this.lblCapturedD.Text = "Captured Date:";
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
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 65);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
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
            // frmUpdateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 324);
            this.Controls.Add(this.grpUpdateContractInfo);
            this.Name = "frmUpdateDetails";
            this.Text = "frmUpdateDetails";
            this.Load += new System.EventHandler(this.frmUpdateDetails_Load);
            this.grpUpdateContractInfo.ResumeLayout(false);
            this.grpUpdateContractInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUMonths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateContractInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nudUMonths;
        private System.Windows.Forms.DateTimePicker dtpUCDate;
        private System.Windows.Forms.TextBox txtUDName;
        private System.Windows.Forms.TextBox txtUSurname;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCapturedD;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
    }
}