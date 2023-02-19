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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allBooksButton_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            displayAllBooks display = new displayAllBooks();
            display.TopLevel = false;
            centerPanel.Controls.Add(display);
            display.Show();
        }

        private void bookCategoriesButton_Click(object sender, EventArgs e)
        {
            if(dropdownPanel.Height == 332)
            {
                dropdownPanel.Height = 67;
            } else
            {
                dropdownPanel.Height = 332;
            }
        }

        private void compsciButton_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            displayComputerScienceBooks display = new displayComputerScienceBooks();
            display.TopLevel = false;
            centerPanel.Controls.Add(display);
            display.Show();
        }

        private void networkingButton_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            displayNetworkingBooks display = new displayNetworkingBooks();
            display.TopLevel = false;
            centerPanel.Controls.Add(display);
            display.Show();
        }

        private void mathematicsButton_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            displayMathematicsBooks display = new displayMathematicsBooks();
            display.TopLevel = false;
            centerPanel.Controls.Add(display);
            display.Show();
        }

        private void softwareDevButton_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            displaySoftwareDevBooks display = new displaySoftwareDevBooks();
            display.TopLevel = false;
            centerPanel.Controls.Add(display);
            display.Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            dashboard display = new dashboard();
            display.TopLevel = false;
            centerPanel.Controls.Add(display);
            display.Show();
        }
    }
}
