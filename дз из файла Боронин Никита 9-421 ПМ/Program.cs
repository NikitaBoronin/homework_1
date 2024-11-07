using System;
using System.Collections;
using System.Xml.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Globalization;
using System.Data;




namespace SimpleCode_kek
{

    class Program
    {


        static void Main(string[] args)
        {

            // Задача 1 Файл
            Console.WriteLine("1 Задача \n");
            double e = Math.E;
            Console.WriteLine($"{e:F1}");
            Console.WriteLine("\n");

            // 2 задача
            Console.WriteLine("2 Задача \n");
            Console.WriteLine(50);
            Console.WriteLine(10);
            Console.WriteLine("\n");

            // 3 задача (Составить программу вывода на экран «столбиком» четырех любых чисел.)
            Console.WriteLine("3 Задача \n");
            int num_one = int.Parse(Console.ReadLine());
            int num_two = int.Parse(Console.ReadLine());
            int num_three = int.Parse(Console.ReadLine());
            int num_four = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine($"{num_one}\n{num_two}\n{num_three}\n{num_four}");
            Console.WriteLine("\n");

            // 4 задача
            Console.WriteLine("4 Задача \n");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + 10);
            Console.WriteLine("\n");

            // 5 задача
            Console.WriteLine("5 Задача \n");
            Console.WriteLine("Введите сторону квадрата: ");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine(side * 4);
            Console.WriteLine("\n");

