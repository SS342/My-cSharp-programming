using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1

{
    class Programming
    {
        static void Main(string[] args)
        {
            Student sl = new Student();
            sl.Name = "Jenny";

            Student s2 = new Student();
            s2.Name = sl.Name;

            // "Изменение " имени объекта sl не изменяет сам
            // объект, поскольку ToUpper () возвращает новую
            // строку, не влияя на оригинал

            s2.Name = sl.Name.ToUpper();
            Console.WriteLine(" sl - " + sl.Name + ", s2 - " + s2.Name);

            // Ожидаем подтверждения пользователя
            Console.WriteLine("Haжмитe <Enter> для " + "завершения программы ... ");

            Console.Read();

        }
    }

    class Student
    {
        public String Name;
    }
}
