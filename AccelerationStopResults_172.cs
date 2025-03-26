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
    public partial class AccelerationStopResults_172: Form
    {
       // private Cessna172Calulations cessna172Calulations;
        Cessna172Calulations cessna172Calulations = new Cessna172Calulations();

        public AccelerationStopResults_172()
        {
            InitializeComponent();
          viewResults(cessna172Calulations);
            
            int num = 1720;
            textBox1.Text = num.ToString();
        }
        public string viewResults(Cessna172Calulations cessna172Calulations)
        {
            if (cessna172Calulations == null)
            {
                MessageBox.Show("Error: Cessna172Calulations instance is null!");
                return "Error";
            }

            Cessna172 cessna172 = new Cessna172();

            int takeOffMoment = cessna172.calculatingMoment172(cessna172Calulations);

            MessageBox.Show("The Takeoff Moment is: " + takeOffMoment);

            return takeOffMoment.ToString();
        }

    
    }
}

