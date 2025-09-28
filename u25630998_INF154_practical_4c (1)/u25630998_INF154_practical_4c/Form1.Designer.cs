namespace u25630998_INF154_practical_4c
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
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UnitsUsed = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.rtb_BillOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(207, 355);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(129, 39);
            this.btn_Calculate.TabIndex = 1;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Water units used";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // txt_UnitsUsed
            // 
            this.txt_UnitsUsed.Location = new System.Drawing.Point(236, 227);
            this.txt_UnitsUsed.Name = "txt_UnitsUsed";
            this.txt_UnitsUsed.Size = new System.Drawing.Size(100, 22);
            this.txt_UnitsUsed.TabIndex = 4;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(236, 156);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(100, 22);
            this.txt_CustomerName.TabIndex = 5;
            // 
            // rtb_BillOutput
            // 
            this.rtb_BillOutput.Location = new System.Drawing.Point(507, 209);
            this.rtb_BillOutput.Name = "rtb_BillOutput";
            this.rtb_BillOutput.Size = new System.Drawing.Size(304, 185);
            this.rtb_BillOutput.TabIndex = 6;
            this.rtb_BillOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::u25630998_INF154_practical_4c.Properties.Resources.WaterImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 605);
            this.Controls.Add(this.rtb_BillOutput);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.txt_UnitsUsed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculate);
            this.Name = "Form1";
            this.Text = "Customer water bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UnitsUsed;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.RichTextBox rtb_BillOutput;
    }
}

