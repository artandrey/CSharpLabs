using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class User<T> where T : Phone
    {
        private T phone;
        public User(T phone)
        {
            this.phone = phone;
        }

        public T GetPhone()
        {
            return this.phone;
        }
    }
}
