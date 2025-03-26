using System;
using System.Windows.Forms;

namespace W_B_Calculator
{
    public partial class AccelerationStop_Cessna172 : Form
    {
        private Cessna172Calulations cessna172Calulations;  // To hold the Cessna172Calulations data

        // Constructor accepting Cessna172Calulations
      
    

        public AccelerationStop_Cessna172()
        {
            InitializeComponent();
            cessna172Calulations = calculations;
        }

        private int totalTemperature = 0; // Store user input
        private void enterTemperature_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(enterTemperature.Text, out totalTemperature))
            {
                totalTemperature = 0; // Reset if invalid
            }
        }

        public int GetTemperature()
        {
            return totalTemperature;
        }

        // Getting Altitude
        private int totalAlt = 0; // Store user input   
        private Cessna172 cessna172;
        private Cessna172Calulations calculations;

        private void enterAlt_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(enterAlt.Text, out totalAlt))
            {
                totalAlt = 0; // Reset if invalid
            }
        }

        public int GetAlt()
        {
            return totalAlt;
        }

        // Method to display weight information from Cessna172Calulations
       

        // Button to view results
        private void viewResultCessna172_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccelerationStopResults_172 accelerationStopResults_172 = new AccelerationStopResults_172();
            accelerationStopResults_172.FormClosed += (s, args) => this.Close();
            accelerationStopResults_172.Show();
        }


    }
}
