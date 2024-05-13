using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroTechFiestaV2
{
    public partial class ClientsPage : Form
    {
        //Recea
        //string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        DataSet dsClients;
        DataSet dsBooks;
        DataSet dsOwnedBooks;
        public ClientsPage()
        {
            InitializeComponent();
            bookListClients.Items.Clear();
            bookListClients.View = View.Details;
            bookListClients.Columns.Add("Id", 60);
            bookListClients.Columns.Add("Titlul", 280);
            bookListClients.Columns.Add("Autorul", 280);
            bookListClients.Columns.Add("Stoc", 280);
            showAllBooks();
            booksOwned.Items.Clear();
            booksOwned.View = View.Details;
           // booksOwned.Columns.Add("Id", 60);
            booksOwned.Columns.Add("Titlul", 200);
            booksOwned.Columns.Add("Autorul", 200);
            showLoanedBooks();
            
           
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
                listViewItem.Tag = id;
                bookListClients.Items.Add(listViewItem);
            }
            connection.Close();
            showLoanedBooks();
        }

        public void showLoanedBooks()
        {
            booksOwned.Items.Clear();
            SqlConnection connection = new SqlConnection(conn);
            dsOwnedBooks = new DataSet();
            string query = @"SELECT Books.Id, Books.title, Books.author
                         FROM Loans
                         INNER JOIN Books ON Loans.IdBook = Books.Id
                         WHERE Loans.IdClient = @IdClient AND Loans.returned = 0";
            
            SqlDataAdapter daOwnedBooks = new SqlDataAdapter(query, connection);
            daOwnedBooks.SelectCommand.Parameters.AddWithValue("@IdClient", clientId);

            try
            {
                connection.Open();
                daOwnedBooks.Fill(dsOwnedBooks, "Books");

                foreach (DataRow dr in dsOwnedBooks.Tables["Books"].Rows)
                {
                    String id = dr.ItemArray.GetValue(0).ToString();
                    String name = dr.ItemArray.GetValue(1).ToString();
                    String author = dr.ItemArray.GetValue(2).ToString();

                    ListViewItem listViewItem = new ListViewItem(name);
                    //listViewItem.SubItems.Add(name);
                    listViewItem.SubItems.Add(author);
                    listViewItem.Tag = id;
                    booksOwned.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
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
               // string bookName =bookListClients.SelectedItems[0].SubItems[1].Text;
                int bookId = Convert.ToInt32(bookListClients.SelectedItems[0].SubItems[0].Text); // Presupunând că ID-ul cărții este stocat în proprietatea Tag a elementului ListView
                Console.WriteLine("indexul cartii: " + bookId);
                if (!VerifyLoans(bookId, clientId))
                {
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
                }else
                {
                    MessageBox.Show("Carte deja imprumutata!");
                }
            }
            else
            {
                // Mesaj de eroare dacă nu este selectată nicio carte
                MessageBox.Show("Vă rugăm să selectați o carte pentru împrumut.");
            }
            showAllBooks();
            //showLoanedBooks();
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
                string query = "SELECT quantity FROM Books WHERE Id = @bookId";
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
        private bool VerifyLoans(int bookId,int clientId)
        {
            bool exist=false;
            int id=-1;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                
                connection.Open();

                // Interogarea pentru a obține numărul curent de cărți disponibile
                string query = "SELECT Id FROM Loans WHERE IdBook = @bookId AND IdClient=@clientId AND returned=0";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bookId", bookId);
                command.Parameters.AddWithValue("@clientId", clientId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                     id= reader.GetInt32(0);
                    Console.WriteLine("select " + id);

                }
                reader.Close();
            }
            if (id != -1)
            {
                exist = true;
            }
            return exist;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            int ownedBookId = Convert.ToInt32(booksOwned.SelectedItems[0].Tag);
            using (SqlConnection connection = new SqlConnection(conn))
            {
                // Deschiderea conexiunii
                connection.Open();

                // Tranzacție pentru a asigura consistența datelor
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Comanda SQL pentru a actualiza atributul returned în tabela Loans
                    string updateLoanQuery = @"UPDATE Loans SET returned = 1 
                                        WHERE IdBook = @IdBook AND IdClient = @IdClient AND returned = 0";
                    SqlCommand updateLoanCommand = new SqlCommand(updateLoanQuery, connection, transaction);
                    updateLoanCommand.Parameters.AddWithValue("@IdBook", ownedBookId);
                    updateLoanCommand.Parameters.AddWithValue("@IdClient", clientId);

                    // Executarea actualizării împrumutului
                    int rowsAffected = updateLoanCommand.ExecuteNonQuery();

                    //if (rowsAffected == 1)
                    //{
                        // Comanda SQL pentru a crește cantitatea cărților disponibile în tabela Books
                        string updateBookQuantityQuery = @"UPDATE Books SET Quantity = Quantity + 1 WHERE Id = @IdBook";
                        SqlCommand updateBookQuantityCommand = new SqlCommand(updateBookQuantityQuery, connection, transaction);
                        updateBookQuantityCommand.Parameters.AddWithValue("@IdBook", ownedBookId);

                        // Executarea actualizării cantității cărților disponibile
                        updateBookQuantityCommand.ExecuteNonQuery();

                        // Confirmarea tranzacției dacă ambele actualizări sunt reușite
                        transaction.Commit();
                        MessageBox.Show("Împrumut returnat cu succes!");
                    //}
                    //else
                    //{
                        // Rularea înapoi a tranzacției dacă nu s-a putut găsi un împrumut ne-returnat cu acele ID-uri
                        //transaction.Rollback();
                        //MessageBox.Show("Nu s-a putut găsi un împrumut activ cu aceste ID-uri!");
                    //}
                }
                catch (Exception ex)
                {
                    // Rularea înapoi a tranzacției în caz de eroare
                    transaction.Rollback();
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
            showLoanedBooks();
            showAllBooks();
        }
        
        private void showLoanedButton_Click(object sender, EventArgs e)
        {
            showLoanedBooks();
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
                this.Hide();
                this.Close();
                MainPage mainPage = new MainPage();
                mainPage.Show();
        }
    }
}
