using System;
using System.Text;
namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Writeline("NO ARGUMENTS");
            
            }
            else
            {
                string[] uppercase = new string[args.Length];
                
                for (int i = 0; i < args.Length; i++);
                {
                    uppercase[i] = args[i].ToUpper();
                }
                Array.Sort(uppercase, StringComparer.OrdinalIgnoreCase);
                
            }
        }
    }
}
