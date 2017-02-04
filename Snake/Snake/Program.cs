using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(3,5,'#');
            p2.Draw();

            List<int> NumList = new List<int>(); /* Объявнление списка с целыми числами */
            NumList.Add(0);
            NumList.Add(1);
            NumList.Add(2);
            int x = NumList[0]; /* Индекс в листе начинается с 0. Х = первому элементу листа */
            
            foreach(int i in NumList)    /* Передача всех значений в NumList в переменную i */
            {
                Console.WriteLine(i);
            }
            NumList.RemoveAt(0); /* Удаление из списка элемента с индексом 0 */

            List<Point> pList = new List<Point>(); /* Список, содержащий точки */
            pList.Add(p1); /* Помещаем первую точку в лист */
            pList.Add(p2);



            Console.ReadLine();
        }
    }
}
