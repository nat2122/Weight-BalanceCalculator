using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_B_Calculator
{
    public partial class WithinEnvelope_Cessna172 : Form
    {
        private Cessna172Calulations cessna172Calulations;

        // Constructor accepting Cessna172Calulations
        public WithinEnvelope_Cessna172(Cessna172Calulations calculations)
        {
            InitializeComponent();
            cessna172Calulations = calculations;  // Save the calculations object for later use
            this.Load += WithinEnvelope_Cessna172_Load;
        }

        private void WithinEnvelope_Cessna172_Load(object sender, EventArgs e)
        {
            if (formsPlot1 == null)
            {
                MessageBox.Show("formsPlot1 is NULL! It was never added to the form.");
                return;
            }

            // You can use the weight data in calculations here if necessary
            // You can also update the form with the weight details
            if (cessna172Calulations != null)
            {
                // Displaying data as an example
                MessageBox.Show($"Total Weight: {cessna172Calulations.GetTotalWeight172()}\n" +
                                 $"Passenger Weight: {cessna172Calulations.GetWeightOfPass172()}\n" +
                                 $"Baggage Weight: {cessna172Calulations.GetTotalBag172()}\n" +
                                 $"Fuel Weight: {cessna172Calulations.GetWeightFuel172()}");
            }

            // Adding the plot for the form
            formsPlot1.Plot.Clear();
            double[] xs = { 52, 68, 83, 95, 105.5 };
            double[] ys = { 1500, 1950, 2200, 2400, 2550 };
            // top line 
            double[] xa = { 105.5, 110, 115, 121 };
            double[] ya = { 2550, 2550, 2550, 2550 };
            //second line
            double[] xb = { 121, 97, 81.5, 78.5, 70.5 };
            double[] yb = { 2550, 2050, 1700, 1650, 1500 };
            //bottom line
            double[] xc = { 52, 70.5 };
            double[] yc = { 1500, 1500 };
            formsPlot1.Plot.Add.Scatter(xs, ys);
            formsPlot1.Plot.Add.Scatter(xa, ya);
            formsPlot1.Plot.Add.Scatter(xb, yb);
            formsPlot1.Plot.Add.Scatter(xc, yc);
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            if (formsPlot1 == null)
            {
                MessageBox.Show("formsPlot1 is NULL! It was never added to the form.");
                return;
            }

            // Plotting data as per the logic
            formsPlot1.Plot.Clear();
            double[] xs = { 52, 68, 83, 95, 105.5 };
            double[] ys = { 1500, 1950, 2200, 2400, 2550 };
            // top line 
            double[] xa = { 105.5, 110, 115, 121 };
            double[] ya = { 2550, 2550, 2550, 2550 };
            //second line
            double[] xb = { 105.5, 97, 81.5, 78.5, 70.5 };
            double[] yb = { 2550, 2050, 1700, 1650, 1500 };
            //bottom line
            double[] xc = { 52, 70.5 };
            double[] yc = { 1500, 1500 };
            formsPlot1.Plot.Add.Scatter(xs, ys);
            formsPlot1.Plot.Add.Scatter(xa, ya);
            formsPlot1.Plot.Add.Scatter(xb, yb);
            formsPlot1.Plot.Add.Scatter(xc, yc);
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }
    }
}


