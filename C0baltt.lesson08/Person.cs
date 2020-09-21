using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C0baltt.lesson08
{
    public class Person//создаем открытый класс Person (человк)
    {
        public string Firstname;//добавляем открытое значение Firstname (имя)
        public string Lastname;//добавляем открытое значение Lastname (фамилия)

        protected decimal Money;//добавляем защищенное значение Money (деньги)
    }
}
/*class Person
    {
        public //открытый
        internal //открытый в пределах проекта
        protected//защищенный(будет доступно у наследника)
        private //закрытый(не будет доступно у наследника, т. е. есть только у данного класса)
    }*/