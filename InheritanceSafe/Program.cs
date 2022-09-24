using System;

namespace InheritanceSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            SafeOwner owner = new SafeOwner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();

            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey(true);
        }
    }
}