            // 6 задача
            Console.WriteLine("6 Задача \n");
            int radius = int.Parse(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;
            double area_circle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Длина окружности: {circumference}");
            Console.WriteLine($"Площадь окружности: {area_circle}");
            Console.WriteLine("\n");

            // 7 задача
            Console.WriteLine("7 Задача \n");
            double degrees = double.Parse(Console.ReadLine());
            double radians = degrees * (Math.PI / 180);
            double y = Math.Cos(radians);
            Console.WriteLine(y);
            Console.WriteLine($"Косинус {degrees} градусов равен {y}");
            Console.WriteLine("\n");

            // 8 задача
            Console.WriteLine("8 Задача \n");
            int base_of_trapezoid_big = 19;
            int base_of_trapezoid_small = 3;
            int height_trapezoid = 6;
            double side_of_a_rectangle = (base_of_trapezoid_big - base_of_trapezoid_small)/2;
            double hypotenuse_of_a_triangle = Math.Sqrt(height_trapezoid * height_trapezoid + side_of_a_rectangle * side_of_a_rectangle);
            double perimetr = 2 * hypotenuse_of_a_triangle + base_of_trapezoid_small + base_of_trapezoid_big;
            Console.WriteLine($"Периметр равен: {perimetr}");
            Console.WriteLine("\n");

            // 9 задача
            Console.WriteLine("9 Задача \n");
            int price_cookie = 20;
            int price_apple = 15;
            int price_sweet = 40;
            Console.WriteLine("Сколько кг печенья взять ");
            int number_of_cookies = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок взять? ");
            int number_of_apple = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг конфет взять? ");
            int number_of_sweet = int.Parse(Console.ReadLine());
            int fihish_price = (price_cookie * number_of_cookies) + (price_apple * number_of_apple) + (price_sweet * number_of_sweet);
            Console.WriteLine($"Итоговая цена данной корзины = {fihish_price}");

            Console.WriteLine("\n");

            // 10 задача
            Console.WriteLine("10 Задача \n");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("     Труд");
            Console.WriteLine("           Май");
            Console.WriteLine("\n");

            // 11 задача
            Console.WriteLine("11 Задача \n");
            Console.WriteLine("Введите 2 числа: ");
            double first_answer = 0;
            double second_answer = 0;

            try
            {
                string strfirst_answer = Console.ReadLine();
                string strsecond_answer = Console.ReadLine();
                strfirst_answer = strfirst_answer.Replace(',', '.');
                strsecond_answer = strsecond_answer.Replace(',', '.');

                first_answer = Double.Parse(strfirst_answer, CultureInfo.InvariantCulture);
                second_answer = Double.Parse(strsecond_answer, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {

                Console.WriteLine("Вы ввели не число!"); ;
            }
            
            double reverse_first = second_answer;
            double reverse_second = first_answer;
            Console.WriteLine(reverse_first);
            Console.WriteLine(reverse_second);
            Console.WriteLine("\n");

            

            
            // 12 задание
            Console.WriteLine("12 Задача \n");
            Console.WriteLine("Выберите фигуру:\nТреугольник - 1\nЧетырехугольник - 2\nКруг - 3");

            // Считывание выбора фигуры
            int answer_user = int.Parse(Console.ReadLine());

            Console.WriteLine("Также выберите, что вы хотите найти:\nПериметр - 1\nПлощадь - 2");

            // Считывание выбора типа вычисления
            int answer_user_for_figure = int.Parse(Console.ReadLine());

            double calculatedValue = 0;

            // Проверка выбора фигуры
            if (answer_user == 1) // Треугольник
            {
                if (answer_user_for_figure == 1) // Периметр треугольника
                {
                    Console.WriteLine("Введите длины сторон треугольника (a, b, c): ");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());

                    calculatedValue = a + b + c;
                    Console.WriteLine($"Периметр треугольника = {calculatedValue}");

                    // Рассчитываем периметры других фигур на основе этого значения
                    Console.WriteLine("\nРассчитаем возможные периметры других фигур:");
                    Console.WriteLine($"Периметр четырехугольника: {calculatedValue}");
                    double radiusFromPerimeter = calculatedValue / (2 * Math.PI);
                    Console.WriteLine($"Длина окружности с приблизительным радиусом {radiusFromPerimeter:F2}");
                }
                else if (answer_user_for_figure == 2) // Площадь треугольника
                {
                    Console.WriteLine("Введите основание и высоту треугольника\nВ таком виде: основание, высота:");
                    double baseLength = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());

                    calculatedValue = 0.5 * baseLength * height;
                    Console.WriteLine($"Площадь треугольника = {calculatedValue}");

                    // Рассчитываем площади других фигур на основе этого значения
                    Console.WriteLine("\nРассчитаем возможные площади других фигур:");
                    double side_treyg = Math.Sqrt(calculatedValue);
                    Console.WriteLine($"Площадь четырехугольника с приблизительной стороной {side:F2}");
                    double radiusFromArea = Math.Sqrt(calculatedValue / Math.PI);
                    Console.WriteLine($"Площадь круга с приблизительным радиусом {radiusFromArea:F2}");
                }
            }
            else if (answer_user == 2) // Четырехугольник
            {
                if (answer_user_for_figure == 1) // Периметр четырехугольника
                {
                    Console.WriteLine("Введите длины сторон четырехугольника (a, b, c, d): ");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());

                    calculatedValue = a + b + c + d;
                    Console.WriteLine($"Периметр четырехугольника = {calculatedValue}");

                    // Рассчитываем периметры других фигур на основе этого значения
                    Console.WriteLine("\nРассчитаем возможные периметры других фигур:");
                    Console.WriteLine($"Периметр треугольника: {calculatedValue}");
                    double radiusFromPerimeter = calculatedValue / (2 * Math.PI);
                    Console.WriteLine($"Длина окружности с приблизительным радиусом {radiusFromPerimeter:F2}");
                }
                else if (answer_user_for_figure == 2) // Площадь четырехугольника
                {
                    Console.WriteLine("Введите длину и ширину четырехугольника:");
                    double length = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    calculatedValue = length * width;
                    Console.WriteLine($"Площадь четырехугольника = {calculatedValue}");

                    // Рассчитываем площади других фигур на основе этого значения
                    Console.WriteLine("\nРассчитаем возможные площади других фигур:");
                    double side_chetryx = Math.Sqrt(calculatedValue);
                    Console.WriteLine($"Площадь треугольника: {calculatedValue}");
                    double radiusFromArea = Math.Sqrt(calculatedValue / Math.PI);
                    Console.WriteLine($"Площадь круга с приблизительным радиусом {radiusFromArea:F2}");
                }
            }
            else if (answer_user == 3) // Круг
            {
                if (answer_user_for_figure == 1) // Периметр (длина окружности)
                {
                    Console.WriteLine("Введите радиус круга:");
                    double radius_krug = double.Parse(Console.ReadLine());

                    calculatedValue = 2 * Math.PI * radius_krug;
                    Console.WriteLine("Длина окружности: " + calculatedValue);

                    // Рассчитываем периметры других фигур на основе этого значения
                    Console.WriteLine("\nРассчитаем возможные периметры других фигур:");
                    Console.WriteLine($"Периметр треугольника: {calculatedValue}");
                    Console.WriteLine($"Периметр четырехугольника: {calculatedValue}");
                }
                else if (answer_user_for_figure == 2) // Площадь круга
                {
                    Console.WriteLine("Введите радиус круга:");
                    double radius_krug = double.Parse(Console.ReadLine());

                    calculatedValue = Math.PI * Math.Pow(radius_krug, 2);
                    Console.WriteLine("Площадь круга: " + calculatedValue);

                    // Рассчитываем площади других фигур на основе этого значения
                    Console.WriteLine("\nРассчитаем возможные площади других фигур:");
                    double side_a = Math.Sqrt(calculatedValue);
                    Console.WriteLine($"Площадь треугольника: {calculatedValue}");
                    Console.WriteLine($"Площадь четырехугольника с приблизительной стороной {side_a:F2}");
                }
            }
            else
            {
                Console.WriteLine("Я не знаю такой фигуры!");
            }

            
            Console.WriteLine("\n");

