using System;

namespace UnremovableDebugArgsProjUserRepro
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            foreach (var a in args)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
