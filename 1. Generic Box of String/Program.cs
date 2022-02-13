using System;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Items.Add(input);
            }

            //int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //box.Swap(swapIndexes[0], swapIndexes[1]);
            //Console.WriteLine(box);
            double itemToComp = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Compare(itemToComp));
        }
    }
}
