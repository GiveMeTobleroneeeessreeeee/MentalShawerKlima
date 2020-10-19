using System;

namespace SensorLibrary
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public string LokaleId { get; set; }
        public float Temp { get; set; }
        public int Fugt { get; set; }
        public int Co2 { get; set; }
        public int Tryk { get; set; }

        public Sensor(int sensorId, string lokaleId, float temp, int fugt, int co2, int tryk)
        {
            SensorId = sensorId;
            LokaleId = lokaleId;
            Temp = temp;
            Fugt = fugt;
            Co2 = co2;
            Tryk = tryk;
        }
    }
}
