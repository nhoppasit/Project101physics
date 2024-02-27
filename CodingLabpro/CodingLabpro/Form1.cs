using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keysight.Visa;



namespace CodingLabpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            Ivi.Visa.Interop.FormattedIO488 MyDMM = new Ivi.Visa.Interop.FormattedIO488();

            txtDMMAddress.Text = "GPIB0::26::INSTR";
            //txtMMC2Address.Text = Properties.Settings.Default.MMC2Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

        }
    }
}
