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
    public partial class OKGibernation : Form
    {
        private void DoOperation(string oparation)
        {
            string filename = string.Empty;
            string arguments = string.Empty;

            switch (oparation)
            {
                case "Hibernation":
                    filename = @"%windir%\system32\rundll32.exe";
                    arguments = "PowrProf.dll, SetSuspendState";
                    break;
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo(filename, arguments);
            Process.Start(processStartInfo);

            this.Close();
        }

        public OKGibernation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Hibernation = "Hibernation";
            DoOperation(Hibernation);
            this.Close();
        }
    }
}
