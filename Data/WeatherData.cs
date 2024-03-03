using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class WeatherData : Subject
    {
        public ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;
        private bool magBur;

        public WeatherData() 
        {
            observers = new ArrayList();
        }
        public void measurementsChanged() 
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature, float humidity, float pressure, bool magBur)
        {
            this.temperature = temperature;
            this.pressure = pressure;
            this.humidity = humidity;
            this.magBur = magBur;
            measurementsChanged();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if(i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void notifyObserver()
        {
            for(int i = 0;i < observers.Count;i++)
            {
                Observer observer = (Observer)observers[i];
                observer.update(temperature, humidity, pressure, magBur);
            }
        }

        public float getTemperatur()
        {
            return 10;
        }
        public float getHumidity()
        {
            return 23;
        }
        public float getPressure()
        {
            return 32;
        }
    }
}
