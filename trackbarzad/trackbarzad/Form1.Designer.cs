namespace trackbarzad
{
    partial class txtboxRez
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
            this.trckbarProba = new System.Windows.Forms.TrackBar();
            this.lblJedan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trckbarProba)).BeginInit();
            this.SuspendLayout();
            // 
            // trckbarProba
            // 
            this.trckbarProba.Location = new System.Drawing.Point(196, 38);
            this.trckbarProba.Maximum = 100;
            this.trckbarProba.Name = "trckbarProba";
            this.trckbarProba.Size = new System.Drawing.Size(352, 45);
            this.trckbarProba.TabIndex = 0;
            this.trckbarProba.Scroll += new System.EventHandler(this.trckbarProba_Scroll);
            // 
            // lblJedan
            // 
            this.lblJedan.AutoSize = true;
            this.lblJedan.Location = new System.Drawing.Point(299, 160);
            this.lblJedan.Name = "lblJedan";
            this.lblJedan.Size = new System.Drawing.Size(124, 13);
            this.lblJedan.TabIndex = 1;
            this.lblJedan.Text = "Postavljena je vrijednost:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtboxRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblJedan);
            this.Controls.Add(this.trckbarProba);
            this.Name = "txtboxRez";
            this.Text = "Upotreba TrackBar Kontrole";
            ((System.ComponentModel.ISupportInitialize)(this.trckbarProba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trckbarProba;
        private System.Windows.Forms.Label lblJedan;
        private System.Windows.Forms.TextBox textBox1;
    }
}

