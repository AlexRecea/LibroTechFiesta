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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace LibroTechFiestaV2
{
    public partial class MainPage : Form
    {
        private void MainPage_Load(object sender, EventArgs e)
        {
            int xPosition =  (Screen.PrimaryScreen.Bounds.Width - usernameText.Width) / 2 + 400;
            usernameText.Location = new System.Drawing.Point(xPosition, 200); 
            passwordText.Location = new System.Drawing.Point(xPosition, 250);
            loginLibrariansButton.Location = new System.Drawing.Point(xPosition, 300);

            int xPosition2 = (Screen.PrimaryScreen.Bounds.Width - passwordText.Width) / 2 - 200;
            usernameClientText.Location = new System.Drawing.Point(xPosition2, 200);
            passwordClientText.Location = new System.Drawing.Point(xPosition2, 250);
            loginButton.Location = new System.Drawing.Point(xPosition2, 300);
            registerButton.Location = new System.Drawing.Point(xPosition2, 350);
        }

        //Recea
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");

        //Elena
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elena\Desktop\Proiect II\LibroTechFiesta\LibroTechFiestaV2\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(" select * from Clients where email=@email COLLATE SQL_Latin1_General_CP1_CS_AS and password=@pass COLLATE SQL_Latin1_General_CP1_CS_AS", connection);
                cmd.Parameters.AddWithValue("@email", usernameClientText.Text);
                cmd.Parameters.AddWithValue("@pass", passwordClientText.Text);

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    ClientsPage clientsPage = new ClientsPage();
                    //MessageBox.Show("Succesfully Login!");
                    this.Hide();
                    //this.Close();
                    clientsPage.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username and Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (usernameText.Text == "username")
            {
                usernameText.Text = "";
                usernameText.ForeColor = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (usernameText.Text == "")
            {
                usernameText.Text = "username";
                usernameText.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == "password")
            {
                passwordText.Text = ""; 
                passwordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                passwordText.Text = "password";
                passwordText.ForeColor = Color.Silver;
            }
        }

        public int GetRowCount ()
        {
            int rowCount = 0;

            // SQL query to count the number of rows in the table
            string query = $"SELECT COUNT(*) FROM Books";

            using (var connection = new SqlConnection(conn))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        // Execute the query and get the result
                        rowCount = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return rowCount;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void loginLibrariansButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(" select * from Librarians where username=@name COLLATE SQL_Latin1_General_CP1_CS_AS and password=@pass COLLATE SQL_Latin1_General_CP1_CS_AS", connection);
                cmd.Parameters.AddWithValue("@name", usernameText.Text);
                cmd.Parameters.AddWithValue("@pass", passwordText.Text);

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    LibrariansPage librariansPage = new LibrariansPage();
                    //MessageBox.Show("Succesfully Login!");
                    this.Hide();
                    //this.Close();
                    librariansPage.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username and Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
