using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figures
    {
        Direction direction;
        public Snake (Point tail, int lenght, Direction _direction)  // tail - положение хвоста; lenght - длинна змейки; direction - направление движения
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i =0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }

        }

        internal void Move()
        {
            Point Tail = pList.First();
            pList.Remove(Tail);
            Point head = GetNextPoint();
            pList.Add(head);

            Tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandlKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else
            if (key == ConsoleKey.RightArrow)
               direction = Direction.RIGHT;
            else
            if (key == ConsoleKey.UpArrow)
               direction = Direction.UP;
            else
            if (key == ConsoleKey.DownArrow)
               direction = Direction.DOWN;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHet(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

    }
}
