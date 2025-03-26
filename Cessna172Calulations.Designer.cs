namespace W_B_Calculator
{
    partial class Cessna172Calulations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cessna172Calulations));
            this.TotalWeight = new System.Windows.Forms.TextBox();
            this.WeightPass = new System.Windows.Forms.TextBox();
            this.WeightOfBag = new System.Windows.Forms.TextBox();
            this.WeightOffuel = new System.Windows.Forms.TextBox();
            this.Accerleration172 = new System.Windows.Forms.Button();
            this.Calculations172 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalWeight
            // 
            this.TotalWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalWeight.Location = new System.Drawing.Point(68, 164);
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.Size = new System.Drawing.Size(250, 20);
            this.TotalWeight.TabIndex = 0;
            // 
            // WeightPass
            // 
            this.WeightPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WeightPass.Location = new System.Drawing.Point(68, 252);
            this.WeightPass.Name = "WeightPass";
            this.WeightPass.Size = new System.Drawing.Size(250, 20);
            this.WeightPass.TabIndex = 1;
            // 
            // WeightOfBag
            // 
            this.WeightOfBag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WeightOfBag.Location = new System.Drawing.Point(68, 342);
            this.WeightOfBag.Name = "WeightOfBag";
            this.WeightOfBag.Size = new System.Drawing.Size(250, 20);
            this.WeightOfBag.TabIndex = 2;
            // 
            // WeightOffuel
            // 
            this.WeightOffuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WeightOffuel.Location = new System.Drawing.Point(68, 418);
            this.WeightOffuel.Name = "WeightOffuel";
            this.WeightOffuel.Size = new System.Drawing.Size(250, 20);
            this.WeightOffuel.TabIndex = 3;
            // 
            // Accerleration172
            // 
            this.Accerleration172.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Accerleration172.BackgroundImage")));
            this.Accerleration172.Location = new System.Drawing.Point(468, 252);
            this.Accerleration172.Name = "Accerleration172";
            this.Accerleration172.Size = new System.Drawing.Size(279, 63);
            this.Accerleration172.TabIndex = 7;
            this.Accerleration172.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Accerleration172.UseVisualStyleBackColor = true;
            this.Accerleration172.Click += new System.EventHandler(this.Accerleration172_Click);
            // 
            // Calculations172
            // 
            this.Calculations172.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculations172.BackgroundImage")));
            this.Calculations172.Location = new System.Drawing.Point(518, 342);
            this.Calculations172.Name = "Calculations172";
            this.Calculations172.Size = new System.Drawing.Size(184, 67);
            this.Calculations172.TabIndex = 8;
            this.Calculations172.UseVisualStyleBackColor = true;
            this.Calculations172.Click += new System.EventHandler(this.Calculations172_Click);
            // 
            // Cessna172Calulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculations172);
            this.Controls.Add(this.Accerleration172);
            this.Controls.Add(this.WeightOffuel);
            this.Controls.Add(this.WeightOfBag);
            this.Controls.Add(this.WeightPass);
            this.Controls.Add(this.TotalWeight);
            this.Name = "Cessna172Calulations";
            this.Text = "Cessna172Calulations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalWeight;
        private System.Windows.Forms.TextBox WeightPass;
        private System.Windows.Forms.TextBox WeightOfBag;
        private System.Windows.Forms.TextBox WeightOffuel;
        private System.Windows.Forms.Button Accerleration172;
        private System.Windows.Forms.Button Calculations172;
    }
}