using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibroTechFiestaV2
{
    public partial class CreateAccount : Form
    {
        
        public CreateAccount()
        {
            InitializeComponent();
            this.Resize+= CreateAccount_Resize;
            CenterObjects();

        }
        private void CreateAccount_Resize(object sender, EventArgs e)
        {
            CenterObjects();
        }
        private void CenterObjects()
        {
            int xPosition = (this.Width - newFirstNameText.Width) / 2;
            int yPosition = 100;
            int dis = 40;
            newFirstNameText.Location = new Point(xPosition, yPosition);
            newLastNameText.Location = new Point(xPosition, yPosition + dis);
            newPhoneNumberText.Location = new Point(xPosition, yPosition + 2 * dis);
            newEmailText.Location = new Point(xPosition, yPosition + 3 * dis);
            newPasswordText.Location = new Point(xPosition, yPosition + 4 * dis);
            int xPosition2 = (this.Width - createNewAccountButton.Width) / 2;
            createNewAccountButton.Location = new Point(xPosition2, yPosition + 5 * dis);
        }
        //Recea
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            string newEmail = newEmailText.Text.Trim();
            string firstName = newFirstNameText.Text.Trim();
            string lastName = newLastNameText.Text.Trim();
            string phoneNumber = newPhoneNumberText.Text.Trim();
            string password = newPasswordText.Text.Trim();
            MainPage mainPage = new MainPage();
            int clientsCount = mainPage.GetClientsCount();
            int nrOfClients = clientsCount + 1;

            try
            {
                if (!CheckIfUserExists(newEmail))
                {
                    if (IsValidFirstName(firstName) && IsValidLastName(lastName))
                    {
                        if (IsValidEmail(newEmail) && !string.IsNullOrEmpty(newEmail))
                        {
                            if (phoneNumber != "Phone number" && IsValidPhoneNumber(phoneNumber)==true && !string.IsNullOrEmpty(phoneNumber))
                            {
                                if (password != "Password" && password.Length > 5 && !string.IsNullOrEmpty(password))
                                {
                                    string insertQuery = "INSERT INTO Clients (Id, FirstName, LastName, Email, PhoneNumber, Password) VALUES (@Id, @FirstName, @LastName, @Email, @PhoneNumber, @Password)";

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
                                    MessageBox.Show("Setează o parolă puternică!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Numărul de telefon nu este valid!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email-ul nu este valid!");
                        }
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
        static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        static bool IsValidPhoneNumber(string phoneNumber)
        {
            string formatTelefon = @"^\(?(\d{3})\)?[\s\-]?(\d{3})[\s\-]?(\d{4})$";
            if (Regex.IsMatch(phoneNumber, formatTelefon))
            {
                return true;
            }
            else
            {
                return false;
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
            if(newPhoneNumberText.Text=="Phone number")
            {
                newPhoneNumberText.Text = "";
                newPhoneNumberText.ForeColor=Color.Black;
            }
        }

        private void newPhoneNumberText_Leave(object sender, EventArgs e)
        {
            if (newPhoneNumberText.Text == "")
            {
                newPhoneNumberText.Text = "Phone number";
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
        public bool IsValidFirstName(string firstName)
        {
            // Verifică dacă titlul este null sau gol
            if (string.IsNullOrWhiteSpace(firstName) && firstName == "First Name")
            {
                MessageBox.Show("Prenumele nu poate fi gol.");
                return false;
            }

            // Verifică lungimea titlului (de exemplu, între 1 și 100 de caractere)
            if (firstName.Length < 1 || firstName.Length > 39)
            {
                MessageBox.Show("Prenume trebuie să fie între 1 și 40 de caractere.");
                return false;
            }

            // Verifică dacă titlul conține caractere nepermise (de exemplu, doar litere, cifre și spații)
            if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Prenumele conține caractere nepermise.");
                return false;
            }

            return true;
        }
        public bool IsValidLastName(string lastName)
        {
            // Verifică dacă titlul este null sau gol
            if (string.IsNullOrWhiteSpace(lastName) && lastName == "Last Name")
            {
                MessageBox.Show("Numele nu poate fi gol.");
                return false;
            }

            // Verifică lungimea titlului (de exemplu, între 1 și 100 de caractere)
            if (lastName.Length < 1 || lastName.Length > 39)
            {
                MessageBox.Show("Nume trebuie să fie între 1 și 40 de caractere.");
                return false;
            }

            // Verifică dacă titlul conține caractere nepermise (de exemplu, doar litere, cifre și spații)
            if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Numele conține caractere nepermise.");
                return false;
            }

            return true;
        }
    }
}
