using System;

namespace TempConversionClass
{
    public class ConversionCalculator
    {
        public float BaseTemp { get; set; }
        public char BaseScaleName { get; set; }

        public ConversionCalculator(float baseT, char scaleName)
        {
            BaseTemp = baseT;
            BaseScaleName = scaleName;
        }

        public float toFahrenheight()
        {
            float computedTemp = -10000;
            switch (BaseScaleName)
            {
                case 'F':
                    computedTemp = BaseTemp;
                    break;
                case 'C':
                    computedTemp = BaseTemp * 9 / 5 + 32; 
                    break;
                case 'K':
                    computedTemp = (BaseTemp - 273 ) * 9/5 + 32;
                    break;
            }
            return computedTemp;
        }

        public float toCelsius()
        {
            float computedTemp = -10000;
            switch (BaseScaleName)
            {
                case 'F':
                    computedTemp = (BaseTemp - 32) * 5 / 9;
                    break;
                case 'C':
                    computedTemp = BaseTemp;
                    break;
                case 'K':
                    computedTemp = BaseTemp - 273;
                    break;
            }
            return computedTemp;
        }

        public float toKelvin()
        {
            float computedTemp = -10000;
            switch (BaseScaleName)
            {
                case 'F':
                    computedTemp = ( BaseTemp - 32 ) * 5/9 + 273;
                    break;
                case 'C':
                    computedTemp = BaseTemp + 273;
                    break;
                case 'K':
                    computedTemp = BaseTemp;
                    break;
            }
            return computedTemp;
        }
    }
}
