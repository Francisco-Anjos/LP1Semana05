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

                var builder = new StringBuilder();
                builder.Append(uppercase[0]);

                for (int i = 1; i < uppercase.Length; i++);
                {
                    builder.Append("-");
                    builder.Append(uppercase[i]);

                }

                Console.Writeline(builder.ToString());
            }
        }
    }
}
