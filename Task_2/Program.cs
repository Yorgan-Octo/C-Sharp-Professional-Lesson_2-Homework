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
            //це так трохи погратися 
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
                        new List<int>{
                                        117,
                                        717,

                                     }
                    },


                    {
                        "Gala",
                        new List<int>{
                                        311,
                                        717,

                                     }
                    },


                    {
                        "Sara",
                        new List<int>{
                                        717,
                                        867,

                                     }
                    },

                    {
                        "Ron",
                        new List<int>{
                                        123,
                                        311,

                                     }
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
            Console.WriteLine();

            var res2 =
                from x in infopolis["Ivan"]
                join y in hashtable
                on x equals y.Key
                select y.Value;

            foreach (var item1 in res2)
            {
                Console.WriteLine("   " + item1);
            }



            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in infopolis)
            {
                var res3 =
                from x in item.Value
                join y in hashtable
                on x equals y.Key
                select y.Value;

                foreach (var item1 in res3)
                {
                    if (item1 == "Попутова техніка")
                    {
                        Console.WriteLine(item.Key);
                    }
                }

            }



            //Створіть колекцію, до якої можна додавати покупців.
            //та категорію придбаної ними продукції.
            //З колекції можна отримувати категорії товарів,
            //які купив покупець або за категорією визначити покупців.






            Console.ReadKey();
        }
    }
}