using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject1
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<string> list = new CustomList<string>();
            list.Add("Messi");
            list.Add("Ronaldo");
            list.Add("Beckham");
            list.Add("Kaka");
            list.Add("Ibrahimovic");
            Console.ReadKey();

      //      list.Remove("Ronaldo");
       //     for (int index = 0; index < list.count; index++)
        //    {
        //      Console.WriteLine(list[index]);
        //    }
         //     Console.ReadKey();
        }
    }
}
