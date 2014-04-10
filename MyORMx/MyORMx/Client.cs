using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyORMx
{
    public class Client
    {
        public bool AddPerson(Person p,IAccessor accessor) 
        {
            accessor.AddPerson(p);
            return true;
        }
    }
}
