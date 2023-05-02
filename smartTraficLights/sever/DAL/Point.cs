using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Point
    {//id אוטומטי
        public int idPoint { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        //בנאי מלא
        public Point(int idPoint, double x, double y)
        {
            this.idPoint = idPoint;
            this.x = x;
            this.y = y;
        }
        //בנאי ריק
        public Point()
        {
        }
        //בנאי מלא בלי ID
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
