﻿using System;
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
        public event EventHandler ButtonClicked;
        public AddNewBook()
        {
            InitializeComponent();
            this.Resize += AddNewBook_Resize;
            CenterObjects();
        }
        //Recea
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        //string conn =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";

        private void AddNewBook_Resize(object sender, EventArgs e)
        {
            CenterObjects();
        }

        public void CenterObjects()
        {
            int xPosition = (this.Width - newBookTitle.Width) / 2;
            newBookTitle.Location = new Point(xPosition, 100);
            int xPosition2 = (this.Width - newBookAuthor.Width) / 2;
            newBookAuthor.Location = new Point(xPosition2, 150);
            int xPosition3 = (this.Width - newBookQuantity.Width) / 2;
            newBookQuantity.Location = new Point(xPosition3, 200);
            int xPosition4 = (this.Width - newBookDetails.Width) / 2;
            newBookDetails.Location = new Point(xPosition4, 250);
            int xPosition5 = (this.Width - addNewBookButton.Width) / 2;
            addNewBookButton.Location = new Point(xPosition5, 300);

        }

        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            string title = newBookTitle.Text.Trim();
            string author = newBookAuthor.Text.Trim();
            int quantity = int.Parse(newBookQuantity.Text.Trim());
            string details= newBookDetails.Text.Trim();
            MainPage mainPage = new MainPage();
            int nrOfRows = mainPage.GetRowCount();
            int id = nrOfRows + 1;

            InsertOrUpdateBook(title, author, quantity, id, details);
            this.Close();
            
            
        }

        public void InsertOrUpdateBook(string title, string author, int quantity, int id, string details)
        {
            
           // Check if the book already exists in the database
           string selectQuery = "SELECT COUNT(*) FROM Books WHERE Title = @Title";
           string updateQuery = "UPDATE Books SET Quantity = Quantity + @Quantity WHERE Title = @Title";
           string insertQuery = "INSERT INTO Books (Id, Title, Author, Quantity) VALUES (@IdBook, @Title, @Author, @Quantity)";
           string insertQueryDetails = "INSERT INTO BookDetails (Id, IdBook, preview) VALUES (@Id1, @IdBook, @Details)";
           string updateQueryDetails = "UPDATE BookDetails INNER JOIN Books ON BookDetails.IdBook = Books.Id SET BookDetails.preview = @preview WHERE Books.title = @Title;";

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
                            int nrOfBooks = GetNrOfBooks(title);
                            if (nrOfBooks + quantity >= 0)
                            {
                               // If the book already exists, update the quantity
                            using (var updateCommand = new SqlCommand(updateQuery, connection, transaction))
                            {
                                updateCommand.Parameters.AddWithValue("@Title", title);
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.ExecuteNonQuery();
                                MessageBox.Show("Cartea deja exista, am dat update!");
                            }
                            using (var updateCommand2 = new SqlCommand(updateQueryDetails, connection, transaction))
                            {
                                updateCommand2.Parameters.AddWithValue("@preview", details);
                                updateCommand2.Parameters.AddWithValue("@Title", title);
                                updateCommand2.ExecuteNonQuery();
                            }
                            }
                            else
                            {
                                MessageBox.Show("Nu poti elimina acest numar de carti!");
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
                                insertCommand.Parameters.AddWithValue("@IdBook", id);
                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show("Carte adăugată cu succes!");
                            }
                            using (var insertCommand2 = new SqlCommand(insertQueryDetails, connection, transaction))
                            {
                                insertCommand2.Parameters.AddWithValue("@Details", details);
                                insertCommand2.Parameters.AddWithValue("@IdBook", id);
                                insertCommand2.Parameters.AddWithValue("@Id1", id);
                                insertCommand2.ExecuteNonQuery();
                            }
                        }

                        // Commit the transaction
                        transaction.Commit();
                        ButtonClicked?.Invoke(this, EventArgs.Empty);
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

        public int GetNrOfBooks(string title)
        {
            int nrOfBooks = 0;

            // SQL query to count the number of rows in the table
            string query = $"SELECT quantity FROM Books WHERE title = @title";

            using (var connection = new SqlConnection(conn))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@title", title);
                        connection.Open();
                        // Execute the query and get the result
                        nrOfBooks = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return nrOfBooks;
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

        private void newBookDetails_Enter(object sender, EventArgs e)
        {
            if (newBookDetails.Text == "Details")
            {
                newBookDetails.Text = "";
                newBookDetails.ForeColor = Color.Black;
            }
        }

        private void newBookDetails_Leave(object sender, EventArgs e)
        {
            if (newBookDetails.Text == "")
            {
                newBookDetails.Text = "Details";
                newBookDetails.ForeColor = Color.Silver;
            }
        }

        
    }
}
