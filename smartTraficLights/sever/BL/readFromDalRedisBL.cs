using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class readFromDalRedisBL
    {
        public static double receivingLength(int carIndex)
        {
            return DAL.RedisClientNew.lengthOfCar(carIndex); ;
        }
        public static double receivingWidth(int carIndex)
        {
            return DAL.RedisClientNew.widthOfCar(carIndex); ;
        }
        //הוספת מכונית עם האורך והרוחב שלה
        public static void addCar(Car c,int weight)
        {
             Tuple<double, double> LandW= DAL.RedisClientNew.GetTransportByWeight(weight);
            c.carLength = LandW.Item1;
            c.carWidth = LandW.Item2;
            DAL.RedisClientNew.addCarToBD(c);
        }
        public static void addBlcko(Block b)
        {
            DAL.RedisClientNew.addBlockToBD(b);
        }
        public static void addTraficLight(TraficLight t)
        {
            DAL.RedisClientNew.addTrafficLightsToBD(t);
        }
    }
}
