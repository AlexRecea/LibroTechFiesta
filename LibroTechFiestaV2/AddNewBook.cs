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
    public partial class AddNewBook : Form
    {
        private void AddNewBook_Load(object sender, EventArgs e)
        {
            int xPosition = (Width - newBookTitle.Width) / 2 ;
            newBookTitle.Location = new Point(xPosition, 100);
            int xPosition2 = (Width - newBookAuthor.Width) / 2;
            newBookAuthor.Location = new Point(xPosition2, 150);
            int xPosition3 = (Width - newBookQuantity.Width) / 2;
            newBookQuantity.Location = new Point(xPosition3, 200);
            int xPosition4 = (Width - addNewBookButton.Width) / 2;
            newBookQuantity.Location = new Point(xPosition4, 250);
        }
            public AddNewBook()
        {
            InitializeComponent();
        }

        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            string title = newBookTitle.Text.Trim();
            string author = newBookAuthor.Text.Trim();
            int quantity = int.Parse(newBookQuantity.Text.Trim());
            MainPage mainPage = new MainPage();
            int nrOfRows = mainPage.GetRowCount();
            int id = nrOfRows + 1;

            InsertOrUpdateBook(title, author, quantity,id);
            
        }

        public void InsertOrUpdateBook(string title, string author, int quantity,int id)
        {
            //Recea
            //string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

            //Elena
            string conn =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";

           // Check if the book already exists in the database
           string selectQuery = "SELECT COUNT(*) FROM Books WHERE Title = @Title";
            string updateQuery = "UPDATE Books SET Quantity = Quantity + @Quantity WHERE Title = @Title";
            string insertQuery = "INSERT INTO Books (Id, Title, Author, Quantity) VALUES (@Id, @Title, @Author, @Quantity)";

            using (var connection = new SqlConnection(conn))
            {
                connection.Open();

                // Start a transaction
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int existingCount;
                        using (var selectCommand = new SqlCommand(selectQuery, connection, transaction))
                        {
                            selectCommand.Parameters.AddWithValue("@Title", title);
                            existingCount = Convert.ToInt32(selectCommand.ExecuteScalar());
                        }

                        if (existingCount > 0)
                        {
                            // If the book already exists, update the quantity
                            using (var updateCommand = new SqlCommand(updateQuery, connection, transaction))
                            {
                                updateCommand.Parameters.AddWithValue("@Title", title);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.ExecuteNonQuery();
                                MessageBox.Show("Cartea deja exista, am modificat cantitatea!");
                            }
                        }
                        else
                        {
                            // If the book doesn't exist, insert it
                            using (var insertCommand = new SqlCommand(insertQuery, connection, transaction))
                            {
                                insertCommand.Parameters.AddWithValue("@Title", title);
                                insertCommand.Parameters.AddWithValue("@Author", author);
                                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                insertCommand.Parameters.AddWithValue("@Id", id);
                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show("Carte adăugată cu succes!");
                            }
                        }

                        // Commit the transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // If an error occurs, rollback the transaction
                        transaction.Rollback();
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void newBookTitle_Enter(object sender, EventArgs e)
        {
            if (newBookTitle.Text == "Title")
            {
                newBookTitle.Text = "";

                newBookTitle.ForeColor = Color.Black;
            }
        }

        private void newBookTitle_Leave(object sender, EventArgs e)
        {
            if(newBookTitle.Text == "")
            {
                newBookTitle.Text = "Title";

                newBookTitle.ForeColor = Color.Silver;
            }
        }

        private void newBookAuthor_Enter(object sender, EventArgs e)
        {
            if(newBookAuthor.Text == "Author")
            {
                newBookAuthor.Text = "";
                newBookAuthor.ForeColor = Color.Black;
            }
        }

        private void newBookAuthor_Leave(object sender, EventArgs e)
        {
            if( newBookAuthor.Text == "")
            {
                newBookAuthor.Text= "Author";
                newBookAuthor.ForeColor= Color.Silver;
            }
        }

        private void newBookQuantity_Enter(object sender, EventArgs e)
        {
            if(newBookQuantity.Text == "Quantity")
            {
                newBookQuantity.Text = "";
                newBookQuantity.ForeColor=Color.Black;
            }
        }

        private void newBookQuantity_Leave(object sender, EventArgs e)
        {
            if(newBookQuantity.Text == "")
            {
                newBookQuantity.Text = "Quantity";
                newBookQuantity.ForeColor= Color.Silver;
            }
        }
    }
}
