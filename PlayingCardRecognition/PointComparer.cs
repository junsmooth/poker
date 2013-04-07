using System;
using System.Collections.Generic;
using System.Drawing;

namespace PlayingCardRecognition
{
    /// <summary>
    /// Comparer class for sorting points
    /// </summary>
    public class PointComparer : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            return p1.X.CompareTo(p2.X);
        }
    }
}
