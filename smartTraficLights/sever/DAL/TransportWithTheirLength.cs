using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class TransportWithTheirLength
    {
        public int kind { get; set; }
        public int Weight { get; set; }
        public int length { get; set; }
        public int width { get; set; }

        public TransportWithTheirLength()
        {
        }

        public TransportWithTheirLength(int kind, int weight, int length, int width)
        {
            this.kind = kind;
            Weight = weight;
            this.length = length;
            this.width = width;
        }
    }
}
