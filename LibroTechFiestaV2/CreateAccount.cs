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
    public partial class CreateAccount : Form
    {
        private void CreateAccount_Load(object sender, EventArgs e)
        {/*
            int xPosition = (Width - newFirstNameText.Width) / 2;
            int yPosition = 50;
            newFirstNameText.Location = new Point(xPosition, yPosition);
            newLastNameText.Location = new Point(xPosition, yPosition+newFirstNameText.Height+20);         
            newPhoneNumberText.Location = new Point(xPosition, yPosition+2*(newFirstNameText.Height + 20));         
            newEmailText.Location = new Point(xPosition, yPosition+3*(newFirstNameText.Height + 20));           
            newPhoneNumberText.Location = new Point(xPosition, yPosition+4*(newFirstNameText.Height + 20));
            newPhoneNumberText.Location = new Point(xPosition, yPosition + 5 * (newFirstNameText.Height + 20));
            */
        }
        public CreateAccount()
        {
            InitializeComponent();
        }
        //Recea
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";
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
                            clientsPage.SetClientId(nrOfClients);
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

        private void newFirstNameText_Enter(object sender, EventArgs e)
        {
            if(newFirstNameText.Text=="First Name")
            {
                newFirstNameText.Text = "";
                newFirstNameText.ForeColor = Color.Black;
            }
        }

        private void newFirstNameText_Leave(object sender, EventArgs e)
        {
            if (newFirstNameText.Text == "")
            {
                newFirstNameText.Text = "First Name";
                newFirstNameText.ForeColor = Color.Silver;
            }
        }

        private void newLastNameText_Enter(object sender, EventArgs e)
        {
            if(newLastNameText.Text=="Last Name")
            {
                newLastNameText.Text = "";
                newLastNameText.ForeColor = Color.Black;
            }
        }

        private void newLastNameText_Leave(object sender, EventArgs e)
        {
            if( newLastNameText.Text == "")
            {
                newLastNameText.Text = "Last Name";
                newLastNameText.ForeColor=Color.Silver;
            }
        }

        private void newEmailText_Enter(object sender, EventArgs e)
        {
            if (newEmailText.Text == "email")
            {
                newEmailText.Text = "";
                newEmailText.ForeColor=Color.Black;
            }
        }

        private void newEmailText_Leave(object sender, EventArgs e)
        {
            if (newEmailText.Text == "")
            {
                newEmailText.Text = "email";
                newEmailText.ForeColor=Color.Silver;
            }
        }

        private void newPhoneNumberText_Enter(object sender, EventArgs e)
        {
            if(newPhoneNumberText.Text=="Phone")
            {
                newPhoneNumberText.Text = "";
                newPhoneNumberText.ForeColor=Color.Black;
            }
        }

        private void newPhoneNumberText_Leave(object sender, EventArgs e)
        {
            if (newPhoneNumberText.Text == "")
            {
                newPhoneNumberText.Text = "Phone";
                newPhoneNumberText.ForeColor = Color.Silver;
            }

        }

        private void newPasswordText_Enter(object sender, EventArgs e)
        {
            if (newPasswordText.Text == "Password")
            {
                newPasswordText.Text = "";
                newPasswordText.ForeColor=Color.Black;
            }
        }

        private void newPasswordText_Leave(object sender, EventArgs e)
        {
            if (newPasswordText.Text == "")
            {
                newPasswordText.Text = "Password";
                newPasswordText.ForeColor = Color.Silver;
            }
        }
    }
}
