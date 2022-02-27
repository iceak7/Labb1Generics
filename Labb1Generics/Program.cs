using System;

namespace Labb1Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxCollection collection = new BoxCollection();

            collection.Add(new Box(10, 10, 10));
            collection.Add(new Box(12, 12, 10));
            collection.Add(new Box(14, 11, 10));
            collection.Add(new Box(16, 10, 10));
            collection.Add(new Box(18, 8, 10));

            Display(collection);

            collection.Add(new Box(10, 10, 10));

            Console.WriteLine("\nBox dimensioner: 12, 10, 12");
            if (collection.Remove(new Box(12, 12, 10)))
            {
                Console.WriteLine("Boxen togs bort.");
            }
            else
            {
                Console.WriteLine("Boxen togs inte bort.");
            }

            Display(collection);

            Console.WriteLine("\nBox dimensioner: 18, 10, 8");
            if (collection.Contains(new Box(18, 8, 10))) 
            {
                Console.WriteLine("Kollektionen innehåller boxen.");
            }
            else
            {
                Console.WriteLine("Kollektionen innehåller inte boxen.");
            }

        }

        static void Display(BoxCollection collection)
        {
            Console.WriteLine();
            foreach (var b in collection)
            {
                Console.WriteLine($"H: {b.height} - W: {b.width} - L: {b.length}");
            }
        }
    }
}
