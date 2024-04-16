using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroTechFiestaV2
{
    public partial class ClientsPage : Form
    {
        
        public ClientsPage()
        {
            InitializeComponent();
            bookListClients.Items.Clear();
            bookListClients.View = View.Details;
            bookListClients.Columns.Add("Titlul", 300);
            bookListClients.Columns.Add("Autorul", 300);
            bookListClients.Columns.Add("Stoc", 300);
            LibrariansPage librariansPage = new LibrariansPage();
            librariansPage.showAllBooks();
        }


    }
}