            // 13 задача
            Console.WriteLine("13 Задача \n");
            int number_user = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {number_user}");
            Console.WriteLine("\n");

            // 14 задача
            Console.WriteLine("14 Задача \n");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            Console.WriteLine("\n");

            // 15 задача
            Console.WriteLine("15 Задача \n");
            Random random_num = new Random();
            for (int i = 0; i < 4; i++)
            {
                int input_num = random_num.Next(10, 121);
                Console.WriteLine(input_num);
            }
            Console.WriteLine("\n");

            // 16 задача
            Console.WriteLine("16 Задача \n");
            Console.WriteLine("Введите коэффиценты квадратного уравнения вида: ax^2 + bx + c = 0");
            Console.WriteLine("Введите а: ");
            int firstkoef = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int secondkoef = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            int thridkoef = int.Parse(Console.ReadLine());

            if (firstkoef == 0)
            {
                Console.WriteLine("Это не квадратное уравнение! ");
            }

            double D = secondkoef * secondkoef - 4 * firstkoef * thridkoef;

            if (D > 0)
            {
                double iks1 = (-secondkoef + Math.Sqrt(D)) / (2 * firstkoef);
                double iks2 = (-secondkoef - Math.Sqrt(D)) / (2 * firstkoef);
                Console.WriteLine($"Получилось 2 корня! x1 = {iks1}, x2 = {iks2}");
            }
            else if (D == 0)
            {
                double iks = -secondkoef/ (2 * firstkoef);
                Console.WriteLine($"Получился 1 корень! x={iks}");
            }
            else if (D < 0)
            {
                Console.WriteLine($"Вещественных корней нет!");
            }
            
            Console.WriteLine("\n");

            // 17 задача
            Console.WriteLine("17 Задача \n");
            int num1 = 4;
            int num2 = 8;
            double arithmetic = (num1 + num2) / 2.0;

            double geometric = Math.Sqrt(num1 * num2);

            Console.WriteLine("\n");

            // 18 задача
            Console.WriteLine("18 Задача \n");
            Console.WriteLine("Введите координаты точек (x1, y1):");
            Console.WriteLine("x1: ");
            double xx1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("y1: ");
            double yy1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точек (x2, y2):");
            Console.WriteLine("x2: ");
            double xx2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("y2: ");
            double yy2 = Double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow((xx2 - xx1), 2) + Math.Pow((yy2 - yy1), 2));
            Console.WriteLine($"Расстояние между точками равно: {distance}");

            Console.WriteLine("\n");

            // 19 Задача
            Console.WriteLine("19 Задача \n");
            int firstperemenna = 3;
            int secondperemenna = 7;
            int thirdperemenna = 8;

