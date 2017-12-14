using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Целостность_данных.Прямоугольник
{
    class Top
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Top(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class Rectangle
    {
        public Top Top1 { get; set; }
        public Top Top2 { get; set; }
        public Top Top3 { get; set; }
        public Top Top4 { get; set; }
        public static double Segment(Top top1, Top top2)
        {
            return Math.Sqrt((top1.X - top2.X) * (top1.X - top2.X) + (top1.Y - top2.Y) * (top1.Y - top2.Y));
        }
        public static bool IsNinetyDegrees(Top top1, Top top2, Top top3)
        {
            if ((Math.Sqrt(Segment(top1, top2) * Segment(top1, top2) + Segment(top2, top3) * Segment(top2, top3)) == Segment(top1, top3)) ||
                (Math.Sqrt(Segment(top1, top2) * Segment(top1, top2) + Segment(top1, top3) * Segment(top1, top3)) == Segment(top2, top3)) ||
                (Math.Sqrt(Segment(top1, top3) * Segment(top1, top3) + Segment(top2, top3) * Segment(top2, top3)) == Segment(top1, top2)))
                return true;
            else
                return false;
        }
        public static bool IsTop3 (Top top1, Top top2, Top top3)
        {
            if (IsNinetyDegrees(top1, top2, top3))
                return true;
            else
                return false;
        }
        public static bool IsTop4(Top top1, Top top2, Top top4)
        {
            if (IsNinetyDegrees(top1, top2, top4))
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();

            if ((Rectangle.IsTop3(rectangle.Top1, rectangle.Top2, rectangle.Top3))&&
                    (Rectangle.IsTop4(rectangle.Top1, rectangle.Top2, rectangle.Top4)))
            {
                Console.WriteLine(Rectangle.Segment(rectangle.Top1, rectangle.Top2));
                Console.WriteLine(Rectangle.Segment(rectangle.Top2, rectangle.Top3));
            }
        }
    }
}
