using Practice8._2.structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator mobileOperator = new Operator();
            
            User<DiscPhone> user1 = new User<DiscPhone>(new DiscPhone(mobileOperator));
            User<DiscPhone> user2 = new User<DiscPhone>(new DiscPhone(mobileOperator));

            User<ButtonPhone> user3 = new User<ButtonPhone>(new ButtonPhone(mobileOperator));
            User<ButtonPhone> user4 = new User<ButtonPhone>(new ButtonPhone(mobileOperator));

            User<MonocolorScreenPhone> user5 = new User<MonocolorScreenPhone>(new MonocolorScreenPhone(mobileOperator, ConsoleColor.Blue, new Screen(100, 200, 4, 2, false)));

            User<MonocolorScreenPhone> user6 = new User<MonocolorScreenPhone>(new MonocolorScreenPhone(mobileOperator, ConsoleColor.DarkBlue, new Screen(100, 200, 4, 2, false)));
            User<ColorScreenPhone> user7 = new User<ColorScreenPhone>(new ColorScreenPhone(mobileOperator, ConsoleColor.DarkBlue, new Screen(100, 200, 4, 2, false)));
            User<ColorScreenPhone> user8 = new User<ColorScreenPhone>(new ColorScreenPhone(mobileOperator, ConsoleColor.DarkBlue, new Screen(100, 200, 4, 2, false)));
            User<Smartphone> user9 = new User<Smartphone>(new Smartphone(mobileOperator, ConsoleColor.DarkBlue, new Screen(100, 200, 4, 2, false), 10, 2));




            user1.GetPhone().Call(user2.GetPhone().GetPhoneNumber());
            Console.WriteLine("---------------------------------");
            user3.GetPhone().Call(user4.GetPhone().GetPhoneNumber());
            Console.WriteLine("---------------------------------");
            user6.GetPhone().Call(user4.GetPhone().GetPhoneNumber());
            Console.WriteLine("---------------------------------");
            user6.GetPhone().SendSMS(user1.GetPhone().GetPhoneNumber(), "My message");
            Console.WriteLine("---------------------------------");

            user9.GetPhone().SendMMS(user7.GetPhone().GetPhoneNumber(), user9.GetPhone().TakePhotoUsingCamera(1), 1);




            Console.ReadLine();
        }
    }
}
