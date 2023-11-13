using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_16
{
    internal class ComputerSystem
    {
        public event Action<ITemperatureControl> TemperatureExceededThreshold;

        List<ITemperatureControl> ComputerParts;
        Cooler cooler;
        public ComputerSystem(string nameCooler, int tempCooler)
        {
            ComputerParts= new List<ITemperatureControl>();
            cooler = new Cooler(nameCooler, tempCooler);
        }

        public void Add(ITemperatureControl part)
        {
            ComputerParts.Add(part);
        }

        public void Remove(ITemperatureControl part)
        {
            ComputerParts.Remove(part);
        }

        public void TempretureMonitoring()
        {
            int maxTempreture = ComputerParts.Max(p => p.GetTempreture());
            var part = ComputerParts.Where(p => p.GetTempreture() == maxTempreture).Select(p => p).ToList();
            foreach(var item in part)
            {
                Console.WriteLine("Самый горячий компонент -> " + item.ToString());
                break;
            }
            
            for(int i = 0; i < ComputerParts.Count; i++)
            {
                int tempreture = ComputerParts[i].MonitorTemperature();
                if(tempreture > 70) 
                {
                    TemperatureExceededThreshold?.Invoke(ComputerParts[i]);
                    //cooler.CoolDown(ComputerParts[i]);
                }
            }
        }


    }
}
