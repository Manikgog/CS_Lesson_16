using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_Lesson_16
{
    internal class GraphicsCard : ITemperatureControl
    {
        public string Name { get; set; }
        public int Temperature { get; set; }
        public GraphicsCard(string name, int temperature)
        {
            Name = name;
            Temperature = temperature;
        }

        public int GetTempreture()
        {
            return Temperature;
        }

        public int MonitorTemperature()
        {
            Random rnd = new Random(25);
            return Temperature = rnd.Next(30) + 50;
        }

        public void CoolDown()
        {
            Console.WriteLine("Запущен процесс охлаждения " + Name);
            while(true)
            {
                Console.WriteLine("Температура " + Name + " " + Temperature + " град. Цельсия.");
                Temperature--;
                if(Temperature <= 50) 
                {
                    break;
                }
                Thread.Sleep(500);
            }
        }

        public override string ToString()
        {
            return Name + " " + Temperature + " C.";
        }

    }
}
