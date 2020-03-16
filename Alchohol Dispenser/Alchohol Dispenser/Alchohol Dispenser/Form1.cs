using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScaleModelAutomator;
namespace Alchohol_Dispenser
{
    public partial class Form1 : Form
    {
        MCUController _mcu = new MCUController();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mcu.TriggerOnOff("DISPENSE");
            _mcu.TriggerOnOff("OK");
        }
    }
}
