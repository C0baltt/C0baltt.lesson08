using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0baltt.lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Int32 j = new Int32();

            Person person = new Person();
            person.Firstname = "Вадим";
            person.Lastname = "Шванов";

            Person p2 = new Person();
            p2.Firstname = "Иван";
            p2.Lastname = "Иванов";

            var d = new Doctor();
            d.Firstname = "Роман";
            d.Specialization = "333";

            Console.WriteLine(d.Firstname);
            Console.WriteLine(d.Specialization);

            Person p = d;

            Console.WriteLine(p.)

            Doctor dd =p (Doctor)p;
            
        }
    }
}
