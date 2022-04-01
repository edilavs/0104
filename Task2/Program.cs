using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sagirdin adi:");
            string name = Console.ReadLine();
            Console.WriteLine("Sagirdin soyadi:");
            string surname = Console.ReadLine();
            Console.WriteLine("Sagirdin yasi:");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Sagirdin IQ imtahan neticesi:");
            double IQRank = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sagirdin Dil imtahan neticesi:");
            double languageRank = Convert.ToDouble(Console.ReadLine());
            Student student = new Student(name,surname,age,IQRank,languageRank);
            student.ExamResult();
        }
    }
}
