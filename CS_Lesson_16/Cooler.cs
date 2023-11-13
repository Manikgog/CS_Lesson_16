using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_Lesson_16
{
    internal class Cooler
    {
        public string Name { get; set; }
        public int Temperature { get; set; }

        public Cooler(string name, int temperature)
        {
            Name = name;
            Temperature = temperature;
        }

        public int MonitorTemperature()
        {
            return Temperature;
        }

        public void CoolDown(ITemperatureControl part)
        {
            part.CoolDown();
        }
    }
}
