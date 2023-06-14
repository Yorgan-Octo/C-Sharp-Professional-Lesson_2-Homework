using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    internal class Program
    {
        static void Main()
        {
            //це так трохи погратися и для практи в LINQ
            SortedList<int, string> hashtable = new SortedList<int, string>()
                {
                    {117, "Побутова хімія" },
                    {311, "Товари для тварин" },
                    {123, "Спорт та відпочинок" },
                    {717, "Попутова техніка" },
                    {867, "Одях та взуття" },

                };

            Dictionary<string, List<int>> infopolis = new Dictionary<string, List<int>>()
                {

                    {
                        "Ivan",
                        new List<int>{ 117, 717}
                    },


                    {
                        "Gala",
                        new List<int>{ 311, 717, 117, 123 }
                    },


                    {
                        "Sara",
                        new List<int>{717}
                    },

                    {
                        "Ron",
                        new List<int>{123, 311, 867 }
                    },

                };

            foreach (var item in infopolis)
            {
                Console.WriteLine(item.Key);

                //це так трохи погратися и трохи для практики
                var res =
                    from x in item.Value
                    join y in hashtable
                    on x equals y.Key
                    select y.Value;

                foreach (var item1 in res)
                {
                    Console.WriteLine("   " + item1);
                }

            }

            Console.WriteLine(new String('-', 50));

            string nameUser = "Ivan";


            var res2 =
                from x in infopolis[nameUser]
                join y in hashtable
                on x equals y.Key
                select y.Value;


            Console.WriteLine(nameUser + " купив товари з категорій:");
            foreach (var item1 in res2)
            {
                Console.WriteLine(" -" + item1);
            }

            Console.WriteLine(new String('-',50));


            string categori = "Попутова техніка";
            Console.WriteLine($"Товари з категорії \"{categori}\" купили");

            foreach (var item in infopolis)
            {
                var res3 =
                from x in item.Value
                join y in hashtable
                on x equals y.Key
                select y.Value;

                foreach (var item1 in res3)
                {
                    if (item1 == categori)
                    {
                        Console.WriteLine(" -" + item.Key);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}