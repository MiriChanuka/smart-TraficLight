using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using DAL;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //API.Controllers.LicenseNumberForTheWeightOfTheCarController.aAsync();

            //string b = BL.blockBL.GetCarProductCode2("1003952");
            //API.Controllers.LicenseNumberForTheWeightOfTheCarController.GetCarProduct(1000231);
            DAL.RedisClientNew.fffff();
            //DAL.RedisClientNew.addTheListOfMeansOfTransportWithTheirLength();
            DAL.Car c = new DAL.Car("100010", 50, new DAL.Point(31.2, 31.2));
            int a = API.Controllers.LicenseNumberForTheWeightOfTheCarController.FunctionsForFindingVehicleWeightAsync(c.idCar).Result;
            BL.readFromDalRedisBL.addCar(c,a);
            //string a =  API.Controllers.LicenseNumberForTheWeightOfTheCarController.GetCarProductCodeTRY("1003952");
            //System.Threading.Tasks.Task<string>  a = BL.blockBL.GetCarProductCodeAsync("1003952");
            //string c = a + "ggggggggg";
            // DAL.RedisClientNew.fffff();
            // //DAL.RedisClientNew redis = new DAL.RedisClientNew();
            // //redis.AddData();
            // DAL.RedisClientNew.addPoprtiesCar();
            // //DAL.RoadGraph roadGraph =new DAL.RoadGraph();
            // //roadGraph.addGraph();

            //API.Controllers.allBlockController.constructionOfARoadSection();

            //BL.RedisConnectorHelperProgram a = new BL.RedisConnectorHelperProgram();
            MyFunction();
        }

        private void MyFunction()
        {
            MessageBox.Show("Hello, world!");
        }

        private void MyFunction1()
        {
            MessageBox.Show("hgjh, world!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
