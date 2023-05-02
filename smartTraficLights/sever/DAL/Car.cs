using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Car
    {        //id מספר הרישוי
        public string idCar { get; set; }
        //מהירות המכונית
        public int speed { get; set; }
        //אורך המכונית
        public double carLength { get; set; }
        public double carWidth { get; set; }
        public Point locationOfCar { get; set; }
        //בנאי מלא

        public Car(string idCar, int speed, double carLength, double carWidth, Point locationOfCar)
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
        public Car(int speed, double carLength, double carWidth, Point locationOfCar)
        {
            this.speed = speed;
            this.carLength = carLength;
            this.carWidth = carWidth;
            this.locationOfCar = locationOfCar;
        }

        public Car(string idCar, int speed, Point locationOfCar)
        {
            this.idCar = idCar;
            this.speed = speed;
            this.locationOfCar = locationOfCar;
        }
    }
}
