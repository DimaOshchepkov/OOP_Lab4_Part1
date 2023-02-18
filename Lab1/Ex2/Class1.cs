using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class AirConditioner
    {
        private int temperature = MIN_INTENSITY;
        private int intensity = MIN_INTENSITY;

        private const int MAX_TEMPERATURE = 30;
        private const int MIN_TEMPERATURE = 15;

        private const int MAX_INTENSITY = 9;
        private const int MIN_INTENSITY = 1;

        public AirConditioner() { }
     

        public AirConditioner(int temperature, int intensity)
        {
            if (MIN_TEMPERATURE <= temperature && temperature <= MAX_TEMPERATURE)
                this.temperature = temperature;
            if (MIN_INTENSITY <= intensity && intensity <= MAX_INTENSITY)
                this.intensity = intensity;
        }


        public void prevTemperatureButton()
        {
            if (temperature > MIN_TEMPERATURE)
                temperature--;
        }
        public void nextTemperatureButton()
        {
            if (temperature < MAX_TEMPERATURE)
                temperature++;
        }

        public void prevIntensityButton()
        {
            if (intensity == MIN_INTENSITY)
                intensity = MAX_INTENSITY;
            else
                intensity--;
        }

        public void nextIntensityButton()
        {
            if (intensity == MAX_INTENSITY)
                intensity = MIN_INTENSITY;
            else
                intensity++;
        }

        public void SetTemperature(int valueTemperature)
        {
            if (MIN_TEMPERATURE <= valueTemperature && valueTemperature <= MAX_TEMPERATURE)
                temperature = valueTemperature;
        }

        public int GetTemperature()
        {
            return temperature;
        }
        public int GetIntensity()
        {
            return intensity;
        }
    }
}
