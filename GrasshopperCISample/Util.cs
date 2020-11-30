using System;
using Rhino.Geometry;

namespace GrasshopperCISample
{
    public class Util
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double LineLength(Line line)
        {
            Point3d from = line.From;
            Point3d to = line.To;
            
            double fromX = from.X;
            double fromY = from.Y;
            double fromZ = from.Z;
            double toX = to.X;
            double toY = to.Y;
            double toZ = to.Z;

            double lenX = Math.Abs(fromX - toX);
            double lenY = Math.Abs(fromY - toY);
            double lenZ = Math.Abs(fromZ - toZ);

            double length = Math.Sqrt(Math.Pow(lenX, 2) + Math.Pow(lenY, 2) + Math.Pow(lenZ, 2));

            return length;
        }

        public static Line[] DivideLine(Line line, int nDiv)
        {
            var divLine = new Line[nDiv];

            Point3d from = line.From;
            Point3d to = line.To;

            double fromX = from.X;
            double fromY = from.Y;
            double fromZ = from.Z;
            double toX = to.X;
            double toY = to.Y;
            double toZ = to.Z;

            double lenX = Math.Abs(fromX - toX);
            double lenY = Math.Abs(fromY - toY);
            double lenZ = Math.Abs(fromZ - toZ);

            double length = Math.Sqrt(Math.Pow(lenX, 2) + Math.Pow(lenY, 2) + Math.Pow(lenZ, 2));

            double dLength = length / nDiv;
            Vector3d vec = line.Direction;

            Point3d ptStart = from;
            for (var i = 0; i < nDiv; i++)
            {
                divLine[i] = new Line(ptStart, vec, dLength);
                ptStart = divLine[i].To;
            }

            return divLine;
        }
    }
}