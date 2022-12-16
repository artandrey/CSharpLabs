using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class ButtonPhone : DiscPhone, ICallsDeviceReceiver
    {
        public ButtonPhone(Operator mobileOperator) : base(mobileOperator)
        {
            this.keyboard.keys.Append('#');
            this.keyboard.keys.Append('*');
        }


        public new void ReceiveCall(string phone)
        {
            Console.WriteLine("Recieved call from {0}", phone);
        }
    }
}
