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
    public partial class Cessna172Calulations: Form
    {
        public Cessna172Calulations()
        {
            InitializeComponent();
        }

        // TEXTBOXES //

        // getting total weight
        public int GetTotalWeight172() // get total weight
        {
            int totalWeight172 = Int32.Parse(TotalWeight.Text);
            return totalWeight172;
        }

        // getting weight of passengers
        public int GetWeightOfPass172()
        {
            int weightOfPass172 = Int32.Parse(WeightPass.Text);
            return weightOfPass172;
        }
        // getting total weight of the baggage
       public int GetTotalBag172()
        {
            int totalWeightBag172 = Int32.Parse(WeightOfBag.Text);
            return totalWeightBag172;
        }
        // getting total weight of fuel in both wings
        public int GetWeightFuel172()
        {
            int getWeightfuel172 = Int32.Parse(WeightOffuel.Text);
            return getWeightfuel172;

        }
       
        // BUTTONS //
        private void Calculations182_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithinEnvelope_Cessna172 withinEnvelope_Cessna172 = new WithinEnvelope_Cessna172();
            withinEnvelope_Cessna172.FormClosed += (s, args) => this.Close();
            withinEnvelope_Cessna172.Show();
            // if statements here for all of the sections about the max and min for each

           if(GetTotalWeight172() + GetTotalBag172() + GetWeightFuel172() + GetWeightOfPass172() + 1450 > 2550)
            {
                MessageBox.Show("Exceeds weight limits, please try again");
            }
           
        }
     
        private void Accerleration182_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccelerationStopResults_172 accelerationStopResults_172 = new AccelerationStopResults_172();
            accelerationStopResults_172.FormClosed += (s, args) => this.Close();
            accelerationStopResults_172.Show();
        }
    }
}
