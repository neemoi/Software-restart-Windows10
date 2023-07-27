using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnemoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OKShutDown oKShutDown = new OKShutDown();
            oKShutDown.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OKReload oKReload = new OKReload();
            oKReload.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OKLogIn oKLogIn = new OKLogIn();
            oKLogIn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OKLock oKLock = new OKLock();
            oKLock.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OKSleep oKSleep = new OKSleep();
            oKSleep.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OKGibernation oKGibernation = new OKGibernation();
            oKGibernation.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}