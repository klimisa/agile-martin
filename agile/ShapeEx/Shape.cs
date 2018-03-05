using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace agile.ShapeEx
{
//    public abstract class Shape: IShape
//    {
//        public abstract void Draw();
//    }

    public interface IShape: IComparable
    {
        void Draw();
    }

    public class Circle: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Circle!");
        }

        public int CompareTo(object obj)
        {
            if (obj is Square)
            {
                return -1;
            }
            return 0;
        }
    }

    public class Square: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Square!");
        }

        public int CompareTo(object obj)
        {
            if (obj is Circle)
            {
                return -1;
            }
            return 0;
        }
    }

    public class Gui
    {
        public static void DrawAllShapes(ArrayList shapes)
        {
            shapes.Sort();
            foreach (IShape shape in shapes)
                shape.Draw();
        }
    }
}