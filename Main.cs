using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catedra1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            ScottPlot.Plot myPlot = new();

            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };
            myPlot.Add.Scatter(dataX, dataY);

            myPlot.SavePng("demo.png", 400, 300);
        }
    }
}
