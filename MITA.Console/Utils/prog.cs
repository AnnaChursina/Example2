using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class prog
    {
        static void Main(string[] args)
        {
            // ссылка на библиотеку:
            var employee = new Emp(30);
            
           
            Console.WriteLine(employee.Salary);
            employee.Profession = "Manager";
            employee.Profession = "Pechnic";

            employee.Name = "N1";
            employee.Name = "Bad";
            
            Console.WriteLine(employee.IsGift);
            employee.SetAge(24);
           // Console.WriteLine(employee.Age); //неправильный код, путает программиста. через get не стоит делать
            Console.ReadKey();
        }
    
    }
}
