using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // publisher
    public interface Subject
    {
        void addObserver(Observer obs);
        void removeObserver(Observer obs);
        void updateObservers();
    }

    // subscriber
    public interface Observer
    {
        void update(double temp, double humidity, double pressure);
    }

    public class WeatherDataObject : Subject
    {
        private List<Observer> observers = new List<Observer>();

        double temp, humidty, pressure;

        public void addObserver(Observer obs)
        {
            this.observers.Add(obs);
        }

        public void removeObserver(Observer obs)
        {
            this.observers.Remove(obs);
        }

        public void updateObservers()
        {
            foreach (Observer obs in this.observers)
            {
                obs.update(this.temp, this.humidty, this.pressure);
            }
        }

        public void setMeasurements(double temp, double humidty, double pressure)
        {
            this.temp = temp;
            this.humidty = humidty;
            this.pressure = pressure;
            updateObservers();
        }
    }

    // display elements
    public interface Display
    {
        void display();
    }

    public class CurrentConditionsDisplay : Display, Observer
    {
        private Subject weatherData;

        double temp, humidty, pressure;

        public CurrentConditionsDisplay(Subject wdo)
        {
            this.weatherData = wdo;
            wdo.addObserver(this);
        }

        public void update(double temp, double humidty, double pressure)
        {
            this.temp = temp;
            this.humidty = humidty;
            this.pressure = pressure;
            display();
        }

        public void display()
        {
            System.Console.WriteLine("Current conditions {0} {1} {2}",
                this.temp, this.humidty, this.pressure);
        }
    }
}
