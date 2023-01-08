using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11._2.Extension
{
    public static class Extention
    {
        internal static List<Student> FindStudent (this List<Student> list, StudentPredicateDelegate searchDelegate)
        {
            return list.FindAll(searchDelegate.Invoke);
        }
    }
}
