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
    {/*
        private void LibrariaPage_Load(object sender, EventArgs e)
        {
            int xPosition = (Screen.PrimaryScreen.Bounds.Width - usernameText.Width) / 2 + 400;
            usernameText.Location = new System.Drawing.Point(xPosition, 200);
            passwordText.Location = new System.Drawing.Point(xPosition, 250);
            loginLibrariansButton.Location = new System.Drawing.Point(xPosition, 300);

            int xPosition2 = (Screen.PrimaryScreen.Bounds.Width - passwordText.Width) / 2 - 200;
            usernameClientText.Location = new System.Drawing.Point(xPosition2, 200);
            passwordClientText.Location = new System.Drawing.Point(xPosition2, 250);
            loginButton.Location = new System.Drawing.Point(xPosition2, 300);
            registerButton.Location = new System.Drawing.Point(xPosition2, 350);
        }
        */
        //Recea
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        DataSet dsClients;
        DataSet dsBooks;
        DataSet dsBookDetails;
        public LibrariansPage()
        {
            InitializeComponent();
            booksView.View = View.Details;
            booksView.Columns.Add("Titlul", 300); //300 e latimea fiecarei coloane in pixeli (latimea totala a viewBox e 905, nu fix 900)
            booksView.Columns.Add("Autorul", 300);
            booksView.Columns.Add("Stoc", 280);
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

        public void showAllBooks ()
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
                string id = dr.ItemArray.GetValue(0).ToString();
                String name = dr.ItemArray.GetValue(1).ToString();
                String author = dr.ItemArray.GetValue(2).ToString();
                String quantity = dr.ItemArray.GetValue(3).ToString();
                //booksList.Items.Add(name);
                //Un item este o linie si SubItem e o coloana de pe linie
                //Daca pui multe items se face automat viewBox-ul cu scroll
                ListViewItem listViewItem = new ListViewItem(name);
                listViewItem.SubItems.Add(author);
                listViewItem.SubItems.Add(quantity);
                listViewItem.Tag = id;
                booksView.Items.Add(listViewItem);
            }
            connection.Close();
        }
        public void AddNewBook_addNewBookButtonClicked(object sender, EventArgs e)
        {
            showAllBooks();
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
            addNewBook.ButtonClicked += AddNewBook_addNewBookButtonClicked;
        }
        public void showDetails(RichTextBox richTextBox, int id)
        {

            dsBookDetails = new DataSet();
            string query = "SELECT preview FROM BookDetails WHERE IdBook=@Id";
            richTextBox.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Citește doar prima înregistrare găsită
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                richTextBox.AppendText(reader[i].ToString() + Environment.NewLine);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu a fost găsită nicio înregistrare cu ID-ul specificat.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }

        }
      

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (booksView.SelectedItems.Count > 0)
                {
                    int id = Convert.ToInt32(booksView.SelectedItems[0].Tag);
                    showDetails(richTextBox1, id);
                }
                else
                {
                    MessageBox.Show("Selectați o carte din listă.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }
    }
}
