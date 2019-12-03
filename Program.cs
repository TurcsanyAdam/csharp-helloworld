using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 1)
            {
                foreach (string name in args)
                {
                    if (name != "Program.cs")
                    {
                        Console.WriteLine("Hello " + name + " !");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Hello World !");
            }

            Console.ReadLine();
            
        }
    }
}
