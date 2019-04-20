/* Lily Ayala
 * PROG 260
 * Instructor: Kurt Friedrich
 * HW10 - Project
 * Date: May 26th 2018
 * 
  */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST_Book_HW
{
    public partial class Form1 : Form
    {

        BSTclass myBST = new BSTclass();
        ISBNclass allISBN = new ISBNclass();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            //when user clicks Submit New Book, 
            // you code creates a new Book object,
            Book book1 = new Book();
            book1.Title = txtBox_BookTitle.Text;
            book1.Author = txtBox_BookAuthor.Text;
            book1.Rating = Convert.ToInt32(txtBox_BookRating.Text);
            book1.Year = Convert.ToInt32(txtbox_Year.Text);
            int newISBN;

            try
            {
                newISBN = Convert.ToInt32(txtBox_ISBN.Text);
                myBST.Add(newISBN, book1);

            }
            catch (Exception)
            {
                txtBox_BookTitle.Text = "Invalid ISBN";
            }

            txtBox_BookAuthor.Clear();
            txtBox_BookRating.Clear();
            txtBox_BookTitle.Clear();
            txtBox_ISBN.Clear();
            txtbox_Year.Clear();



        }

        private void Btn_ISBNtoFind_Click(object sender, EventArgs e)
        {
            //when a user clicks the Find button,
            //you use the ISBN field, call your BST class 
            //to find that object, get the book object back, 
            //and use its values to fill in the other 3 textboxes
            int newISBN;

            try
            {
                newISBN = Convert.ToInt32(txtBox_ISBN.Text);
                var book = myBST.Find(newISBN);

                if (book != null)
                {
                    txtBox_BookTitle.Text = book.Title;
                    txtBox_BookAuthor.Text = book.Author;
                    txtBox_BookRating.Text = book.Rating.ToString();
                    txtbox_Year.Text = book.Year.ToString();
                }
                else
                {
                    txtBox_BookTitle.Text = "Not book was found";
                    txtBox_BookAuthor.Text = " ";
                    txtBox_BookRating.Text = "0";
                    txtbox_Year.Text = "0";


                    txtBox_BookAuthor.Clear();
                    txtBox_BookRating.Clear();
                    txtBox_ISBN.Clear();
                    txtbox_Year.Clear();


                }
            }
            catch (Exception)
            {
                txtBox_BookTitle.Text = "Invalid ISBN";
            }



        }

        private void btn_GetIsbn_Click(object sender, EventArgs e)
        {
            var myList = myBST.GetISBNs();

            foreach (ISBNclass l in myList)
            {
                dataGridView.DataSource = myList;

            }
            
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int newISBN;

            try
            {
                newISBN = Convert.ToInt32(txtBox_ISBN.Text);
                var book = myBST.Find(newISBN);

                if (book != null)
                {
                    txtBox_BookTitle.Text = book.Title;
                    txtBox_BookAuthor.Text = book.Author;
                    txtBox_BookRating.Text = book.Rating.ToString();
                    txtbox_Year.Text = book.Year.ToString();

                    myBST.Remove(newISBN); //Remove book

                    txtBox_BookTitle.Text = "Book has been deleted";
                    txtBox_BookAuthor.Clear();
                    txtBox_BookRating.Clear();
                    txtBox_ISBN.Clear();
                    txtbox_Year.Clear();

                }
               
            }
            catch (Exception)
            {
                txtBox_BookTitle.Text = "ISBN was deleted";
            }
        }
    }
}
