using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{

    internal class MonocolorScreenPhone : ButtonPhone, ISMSDevice
    {
        protected Screen Screen;
        protected Resolution Resolution;
        protected float ScreenSize;
        public ConsoleColor Color;
        public MonocolorScreenPhone(Operator mobileOperator, ConsoleColor color, Screen screen) : base(mobileOperator)
        {
            this.Screen = screen;
            this.Resolution = screen.GetResolution();
            this.Color = color;
            this.ScreenSize = Screen.size;
            this.keyboard.keys.Add('+');
        }
        public void SendSMS(string phone, string message)
        {
            Console.WriteLine("SMSing to {0}", phone);
            this.mobileOperator.SendSMSTo(this.GetPhoneNumber(), phone, message);
        }
        public void ReceiveSMS(string phone, string message)
        {
            Console.BackgroundColor = Color;

            Console.WriteLine("Recieved SMS from {0}", phone);
            Console.WriteLine("-----------------\n {0} \n-----------------", message);
            Console.ResetColor();

        }
    }
}
