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
    public partial class Cessna182Calulations : Form
    {
        public Cessna182Calulations()
        {
            InitializeComponent();
        }

        private void Calculations182_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithinEnvelope_Cessna182 withinEnvelope_Cessna182 = new WithinEnvelope_Cessna182();
            withinEnvelope_Cessna182.FormClosed += (s, args) => this.Close();
            withinEnvelope_Cessna182.Show();
        }

        private void Accerleration182_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccelerationStop_Cessna182 accelerationStop_Cessna182 = new AccelerationStop_Cessna182();
            accelerationStop_Cessna182.FormClosed += (s, args) => this.Close();
            accelerationStop_Cessna182.Show();
        }
    }
}
