using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class Thermostat
    {
        private int _Temperature;
        public Thermostat()
        {
            this._Temperature = 20;
        }
        public void SetTemperature(int temperature)
        {
            if (temperature >= 16 && temperature <= 30)
            {
                this._Temperature = temperature;
                Console.WriteLine($"Temperature set to: {temperature}");
            }
            else
            {
                Console.WriteLine("Invalid temperature!");
            }
        }
    }
}
