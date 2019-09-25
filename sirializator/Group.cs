using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirializator
{
    public class Group
    {
        private Random random = new Random(DateTime.Now.Millisecond);

        public  string Name { get; set; }
        public int  Number { get; set; }

        public Group ()
        {
            Number = random.Next(1, 10);
            Name = "группа " + random;
        }

        public Group(string name , int number  )
        {
             if (String.IsNullOrWhiteSpace(name))
             {
                throw new ArgumentNullException(nameof(name));
             }

            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }

    }
}
