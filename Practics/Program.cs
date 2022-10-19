using System;

namespace Practics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNumberCount());
        }

        public (string Name, int quality) GetNumberCount() {
            return (Name: "Apple", quality: 15);
        }
    }
}
