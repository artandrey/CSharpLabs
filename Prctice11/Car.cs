using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{

    internal class Car
    {

        public bool CollapseConvergence { get; set; } = false;
        public bool Painted { get; set; } = false;
        public bool OilChanged { get; set; } = false;
        public bool FullTechReview { get; set; } = false;
        public bool WheelReplace { get; set; } = false;
        public bool BodyRepair { get; set; } = false;

        public override string ToString()
        {
            return $"CollapseConvergence —— {CollapseConvergence}\n" +
                   $"Painted —— {Painted}\n" +
                   $"OilChanged —— {OilChanged}\n" +
                   $"FullTechReview —— {FullTechReview}\n" +
                   $"WheelReplace —— {WheelReplace}\n" +
                   $"BodyRepair —— {BodyRepair}\n";
        }
    }
}
