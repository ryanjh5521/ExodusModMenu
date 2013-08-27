using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XRPCLib;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XRPC Jtag = new XRPC();

        private void button1_Click(object sender, EventArgs e)
        {
            Jtag.Connect();


            if (Jtag.activeConnection)
            {
                System.Windows.Forms.MessageBox.Show("Connected");


            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Connection Failed");
            }
        }
    }
}
