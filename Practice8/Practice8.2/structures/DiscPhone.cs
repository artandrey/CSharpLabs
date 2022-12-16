using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class DiscPhone : Phone, ICallsDevice
    {

        protected PhoneKeyboard keyboard { get; }
        public DiscPhone(Operator mobileOperator): base(mobileOperator)
        {
            char[] keys = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            this.keyboard = new PhoneKeyboard(keys);
        }

        public void Call(string phone)
        {
            Console.WriteLine("Calling to {0}", phone);
            this.mobileOperator.CallTo(this.GetPhoneNumber(), phone);
        }
        public void ReceiveCall(string phone)
        {
            Console.WriteLine("Recieved call from ...");
        }

    }
}
