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
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            string titlu = newBookTitle.Text.Trim();
            string autor = newBookAuthor.Text.Trim();
            int cantitate = int.Parse(newBookQuantity.Text.Trim());

            string query = "INSERT INTO Books (Title, Author, Quantity) VALUES (@Title, @Author, @Quantity)";

            string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", titlu);
                    command.Parameters.AddWithValue("@Author", autor);
                    command.Parameters.AddWithValue("@Quantity", cantitate);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Carte adăugată cu succes!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare: " + ex.Message);
                    }
                }
            }
        }
    }
}
