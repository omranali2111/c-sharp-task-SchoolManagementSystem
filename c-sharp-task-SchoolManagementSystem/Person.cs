using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_task_SchoolManagementSystem
{
    
    internal class Person
    {
       public string Name;
       public int Age;
       public string Address;

        public Person(string Name,int Age,string Address) 
        { 
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
        }

        public void displayPerson() 
        {
            Console.WriteLine($"name is  {Name} Age is {Age} Address is {Address}");
        }
    }
}
