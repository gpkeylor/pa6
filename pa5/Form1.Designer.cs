
namespace pa5
{
    partial class frmCWID
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
            this.lblCWID = new System.Windows.Forms.Label();
            this.txtCWID = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCWID
            // 
            this.lblCWID.AutoSize = true;
            this.lblCWID.Location = new System.Drawing.Point(12, 45);
            this.lblCWID.Name = "lblCWID";
            this.lblCWID.Size = new System.Drawing.Size(233, 32);
            this.lblCWID.TabIndex = 0;
            this.lblCWID.Text = "Enter your CWID:";
            // 
            // txtCWID
            // 
            this.txtCWID.Location = new System.Drawing.Point(279, 39);
            this.txtCWID.Name = "txtCWID";
            this.txtCWID.Size = new System.Drawing.Size(220, 39);
            this.txtCWID.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(278, 107);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(110, 39);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(394, 107);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(104, 39);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmCWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 186);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtCWID);
            this.Controls.Add(this.lblCWID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCWID";
            this.Text = "CWID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCWID;
        private System.Windows.Forms.TextBox txtCWID;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnclose;
    }
}

