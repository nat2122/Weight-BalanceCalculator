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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Accerleration182 = new System.Windows.Forms.Button();
            this.Calculations182 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(68, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(68, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox3.Location = new System.Drawing.Point(68, 342);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox4.Location = new System.Drawing.Point(68, 418);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 20);
            this.textBox4.TabIndex = 3;
            // 
            // Accerleration182
            // 
            this.Accerleration182.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Accerleration182.BackgroundImage")));
            this.Accerleration182.Location = new System.Drawing.Point(468, 252);
            this.Accerleration182.Name = "Accerleration182";
            this.Accerleration182.Size = new System.Drawing.Size(279, 63);
            this.Accerleration182.TabIndex = 7;
            this.Accerleration182.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Accerleration182.UseVisualStyleBackColor = true;
            // 
            // Calculations182
            // 
            this.Calculations182.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculations182.BackgroundImage")));
            this.Calculations182.Location = new System.Drawing.Point(518, 342);
            this.Calculations182.Name = "Calculations182";
            this.Calculations182.Size = new System.Drawing.Size(184, 67);
            this.Calculations182.TabIndex = 8;
            this.Calculations182.UseVisualStyleBackColor = true;
            this.Calculations182.Click += new System.EventHandler(this.Calculations182_Click);
            // 
            // Cessna172Calulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculations182);
            this.Controls.Add(this.Accerleration182);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Cessna172Calulations";
            this.Text = "Cessna172Calulations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Accerleration182;
        private System.Windows.Forms.Button Calculations182;
    }
}