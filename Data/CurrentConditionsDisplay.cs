using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Data
{
    public class CurrentConditionsDisplay : Observer,DisplayElement
    {
        private float temperatur;
        private float humidity;
        private bool magBur;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure, bool magBur)
        {
            this.temperatur = temperature;
            this.humidity = humidity;
            this.magBur = magBur;
            display();
        }
        public void display() 
        {
            string otvet = "";
            if (magBur) otvet = "there's a magnetic storm";
            else otvet = "there's no magnetic storm.";

            MessageBox.Show("Current condition " + temperatur + " F degrees and " + humidity + " % humidity and " + otvet );
        }
    }
} 
