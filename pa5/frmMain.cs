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
    public partial class rentalform : Form
    {
        string cwid;
        List<Book> myBooks;
        public rentalform(string tempCWID)
        {
            this.cwid = tempCWID;
            InitializeComponent();
            pbcover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            myBooks = BookFile.GetAllBooks(cwid);
            lstbooks.DataSource = myBooks;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstbooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)lstbooks.SelectedItem;

            txttitledata.Text = myBook.title;
            txtauthordata.Text = myBook.author;
            txtgenredata.Text = myBook.genre;
            txtcopiesavailabledata.Text = myBook.copies.ToString();
            txtISBNdata.Text = myBook.isbn;
            txtlengthdata.Text = myBook.length.ToString();

            try
            {
                pbcover.Load(myBook.cover);
            }
            catch
            {

            }

        }

        private void txttitledata_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrent_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)lstbooks.SelectedItem;
            myBook.copies--;
            BookFile.SaveBook(myBook, cwid, "edit");
            LoadList();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)lstbooks.SelectedItem;
            myBook.copies++;
            BookFile.SaveBook(myBook, cwid, "edit");
            LoadList();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)lstbooks.SelectedItem;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete" , MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                BookFile.DeleteBook(myBook, cwid);
                LoadList();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)lstbooks.SelectedItem;
            frmedit myForm = new frmedit(myBook, "edit", cwid);
            if(myForm.ShowDialog()==DialogResult.OK)
            {

            }
            else
            {
                LoadList();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Book myBook = new Book();
            frmedit myForm = new frmedit(myBook, "new", cwid);
            if (myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                LoadList();
            }
        }
    }
}
