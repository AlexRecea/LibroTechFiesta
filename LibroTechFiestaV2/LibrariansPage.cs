using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroTechFiestaV2
{
    public partial class LibrariansPage : Form
    {
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");
        DataSet dsClients;
        DataSet dsBooks;
        public LibrariansPage()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection(conn);
            dsBooks = new DataSet();
            SqlDataAdapter daBooks = new SqlDataAdapter("SELECT * FROM Books", connection);
            daBooks.Fill(dsBooks, "Books");

            foreach (DataRow dr in dsBooks.Tables["Books"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                booksList.Items.Add(name);
            }
            connection.Close();

        }

        

        private void showBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                booksList.Items.Add(book.id + "  " + book.title + "           " + book.authorName + "       " + book.quantity);
            }
        }
        private List<Book> getBooks()
        {
            List<Book> books = new List<Book>();
            DataSet dataSetBooks;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=|DataDirectory|Database1.mdf;
                                        Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSetBooks = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", DataConnection);
            adapter.Fill(dataSetBooks, "Books");
            foreach (DataRow dataRow in dataSetBooks.Tables["Books"].Rows)
            {
                int id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                String title = dataRow.ItemArray.GetValue(1).ToString().Trim();
                String author = dataRow.ItemArray.GetValue(2).ToString().Trim();
                int quantity = Convert.ToInt32(dataRow.ItemArray.GetValue(3));
                Book book = new Book(id, title, author, quantity);
                books.Add(book);

            }
            return books;
        }

        private void SearchBoxText_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search")
            {
                searchBox.Text = "";

                searchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBoxText_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search";

                searchBox.ForeColor = Color.Silver;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

       private void backToMainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
            
        }
    }
}
