using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Работа с консолью";
            //Console.WindowWidth = 25;
            //Console.WindowHeight = 15;
            //Console.WriteLine("WindowHeight: " + Console.WindowHeight);
            //Console.WriteLine("WindowWidth: " + Console.WindowWidth);
            //Console.WriteLine("Строка 1");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Строка 2");
            //Console.ResetColor();
            //Console.WriteLine("Строка 3");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Строка 4");
            //Console.CursorVisible = false;
            //bool saveCursorVisible = Console.CursorVisible;
            //if(Console.CapsLock == true )
            //{
            //    Console.WriteLine("The Caps Lock key is ON");
            //}
            //else
            //{
            //    Console.WriteLine("The Caps Lock key is OFF");
            //}
            //if (Console.NumberLock == true)
            //{
            //    Console.WriteLine("The Num Lock key is ON");
            //}
            //else
            //{
            //    Console.WriteLine("The Num Lock key is OFF");
            //}



            //Task 1
            //Вариант 2
            //Console.Write("Введите ваше имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Здравствуйте, {name}");
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Title = name;
            //if(Console.CapsLock == true)
            //{
            //    Console.WriteLine("The Caps Lock is ON");
            //}
            //else
            //{
            //    Console.WriteLine("The Caps Lock is OFF");
            //}
            //if(Console.NumberLock == true)
            //{
            //    Console.WriteLine("The Num Lock is ON");
            //}
            //else
            //{
            //    Console.WriteLine("The Num Lock is OFF");
            //}



            //Task 2
            //Вариант 2
            //Console.Title = "Задание № 2 (Шичкин)";
            //Console.WindowHeight = 40;
            //Console.WindowWidth = 40;
            //Console.BufferHeight = 40;
            //Console.BufferWidth = 40;

            //Console.Write("Введите любой символ: ");
            //char symbol = Convert.ToChar(Console.Read());

            //Console.WriteLine($"Сейчас будет нарисован круг из символов {symbol}");
            //Console.ReadKey();
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.Clear();

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Green;

            //int centerWidth = Console.WindowWidth / 2;
            //int centerHeight = Console.WindowHeight / 2;
            //int radius = 15;

            //int height;
            //int width;
            //int amountOfSymbols;

            //for (int i = 0; i <= radius; i++)
            //{
            //    height = centerHeight - radius + i;
            //    //Нахождение ширины круга на определённой строке с помощью формулы для нахождения длины отрезка на координатной плоскости
            //    width = Convert.ToInt32(centerWidth - Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(centerHeight - height, 2)));

            //    amountOfSymbols = (centerWidth - width) * 2;
            //    Console.SetCursorPosition(width, height);

            //    //Запоняет символами верхнюю часть круга
            //    for (int j = 0; j < amountOfSymbols; j++)
            //    {
            //        Console.Write(symbol);
            //    }

            //    height = centerHeight + radius - i;
            //    Console.SetCursorPosition(width, height);

            //    //Заполняет символами нижную часть круга
            //    for (int j = 0; j < amountOfSymbols; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //}



            //Task 3
            //Варинт 2
            //Console.Title = "Задание № 3 (Шичкин)";
            //Console.WindowHeight = 40;
            //Console.WindowWidth = 40;
            //Console.BufferHeight = 40;
            //Console.BufferWidth = 40;

            //string st = "\"Урок\"";


            //for (int i = Console.WindowWidth - 1; i >= 0; i--)
            //{
            //    if (i - st.Length < 0)
            //    {
            //        Console.SetCursorPosition(0, 0);
            //        Console.Write($"{st.Substring(Math.Abs(i - st.Length))} ");
            //        System.Threading.Thread.Sleep(1000);
            //    }
            //    else
            //    {
            //        Console.SetCursorPosition(i - st.Length, 0);
            //        Console.Write($"{st} ");
            //        System.Threading.Thread.Sleep(1000);
            //    }
            //}

            Console.ReadKey();
        }
    }
}
