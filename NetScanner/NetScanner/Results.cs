using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetScanner
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstFile.SelectedItems.Count > 0)
                {
                    string p = Path.GetDirectoryName(Application.ExecutablePath) + "\\saved\\";
                    p += lstFile.SelectedItems[0].Text;
                    System.Diagnostics.Process.Start(p);
                }
                else
                {
                    MessageBox.Show("Please Select a File Name to Open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string p = Path.GetDirectoryName(Application.ExecutablePath) + "\\saved";
                DirectoryInfo d = new DirectoryInfo(p);//This is going to folder called "saved"
                FileInfo[] Files = d.GetFiles("*.csv"); //Getting Text files as *.csv
                string str = "";
                foreach (FileInfo file in Files) //This will get the CSV files in the SAVED Folder
                {
                    lstFile.Items.Add(new ListViewItem(new String[] { file.Name })); //Add file names to the list
                }
                // MessageBox.Show(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
