using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS_View
{
    public class GPS_Item
    {
        public GLL_Data GLL_Data = new GLL_Data();
        public GGA_Data GGA_Data = new GGA_Data();
        public GSA_Data GSA_Data = new GSA_Data();
        public RMC_Data RMC_Data = new RMC_Data();
        public VTG_Data VTG_Data = new VTG_Data();
    }
    public class GLL_Data
    {
        public string NSDirection { get; set; } // 緯度方向 (N 或 S)
        public string EWDirection { get; set; } // 經度方向 (E 或 W)
        public double Latitude { get; set; } // 緯度值
        public double Longitude { get; set; } // 經度值
        public DateTime UTCTime { get; set; } // UTC 時間
        public string Status { get; set; } // 狀態 (A 或 V)
        public string ModeIndicator { get; set; } // 模式指示 (D 表示差分 GPS 等)
        public void Parse(string[] GGL)
        {
            if(GGL.Length < 7)
            {
                throw new ArgumentException("GPGLL 字串格式錯誤。");
            }
            // 解析緯度和方向
            Latitude = ConvertToDecimalDegrees(GGL[1]);
            NSDirection = GGL[2];
            // 解析經度和方向
            Longitude = ConvertToDecimalDegrees(GGL[3]);
            EWDirection = GGL[4];

            // UTC 時間
            UTCTime = DateTime.ParseExact(GGL[5], "HHmmss.ff", null);

            // 狀態 (A 或 V)
            Status = GGL[6];

            // 模式指示，去除校驗和
            ModeIndicator = GGL[7].Split('*')[0];
        }
        private double ConvertToDecimalDegrees(string coordinate)
        {
            if (string.IsNullOrEmpty(coordinate)) { return 0; }
            // 將度數轉換為小數形式
            double degrees = double.Parse(coordinate.Substring(0, coordinate.Length - 7));
            double minutes = double.Parse(coordinate.Substring(coordinate.Length - 7));
            return degrees + (minutes / 60);
        }
    }
    public class GGA_Data
    {
        public DateTime UTCTime { get; set; } // UTC時間
        public double Latitude { get; set; } // 緯度
        public string NSDirection { get; set; } // 北/南
        public double Longitude { get; set; } // 經度
        public string EWDirection { get; set; } // 東/西
        public int Quality { get; set; } // 定位品質
        public int SatelliteCount { get; set; } // 使用衛星數量
        public double HDOP { get; set; } // 水平精確度指標
        public double Altitude { get; set; } // 海拔
        public double GeoidalSeparation { get; set; } // 大地水準面高
        public void Parse(string[] GGA)
        {
            if (GGA.Length < 15)
            {
                throw new ArgumentException("GGA 字串格式錯誤。");
            }
            UTCTime = DateTime.ParseExact(GGA[1], "HHmmss.ff", null);
            Latitude = ConvertToDecimalDegrees(GGA[2]);
            NSDirection = GGA[3];
            Longitude = ConvertToDecimalDegrees(GGA[4]);
            EWDirection = GGA[5];
            Quality = int.Parse(GGA[6]);
            SatelliteCount = int.Parse(GGA[7]);
            HDOP = double.Parse(GGA[8]);
            Altitude = string.IsNullOrEmpty(GGA[9]) ? 0 : double.Parse(GGA[9]);
            GeoidalSeparation = string.IsNullOrEmpty(GGA[11]) ? 0 : double.Parse(GGA[11]);
        }
        private double ConvertToDecimalDegrees(string coordinate)
        {
            if (string.IsNullOrEmpty(coordinate)) { return 0; }
            double degrees = double.Parse(coordinate.Substring(0, coordinate.Length - 7));
            double minutes = double.Parse(coordinate.Substring(coordinate.Length - 7));
            return degrees + (minutes / 60);
        }
    }
    public class GSA_Data
    {
        public string OperationMode { get; set; } // 操作模式
        public int FixMode { get; set; } // 定位模式
        public List<int> SatellitesUsed { get; set; } = new List<int>(); // 衛星PRN編號
        public double PDOP { get; set; } // 位置精確度因子
        public double HDOP { get; set; } // 水平精確度因子
        public double VDOP { get; set; } // 垂直精確度因子
        public void Parse(string[] GSA)
        {
            if (GSA.Length < 18)
            {
                throw new ArgumentException("GSA 字串格式錯誤。");
            }

            OperationMode = GSA[1];
            FixMode = int.Parse(GSA[2]);

            // 從第3到第14欄位是衛星PRN編號
            for (int i = 3; i <= 14; i++)
            {
                if (int.TryParse(GSA[i], out int prn))
                {
                    SatellitesUsed.Add(prn);
                }
            }

            PDOP = double.Parse(GSA[15]);
            HDOP = double.Parse(GSA[16]);
            VDOP = double.Parse(GSA[17].Split('*')[0]); // 移除校驗和
        }
    }
    public class RMC_Data
    {
        public DateTime UTCTime { get; set; }         // UTC時間
        public bool IsValid { get; set; }             // 定位狀態
        public double Latitude { get; set; }          // 緯度
        public string NSIndicator { get; set; }       // 南北半球標誌
        public double Longitude { get; set; }         // 經度
        public string EWIndicator { get; set; }       // 東西半球標誌
        public double GroundSpeed { get; set; }       // 地面速度
        public double Course { get; set; }            // 航向
        public DateTime UTCDate { get; set; }         // UTC日期
        public double? MagneticVariation { get; set; }// 磁偏角（若有）
        public string MagneticVariationDir { get; set; } // 磁偏角方向
        public void Parse(string[] RMC)
        {
            UTCTime = DateTime.ParseExact(RMC[1], "HHmmss.ff", null);
            IsValid = RMC[2] == "A";

            Latitude = ParseCoordinate(RMC[3]);
            NSIndicator = RMC[4];
            Longitude = ParseCoordinate(RMC[5]);
            EWIndicator = RMC[6];

            GroundSpeed = string.IsNullOrEmpty(RMC[7]) ? 0 : double.Parse(RMC[7]);
            Course = string.IsNullOrEmpty(RMC[8]) ? 0 : double.Parse(RMC[8]);
            UTCDate = DateTime.ParseExact(RMC[9], "ddMMyy", null);

            if (double.TryParse(RMC[10], out double magneticVariation))
            {
                MagneticVariation = magneticVariation;
                MagneticVariationDir = RMC[11];
            }
        }
        private double ParseCoordinate(string coordinate)
        {
            if (string.IsNullOrEmpty(coordinate)) {  return 0; }
            double degrees = double.Parse(coordinate.Substring(0, coordinate.IndexOf('.') - 2));
            double minutes = double.Parse(coordinate.Substring(coordinate.IndexOf('.') - 2));
            return degrees + (minutes / 60);
        }
    }
    public class VTG_Data
    {
        public double TrueCourse { get; set; }             // 航向 (真北)
        public double MagneticCourse { get; set; }         // 航向 (磁北)
        public double SpeedInKnots { get; set; }           // 速度（節）
        public double SpeedInKmh { get; set; }             // 速度（公里/小時）
        public void Parse(string[] VTG)
        {
            TrueCourse = double.TryParse(VTG[1], out double trueCourse) ? trueCourse : 0;
            MagneticCourse = double.TryParse(VTG[3], out double magneticCourse) ? magneticCourse : 0;
            SpeedInKnots = double.TryParse(VTG[5], out double speedKnots) ? speedKnots : 0;
            SpeedInKmh = double.TryParse(VTG[7], out double speedKmh) ? speedKmh : 0;
        }
    }
    
}
