using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    internal interface IPhoneProperties
    {
        int CamerasCount { get; }
        int YearOfCreation { get; }
        float Price { get; }
        ConsoleColor[] AvailableColors { get; }
    }
}