            // Схема а)
            secondperemenna = thirdperemenna;
            firstperemenna = secondperemenna;
            thirdperemenna = firstperemenna;

            firstperemenna = 3;
            secondperemenna = 7;
            thirdperemenna = 8;

            // Схема б)
            secondperemenna = firstperemenna;
            thirdperemenna = secondperemenna;
            firstperemenna = thirdperemenna;

            Console.WriteLine("\n");

            // 20 Задача

            Console.WriteLine("20 Задача\n");
            Console.WriteLine("Введите количество прошедших секунд: ");
            double seconds_passed = Double.Parse(Console.ReadLine());

            int hours = (int)seconds_passed / 3600;
            double ost_seconds = seconds_passed % 3600;
            
            int minutes = (int)ost_seconds / 60;
            double ost_minutes = minutes % 60;

            int seconds = (int)ost_minutes;

            Console.WriteLine($"Полных часов с начала суток = {hours}");
            Console.WriteLine($"Полных минут с начала часа = {minutes}");
            Console.WriteLine($"Полных секунд с начала очередной минуты = {seconds}");
            Console.WriteLine("\n");

            // 21 Задача
            Console.WriteLine("21 Задача\n");
            // Ширина 130, а длина 543
            int sides_square = 130; // это стороны квадрата 
            double kol_dlina = 543 / sides_square;
            int kol_shirina = 130 / sides_square;
            Console.WriteLine($"По длине сможем разрезать {kol_dlina} раз\nА по ширине {kol_shirina} раз");

            Console.WriteLine("\n");

            // 22 Задача
            Console.WriteLine("22 Задача\n");
            int three_digit_number = 328;
            int ost_last_right = 328 % 10;
            int new_three_digit_number = 328 / 10;
            new_three_digit_number = (100 * ost_last_right) + new_three_digit_number;
            Console.WriteLine(new_three_digit_number);

            Console.WriteLine("\n");

            // 23 Задача
            Console.WriteLine("23 Задача\n");
            int n = 1322;
            int kol_sot = 1322 / 100;
            int kol_tis = 1322 / 1000;
            Console.WriteLine(kol_sot);
            Console.WriteLine(kol_tis);
            Console.WriteLine("\n");

