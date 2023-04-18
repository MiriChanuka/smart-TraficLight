using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            BL.RedisClient redis = new BL.RedisClient();
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
    }
}
