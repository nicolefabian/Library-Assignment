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
    public partial class displayAllBooks : Form
    {
        public displayAllBooks()
        {
            InitializeComponent();
    }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ReadDataFile readFile = new ReadDataFile();
            dataGridView1.DataSource = readFile.readFile().ToList();
        }

    }
}
