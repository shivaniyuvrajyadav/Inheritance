using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class Employee
    { 
        public int Experience { get; set; }

        public void Calculatesalary()
        {
            int salary = Experience * 30000;
            Console.WriteLine("salary : {0}", salary);
        }

    }

    public class permanentemployee : Employee
    {
        static void Main (string[] args)
        {
            permanentemployee p = new permanentemployee();
            p.Experience = 5;
            p.Calculatesalary();

            Console.ReadLine();
        }
    }

}

/* what is inheritance ? when to use inheritance ?
 *  inheritance is a parent - child relationship between two classes , where child
 * class will automatically get the properties and methods of the parent .  
 * 
 *  inheritance is good for reusability and abstraction of code. 
 * 
 */