using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS_View
{
    public class GPS_Driver
    {
        public UART_Driver UART_Driver = new UART_Driver();
        public GPS_Item GPS_Item = new GPS_Item();
        public event EventHandler<string> GPS_Message;
        public event EventHandler<GPS_Item> GPS_Message_View;
        public GPS_Driver()
        {
            UART_Driver.Read_Buffer += UART_Driver_Read_Buffer;
        }

        private void UART_Driver_Read_Buffer(object? sender, string e)
        {
            _= Task.Run(() => { GPS_Message?.Invoke(this,e); });
            string[] GPS_LOG = e.Split(',');
            try
            {
                switch (GPS_LOG[0])
                {
                    case "$GPGLL":
                        GPS_Item.GLL_Data.Parse(GPS_LOG);
                        GPS_Message_View?.Invoke(this, GPS_Item);
                        break;
                    case "$GPGGA":
                        GPS_Item.GGA_Data.Parse(GPS_LOG);
                        GPS_Message_View?.Invoke(this, GPS_Item);
                        break;
                    case "$GPGSA":
                        GPS_Item.GSA_Data.Parse(GPS_LOG);
                        GPS_Message_View?.Invoke(this, GPS_Item);
                        break;
                    case "$GPRMC":
                        GPS_Item.RMC_Data.Parse(GPS_LOG);
                        GPS_Message_View?.Invoke(this, GPS_Item);
                        break;
                    case "$GPVTG":
                        GPS_Item.VTG_Data.Parse(GPS_LOG);
                        GPS_Message_View?.Invoke(this, GPS_Item);
                        break;
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public string GPS_Open_Close(string ComPort)
        {
            try
            {
                if (!UART_Driver.UART_Port.IsOpen)
                {
                    UART_Driver.Creat(ComPort);
                    UART_Driver.Open();
                    return "Disconnect";
                }
                else
                {
                    UART_Driver.Close();
                    return "Connect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Connect";
            }
        }       
    }
}
