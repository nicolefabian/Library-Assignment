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
    public partial class displayNetworkingBooks : Form
    {
        public displayNetworkingBooks()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ProcessBooksData processBooksData = new ProcessBooksData();
            networkingDataGrid.DataSource = processBooksData.getNetworkingBooks().ToList();
        }
    }
}
