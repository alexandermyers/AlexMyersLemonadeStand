using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        string sunny;
        string windy;
        string cloudy;
        string raining;
        // Variables (HAS A)
        public int temperature;
        string[] conditions = new string[3];

        // Constructor
        public Weather()
        {
            sunny = "sunny";
            windy = "windy";
            cloudy = "cloudy";
            raining = "raining";

            temperature = 0;
            conditions[0] = sunny;
            conditions[1] = windy;
            conditions[2] = cloudy;
            conditions[3] = raining;
        }
        // Methods
        public void GenerateWeatherConditions()
        {
            int index;
            Random rand = new Random();
            index = rand.Next(conditions.Length);
            Console.WriteLine(conditions[index]);
            Console.ReadLine();
        }
        public void GenerateWeatherTemperature()
        {
            int percent;
            Random rand = new Random();
            percent = rand.Next(0, 100);
        }
        public void GenerateForcastConditions()
        {
            
        }
        public void GenerateForecastTemperatures()
        {
            Weather.GenerateWeatherTemperature();
        }
    }
}