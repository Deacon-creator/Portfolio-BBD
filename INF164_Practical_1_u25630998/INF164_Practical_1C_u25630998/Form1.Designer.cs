namespace INF164_Practical_1C_u25630998
{
    partial class FrmPersonalDetails
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
            this.gbxStoreDetails = new System.Windows.Forms.GroupBox();
            this.btnViewBiography = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.gbxEditDetails = new System.Windows.Forms.GroupBox();
            this.cbxDegree = new System.Windows.Forms.ComboBox();
            this.cbxFaculty = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxStoreDetails.SuspendLayout();
            this.gbxEditDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStoreDetails
            // 
            this.gbxStoreDetails.Controls.Add(this.btnViewBiography);
            this.gbxStoreDetails.Controls.Add(this.lblName);
            this.gbxStoreDetails.Controls.Add(this.lblSurname);
            this.gbxStoreDetails.Controls.Add(this.lblFaculty);
            this.gbxStoreDetails.Controls.Add(this.lblDegree);
            this.gbxStoreDetails.Location = new System.Drawing.Point(181, 270);
            this.gbxStoreDetails.Name = "gbxStoreDetails";
            this.gbxStoreDetails.Size = new System.Drawing.Size(383, 231);
            this.gbxStoreDetails.TabIndex = 0;
            this.gbxStoreDetails.TabStop = false;
            this.gbxStoreDetails.Text = "Stored Personal Details";
            // 
            // btnViewBiography
            // 
            this.btnViewBiography.Location = new System.Drawing.Point(116, 179);
            this.btnViewBiography.Name = "btnViewBiography";
            this.btnViewBiography.Size = new System.Drawing.Size(137, 23);
            this.btnViewBiography.TabIndex = 1;
            this.btnViewBiography.Text = "View Biography";
            this.btnViewBiography.UseVisualStyleBackColor = true;
            this.btnViewBiography.Click += new System.EventHandler(this.btnViewBiography_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 74);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(6, 112);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(50, 16);
            this.lblFaculty.TabIndex = 8;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(6, 151);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(53, 16);
            this.lblDegree.TabIndex = 9;
            this.lblDegree.Text = "Degree";
            // 
            // gbxEditDetails
            // 
            this.gbxEditDetails.Controls.Add(this.cbxDegree);
            this.gbxEditDetails.Controls.Add(this.cbxFaculty);
            this.gbxEditDetails.Controls.Add(this.btnUpdate);
            this.gbxEditDetails.Controls.Add(this.txtName);
            this.gbxEditDetails.Controls.Add(this.txtSurname);
            this.gbxEditDetails.Controls.Add(this.label);
            this.gbxEditDetails.Controls.Add(this.label2);
            this.gbxEditDetails.Controls.Add(this.label3);
            this.gbxEditDetails.Controls.Add(this.label4);
            this.gbxEditDetails.Location = new System.Drawing.Point(181, 31);
            this.gbxEditDetails.Name = "gbxEditDetails";
            this.gbxEditDetails.Size = new System.Drawing.Size(392, 221);
            this.gbxEditDetails.TabIndex = 0;
            this.gbxEditDetails.TabStop = false;
            this.gbxEditDetails.Text = "Edit Personal Details";
            // 
            // cbxDegree
            // 
            this.cbxDegree.FormattingEnabled = true;
            this.cbxDegree.Location = new System.Drawing.Point(116, 161);
            this.cbxDegree.Name = "cbxDegree";
            this.cbxDegree.Size = new System.Drawing.Size(231, 24);
            this.cbxDegree.TabIndex = 6;
            // 
            // cbxFaculty
            // 
            this.cbxFaculty.FormattingEnabled = true;
            this.cbxFaculty.Location = new System.Drawing.Point(116, 124);
            this.cbxFaculty.Name = "cbxFaculty";
            this.cbxFaculty.Size = new System.Drawing.Size(231, 24);
            this.cbxFaculty.TabIndex = 5;
            this.cbxFaculty.SelectedIndexChanged += new System.EventHandler(this.cbxFaculty_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(116, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(231, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 16);
            this.label.TabIndex = 1;
            this.label.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faculty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Degree";
            // 
            // FrmPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.gbxEditDetails);
            this.Controls.Add(this.gbxStoreDetails);
            this.Name = "FrmPersonalDetails";
            this.Text = "Personal Details";
            this.Load += new System.EventHandler(this.FrmPersonalDetails_Load);
            this.gbxStoreDetails.ResumeLayout(false);
            this.gbxStoreDetails.PerformLayout();
            this.gbxEditDetails.ResumeLayout(false);
            this.gbxEditDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStoreDetails;
        private System.Windows.Forms.GroupBox gbxEditDetails;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnViewBiography;
        private System.Windows.Forms.ComboBox cbxDegree;
        private System.Windows.Forms.ComboBox cbxFaculty;
        private System.Windows.Forms.Button btnUpdate;
    }
}

