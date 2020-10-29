using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tblCarsTableAdapter.Fill(this.honestRalphsUsedCarsDataSet.tblCars);
        }

        //counting the total number of cars in the table
        private void button1_Click(object sender, EventArgs e)
        {
            var cars =
             from c in this.honestRalphsUsedCarsDataSet.tblCars
             select c;
            foreach (var c in cars)
                button1.Text = "no. of cars for sale: " + Convert.ToString(cars.Count());

        }

        //displaying the max price of all the cars in the table
        private void button2_Click(object sender, EventArgs e)
        {
            var cars =
             from c in this.honestRalphsUsedCarsDataSet.tblCars
             select c;

            string maxValue = cars.AsEnumerable().Max(row => row["Price"]).ToString();

            foreach (var c in cars)
                button2.Text = "Max Price: $" + Convert.ToString(maxValue);

            
        }

        //displaying the min price of all the cars in the list
        private void button3_Click(object sender, EventArgs e)
        {
            var cars =
             from c in this.honestRalphsUsedCarsDataSet.tblCars
             select c;

            string minValue = cars.AsEnumerable().Min(row => row["Price"]).ToString();

            foreach (var c in cars)
                button3.Text = "Min Price: $" + Convert.ToString(minValue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
