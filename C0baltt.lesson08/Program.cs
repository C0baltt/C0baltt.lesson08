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
            Person person = new Person();//создаем объект person класса Person
            person.Firstname = "Вадим";//записываем в свойство Firstname (имя) значение "Вадим"
            person.Lastname = "Шванов";//записываем в свойство Lastname (фамилия) значение "Шванов"

            Person p2 = new Person();//создаем объект p2 класса Person
            p2.Firstname = "Иван";//записываем в свойство Firstname (имя) значение "Иван"
            p2.Lastname = "Иванов";//записываем в свойство Lastname (фамилия) значение "Иванов"

            var d = new Doctor();//создаем объект d класса Doctor
            d.Firstname = "Роман";//записываем в свойство Firstname (имя) значение "Роман"
            d.Specialization = "333";//записываем в свойство 333 (специализация) значение "Роман"

            Console.WriteLine(d.Firstname);
            Console.WriteLine(d.Specialization);

            Person p = d;

            Console.WriteLine(p);
        }
    }
}
