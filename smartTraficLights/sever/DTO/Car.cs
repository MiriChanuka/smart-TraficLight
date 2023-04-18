using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //רכב
   public class Car
    {
        //id אוטומטי
        public int idCar { get; set; }
        //מהירות המכונית
        public int speed { get; set; }
        //אורך המכונית
        public float carLength { get; set; }
        public float carWidth { get; set; }
        //בנאי מלא
        public Car(int idCar, int speed, float carLength,float carWidth)
        {
            this.idCar = idCar;
            this.speed = speed;
            this.carLength = carLength;
            this.carWidth = carWidth;
        }

        //בנאי ריק

        public Car()
        {
        }

        //בנאי מלא בלי ID
        public Car(int speed, float carLength,float carWidth)
        {
            this.speed = speed;
            this.carLength = carLength;
            this.carWidth = carWidth;
        }


    }
}
