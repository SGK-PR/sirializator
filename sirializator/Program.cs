using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace sirializator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            List<Student> students = new List<Student>();

            for (  int  i = 0; i <10; i ++ )
            {
                groups.Add(new Group("Группа " + i, i));
            }

            for ( int i = 0; i< 300; i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 6), i % 100)
                {
                    Group = groups[i % 9]
                };
                students.Add(student);
            }

            var binFormatter = new BinaryFormatter();
            using (var fille = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fille, groups);
            }

            using (var fille = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(fille) as List<Group>;
                if ( newGroups !=null )
                {
                    foreach (  var group  in  newGroups )
                    {
                        Console.WriteLine(group);
                    }
                }
            }

            Console.Read();
        }
    }
}
