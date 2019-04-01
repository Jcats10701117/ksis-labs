using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private NetworkMetadata _networkMetadata;
        public Form1()
        {
            InitializeComponent();
            _networkMetadata = new NetworkMetadata();
        }

        private void ipConfig_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = _networkMetadata.ShowAllNetworkInterfaces();
        }

        private void dns_button_Click(object sender, EventArgs e)
        {
            if (dns_textBox.Text.Length == 0)
            {
                error_label.Text = "Input dns";
                return;
            }

            error_label.Text = "";

            result_richTextBox.Text = _networkMetadata.GetIpFromDns(dns_textBox.Text);

        }

        private void broadcast_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = _networkMetadata.GetBroadcastAddress();
        }

        private void loopback_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = _networkMetadata.GetLoopback();
        }

        private void any_button_Click(object sender, EventArgs e)
        {
            result_richTextBox.Text = _networkMetadata.GetAny();
        }
    }
}
