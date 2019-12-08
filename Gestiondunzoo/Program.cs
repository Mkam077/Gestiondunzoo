using System;

namespace Gestiondunzoo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Animal A1 = new Animal("Alex", "Lion", 500);
            Animal A2 = new Animal("Gloria", "Hypo", 900);

            Console.WriteLine(A1.ToString());

            Zoo zoodeNewYork = new Zoo("zoo de New York", 20);

            zoodeNewYork.ajouter(A1);
            zoodeNewYork.ajouter(A2);

            Console.WriteLine(zoodeNewYork.ToString());



        }
    }

}
