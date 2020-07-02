using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime.CompilerServices;

namespace cs_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();
                heater.SetTemperature(50);
                heater.TurnOnWater();
                heater.SetTemperature(-2);
                heater.TurnOnWater();
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }            
        }
    }

    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if( temperature < -5 || temperature > 42)
            {
                throw new Exception("범위를 벗어났습니다");
            }
            this.temperature = temperature;
        }
        internal void TurnOnWater()
        {
            WriteLine($"Turn on water : {temperature}");
        }
    }
}
