//Brandon Dorjkhand
//CIS 3309
//Lab Project 2 Bookstore
// 2/19/2020

namespace Bookstore_Project
{
    partial class EmployeeAccessIDEntry
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(380, 156);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Find Me";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(298, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(189, 13);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to the Bookworm Bookstore!";
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Location = new System.Drawing.Point(163, 133);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(345, 13);
            this.lblAccNum.TabIndex = 4;
            this.lblAccNum.Text = "Enter your FIVE DIGIT access ID in the box below. Then click FInd Me.";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Location = new System.Drawing.Point(217, 158);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(100, 20);
            this.txtAccNum.TabIndex = 6;
            this.txtAccNum.TextChanged += new System.EventHandler(this.txtAccNum_TextChanged);
            // 
            // EmployeeAccessIDEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnEnter);
            this.Name = "EmployeeAccessIDEntry";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.TextBox txtAccNum;
    }
}

