using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class ColorScreenPhone : MonocolorScreenPhone, IMMSDevice
    {
        public ColorScreenPhone(Operator mobileOperator, ConsoleColor color, Screen screen) : base(mobileOperator, color, screen)
        {
            this.PhoneNumbers.Add(mobileOperator.RegisterPhone(this));
        }

        public void Call(string phone, int SIM)
        {
            Console.WriteLine("Calling to {0}", phone);
            this.mobileOperator.CallTo(this.GetPhoneNumber(SIM), phone);
        }

        public void SendSMS(string phone, string message, int SIM)
        {
            Console.WriteLine("SMSing to {0}", phone);
            this.mobileOperator.SendSMSTo(this.GetPhoneNumber(SIM), phone, message);
        }
        public void SendMMS(string phone, Image message)
        {
            Console.WriteLine("SMSing to {0}", phone);
            this.mobileOperator.SendMMSTo(this.GetPhoneNumber(), phone, message);
        }
        public void SendMMS(string phone, Image message, int SIM)
        {
            Console.WriteLine("MMSing to {0}", phone);
            this.mobileOperator.SendMMSTo(this.GetPhoneNumber(SIM), phone, message);
        }
        public void ReceiveMMS(string phone, Image message)
        {

            Console.WriteLine("Recieved MMS from {0}", phone);
            message.ShowImage();

        }
    }
}
