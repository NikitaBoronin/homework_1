using System.Globalization;

namespace Tumakov_laba_Boronin_421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.1 Упражнение Тумаков Лаба
            Console.WriteLine("Как Вас зовут?");
            string name_user = Console.ReadLine();
            Console.WriteLine($"Здравствуй {name_user}!");

            // 2.2 Упражнение Тумаков Лаба
            Console.WriteLine("Введите 2 числа: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Делить на 0 нельзя :( ");
            }
            else 
            {
                int delenie = num1/ num2;
                Console.WriteLine(delenie);
            }

            // ДЗ 2.1 
            Console.WriteLine("Введите букву: ");
            char bukva = Console.ReadKey().KeyChar;
            bukva = char.ToUpper(bukva);


            if ( bukva == 'Я')
            {
                Console.WriteLine("Следующая буква: А");
            }
            else
            {
                char nextbukva = (char)(bukva + 1);
                Console.WriteLine($"\nСледующая буква: {nextbukva}");
            }

            // ДЗ 2.2

            Console.WriteLine("Введите коэффиценты: \n a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            int c = int.Parse(Console.ReadLine());

            int D = (b * b) - (4 * a * c);
            
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D))/ (2 * a);
                double x2 = (-b - Math.Sqrt(D))/ (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b/ (2 * a);
                Console.WriteLine($"Получился 1 корень! x={x}");
            }
            else if (D < 0)
            {
                Console.WriteLine($"Вещественных корней нет!");
            }

            
        }
    }
}
