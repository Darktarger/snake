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
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // Подпись
            Console.SetCursorPosition(64, 24);
            Console.Write("Snake by Targer");

            //Отрисовка рамки
            HorizontalLine UpLine = new HorizontalLine(1,78,0,'═');
            UpLine.Drow();
            HorizontalLine DownLine = new HorizontalLine(1, 78, 23, '═');
            DownLine.Drow();
            VerticalLine LeftLine = new VerticalLine(0, 1, 23, '║');
            LeftLine.Drow();
            VerticalLine RightLine= new VerticalLine(79, 1, 23, '║');
            RightLine.Drow();
            Console.SetCursorPosition(79, 0);
            Console.Write("╗");
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            Console.SetCursorPosition(79, 23);
            Console.Write("╝");
            Console.SetCursorPosition(0, 23);
            Console.Write("╚");



            Point p = new Point(1,1,'*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);


            Console.ReadLine();
        }
    }
}
