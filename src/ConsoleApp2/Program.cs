using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public class Program
    {
        public void Main(string[] args)
        {
            string inputValue = Console.ReadLine();
            int splitInterval = 2;
            int outPutValue = (int)Math.Ceiling(inputValue.Length / (decimal)splitInterval);
            Console.WriteLine(outPutValue.ToString());
            Console.ReadLine();
        }
    }
}
