using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agile.DoorTimer;
using agile.ShapeEx;

namespace agile
{
    class Program
    {
        static void Main(string[] args)
        {
//            var shapes = new ArrayList { new Square(), new Circle(), new Circle(), new Square(), new Circle() };
//            Gui.DrawAllShapes(shapes);

            var root = new Tree.TreeMap<string, string>();
            root.Add("0","A");
            root.Add("1","B");
            root.Add("2", "C");
            root.Add("3", "D");

            var node = root.Get("3");

            Console.WriteLine(node);
            Console.ReadKey();
        }
    }
}
