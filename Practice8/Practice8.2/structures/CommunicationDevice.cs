using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{

    interface ICallsDeviceReceiver
    {
        void ReceiveCall(string phone);

    }
    interface ICallsDevice : ICallsDeviceReceiver
    {
        void Call(string phone);
    }

    interface ISMSDeviceReceiver
    {
        void ReceiveSMS(string phone, string message);

    }
    interface ISMSDevice : ISMSDeviceReceiver
    {
        void SendSMS(string phone, string message);
    }

    interface IMMSDeviceReceiver
    {
        void ReceiveMMS(string phone, Image message);

    }
    interface IMMSDevice : IMMSDeviceReceiver
    {
        void SendMMS(string phone, Image message);
    }

}
