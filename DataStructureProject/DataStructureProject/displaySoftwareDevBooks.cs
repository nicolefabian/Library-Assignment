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
    public partial class displaySoftwareDevBooks : Form
    {
        public displaySoftwareDevBooks()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ProcessBooksData processBooksData = new ProcessBooksData();
            softwareDevelopmentDataGrid.DataSource = processBooksData.getSoftwareDevelopmentBooks().ToList();
        }
    }
}
