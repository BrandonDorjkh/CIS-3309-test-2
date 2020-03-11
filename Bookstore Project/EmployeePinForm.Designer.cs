namespace Bookstore_Project
{
    partial class EmployeePinForm
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
            this.lblStore = new System.Windows.Forms.Label();
            this.lblPinEntry = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(262, 23);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(113, 13);
            this.lblStore.TabIndex = 0;
            this.lblStore.Text = "Bookworm Book Store";
            // 
            // lblPinEntry
            // 
            this.lblPinEntry.AutoSize = true;
            this.lblPinEntry.Location = new System.Drawing.Point(282, 54);
            this.lblPinEntry.Name = "lblPinEntry";
            this.lblPinEntry.Size = new System.Drawing.Size(75, 13);
            this.lblPinEntry.TabIndex = 1;
            this.lblPinEntry.Text = "Pin Entry Form";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(131, 144);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(116, 13);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Enter pin and press OK";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(141, 183);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(106, 13);
            this.lblPin.TabIndex = 3;
            this.lblPin.Text = "Pin (a 4 digit number)";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(265, 233);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(355, 165);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 5;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // EmployeePinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblPinEntry);
            this.Controls.Add(this.lblStore);
            this.Name = "EmployeePinForm";
            this.Text = "EmployeePinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblPinEntry;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPin;
    }
}