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
        public GPS_Driver()
        {

        }
        public string GPS_Open_Close()
        {
            try
            {
                if (!UART_Driver.UART_Port.IsOpen)
                {
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
        public void Creat(string Com_port)
        {
            UART_Driver.Creat(Com_port);
        }
    }
}
