using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureProject
{
    public partial class displayComputerScienceBooks : Form
    {
        public displayComputerScienceBooks()
        {
            InitializeComponent();
        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            ProcessBooksData processBooksData = new ProcessBooksData();
            computerScienceDataGrid.DataSource = processBooksData.getComputerScienceBooks().ToList();
        }
    }
}
