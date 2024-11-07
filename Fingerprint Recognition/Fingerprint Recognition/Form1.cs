using System.IO.Ports;
using System.Timers;

namespace Fingerprint_Recognition
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            Port_comboBox.Items.Clear();
            Port_comboBox.Items.AddRange(SerialPort.GetPortNames());
        }
    }
}
