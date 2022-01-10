using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    public class Person
    {
        public string Name { get; set; }
        public Person()
        {
            Name = "Empty";
        }
        public Person(string _name)
        {
            Name = _name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
