using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerSystem computerSystem = new ComputerSystem("CoolerFan", 20);
            computerSystem.Add(new Processor("Athlon", 20));
            computerSystem.Add(new GraphicsCard("GForce", 20));
            Cooler cooler = new Cooler("CoolerFan", 20);
            computerSystem.TemperatureExceededThreshold += (o) =>  cooler.CoolDown(o);

            do
            {
                computerSystem.TempretureMonitoring();
            }while(true);

        }
    }
}
