using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4150PS2
{
    class Ceiling
    {
        
        static void Main(string[] args)
        {
            Ceiling c = new Ceiling();
            Console.WriteLine(c.UniqueTrees());
        }


        public string UniqueTrees()
        {
            string line = "";
            char[] whitespace = { ' ', '\t' };
            string[] numbers;
            int count = 0;
            while((line = Console.ReadLine()) != null)
            {
                if (count > 0)
                {
                    numbers = line.Split(whitespace);
                }
                count++;
            }
            
            return "";
        }
    }
}
