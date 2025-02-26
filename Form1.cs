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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cessna172_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Cessna172Calulations cessna172Calulations = new Cessna172Calulations();
                cessna172Calulations.FormClosed += (s, args) => this.Close();
                cessna172Calulations.Show();

            }
        }

        private void Cessna182_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Cessna182Calulations cessna182Calulations = new Cessna182Calulations();
                cessna182Calulations.FormClosed += (s, args) => this.Close();
                cessna182Calulations.Show();
            }
        }

        private void CitationMustang_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                CitationMustangCalulations citationMustangCalulations = new CitationMustangCalulations();
                citationMustangCalulations.FormClosed += (s, args) => this.Close();
                citationMustangCalulations.Show();

            }
        }
    }

}
