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
    public partial class AccelerationStop_Mustang: Form
    {
        public AccelerationStop_Mustang()
        {
            InitializeComponent();
        }

        private void viewResultMustang_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccelerationStopResults_Mustang accelerationStopResults_Mustang = new AccelerationStopResults_Mustang();
            accelerationStopResults_Mustang.FormClosed += (s, args) => this.Close();
            accelerationStopResults_Mustang.Show();
        }
    }
}
