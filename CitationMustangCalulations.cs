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
    public partial class CitationMustangCalulations : Form
    {
        public CitationMustangCalulations()
        {
            InitializeComponent();
        }

        private void Accerleration182_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccelerationStop_Mustang accelerationStop_Mustang = new AccelerationStop_Mustang();
            accelerationStop_Mustang.FormClosed += (s, args) => this.Close();
            accelerationStop_Mustang.Show();
        }

        private void Calculations182_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithinEnvelope_CitationMustang withinEnvelope_CitationMustang = new WithinEnvelope_CitationMustang();
            withinEnvelope_CitationMustang.FormClosed += (s, args) => this.Close();
            withinEnvelope_CitationMustang.Show();
        }
    }
}
