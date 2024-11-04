using System.ComponentModel;
using System.IO.Ports;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace GPS_View
{
    public partial class Form1 : Form
    {
        GPS_Driver GPS_Driver = new GPS_Driver();
        public Form1()
        {
            InitializeComponent();
            GPS_Driver.GPS_Message += GPS_Driver_GPS_LOG;
            GPS_Driver.GPS_Message_View += GPS_Driver_GPS_Message_View;
        }

        private void GPS_Driver_GPS_Message_View(object? sender, GPS_Item e)
        {
            BeginInvoke(new Action(() =>
            {
                GGA_UTC.Text = e.GGA_Data.UTCTime.ToString();
                GGA_Latitude.Text = e.GGA_Data.Latitude.ToString();
                GGA_Longitude.Text = e.GGA_Data.Longitude.ToString();
                GGA_NSDirection.Text = e.GGA_Data.NSDirection;
                GGA_EWDirection.Text = e.GGA_Data.EWDirection;
                GGA_Quality.Text = e.GGA_Data.Quality.ToString();
                GGA_SatelliteCount.Text = e.GGA_Data.SatelliteCount.ToString();
                GGA_Altitude.Text = e.GGA_Data.Altitude.ToString();
                GGA_GeoidalSeparation.Text = e.GGA_Data.GeoidalSeparation.ToString();

                VTG_TrueCourse.Text = e.VTG_Data.TrueCourse.ToString();
                VTG_MagneticCourse.Text =e.VTG_Data.MagneticCourse.ToString();
                VTG_SpeedInKnots.Text = e.VTG_Data.SpeedInKmh.ToString();
                VTG_SpeedInKmh.Text = e.VTG_Data.SpeedInKmh.ToString();
                
            }));
            
        }

        private void GPS_Driver_GPS_LOG(object? sender, string e)
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
            Connect_button.Text = GPS_Driver.GPS_Open_Close(Port_Name_comboBox.SelectedItem.ToString());
        }

        private void Clear_Log_button_Click(object sender, EventArgs e)
        {
            GPS_Log_listBox.Items.Clear();
        }
    }
}
