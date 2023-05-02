using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class TraficLight
    { //id אוטומטי
        public int idTraficLight { get; set; }
        //מיקום הרמזור (באנקדטות)
        public DAL.Point location { get; set; }
        public bool red { get; set; }
        public bool green { get; set; }
        public bool yellow { get; set; }
        public int AFewSecondsToActivate { get; set; }
        //בנאי מלא
        public TraficLight(int idTraficLight, Point location, bool red, bool green, bool yellow,int AFewSecondsToActivate)
        {
            this.idTraficLight = idTraficLight;
            this.location = location;
            this.red = red;
            this.green = green;
            this.yellow = yellow;
            this.AFewSecondsToActivate = AFewSecondsToActivate;
        }
        //בנאי ריק
        public TraficLight()
        {
        }
        //בנאי מלא בלי ID
        public TraficLight(Point location, bool red, bool green, bool yellow, int AFewSecondsToActivate)
        {
            this.location = location;
            this.red = red;
            this.green = green;
            this.yellow = yellow;
            this.AFewSecondsToActivate = AFewSecondsToActivate;
        }
    }
}
