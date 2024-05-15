using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    public class MilitaryUnit
    {
        public MilitaryUnit()
        {
            _part = new PartCommander();
            _platoon = new PlatoonСommander();
        }

        public void Say()
        {
            _part.Say();
            _platoon.Say();
        }

        private PartCommander _part;
        private PlatoonСommander _platoon;
    }

    class PlatoonСommander
    {
        public void Say()
        {
            Console.WriteLine("Командир взвода Пупкин по Вашему приказанию прибыл!");
        }
    }

    class PartCommander
    {
        public void Say()
        {
            Console.WriteLine("Командир отделения Дрищук по Вашему приказанию прибыл!");
        }
    }

}
