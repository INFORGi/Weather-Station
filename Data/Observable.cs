using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Observable : WeatherData
    {
        bool changed = false;

        void setChanged() { changed = true; }
        void addObserver() { }
        void deleteObserver() { }
        void notifyObserver(object args) {
            if (changed)
            { 
                WeatherData weatherData = new WeatherData();
                foreach (var observer in observers)
                {
                    
                }
            }
        }

        void notifyObservers() {
            notifyObserver(null);
        }
        void setObserver() { }
    }
}
