using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingLabpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDMMAddress.Text = Properties.Settings.Default.DMMAddress;
            txtMMC2Address.Text = Properties.Settings.Default.MMC2Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GPIB0::26::INSTR address of your IEEE-488 device
            string deviceAddress = "GPIB0::26::INSTR";

            //Create a new VisaResourceManager
            using (var visaResourceManager = new ResourceManager())
            {
                //Open a connection to the device 
                using (var device = visaResourceManager.Open(deviceAddress))
                {
                    // Send a command to the device 
                    string command = "IDN?";
                    device.Write(command );

                    // Read the response from the device
                    string response = device.ReadString();


                    Console.WriteLine("Response from device: " + response);

                }
            }
        }
    }
}
