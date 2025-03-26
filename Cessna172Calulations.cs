using System.Windows.Forms;
using System;

namespace W_B_Calculator
{
    public partial class Cessna172Calulations : Form
    {
        private int totalWeight172 = 0;
        private int totalWeightOfPass = 0;
        private int totalWeightbag172 = 0;
        private int totalWeightFuel172 = 0;

        public Cessna172Calulations()
        {
            InitializeComponent();

            TotalWeight.TextChanged += TotalWeight_TextChanged;
            WeightPass.TextChanged += WeightPass_TextChanged;
            WeightOfBag.TextChanged += WeightOfBag_TextChanged;
            WeightOffuel.TextChanged += WeightOffuel_TextChanged;

            TotalWeight.KeyPress += TextBox_KeyPress;
            WeightPass.KeyPress += TextBox_KeyPress;
            WeightOfBag.KeyPress += TextBox_KeyPress;
            WeightOffuel.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TotalWeight_TextChanged(object sender, EventArgs e)
        {
            totalWeight172 = int.TryParse(TotalWeight.Text, out int weight) ? weight : 0;
        }

        private void WeightPass_TextChanged(object sender, EventArgs e)
        {
            totalWeightOfPass = int.TryParse(WeightPass.Text, out int weightOfPass) ? weightOfPass : 0;
        }

        private void WeightOfBag_TextChanged(object sender, EventArgs e)
        {
            totalWeightbag172 = int.TryParse(WeightOfBag.Text, out int weightOfBag) ? weightOfBag : 0;
        }

        private void WeightOffuel_TextChanged(object sender, EventArgs e)
        {
            totalWeightFuel172 = int.TryParse(WeightOffuel.Text, out int weightFuel) ? weightFuel : 0;
        }

        public int GetTotalWeight172() => totalWeight172;
        public int GetWeightOfPass172() => totalWeightOfPass;
        public int GetTotalBag172() => totalWeightbag172;
        public int GetWeightFuel172() => totalWeightFuel172;
        

        private void Accerleration172_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccelerationStop_Cessna172 accelerationStop_Cessna172 = new AccelerationStop_Cessna172();
            accelerationStop_Cessna172.Show();
            accelerationStop_Cessna172.FormClosed += (s, args) => this.Close();
            accelerationStop_Cessna172.Show();
           // string g = GetTotalBag172().ToString();
            //MessageBox.Show(g);
         
        }

        private void Calculations172_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithinEnvelope_Cessna172 withinEnvelope_Cessna172 = new WithinEnvelope_Cessna172(this);
            withinEnvelope_Cessna172.Show();
            withinEnvelope_Cessna172.FormClosed += (s, args) => this.Close();
            withinEnvelope_Cessna172.Show();

        }
    }
}


