namespace u25630998_INF164_Practical_2._1
{
    partial class frmTicTacToe
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
            this.btnMiddle = new System.Windows.Forms.Button();
            this.rdoX = new System.Windows.Forms.RadioButton();
            this.rdoO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMiddleRight = new System.Windows.Forms.Button();
            this.btnMiddleLeft = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnTopMiddle = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnBottomMiddle = new System.Windows.Forms.Button();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMiddle
            // 
            this.btnMiddle.Location = new System.Drawing.Point(423, 243);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(75, 76);
            this.btnMiddle.TabIndex = 5;
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // rdoX
            // 
            this.rdoX.AutoSize = true;
            this.rdoX.Location = new System.Drawing.Point(25, 48);
            this.rdoX.Name = "rdoX";
            this.rdoX.Size = new System.Drawing.Size(78, 20);
            this.rdoX.TabIndex = 9;
            this.rdoX.TabStop = true;
            this.rdoX.Text = "Player X";
            this.rdoX.UseVisualStyleBackColor = true;
            // 
            // rdoO
            // 
            this.rdoO.AutoSize = true;
            this.rdoO.Location = new System.Drawing.Point(250, 48);
            this.rdoO.Name = "rdoO";
            this.rdoO.Size = new System.Drawing.Size(80, 20);
            this.rdoO.TabIndex = 10;
            this.rdoO.TabStop = true;
            this.rdoO.Text = "Player O";
            this.rdoO.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoX);
            this.groupBox1.Controls.Add(this.rdoO);
            this.groupBox1.Location = new System.Drawing.Point(364, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turn";
            // 
            // btnMiddleRight
            // 
            this.btnMiddleRight.Location = new System.Drawing.Point(504, 243);
            this.btnMiddleRight.Name = "btnMiddleRight";
            this.btnMiddleRight.Size = new System.Drawing.Size(75, 76);
            this.btnMiddleRight.TabIndex = 12;
            this.btnMiddleRight.UseVisualStyleBackColor = true;
            this.btnMiddleRight.Click += new System.EventHandler(this.btnMiddleRight_Click);
            // 
            // btnMiddleLeft
            // 
            this.btnMiddleLeft.Location = new System.Drawing.Point(342, 243);
            this.btnMiddleLeft.Name = "btnMiddleLeft";
            this.btnMiddleLeft.Size = new System.Drawing.Size(75, 76);
            this.btnMiddleLeft.TabIndex = 13;
            this.btnMiddleLeft.UseVisualStyleBackColor = true;
            this.btnMiddleLeft.Click += new System.EventHandler(this.btnMiddleLeft_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.Location = new System.Drawing.Point(342, 325);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(75, 76);
            this.btnBottomLeft.TabIndex = 14;
            this.btnBottomLeft.UseVisualStyleBackColor = true;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnBottomLeft_Click);
            // 
            // btnTopMiddle
            // 
            this.btnTopMiddle.Location = new System.Drawing.Point(423, 161);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(75, 76);
            this.btnTopMiddle.TabIndex = 15;
            this.btnTopMiddle.UseVisualStyleBackColor = true;
            this.btnTopMiddle.Click += new System.EventHandler(this.btnTopMiddle_Click_1);
            // 
            // btnTopRight
            // 
            this.btnTopRight.Location = new System.Drawing.Point(504, 161);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(75, 76);
            this.btnTopRight.TabIndex = 16;
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.Location = new System.Drawing.Point(423, 325);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(75, 76);
            this.btnBottomMiddle.TabIndex = 17;
            this.btnBottomMiddle.UseVisualStyleBackColor = true;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btnBottomMiddle_Click);
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.Location = new System.Drawing.Point(504, 325);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(75, 76);
            this.btnBottomRight.TabIndex = 18;
            this.btnBottomRight.UseVisualStyleBackColor = true;
            this.btnBottomRight.Click += new System.EventHandler(this.btnBottomRight_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.Location = new System.Drawing.Point(342, 161);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(75, 76);
            this.btnTopLeft.TabIndex = 19;
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTopLeft);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomMiddle);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopMiddle);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnMiddleLeft);
            this.Controls.Add(this.btnMiddleRight);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.frmTicTacToe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.RadioButton rdoX;
        private System.Windows.Forms.RadioButton rdoO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMiddleRight;
        private System.Windows.Forms.Button btnMiddleLeft;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnTopMiddle;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnBottomMiddle;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Button btnTopLeft;
    }
}

