using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Emp
    {
        private string _profession;
        private int? _age; // переменная =null по умолчанию
        private readonly DateTime _hireDate= DateTime.Now;
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="salary"></param>


        public Emp(int salary) // конструктор
            ///<salary>
            /// Name Employee
            /// </salary>
            {
            Salary=salary;
            _hireDate = DateTime.Now;
            
            }
        // если есть публ св-во, надо задавать значения через него.
        public int Salary { get; private set; }

        public DateTime HireDate
        {
            get;
        }

        public void SuperMetod()

        {
            Salary = 10000;
        }

        /* private set запрещает изменение зарплаты;
        как задать з/п?  1) инверсия зависимости через конструктор ex.--> Employee(). на констр указ-т круглые скобки:
         2) инверсия: зависимость объектов (наслед, инт-сы), входные параметры
        приватные поля: _ххх; локальна переменная: ххх. 
        при констр с параметром компилятор откажется делать констр с параметром 
        */

        public bool IsGift => _age < 18;// подходит, если есть только 1 выр: откр скобки от ; до ;
        // не делать публ полей, не надо дават ьдоступ к этому.
  
           // {
             //   return _age<18;
            //}
        // профессия. создадим приватный field
 
           // public string Name 
        public string Profession
        {
            get { return _profession; }
            set
            {
                if (string.IsNullOrEmpty(_profession))
                {
                    _profession = value;
                }
                else
                { throw new Exception("read documentation"); }
            }
        }
        // public int Age { private get; set; }
        public void SetAge(int age)
        {
            _age = age;
        }
    }

}
