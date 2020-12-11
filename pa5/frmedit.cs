using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa5
{
    public partial class frmedit : Form
    {
        private Book myBook;
        private string cwid;
        private string mode;

        public frmedit(Object tempBook, string tempMode, string tempcwid)
        {
            myBook = (Book)tempBook;
            cwid = tempcwid;
            mode = tempMode;
            InitializeComponent();
            pbcover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmedit_Load(object sender, EventArgs e)
        {
            if(mode=="edit")
            {
                txttitledata.Text = myBook.title;
                txtauthordata.Text = myBook.author;
                txtgenredata.Text = myBook.genre;
                txtcopiesavailabledata.Text = myBook.copies.ToString();
                txtISBNdata.Text = myBook.isbn;
                txtlengthdata.Text = myBook.length.ToString();
                txtcoverdata.Text = myBook.cover;

                pbcover.Load(myBook.cover);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            myBook.title = txttitledata.Text;
            myBook.author = txtauthordata.Text;
            myBook.genre = txtgenredata.Text;
            myBook.copies = int.Parse(txtcopiesavailabledata.Text);
            myBook.isbn = txtISBNdata.Text;
            myBook.length = int.Parse(txtlengthdata.Text);
            myBook.cover = txtcoverdata.Text;
            myBook.cwid = cwid;

            BookFile.SaveBook(myBook, cwid, mode);
            MessageBox.Show("Content was saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
