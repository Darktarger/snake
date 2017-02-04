using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figures
    {
        public Snake (Point tail, int lenght, Direction direction)  // tail - положение хвоста; lenght - длинна змейки; direction - направление движения
        {
            pList = new List<Point>();
            for (int i =0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }

        }
    }
}
