using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetScanner
{
    public partial class Scanner : Form
    {

        Thread myThread = null;
        IPAddress[] address;
        int ipcount = 0;
        public Scanner()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //GetIPAddress();
        }
        public void scan()
        {
            Ping myPing;
            PingReply reply;
            IPAddress addr;
            IPHostEntry host;
            string subnet = "";

            progressBar1.Maximum = 254;
            progressBar1.Value = 0;
            lstView.Items.Clear();

            //for (int j = 0; j < address.Length; j++)
            //{
            String[] ipp = txtIp.Text.Split('.');
            // if (address[j].ToString().Length <= 15)
            //{
            // String[] ipp = address[j].ToString().Split('.');
            subnet = ipp[0] + "." + ipp[1] + "." + ipp[2];
            for (int i = 1; i < 255; i++)
            {
                string subnetn = "." + i.ToString(); //This is where the ip address is created 192.168.1.1 - 192.168.1.254
                myPing = new Ping();
                reply = myPing.Send(subnet + subnetn); // This where the check is done to see if it's a valid ip or not.

                if (reply.Status == IPStatus.Success) // If the ip is valid go to the below functions
                {
                    try
                    {
                        addr = IPAddress.Parse(subnet + subnetn); //Creates the ip address to display in the form
                        host = Dns.GetHostEntry(addr);  //Get the host name of the ip address

                        lstView.Items.Add(new ListViewItem(new String[] { subnet + subnetn, host.HostName, "Up" })); // adds the valid ip addresses to the list view
                    }
                    catch
                    {
                        
                    }
                }
                lbl_ipname.Text = subnet + subnetn;
                progressBar1.Value += 1; //Update the prograss bar value
            }
            //}
            // }
            btn_Scan.Enabled = true;
            btnStop.Enabled = false;
            btnSave.Enabled = true;
            int count = lstView.Items.Count;
            MessageBox.Show("Scanning done!\nFound " + count.ToString() + " hosts.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_Scan_Click(object sender, EventArgs e)
        {
            if (txtIp.Text == null)
            {
                MessageBox.Show("Please Enter IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIp.Text.Split('.').Length < 3)
            {
                MessageBox.Show("Invalid IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myThread = new Thread(() => scan()); //Starts the scanning process
                myThread.Start();

                if (myThread.IsAlive == true)
                {
                    btnStop.Enabled = true;
                    btn_Scan.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                myThread.Suspend(); //Stop the scanning process
                btnSave.Enabled = true;
                btn_Scan.Enabled = true;
                btnStop.Enabled = false;
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                string p = Path.GetDirectoryName(Application.ExecutablePath) + "\\saved\\" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".csv"; //Create a new excel file with current date and time.
                string data = "";
                for (int i = 0; i < lstView.Items.Count; i++)
                {
                    data = data + lstView.Items[i].SubItems[0].Text + "," + lstView.Items[i].SubItems[1].Text + "\n"; //Adds the data in listview to the string "data"
                }
                //MessageBox.Show(data);
                File.WriteAllText(p, data); //Then write above data in to the excel file.
                MessageBox.Show("Successfully Saved", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
