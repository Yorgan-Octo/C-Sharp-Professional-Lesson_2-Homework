using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {

        public class Comparison : IEqualityComparer
        {

            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

            public int GetHashCode(object obj)
            {
                return obj.ToString().ToLowerInvariant().GetHashCode();
            }

            public new bool Equals(object x, object y)
            {
                return comparer.Compare(x, y) == 0;
            }
        }

        static void Main(string[] args)
        {

            OrderedDictionary elemenBase = new OrderedDictionary(new Comparison())
            {
                { "Магнус Карлсен", 1222},
                { "Фабиано Каруана", "2847" },
                { "Левон Аронян", 1222 },
                { "Вишванатан Ананд", "2847" },
                { "Шхрияр Мамедьяров", 2847 }
             };

            foreach (DictionaryEntry entry in elemenBase)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
            Console.WriteLine();

            Console.WriteLine(elemenBase[0].MyEqualsExten(1222));
            Console.WriteLine(elemenBase[0].MyEqualsExten(elemenBase[2]));
            Console.WriteLine(elemenBase[0].MyEqualsExten("2847"));
            Console.WriteLine(elemenBase[1].MyEqualsExten("2847"));
            Console.WriteLine(elemenBase[2].MyEqualsExten(elemenBase[4]));
            Console.WriteLine(elemenBase[3].MyEqualsExten(elemenBase[4]));

            Console.ReadKey();

        }
    }

    public static class Extenthis
    {
        public static bool MyEqualsExten<T>(this T left, T right)
        {
            //тут просто якась логика
            if (left is int)
                return left.Equals(right);
            else
                return left.GetHashCode() == right.GetHashCode();



            //або просто так
            //return left.GetHashCode() == right.GetHashCode();

            //або так
            //return left.Equals(right);
        }
    }

}
