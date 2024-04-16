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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");


        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            string newEmail = newEmailText.Text.Trim();
            MainPage mainPage = new MainPage();
            int clientsCount = mainPage.GetClientsCount();
            int nrOfClients = clientsCount + 1;

            try
            {
                if (!CheckIfUserExists(newEmail))
                {
                    string insertQuery = "INSERT INTO Clients (Id, FirstName, LastName, Email, PhoneNumber, Password) VALUES (@Id, @FirstName, @LastName, @Email, @PhoneNumber, @Password)";
                    string firstName = newFirstNameText.Text.Trim();
                    string lastName = newLastNameText.Text.Trim();
                    string phoneNumber = newPhoneNumberText.Text.Trim();
                    string password = newPasswordText.Text.Trim();

                    using (var connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (var insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Id", nrOfClients);
                            insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                            insertCommand.Parameters.AddWithValue("@LastName", lastName);
                            insertCommand.Parameters.AddWithValue("@Email", newEmail);
                            insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            insertCommand.Parameters.AddWithValue("@Password", password);
                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("Cont nou creat cu succes!");
                            ClientsPage clientsPage = new ClientsPage();
                            clientsPage.Show();
                            this.Close();
                        }
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Un cont cu acest email există deja.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la înregistrare: " + ex.Message);
            }
        }
        public bool CheckIfUserExists(string email)
        {
            string query = "SELECT COUNT(*) FROM Clients WHERE Email = @Email";

            using (var connection = new SqlConnection(conn))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Returnează true dacă utilizatorul există deja, altfel false
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false; // În caz de eroare, returnează false
                    }
                }
            }
        }
    }
}
