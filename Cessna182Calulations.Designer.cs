namespace W_B_Calculator
{
    partial class Cessna182Calulations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cessna182Calulations));
            this.totalWeight182 = new System.Windows.Forms.TextBox();
            this.TotalWeightPass182 = new System.Windows.Forms.TextBox();
            this.TotalWeightofBag182 = new System.Windows.Forms.TextBox();
            this.TotalWeightFuel182 = new System.Windows.Forms.TextBox();
            this.Accerleration182 = new System.Windows.Forms.Button();
            this.Calculations182 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalWeight182
            // 
            this.totalWeight182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.totalWeight182.Location = new System.Drawing.Point(46, 171);
            this.totalWeight182.Name = "totalWeight182";
            this.totalWeight182.Size = new System.Drawing.Size(251, 20);
            this.totalWeight182.TabIndex = 0;
            // 
            // TotalWeightPass182
            // 
            this.TotalWeightPass182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TotalWeightPass182.Location = new System.Drawing.Point(46, 263);
            this.TotalWeightPass182.Name = "TotalWeightPass182";
            this.TotalWeightPass182.Size = new System.Drawing.Size(251, 20);
            this.TotalWeightPass182.TabIndex = 1;
            // 
            // TotalWeightofBag182
            // 
            this.TotalWeightofBag182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TotalWeightofBag182.Location = new System.Drawing.Point(46, 352);
            this.TotalWeightofBag182.Name = "TotalWeightofBag182";
            this.TotalWeightofBag182.Size = new System.Drawing.Size(251, 20);
            this.TotalWeightofBag182.TabIndex = 2;
            // 
            // TotalWeightFuel182
            // 
            this.TotalWeightFuel182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TotalWeightFuel182.Location = new System.Drawing.Point(46, 440);
            this.TotalWeightFuel182.Name = "TotalWeightFuel182";
            this.TotalWeightFuel182.Size = new System.Drawing.Size(251, 20);
            this.TotalWeightFuel182.TabIndex = 3;
            // 
            // Accerleration182
            // 
            this.Accerleration182.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Accerleration182.BackgroundImage")));
            this.Accerleration182.Location = new System.Drawing.Point(464, 196);
            this.Accerleration182.Name = "Accerleration182";
            this.Accerleration182.Size = new System.Drawing.Size(267, 63);
            this.Accerleration182.TabIndex = 4;
            this.Accerleration182.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Accerleration182.UseVisualStyleBackColor = true;
            this.Accerleration182.Click += new System.EventHandler(this.Accerleration182_Click);
            // 
            // Calculations182
            // 
            this.Calculations182.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculations182.BackgroundImage")));
            this.Calculations182.Location = new System.Drawing.Point(503, 305);
            this.Calculations182.Name = "Calculations182";
            this.Calculations182.Size = new System.Drawing.Size(184, 67);
            this.Calculations182.TabIndex = 5;
            this.Calculations182.UseVisualStyleBackColor = true;
            this.Calculations182.Click += new System.EventHandler(this.Calculations182_Click);
            // 
            // Cessna182Calulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 472);
            this.Controls.Add(this.Calculations182);
            this.Controls.Add(this.Accerleration182);
            this.Controls.Add(this.TotalWeightFuel182);
            this.Controls.Add(this.TotalWeightofBag182);
            this.Controls.Add(this.TotalWeightPass182);
            this.Controls.Add(this.totalWeight182);
            this.Name = "Cessna182Calulations";
            this.Text = "Cessna182Calulations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalWeight182;
        private System.Windows.Forms.TextBox TotalWeightPass182;
        private System.Windows.Forms.TextBox TotalWeightofBag182;
        private System.Windows.Forms.TextBox TotalWeightFuel182;
        private System.Windows.Forms.Button Accerleration182;
        private System.Windows.Forms.Button Calculations182;
    }
}