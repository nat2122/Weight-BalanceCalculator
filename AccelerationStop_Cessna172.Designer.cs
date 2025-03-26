namespace W_B_Calculator
{
    partial class AccelerationStop_Cessna172
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccelerationStop_Cessna172));
            this.enterTemperature = new System.Windows.Forms.TextBox();
            this.enterWind = new System.Windows.Forms.TextBox();
            this.enterAlt = new System.Windows.Forms.TextBox();
            this.viewResultCessna172 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterTemperature
            // 
            this.enterTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.enterTemperature.Location = new System.Drawing.Point(32, 134);
            this.enterTemperature.Name = "enterTemperature";
            this.enterTemperature.Size = new System.Drawing.Size(209, 20);
            this.enterTemperature.TabIndex = 1;
            this.enterTemperature.TextChanged += new System.EventHandler(this.enterTemperature_TextChanged);
            // 
            // enterWind
            // 
            this.enterWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.enterWind.Location = new System.Drawing.Point(32, 255);
            this.enterWind.Name = "enterWind";
            this.enterWind.Size = new System.Drawing.Size(209, 20);
            this.enterWind.TabIndex = 2;
            // 
            // enterAlt
            // 
            this.enterAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.enterAlt.Location = new System.Drawing.Point(32, 355);
            this.enterAlt.Name = "enterAlt";
            this.enterAlt.Size = new System.Drawing.Size(209, 20);
            this.enterAlt.TabIndex = 3;
            this.enterAlt.TextChanged += new System.EventHandler(this.enterAlt_TextChanged);
            // 
            // viewResultCessna172
            // 
            this.viewResultCessna172.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewResultCessna172.BackgroundImage")));
            this.viewResultCessna172.Location = new System.Drawing.Point(541, 188);
            this.viewResultCessna172.Name = "viewResultCessna172";
            this.viewResultCessna172.Size = new System.Drawing.Size(173, 72);
            this.viewResultCessna172.TabIndex = 5;
            this.viewResultCessna172.UseVisualStyleBackColor = true;
            this.viewResultCessna172.Click += new System.EventHandler(this.viewResultCessna172_Click);
            // 
            // AccelerationStop_Cessna172
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewResultCessna172);
            this.Controls.Add(this.enterAlt);
            this.Controls.Add(this.enterWind);
            this.Controls.Add(this.enterTemperature);
            this.Name = "AccelerationStop_Cessna172";
            this.Text = "AccelerationStop_Cessna172";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterTemperature;
        private System.Windows.Forms.TextBox enterWind;
        private System.Windows.Forms.TextBox enterAlt;
        private System.Windows.Forms.Button viewResultCessna172;
    }
}