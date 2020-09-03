using System;

namespace Ex9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "유민", Age = "19" };
            Console.WriteLine("이름:{0}, 나이:{1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = "1", Imaginary = "2" };
            Console.WriteLine("Real:{0},Imaginary:{1}", complex.Real, complex.Imaginary);
        }
    }
}
