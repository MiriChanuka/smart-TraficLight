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
        //id מספר הרישוי
        public int idCar { get; set; }
        //מהירות המכונית
        public int speed { get; set; }
        //אורך המכונית
        public double carLength { get; set; }
        public double carWidth { get; set; }
        public point locationOfCar { get; set; }
        //בנאי מלא
        public Car(int idCar, int speed, double carLength,double carWidth,point locationOfCar)
        {
            this.idCar = idCar;
            this.speed = speed;
            this.carLength = carLength;
            this.carWidth = carWidth;
            this.locationOfCar = locationOfCar;
        }

        //בנאי ריק

        public Car()
        {
        }

        //בנאי מלא בלי ID
        public Car(int speed, double carLength,double carWidth, point locationOfCar)
        {
            this.speed = speed;
            this.carLength = carLength;
            this.carWidth = carWidth;
            this.locationOfCar = locationOfCar;
        }


    }
}
