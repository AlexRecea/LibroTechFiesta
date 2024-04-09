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
using System.Data.SqlClient;

namespace LibroTechFiestaV2
{
    public partial class MainPage : Form
    {
        private void MainPage_Load(object sender, EventArgs e)
        {
            int xPosition = (Screen.PrimaryScreen.Bounds.Width - textBox1.Width) / 2;
            textBox1.Location = new System.Drawing.Point(xPosition, 200);
        }
        SqlConnection myCon = new SqlConnection();
        DataSet dsClients;
        DataSet dsBooks;
        string conn = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Project_II\\LibroTechFiestaV2\\Database1.mdf;Integrated Security=True");
        LibrariansPage librariansPage = new LibrariansPage();
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection= new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(" select * from Librarians where username=@name and password=@pass", connection);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    //MessageBox.Show("Succesfully Login!");
                    this.Hide();
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
