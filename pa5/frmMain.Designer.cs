
namespace pa5
{
    partial class rentalform
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txttitledata = new System.Windows.Forms.TextBox();
            this.txtauthordata = new System.Windows.Forms.TextBox();
            this.lblauthor = new System.Windows.Forms.Label();
            this.txtgenredata = new System.Windows.Forms.TextBox();
            this.lblgenre = new System.Windows.Forms.Label();
            this.txtcopiesavailabledata = new System.Windows.Forms.TextBox();
            this.lblcopies = new System.Windows.Forms.Label();
            this.txtISBNdata = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtlengthdata = new System.Windows.Forms.TextBox();
            this.lbllength = new System.Windows.Forms.Label();
            this.lstbooks = new System.Windows.Forms.ListBox();
            this.pbcover = new System.Windows.Forms.PictureBox();
            this.btnrent = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbcover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(319, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txttitledata
            // 
            this.txttitledata.Location = new System.Drawing.Point(325, 44);
            this.txttitledata.Name = "txttitledata";
            this.txttitledata.Size = new System.Drawing.Size(210, 39);
            this.txttitledata.TabIndex = 1;
            this.txttitledata.TextChanged += new System.EventHandler(this.txttitledata_TextChanged);
            // 
            // txtauthordata
            // 
            this.txtauthordata.Location = new System.Drawing.Point(325, 138);
            this.txtauthordata.Name = "txtauthordata";
            this.txtauthordata.Size = new System.Drawing.Size(210, 39);
            this.txtauthordata.TabIndex = 3;
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Location = new System.Drawing.Point(319, 103);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(99, 32);
            this.lblauthor.TabIndex = 2;
            this.lblauthor.Text = "Author";
            // 
            // txtgenredata
            // 
            this.txtgenredata.Location = new System.Drawing.Point(325, 227);
            this.txtgenredata.Name = "txtgenredata";
            this.txtgenredata.Size = new System.Drawing.Size(210, 39);
            this.txtgenredata.TabIndex = 5;
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(319, 192);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(94, 32);
            this.lblgenre.TabIndex = 4;
            this.lblgenre.Text = "Genre";
            this.lblgenre.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcopiesavailabledata
            // 
            this.txtcopiesavailabledata.Location = new System.Drawing.Point(325, 321);
            this.txtcopiesavailabledata.Name = "txtcopiesavailabledata";
            this.txtcopiesavailabledata.Size = new System.Drawing.Size(210, 39);
            this.txtcopiesavailabledata.TabIndex = 7;
            // 
            // lblcopies
            // 
            this.lblcopies.AutoSize = true;
            this.lblcopies.Location = new System.Drawing.Point(319, 286);
            this.lblcopies.Name = "lblcopies";
            this.lblcopies.Size = new System.Drawing.Size(229, 32);
            this.lblcopies.TabIndex = 6;
            this.lblcopies.Text = "Copies Available";
            // 
            // txtISBNdata
            // 
            this.txtISBNdata.Location = new System.Drawing.Point(325, 413);
            this.txtISBNdata.Name = "txtISBNdata";
            this.txtISBNdata.Size = new System.Drawing.Size(210, 39);
            this.txtISBNdata.TabIndex = 9;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(319, 378);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(80, 32);
            this.lblISBN.TabIndex = 8;
            this.lblISBN.Text = "ISBN";
            this.lblISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlengthdata
            // 
            this.txtlengthdata.Location = new System.Drawing.Point(325, 518);
            this.txtlengthdata.Name = "txtlengthdata";
            this.txtlengthdata.Size = new System.Drawing.Size(210, 39);
            this.txtlengthdata.TabIndex = 11;
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Location = new System.Drawing.Point(319, 483);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(103, 32);
            this.lbllength.TabIndex = 10;
            this.lbllength.Text = "Length";
            this.lbllength.Click += new System.EventHandler(this.label2_Click);
            // 
            // lstbooks
            // 
            this.lstbooks.FormattingEnabled = true;
            this.lstbooks.ItemHeight = 32;
            this.lstbooks.Location = new System.Drawing.Point(12, 11);
            this.lstbooks.Name = "lstbooks";
            this.lstbooks.Size = new System.Drawing.Size(261, 484);
            this.lstbooks.TabIndex = 12;
            this.lstbooks.SelectedIndexChanged += new System.EventHandler(this.lstbooks_SelectedIndexChanged);
            // 
            // pbcover
            // 
            this.pbcover.Location = new System.Drawing.Point(566, 44);
            this.pbcover.Name = "pbcover";
            this.pbcover.Size = new System.Drawing.Size(243, 304);
            this.pbcover.TabIndex = 13;
            this.pbcover.TabStop = false;
            // 
            // btnrent
            // 
            this.btnrent.Location = new System.Drawing.Point(566, 413);
            this.btnrent.Name = "btnrent";
            this.btnrent.Size = new System.Drawing.Size(113, 50);
            this.btnrent.TabIndex = 14;
            this.btnrent.Text = "Rent";
            this.btnrent.UseVisualStyleBackColor = true;
            this.btnrent.Click += new System.EventHandler(this.btnrent_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(703, 413);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(116, 50);
            this.btnreturn.TabIndex = 15;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(265, 581);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(124, 34);
            this.btnnew.TabIndex = 16;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(411, 581);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(124, 34);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(555, 581);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(124, 34);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(695, 581);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(124, 34);
            this.btnclose.TabIndex = 19;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // rentalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 627);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnrent);
            this.Controls.Add(this.pbcover);
            this.Controls.Add(this.lstbooks);
            this.Controls.Add(this.txtlengthdata);
            this.Controls.Add(this.lbllength);
            this.Controls.Add(this.txtISBNdata);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtcopiesavailabledata);
            this.Controls.Add(this.lblcopies);
            this.Controls.Add(this.txtgenredata);
            this.Controls.Add(this.lblgenre);
            this.Controls.Add(this.txtauthordata);
            this.Controls.Add(this.lblauthor);
            this.Controls.Add(this.txttitledata);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "rentalform";
            this.Text = "Audio Book Rental System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txttitledata;
        private System.Windows.Forms.TextBox txtauthordata;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.TextBox txtgenredata;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.TextBox txtcopiesavailabledata;
        private System.Windows.Forms.Label lblcopies;
        private System.Windows.Forms.TextBox txtISBNdata;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtlengthdata;
        private System.Windows.Forms.Label lbllength;
        private System.Windows.Forms.ListBox lstbooks;
        private System.Windows.Forms.PictureBox pbcover;
        private System.Windows.Forms.Button btnrent;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
    }
}