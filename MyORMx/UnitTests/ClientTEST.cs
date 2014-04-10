using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyORMx;

namespace UnitTests
{
    [TestFixture]
    class ClientTEST
    {
        [Test]
        public void ClientConstructorTEST() 
        {
            public Person Homer = new Person() { Name = "Homer", Age = 47 };
            public Person Marge = new Person() { Name = "Marge", Age = 40 };
            public Person Bard = new Person() { Name = "Bard", Age = 9 };
            public Person Lisa = new Person() { Name = "Lisa", Age = 8 };

            Client c = new Client();
            
        }
    }
}
