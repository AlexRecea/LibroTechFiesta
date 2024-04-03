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
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsClients;
        DataSet dsBooks;
        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project_II\LibroTechFiestaV2\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsClients = new DataSet();
            dsBooks = new DataSet();
            SqlDataAdapter daClients = new SqlDataAdapter("SELECT * FROM Clients", myCon);
            SqlDataAdapter daBooks = new SqlDataAdapter("SELECT * FROM Books", myCon);
            daBooks.Fill(dsBooks, "Books");
            daClients.Fill(dsClients, "Clients");

            foreach (DataRow dr in dsBooks.Tables["Books"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox1.Items.Add(name);
            }
            myCon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
