using System;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personName = Console.ReadLine().Split();
            string city = String.Empty;
            for (int i = 3; i < personName.Length; i++)
            {
                city += personName[i] + " ";
            }
            MyTuple<string, string, string> personFullName = new MyTuple<string, string, string>((personName[0] + " " + personName[1]), personName[2], city);

            string[] beerLtrs = Console.ReadLine().Split();
            string person = String.Empty;
            if (beerLtrs[2] == "drunk")
            {
                person = "True";
            }
            else
            {
                person = "False";
            }
            MyTuple<string, int, string> beerLiters = new MyTuple<string, int, string>(beerLtrs[0], int.Parse(beerLtrs[1]), person);

            string[] currinput = Console.ReadLine().Split();
            MyTuple<string, double, string> integers = new MyTuple<string, double, string>(currinput[0], double.Parse(currinput[1]), currinput[2]);

            Console.WriteLine(personFullName);
            Console.WriteLine(beerLiters);
            Console.WriteLine(integers);
        }
    }
}