            // 24 Задача 
            Console.WriteLine("24 Задача\n");
            int numberint = 8392; 
            string numberStr = numberint.ToString(); 

            
            char[] charArray = numberStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);

            // Преобразуем реверсированную строку обратно в число
            int reversedNumber = int.Parse(reversedStr);

            Console.WriteLine("Число, полученное при прочтении цифр справа налево: " + reversedNumber);
            Console.WriteLine("\n");

            // 25 Задача
            Console.WriteLine("25 Задача\n");
            Console.Write("Введите число n (100 ≤ n ≤ 999 и число десятков не равно нулю): ");
            int nu = int.Parse(Console.ReadLine());

            // Проверяем, что n соответствует условиям
            if (nu < 100 || nu > 999 || (nu / 10) % 10 == 0)
        {
                Console.WriteLine("Число n не соответствует условиям задачи.");
                return;
            }

            // Последняя цифра числа n
            int lastDigit = nu % 10;

            // Остальные цифры числа n без последней
            int remainingPart = nu / 10;

            // Восстанавливаем число x
            int x = remainingPart * 10 + lastDigit;

            // Выводим результат
            Console.WriteLine($"Число x = {x}\n");

            // 26 Задание
            Console.WriteLine("26 Задание");
            Console.WriteLine("Введите количество часов: ");
            int chas = int.Parse(Console.ReadLine());
            chas = chas % 12; // У нас всего же 12-ти часовая стрелка как AM и PM
            Console.WriteLine("Введите количество минут: ");
            int minuti = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество секунд: ");
            int secund = int.Parse(Console.ReadLine());
       
            double gradus = (chas * 30) + (minuti * 0.5) + (secund * (0.5 / 60));
            Console.WriteLine(gradus);

            Console.WriteLine("\n");

            // 27 Задача
            Console.WriteLine("27 Задача");


            Console.WriteLine("\n");

            



            // 28 Задача
            Console.WriteLine("28 Задание\n");
            double Num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double Num2 = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double Num3 = double.Parse(Console.ReadLine());

            
            double absNum1 = Math.Abs(Num1);
            double absNum2 = Math.Abs(Num2);
            double absNum3 = Math.Abs(Num3);

            
            double minValue = Num1; // Сначала предполагаем, что первое число минимально

            if (absNum2 < absNum1)
            {
                minValue = Num2; // Второе число меньше по модулю
            }

            if (absNum3 < Math.Abs(minValue))
            {
                minValue = Num3; // Третье число меньше по модулю
            }

           
            Console.WriteLine($"{minValue}");


            Console.WriteLine("\n");

            // 29 Задача
            Console.WriteLine("29 Задача\n");
            int numone = int.Parse(Console.ReadLine());
            int numtwo = int.Parse(Console.ReadLine());
            int numthree = int.Parse(Console.ReadLine());

            int MaxNum = Math.Max(numone, Math.Max(numtwo, numthree));
            int MinNum = Math.Min(numone, Math.Min(numtwo, numthree));
            
            int sum = MaxNum + MinNum;
            Console.WriteLine(sum);
            Console.WriteLine("\n");

            // 30 Задача 
            Console.WriteLine("30 Задача\n");
            
            Console.WriteLine("Введите натуральное число:");
            int nat = int.Parse(Console.ReadLine());

            
            int count = 0;            
            for (int i = 1; i <= Math.Sqrt(nat); i++)
            {
                if (nat % i == 0) 
                {
                    count++; 
                    if (i != nat / i) 
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Количество делителей числа {nat}: {count}");

            // 32 Задача
            Console.WriteLine("32 Задача");
            int pervi_chlen = 3;
            int two_chlen = 6;

            int plus = two_chlen - pervi_chlen;
            Console.WriteLine("Введите номер элемента: ");
            int nomer_elementa = int.Parse(Console.ReadLine());

            int result_num = plus * nomer_elementa;
            Console.WriteLine(result_num);


            Console.WriteLine("\n");

            // 33 Задача
            Console.WriteLine("33 Задача");
            Console.Write("Вы студент? (да/нет): ");
            string isStudent = Console.ReadLine().ToLower();

            Console.Write("Вы пенсионер? (да/нет): ");
            string isPensioner = Console.ReadLine().ToLower();

            Console.Write("Вы трудоустроены? (да/нет): ");
            string isEmployed = Console.ReadLine().ToLower();

            // Логика проверки на получение кредита
            bool student = isStudent == "да";
            bool pensioner = isPensioner == "да";
            bool employed = isEmployed == "да";

            // Проверяем условия
            if ((student && pensioner) || (employed && !student && !pensioner))
            {
                Console.WriteLine("Кредит не дадут.");
            }
            else if ((student && !employed) || (pensioner && !employed))
            {
                Console.WriteLine("Кредит дадут.");
            }
            else
            {
                Console.WriteLine("Кредит не дадут.");
            }
            Console.WriteLine("\n");

            // 34 Задача
            Console.WriteLine("34 Задача\n");
            Console.WriteLine("Как Вас зовут?");
            string Name_user = Console.ReadLine();
            Console.WriteLine(Name_user);
            Console.WriteLine($"Здравствуйте {Name_user}");
            Console.WriteLine("\n");

            // 35 Задание
            Console.WriteLine("35 Задание\n");

            Console.WriteLine("(пользователь) Привет Консоль!\n(консоль) Как Вас зовут?");
            Console.WriteLine("(пользователь) Меня зовут (введите Ваше имя)");
            string name = Console.ReadLine();
            Console.WriteLine($"(консоль) привет, {name}\n(пользователь) Знаешь ли ты что-то о тайной комнате?");
            Console.WriteLine("(консоль) да\n(пользователь) А можешь рассказать мне?\n(консоль) нет");
            Thread.Sleep(5000);
            Console.WriteLine("(консоль) но могу показать");
            Random random = new Random();
            int colorIndex = random.Next(1, 4);
            if (colorIndex == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            else if (colorIndex == 2)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else if (colorIndex == 3)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            
            Console.WriteLine("\n");
            


        }

        


        
       

    }

}