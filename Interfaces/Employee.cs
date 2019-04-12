using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Employee : IComparable
    {
        public int ID { get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            Employee that = obj as Employee;

            //if (this.Name > that.Name)
            //    return 1;
            //else if (this.Name < that.Name)
            //    return -1;
            //else
            //    return 0;

            return this.Name.CompareTo(that.Name);

        }

        public override string ToString()
        {
            return string.Format($"{ID} {Salary} {Name}");
        }
    }
}
