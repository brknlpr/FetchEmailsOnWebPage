using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchMaillist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMails_Click(object sender, EventArgs e)
        {
            string address = txtUrl.Text;
            WebClient webClient = new WebClient();
            byte[] Data = webClient.DownloadData(address);
            string stringData = Encoding.ASCII.GetString(Data);
            Regex regex = new Regex("([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})");
            MatchCollection collection = regex.Matches(stringData);

            foreach(var email in collection)
            {
                mailListBox.Items.Add(email.ToString());
            }

            lblListResult.Text = "Emails on the website have been listed...";
        }
    }
}
