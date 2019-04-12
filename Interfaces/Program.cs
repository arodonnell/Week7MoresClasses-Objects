using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> staff = new List<Employee>();

            Employee e1 = new Employee() { Name = "Tom", ID = 5, Salary = 10000m };
            Employee e2 = new Employee() { Name = "Mary", ID = 1, Salary = 20000m };
            Employee e3 = new Employee() { Name = "Sue", ID = 4, Salary = 30000m };
            Employee e4 = new Employee() { Name = "Alan", ID = 3, Salary = 40000m };
            Employee e5 = new Employee() { Name = "Jess", ID = 2, Salary = 50000m };

            staff.Add(e1);
            staff.Add(e2);
            staff.Add(e3);
            staff.Add(e4);
            staff.Add(e5);


            staff.Sort();

            foreach (var item in staff)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

    }
}
