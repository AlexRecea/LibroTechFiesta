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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibroTechFiestaV2
{
    public partial class LibrariansPage : Form
    {
        //Recea
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        // string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        DataSet dsClients;
        DataSet dsBooks;
        public LibrariansPage()
        {
            InitializeComponent();
            booksView.View = View.Details;
            booksView.Columns.Add("Titlul", 300); //300 e latimea fiecarei coloane in pixeli (latimea totala a viewBox e 905, nu fix 900)
            booksView.Columns.Add("Autorul", 300);
            booksView.Columns.Add("Stoc", 300);
            showAllBooks();

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
            string searchTerm = searchBox.Text.Trim().ToLower();
            showAllBooks();

            if (searchTerm != "search")
            {
                foreach (ListViewItem item in booksView.Items)
                {
                    bool match = false;
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.Trim().ToLower().Contains(searchTerm))
                        {
                            match = true;
                            break;
                        }
                    }

                    if (match == false)
                    {
                        item.Remove();
                    }
                }
            }
        }

        private void showAllBooks ()
        {
            booksView.Items.Clear();
            
            // Ajustarea coloanelor pentru a se potrivi conținutului
            //foreach (ColumnHeader column in booksView.Columns)
            //{
            //    column.Width = -2;
            //}

            SqlConnection connection = new SqlConnection(conn);
            dsBooks = new DataSet();
            SqlDataAdapter daBooks = new SqlDataAdapter("SELECT * FROM Books", connection);
            daBooks.Fill(dsBooks, "Books");

            foreach (DataRow dr in dsBooks.Tables["Books"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                String author = dr.ItemArray.GetValue(2).ToString();
                String quantity = dr.ItemArray.GetValue(3).ToString();
                //booksList.Items.Add(name);
                //Un item este o linie si SubItem e o coloana de pe linie
                //Daca pui multe items se face automat viewBox-ul cu scroll
                ListViewItem listViewItem = new ListViewItem(name);
                listViewItem.SubItems.Add(author);
                listViewItem.SubItems.Add(quantity);
                booksView.Items.Add(listViewItem);
            }
            connection.Close();
        }
       private void backToMainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
            
        }

        private void addNewBook_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook(); 
            addNewBook.Show();
        }
    }
}
