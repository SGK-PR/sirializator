using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirializator
{
    public  class Student
    {
        public  string Name { get; set; }
        public int Age { get; set; }

        public  Group Group { get; set; }

        public  Student ( string name , int age )
        {
            #region проверки
            if (String.IsNullOrWhiteSpace ( name))
            {
                throw new ArgumentNullException( "Имя не может быть  пустым " +nameof(name));
            }

            if (age < 0 || age>120)
            {
                throw new ArgumentOutOfRangeException("Недопустимое  значение " + nameof(age));
            }
            #endregion

            Name = name; Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
