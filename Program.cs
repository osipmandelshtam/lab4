using System;
using System.Collections.Generic;

namespace lab4
{
    class Point
    {
        int x;
        int y;
        char sym;
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
    class Figure
    {
        protected List<Point> pList;
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y =yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine h1 = new HorizontalLine(1, 12, 1, '*');
            h1.Draw();
            HorizontalLine h2 = new HorizontalLine(1, 12, 5, '*');
            h2.Draw();
            VerticalLine v1 = new VerticalLine(1, 5, 1, '*');
            v1.Draw();
            VerticalLine v2 = new VerticalLine(1, 5, 12, '*');
            v2.Draw();
            Console.WriteLine("/n");
            Console.WriteLine("Нажмите любую клавишу для закрытия программы...");
            Console.ReadKey();
        }
    }
}
