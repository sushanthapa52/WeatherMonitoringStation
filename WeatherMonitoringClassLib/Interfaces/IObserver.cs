using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// Observer interface.
    /// </summary>
    public interface IObserver
    {
        void Update(double temperature, double humidity, double pressure);
    }
}
