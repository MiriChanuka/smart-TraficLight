using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;

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
        public void constructionOfARoadSection()
        {
            

            // חלק1   אורך 232 מטר רוחב 6.5
            Block block1 = new Block(1,232,6.5,2,0,0,1);
           TraficLight traficLight1 = new TraficLight(1,new point(31.79581,35.21974),true, false, false);


            //חלק 2  אורך 635 מטר רוחב 7 מטר
            Block block2 = new Block(2,635,7,2,0,0,2);
            TraficLight traficLight2 = new TraficLight(2, new point(31.795706, 35.219996), true, false, false);

            // חלק 3   אורך 228 מטר רוחב 6.5 

            Block block3 = new Block(3,228,6.5,2,0,0,3);
            TraficLight traficLight3 = new TraficLight(3, new point(31.795675, 35.219900), true, false, false);
        
            //חלק 4  אורך 212 מטר רוחב 7

            Block block4 = new Block(4, 212, 7, 2, 0, 0, 4);
            TraficLight traficLight4= new TraficLight(4, new point(31.795672, 35.219620), true, false, false);

            //הגרלת מספר המכוניות שיעמדו על הכביש
            Car car = new Car();
            Random random = new Random();
            int numOfCars=4;
            //צריך לצייר אותם ולהכניס אותם לDB 
            for(int i = 0; i < numOfCars; i++)
            {
                //מגריל את נתוני המכוניות
                car.carLength=2;
                // car.idCar =;
                car.carWidth =(float) 1.5;
                car.speed=80;
             
            }
        
        }
    }
}
