using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    internal class Program
    {
        delegate void CarRepairDelegate(Car car);

        static void Main(string[] args)
        {

            CarRepairDelegate FullReapirDelegate = new CarRepairDelegate(AutoService.DoCollapseConvergence);
            FullReapirDelegate += AutoService.DoPainted;
            FullReapirDelegate += AutoService.DoOilChanged;
            FullReapirDelegate += AutoService.DoFullTechReview;
            FullReapirDelegate += AutoService.DoWheelReplace;
            FullReapirDelegate += AutoService.DoBodyRepair;


            Car car = new Car();
            FullReapirDelegate(car);
            Console.WriteLine(car);

            Console.ReadLine();
        }
    }

}
