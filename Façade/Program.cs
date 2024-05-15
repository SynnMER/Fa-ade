using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military;
namespace Façade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit unit = new MilitaryUnit();
            unit.Say();
            Console.ReadKey();
        }
    }
}
