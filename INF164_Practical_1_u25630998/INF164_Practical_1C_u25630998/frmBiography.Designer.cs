namespace INF164_Practical_1C_u25630998
{
    partial class frmBiography
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxLines = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(168, 381);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(132, 16);
            this.lblWordCount.TabIndex = 2;
            this.lblWordCount.Text = "Total Word(s) Count: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Biography below";
            // 
            // rtxLines
            // 
            this.rtxLines.Location = new System.Drawing.Point(171, 53);
            this.rtxLines.Name = "rtxLines";
            this.rtxLines.Size = new System.Drawing.Size(315, 256);
            this.rtxLines.TabIndex = 4;
            this.rtxLines.Text = "";
            this.rtxLines.TextChanged += new System.EventHandler(this.rtxLines_TextChanged);
            // 
            // frmBiography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.btnSave);
            this.Name = "frmBiography";
            this.Text = "frmBiography";
            this.Load += new System.EventHandler(this.frmBiography_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxLines;
    }
}