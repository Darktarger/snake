using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        public static object FoodCreadtor { get; private set; }
        public static object FoodCreator { get; private set; }

        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            int i = 1;
            while(i != 0)
            {
                Console.WriteLine("   Главное меню");
                Console.WriteLine("  1 - Новая игра");
                Console.WriteLine("  2 - Изменить сложность");
                Console.WriteLine("  3 - Выбрать уровень");
                Console.WriteLine("  0 - Выход");
                Console.Write("  Ваш выбор: ");
                string str=Console.ReadLine();
                i = Convert.ToInt32(str);

                if (i == 1)
                {
                    Console.Clear();
                    // Подпись
                    Console.SetCursorPosition(64, 24);
                    Console.Write("Snake by Targer");

                    //Отрисовка рамки
                    
                    HorizontalLine UpLine = new HorizontalLine(1, 78, 0, '═');
                    UpLine.Drow();
                    HorizontalLine DownLine = new HorizontalLine(1, 78, 23, '═');
                    DownLine.Drow();
                    VerticalLine LeftLine = new VerticalLine(0, 1, 23, '║');
                    LeftLine.Drow();
                    VerticalLine RightLine = new VerticalLine(79, 1, 23, '║');
                    RightLine.Drow();
                    Console.SetCursorPosition(79, 0);
                    Console.Write("╗");
                    Console.SetCursorPosition(0, 0);
                    Console.Write("╔");
                    Console.SetCursorPosition(79, 23);
                    Console.Write("╝");
                    Console.SetCursorPosition(0, 23);
                    Console.Write("╚");
                    


                    Point p = new Point(1, 1, '█');
                    Snake snake = new Snake(p, 4, Direction.RIGHT);
                    snake.Drow();

                    FoodCreator foodCreator = new FoodCreator(30, 30, '#');
                    Point food = foodCreator.CreateFood();
                    food.Draw();

                    while (true)
                    {
                        if (snake.Eat(food))
                        {
                            food = foodCreator.CreateFood();
                            food.Draw();
                        }
                        else
                        {
                            snake.Move();
                            Thread.Sleep(150);
                        }
                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey();
                            snake.HandlKey(key.Key);
                        }

                    }
                }

                if (i == 2)
                {
                    Console.Clear();
                }

                if(i==3)
                {
                    Console.Clear();
                }


            }
        }
    }
}
