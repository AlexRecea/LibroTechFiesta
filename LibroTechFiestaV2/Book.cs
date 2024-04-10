using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroTechFiestaV2
{
    internal class Book
    {
        public int id { get; set; }
        public String title { get; set; }
        public String authorName { get; set; }

        public int quantity;
        public Book(int id, string title, string authorName, int quantity)
        {
            this.id = id;
            this.title = title;
            this.authorName = authorName;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return id + " " + title + " " + authorName + " " + quantity;
        }
    }
}
