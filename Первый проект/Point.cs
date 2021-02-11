using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Первый_проект
{
    class Point
    {
        public int ord1;
        public int ord2;
        public char symb;

        public Point(int x, int y, char symbol)
        {
            ord1 = x;
            ord2 = y;
            symb = symbol;
        }

        public Point(Point p)
        {
            ord1 = p.ord1;
            ord2 = p.ord2;
            symb = p.symb;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                ord1 = ord1 + offset;
            }
            else if (direction == Direction.LEFT)
            {
                ord1 = ord1 - offset;
            }
            else if (direction == Direction.UP)
            {
                ord2 = ord2 - offset;
            }
            else if (direction == Direction.DOWN)
            {
                ord2 = ord2 + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.ord1 == this.ord1 && p.ord2 == this.ord2;
        }

        public void Clear()
        {
            symb = ' ';
            drawing_paint();
        }

        public void drawing_paint()
        {
            if(ord1 <= 78 && ord2 == 0 || ord1 <= 78 && ord2 == 24)
            {
                if (ord2 == 0)
                {
                    Console.SetCursorPosition(ord1, ord2);
                    Console.WriteLine('+');
                    ord2 = ord2 + 1;
                }
                else if (ord2 == 24)
                {
                    Console.SetCursorPosition(ord1, ord2);
                    Console.WriteLine('+');
                    ord2 = ord2 - 1;
                }
            }
            else if(ord2 <= 24 && ord1 == 0 || ord2 <= 24 && ord1 == 78)
            {
                if (ord1 == 0)
                {
                    Console.SetCursorPosition(ord1, ord2);
                    Console.WriteLine('+');
                    ord1 = ord1 + 1;
                }
                else if (ord1 == 78)
                {
                    Console.SetCursorPosition(ord1, ord2);
                    Console.WriteLine('+');
                    ord1 = ord1 - 1;
                }
            }
            Console.SetCursorPosition(ord1, ord2);
            if(symb != '+')
                Console.WriteLine(symb);
        }

        public override string ToString()
        {
            return ord1 + ", " + ord2 + ", " + symb;
        }
    }
}