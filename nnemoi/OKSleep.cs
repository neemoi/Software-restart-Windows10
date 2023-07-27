using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnemoi
{
    public partial class OKSleep : Form
    {
        private void DoOperation(string oparation)
        {
            string filename = string.Empty;
            string arguments = string.Empty;

            switch (oparation)
            {
                case "Sleep":
                    filename = "Rundll32.exe";
                    arguments = "powrprof.dll, SetSuspendState 0,1,0";
                    break;
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo(filename, arguments);
            Process.Start(processStartInfo);

            this.Close();
        }

        public OKSleep()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Sleep = "Sleep";
            DoOperation(Sleep);
            this.Close();
        }
    }
}
