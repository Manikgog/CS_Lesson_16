using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_16
{
    internal interface ITemperatureControl
    {
        int MonitorTemperature();
        void CoolDown();

        int GetTempreture();
    }
}
