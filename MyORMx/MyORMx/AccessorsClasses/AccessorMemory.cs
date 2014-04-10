using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyORMx
{
    public class AccessorMemory:IAccessor
    {
        Storage stor = new Storage();

        public bool AddPerson(Person p)
        {
            stor.L.Add(p);
            return true;
        }

        public bool RemovePerson(string name)
        {
            for (int i = 0; i < stor.L.Count; i++)
            {
                if (stor.L[i].Name == name)
                {
                    stor.L.RemoveAt(i);
                    i--;
                }
            }

            return true;
        }

        public bool InsertPerson(int index, Person p)
        {
            stor.L.Insert(index, p);
            return true;
        }

        public List<Person> GetAllPerson()
        {
            return stor.L;
        }

        public bool Clear()
        {
            stor.L.Clear();
            return true;
        }

        public Person GetPersonByIndex(int i)
        {
            return stor.L[i];
        }

        public int Count()
        {
            return stor.L.Count();
        }
    }
}
