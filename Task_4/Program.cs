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
                { "Магнус Карлсен", 2847 },
                { "Фабиано Каруана", 2820 },
                { "Левон Аронян", 2797 },
                { "Вишванатан Ананд", 2753 },
                { "Шхрияр Мамедьяров", 2750 }
             };

            foreach (DictionaryEntry entry in elemenBase)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.ReadKey();

        }
    }

    public static class Extenthis
    {
        public static bool KeyEquals<T, R>(this OrderedDictionary left, OrderedDictionary right)
        {
           return left.Values == right.Values;
        }
    }

}
