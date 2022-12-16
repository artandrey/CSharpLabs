using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class Operator
    {
        private Dictionary<string, Phone> abonents = new Dictionary<string, Phone>();
        private MonocolorScreenPhone operatorPhone;

        public Operator() {
            this.operatorPhone = new MonocolorScreenPhone(this, ConsoleColor.DarkMagenta, new Screen(100, 200, 4, 2, false));
        } 

        protected string CreatePhoneNumberFromCount(int count)
        {
            string phone = "+380";
            for (int i = 0; i < 9; i++)
            {
                phone += count.ToString();
            }
            return phone;
        }
        public string RegisterPhone(Phone phone)
        {
            string phoneNumber = CreatePhoneNumberFromCount(abonents.Count);

            this.AddPhoneToAbonents(phone, phoneNumber);


            return phoneNumber;
        }

        private void AddPhoneToAbonents(Phone phone, string receiverPhone)
        {
            abonents.Add(receiverPhone, phone);
        }

        private void NotifySender(string callerPhone, string message)
        {
            message = "MESSAGE FROM OPERAOR:\n" + message;
            this.operatorPhone.SendSMS(callerPhone, message);
        }

        public void CallTo(string callerPhone, string receiverPhone)
        {
            Phone caller = abonents[callerPhone];
            if (caller == null)
            {
                Console.WriteLine("Phone number is not registered {0}", callerPhone);
                return;
            }
            if (abonents.ContainsKey(receiverPhone)) {
                if (abonents[receiverPhone] is ICallsDeviceReceiver)
                {
                    ((ICallsDeviceReceiver)abonents[receiverPhone]).ReceiveCall(caller.GetPhoneNumber());
                    return;
                }

                NotifySender(callerPhone, "Reciever doesnt support this function");
                return;

            }
            NotifySender(callerPhone, "Abonent not found");
            
        }
        public void SendSMSTo(string callerPhone, string receiverPhone, string message)
        {
            Phone caller = abonents[callerPhone];
            if (caller == null)
            {
                Console.WriteLine("Phone number is not registered {0}", callerPhone);
                return;
            }
            if (abonents.ContainsKey(receiverPhone))
            {
                if (abonents[receiverPhone] is ISMSDeviceReceiver)
                {
                    ((ISMSDeviceReceiver)abonents[receiverPhone]).ReceiveSMS(caller.GetPhoneNumber(), message);
                    return;
                }
                NotifySender(callerPhone, "Reciever doesnt support this function");
                return;

            }
            NotifySender(callerPhone, "Abonent not found");

        }
        public void SendMMSTo(string callerPhone, string receiverPhone, Image message)
        {
            Phone caller = abonents[callerPhone];
            if (caller == null)
            {
                Console.WriteLine("Phone number is not registered {0}", callerPhone);
                return;
            }
            if (abonents.ContainsKey(receiverPhone))
            {
                if (abonents[receiverPhone] is IMMSDeviceReceiver)
                {
                    ((IMMSDeviceReceiver)abonents[receiverPhone]).ReceiveMMS(caller.GetPhoneNumber(), message);
                    return;
                }
                NotifySender(callerPhone, "Reciever doesnt support this function");
                return;

            }
            NotifySender(callerPhone, "Abonent not found");

        }
    }
}
