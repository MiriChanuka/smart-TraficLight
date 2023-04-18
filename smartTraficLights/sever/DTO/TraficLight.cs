using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //רמזור

    public class TraficLight
    {
        //id אוטומטי
        public int idTraficLight { get; set; }
        //מיקום הרמזור (באנקדטות)
        public DTO.point location { get; set; }
        public bool red { get; set; }
        public bool green { get; set; }
        public bool yellow { get; set; }
        //בנאי מלא
        public TraficLight(int idTraficLight, point location, bool red, bool green, bool yellow)
        {
            this.idTraficLight = idTraficLight;
            this.location = location;
            this.red = red;
            this.green = green;
            this.yellow = yellow;
        }
        //בנאי ריק
        public TraficLight()
        {
        }
        //בנאי מלא בלי ID
        public TraficLight(point location, bool red, bool green, bool yellow)
        {
            this.location = location;
            this.red = red;
            this.green = green;
            this.yellow = yellow;
        }
    }
}
