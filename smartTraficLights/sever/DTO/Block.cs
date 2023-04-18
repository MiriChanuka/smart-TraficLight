using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //קטע דרך
   public  class Block
    {
        //id אוטומטי
        public int idBlock { get; set; }
        //אורך הקטע 
        public double length { get; set; }
        // רוחב הקטע 
        public double width { get; set; }
        //מספר הנתיבים
        public int numOfLane { get; set; }
        //התנועה  באחוזים?ץ
        public int movement { get; set; }

        public int idTraficLight { get; set; }

        //מספר  הרכבים
        public int numOfCars { get; set; } 
        //בנאי מלא
        public Block(int idBlock, double length, double width, int numOfLane, int movement, int numOfCars,int idTraficLight)
        {
            this.idBlock = idBlock;
            this.length = length;
            this.width = width;
            this.numOfLane = numOfLane;
            this.movement = movement;
            this.numOfCars = numOfCars;
            this.idTraficLight = idTraficLight;
        }
        //בנאי ריק
        public Block()
        {
        }
        //בנאי מלא בלי ID
        public Block( double length, double width, int numOfLane, int movement, int numOfCars,int idTraficLight)
        {
          
            this.length = length;
            this.width = width;
            this.numOfLane = numOfLane;
            this.movement = movement;
            this.numOfCars = numOfCars;
            this.idTraficLight = idTraficLight;
        }

    }
}
