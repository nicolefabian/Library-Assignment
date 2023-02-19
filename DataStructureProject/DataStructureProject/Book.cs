using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProject
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Second_Author { get; set; }
        public string Book_Name { get; set; }
        public string Publisher { get; set; }
        public int Released_Year { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return ISBN + "," + Author + ","  + Second_Author + ", "+ Book_Name + "," + Publisher + "," + Released_Year + "," + Category;
        }

    }
}
