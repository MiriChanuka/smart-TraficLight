using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DAL;

namespace API.Controllers
{//חלק1 מנקודה 31.79581,35.21974 ועד 31.797623-35.217924
 //  האורך
    //חלק2 מנקודה 31.797099,35.222402 ועד 31.795706-35.219996
    // הפחתה בין ה Y  האורך:0.002406
    //חלק3 מנקודה 31.795675,35.219900 ועד 31.793746-35.221673
    //חלק4 מנקודה 31.795672,35.219620 ועד 31.794754-35.217913


    public class allBlockController : ApiController
    {
        //פונקציה שבונה חלק קטן מדרך
        //כאן זה מחושב לא מדויק מכון שהנקודות הם מהתחלה והסוף וכך מחושב האורך  בעתיד נתממשק למפות ישראל וה יהיה מדויק יותר
        //public static void constructionOfARoadSection()
        //{
            

        //    // חלק1   אורך 232 מטר רוחב 6.5
        //    Block block1 = new Block(1,232,6.5,2,0,0,1,new Point(31.79581, 35.21974));
        //   TraficLight traficLight1 = new TraficLight(1,new Point(31.79581,35.21974),true, false, false,10);
        //    BL.readFromDalRedisBL.addBlcko(block1);
        //    BL.readFromDalRedisBL.addTraficLight(traficLight1);
        //    creatCars(block1);
        //    //חלק 2  אורך 635 מטר רוחב 7 מטר
        //    Block block2 = new Block(2,635,7,2,0,0,2, new Point(31.795706, 35.219996));
        //    TraficLight traficLight2 = new TraficLight(2, new Point(31.795706, 35.219996), true, false, false,10);
        //    BL.readFromDalRedisBL.addBlcko(block2);
        //    BL.readFromDalRedisBL.addTraficLight(traficLight2);
        //    creatCars(block2);
        //    // חלק 3   אורך 228 מטר רוחב 6.5 

        //    Block block3 = new Block(3,228,6.5,2,0,0,3, new Point(31.795675, 35.219900));
        //    TraficLight traficLight3 = new TraficLight(3, new Point(31.795675, 35.219900), true, false, false,10);
        //    BL.readFromDalRedisBL.addBlcko(block3);
        //    BL.readFromDalRedisBL.addTraficLight(traficLight3);
        //    creatCars(block3);
        //    //חלק 4  אורך 212 מטר רוחב 7

        //    Block block4 = new Block(4, 212, 7, 2, 0, 0, 4, new Point(31.795672, 35.219620));
        //    TraficLight traficLight4= new TraficLight(4, new Point(31.795672, 35.219620), true, false, false,10);
        //    BL.readFromDalRedisBL.addBlcko(block4);
        //    BL.readFromDalRedisBL.addTraficLight(traficLight4);
        //    creatCars(block4);



        //}
        //פונקציה שיוצרת רכבים באופן רנדומלי 
        //public static bool creatCars(Block b)
        //{
        //    Random random = new Random();
        //    //הגרלת מספר המכוניות שיעמדו על הכביש
        //    int ran = random.Next(0, (int)b.length/10);
        //    Car car = new Car();
        //    //  חישוב מקסימום כמות הרכבים באופן הגיוני לקטע כביש מסוים 
          
        //    //מספר סוגי הרכבים שהוכנסו לdb
        //    int numOfCarInDB = 7;
           
           
        //    int carIndex;
        //    double lengthBlock = 0;
        //    //double lengthBlock
        //    //צריך לצייר אותם ולהכניס אותם לDB 
        //    //*b.numOfLane
        //    for (int i=0;i<ran&& lengthBlock + 5 < b.length;i++)
        //    {
        //        //מגריל את נתוני המכוניות
        //        carIndex = random.Next(0, numOfCarInDB);
        //        car.idCar = carIndex;
        //        car.carLength = BL.readFromDalRedisBL.receivingLength(carIndex);
        //        car.carWidth = BL.readFromDalRedisBL.receivingWidth(carIndex);
        //        car.speed = 80;
        //        car.locationOfCar= new Point(  b.locationOfBlock.x,b.locationOfBlock.y + lengthBlock);

        //        //להוסיף את המכונית לDB 

        //        //BL.readFromDalRedisBL.addCar(car);
        //        //להוסיףה לאורך של הכביש כדי לבדוק שלא חרג מגבולות קטע הדרך 
        //        lengthBlock = lengthBlock + (car.carLength + (car.speed *(2/60)));
        //    }

        //    return true;
        //}
    }
}
