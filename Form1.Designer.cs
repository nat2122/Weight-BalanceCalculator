namespace W_B_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CitationMustang = new System.Windows.Forms.Button();
            this.Cessna182 = new System.Windows.Forms.Button();
            this.Cessna172 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CitationMustang
            // 
            this.CitationMustang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CitationMustang.BackgroundImage")));
            this.CitationMustang.Location = new System.Drawing.Point(644, 407);
            this.CitationMustang.Name = "CitationMustang";
            this.CitationMustang.Size = new System.Drawing.Size(147, 58);
            this.CitationMustang.TabIndex = 0;
            this.CitationMustang.UseVisualStyleBackColor = true;
            // 
            // Cessna182
            // 
            this.Cessna182.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cessna182.BackgroundImage")));
            this.Cessna182.Location = new System.Drawing.Point(365, 407);
            this.Cessna182.Name = "Cessna182";
            this.Cessna182.Size = new System.Drawing.Size(127, 58);
            this.Cessna182.TabIndex = 1;
            this.Cessna182.UseVisualStyleBackColor = true;
            // 
            // Cessna172
            // 
            this.Cessna172.BackColor = System.Drawing.Color.Transparent;
            this.Cessna172.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cessna172.BackgroundImage")));
            this.Cessna172.Location = new System.Drawing.Point(91, 407);
            this.Cessna172.Name = "Cessna172";
            this.Cessna172.Size = new System.Drawing.Size(133, 58);
            this.Cessna172.TabIndex = 2;
            this.Cessna172.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 547);
            this.Controls.Add(this.Cessna172);
            this.Controls.Add(this.Cessna182);
            this.Controls.Add(this.CitationMustang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CitationMustang;
        private System.Windows.Forms.Button Cessna182;
        private System.Windows.Forms.Button Cessna172;
    }
}

