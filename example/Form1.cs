using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoImplementedProperties_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            Car Computer = new Car();
            Computer.Name = "Hasee";

            msg = msg + "电脑品牌:" + Computer.Name + "\n";
            msg = msg + "电脑主人:" + "庄亚欧";
            MessageBox.Show(msg,"电脑信息"); 
        }
    }

    class Car
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { this.name = value ; }
        }

        public int Horsepower
        {
            get;//可读
            set;//可写
        }

        public double Torque
        {
            private get;//不可读
            set;//可写
        }
    }
}
