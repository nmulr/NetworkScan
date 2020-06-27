using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetScanner
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Scanner form2 = new Scanner();
            form2.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Results form3 = new Results();
            form3.Show();
        }
    }
}
