using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurWinForm
{


    public partial class Form1 : Form
    {
        TransportData.Service1Client client;

        public Form1()
        {
            InitializeComponent();
            client = new TransportData.Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           client.GetData(textBox1.Text, textBox2.Text);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
