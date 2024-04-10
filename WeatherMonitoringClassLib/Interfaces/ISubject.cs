using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_monitoring_station;

namespace Weather_monitoring_station
{
    /// <summary>
    /// Subject interface for Observer pattern.
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
