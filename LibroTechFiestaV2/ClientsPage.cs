using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroTechFiestaV2
{
    public partial class ClientsPage : Form
    {
        //Recea
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        DataSet dsClients;
        DataSet dsBooks;

        public ClientsPage()
        {
            InitializeComponent();
            bookListClients.Items.Clear();
            bookListClients.View = View.Details;
            bookListClients.Columns.Add("Id", 60);
            bookListClients.Columns.Add("Titlul", 280);
            bookListClients.Columns.Add("Autorul", 280);
            bookListClients.Columns.Add("Stoc", 280);
            //LibrariansPage librariansPage = new LibrariansPage();
            //librariansPage.showAllBooks();
            showAllBooks();

            
        }
        int clientId;
        public void SetClientId (int id)
        {
            clientId = id;
        }

        public void showAllBooks()
        {
            bookListClients.Items.Clear();

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
                String id = dr.ItemArray.GetValue(0).ToString();
                String name = dr.ItemArray.GetValue(1).ToString();
                String author = dr.ItemArray.GetValue(2).ToString();
                String quantity = dr.ItemArray.GetValue(3).ToString();
                //booksList.Items.Add(name);
                //Un item este o linie si SubItem e o coloana de pe linie
                //Daca pui multe items se face automat viewBox-ul cu scroll
                ListViewItem listViewItem = new ListViewItem(id);
                listViewItem.SubItems.Add(name);
                listViewItem.SubItems.Add(author);
                listViewItem.SubItems.Add(quantity);
                bookListClients.Items.Add(listViewItem);
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
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim().ToLower();
            showAllBooks();

            if (searchTerm != "search")
            {
                foreach (ListViewItem item in bookListClients.Items)
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

        private void loanButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            //int idClient = mainPage.idClient;
            Console.WriteLine("Id client este: " +  clientId);
            int nrOfLoans = mainPage.GetNrOfLoans();
            int idNewLoan = nrOfLoans + 1;
            if (bookListClients.SelectedItems.Count > 0)
            {
                // Obținem ID-ul cărții selectate și numărul curent de cărți disponibile
                int bookId = (int)bookListClients.SelectedItems[0].Index; // Presupunând că ID-ul cărții este stocat în proprietatea Tag a elementului ListView
                Console.WriteLine("indexul cartii: " + bookId);
                int currentQuantity = GetCurrentQuantity(bookId); // Funcție pentru a obține numărul curent de cărți disponibile
              
                // Verificăm dacă sunt disponibile suficiente cărți pentru împrumut
                if (currentQuantity > 0)
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();

                        // Adăugarea unui nou împrumut în tabela LOAN
                        string loanQuery = "INSERT INTO LOANS (Id, IdBook, IdClient, returned) VALUES (@Id, @IdBook, @IdClient, @returned)";
                        SqlCommand loanCommand = new SqlCommand(loanQuery, connection);
                        loanCommand.Parameters.AddWithValue("@Id", idNewLoan);
                        loanCommand.Parameters.AddWithValue("@IdBook", bookId);
                        loanCommand.Parameters.AddWithValue("@IdClient", clientId);
                        loanCommand.Parameters.AddWithValue("@returned", false);
                        loanCommand.ExecuteNonQuery();

                        // Actualizarea numărului de cărți disponibile în tabela Books
                        string updateQuery = "UPDATE Books SET quantity = @newQuantity WHERE Id = @bookId";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@newQuantity", currentQuantity - 1);
                        updateCommand.Parameters.AddWithValue("@bookId", bookId);
                        updateCommand.ExecuteNonQuery();
                    }

                    // Mesaj de împrumut reușit
                    MessageBox.Show("Cartea a fost împrumutată cu succes!");
                }
                else
                {
                    // Mesaj de eroare dacă nu sunt suficiente cărți disponibile
                    MessageBox.Show("Nu sunt suficiente cărți disponibile pentru împrumut.");
                }
            }
            else
            {
                // Mesaj de eroare dacă nu este selectată nicio carte
                MessageBox.Show("Vă rugăm să selectați o carte pentru împrumut.");
            }
        }

        private int GetCurrentQuantity(int bookId)
        {
            int currentQuantity = 0;

            // Conectarea la baza de date și obținerea numărului curent de cărți disponibile pentru cartea cu ID-ul bookId
            //string connectionString = "Data Source=YourDataSource;Initial Catalog=YourDatabase;User ID=YourUsername;Password=YourPassword;";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                // Interogarea pentru a obține numărul curent de cărți disponibile
                string query = "SELECT quantity FROM Books WHERE id = @bookId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bookId", bookId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    currentQuantity = reader.GetInt32(0);
                }
                reader.Close();
            }

            return currentQuantity;
        }
    }
}
