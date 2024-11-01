using System.ComponentModel;
using System.IO.Ports;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace GPS_View
{
    public partial class Form1 : Form
    {
        UART_Driver UART_Driver = new UART_Driver();
        GPS_Driver GPS_Driver = new GPS_Driver();
        public Form1()
        {
            InitializeComponent();
            UART_Driver.Read_Buffer += UART_Driver_Read_Buffer;
        }

        private void UART_Driver_Read_Buffer(object? sender, string e)
        {
            BeginInvoke(new Action(() =>
            {
                GPS_Log_listBox.Items.Add(e);
                GPS_Log_listBox.TopIndex = GPS_Log_listBox.Items.Count - 1;
            }));
        }

        private void Port_Name_comboBox_DropDown(object sender, EventArgs e)
        {
            Port_Name_comboBox.Items.Clear();
            Port_Name_comboBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            GPS_Driver.Creat(Port_Name_comboBox.SelectedItem.ToString());
            Connect_button.Text = GPS_Driver.GPS_Open_Close();
        }

        private void Clear_Log_button_Click(object sender, EventArgs e)
        {
            GPS_Log_listBox.Items.Clear();
        }
    }
}
