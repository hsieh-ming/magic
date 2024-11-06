using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GPS_View
{
    public class UART_Driver
    {
        public SerialPort UART_Port = new SerialPort();
        private bool Read_Flag = false;
        public event EventHandler<string> Read_Buffer;
        public UART_Driver()
        {

        }
        public void Creat(string Port_Name,int BaudRate = 9600,Parity parity = Parity.None,int DataBits = 8,StopBits stopBits = StopBits.One)
        {
            try
            {
                if(!UART_Port.IsOpen)
                {
                    UART_Port.PortName = Port_Name;
                    UART_Port.BaudRate = BaudRate;
                    UART_Port.Parity = parity;
                    UART_Port.DataBits = DataBits;
                    UART_Port.StopBits = stopBits;
                } 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                      
        }
        public bool Open()
        {
            if (!UART_Port.IsOpen)
            {
                try
                {
                    UART_Port.Open();
                    Start_Read();
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false; 
                }
            }
            else
            {
                return false;
            }
        }
        public bool Close()
        {
            if (UART_Port.IsOpen)
            {
                Stop_Read();
                UART_Port.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Start_Read()
        { 
            if(Read_Flag) {
                return;
            }
            Read_Flag = true;
            Task.Run(() => {
                while (Read_Flag) {
                    if (!UART_Port.IsOpen)
                    {
                        break;
                    }
                    try
                    {
                        if(UART_Port.BytesToRead > 0)
                        {
                            string buffer = UART_Port.ReadLine();
                            if (!string.IsNullOrEmpty(buffer))
                            {
                                Read_Buffer?.Invoke(this, buffer);
                            }
                        }
                    }
                    catch (TimeoutException)
                    {

                    }
                    catch
                    {
                        return ;
                    }
                }
                Read_Flag = false;
            });
        }
        public void Stop_Read()
        {
            Read_Flag = false;
        }
    }
}
