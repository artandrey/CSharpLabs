using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    abstract class Phone
    {
        protected Operator mobileOperator;
        protected readonly List<string> PhoneNumbers = new List<string>();
        public Phone(Operator mobileOperator) {
            this.mobileOperator = mobileOperator;
            this.PhoneNumbers.Add(mobileOperator.RegisterPhone(this));
        }

        public string GetPhoneNumber()
        {
            return this.PhoneNumbers[0];
        }

        public string GetPhoneNumber(int SIM)
        {
            return this.PhoneNumbers[SIM];
        }
    }
}
