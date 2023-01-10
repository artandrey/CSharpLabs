using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    internal class AutoService
    {
        public static void DoCollapseConvergence(Car car) => car.CollapseConvergence = true;
        public static void DoPainted(Car car) => car.Painted = true;
        public static void DoOilChanged(Car car) => car.OilChanged = true;
        public static void DoFullTechReview(Car car) => car.FullTechReview = true;
        public static void DoWheelReplace(Car car) => car.WheelReplace = true;
        public static void DoBodyRepair(Car car) => car.BodyRepair = true;
    }
}
