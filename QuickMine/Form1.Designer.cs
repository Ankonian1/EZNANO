namespace QuickMine
{
    partial class EZNANO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EZNANO));
            this.NanoAddress = new System.Windows.Forms.TextBox();
            this.StartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AMD = new System.Windows.Forms.Button();
            this.selectGPUText = new System.Windows.Forms.Label();
            this.Nvidia = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.GroupBox();
            this.sols = new System.Windows.Forms.Label();
            this.acceptedShares = new System.Windows.Forms.Label();
            this.rejectedShares = new System.Windows.Forms.Label();
            this.kWh = new System.Windows.Forms.Label();
            this.electricCost = new System.Windows.Forms.Label();
            this.revenueDay = new System.Windows.Forms.Label();
            this.dailyProfit = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.TextBox();
            this.stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // NanoAddress
            // 
            this.NanoAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NanoAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NanoAddress.Location = new System.Drawing.Point(13, 519);
            this.NanoAddress.Name = "NanoAddress";
            this.NanoAddress.Size = new System.Drawing.Size(360, 21);
            this.NanoAddress.TabIndex = 0;
            this.NanoAddress.Text = "Nano_Address...";
            this.NanoAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartStop
            // 
            this.StartStop.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartStop.FlatAppearance.BorderSize = 0;
            this.StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStop.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStop.Location = new System.Drawing.Point(13, 596);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(360, 41);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Start!";
            this.StartStop.UseVisualStyleBackColor = false;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Donate: xrb_388ff1fzd3rhf5ijidqxo8jt6dj37izwa47t131c4cykpzhg4uured9qyxiz";
            // 
            // AMD
            // 
            this.AMD.BackColor = System.Drawing.Color.OldLace;
            this.AMD.BackgroundImage = global::QuickMine.Properties.Resources.AMD;
            this.AMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AMD.Location = new System.Drawing.Point(20, 170);
            this.AMD.Name = "AMD";
            this.AMD.Size = new System.Drawing.Size(160, 160);
            this.AMD.TabIndex = 3;
            this.AMD.UseVisualStyleBackColor = false;
            this.AMD.Click += new System.EventHandler(this.AMD_Click);
            // 
            // selectGPUText
            // 
            this.selectGPUText.AutoSize = true;
            this.selectGPUText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGPUText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectGPUText.Location = new System.Drawing.Point(130, 127);
            this.selectGPUText.Name = "selectGPUText";
            this.selectGPUText.Size = new System.Drawing.Size(129, 27);
            this.selectGPUText.TabIndex = 5;
            this.selectGPUText.Text = "SELECT GPU";
            // 
            // Nvidia
            // 
            this.Nvidia.BackColor = System.Drawing.Color.OldLace;
            this.Nvidia.BackgroundImage = global::QuickMine.Properties.Resources.Nvidia__2_;
            this.Nvidia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nvidia.Location = new System.Drawing.Point(212, 170);
            this.Nvidia.Name = "Nvidia";
            this.Nvidia.Size = new System.Drawing.Size(160, 160);
            this.Nvidia.TabIndex = 7;
            this.Nvidia.UseVisualStyleBackColor = false;
            this.Nvidia.Click += new System.EventHandler(this.Nvidia_Click);
            // 
            // stats
            // 
            this.stats.Controls.Add(this.dailyProfit);
            this.stats.Controls.Add(this.revenueDay);
            this.stats.Controls.Add(this.electricCost);
            this.stats.Controls.Add(this.kWh);
            this.stats.Controls.Add(this.rejectedShares);
            this.stats.Controls.Add(this.acceptedShares);
            this.stats.Controls.Add(this.sols);
            this.stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stats.Location = new System.Drawing.Point(14, 344);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(359, 169);
            this.stats.TabIndex = 8;
            this.stats.TabStop = false;
            this.stats.Text = "Statistics";
            // 
            // sols
            // 
            this.sols.AutoSize = true;
            this.sols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sols.Location = new System.Drawing.Point(3, 25);
            this.sols.Name = "sols";
            this.sols.Size = new System.Drawing.Size(61, 20);
            this.sols.TabIndex = 0;
            this.sols.Text = "SOL/s: ";
            this.sols.Click += new System.EventHandler(this.sols_Click);
            // 
            // acceptedShares
            // 
            this.acceptedShares.AutoSize = true;
            this.acceptedShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedShares.Location = new System.Drawing.Point(3, 45);
            this.acceptedShares.Name = "acceptedShares";
            this.acceptedShares.Size = new System.Drawing.Size(140, 20);
            this.acceptedShares.TabIndex = 1;
            this.acceptedShares.Text = "Accepted Shares: ";
            // 
            // rejectedShares
            // 
            this.rejectedShares.AutoSize = true;
            this.rejectedShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedShares.Location = new System.Drawing.Point(3, 65);
            this.rejectedShares.Name = "rejectedShares";
            this.rejectedShares.Size = new System.Drawing.Size(136, 20);
            this.rejectedShares.TabIndex = 2;
            this.rejectedShares.Text = "Rejected Shares: ";
            // 
            // kWh
            // 
            this.kWh.AutoSize = true;
            this.kWh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kWh.Location = new System.Drawing.Point(172, 25);
            this.kWh.Name = "kWh";
            this.kWh.Size = new System.Drawing.Size(88, 20);
            this.kWh.TabIndex = 3;
            this.kWh.Text = "GPU kWh: ";
            // 
            // electricCost
            // 
            this.electricCost.AutoSize = true;
            this.electricCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electricCost.Location = new System.Drawing.Point(172, 45);
            this.electricCost.Name = "electricCost";
            this.electricCost.Size = new System.Drawing.Size(135, 20);
            this.electricCost.TabIndex = 4;
            this.electricCost.Text = "Electric Cost/day: ";
            // 
            // revenueDay
            // 
            this.revenueDay.AutoSize = true;
            this.revenueDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueDay.Location = new System.Drawing.Point(172, 65);
            this.revenueDay.Name = "revenueDay";
            this.revenueDay.Size = new System.Drawing.Size(74, 20);
            this.revenueDay.TabIndex = 5;
            this.revenueDay.Text = "Rev/day: ";
            // 
            // dailyProfit
            // 
            this.dailyProfit.AutoSize = true;
            this.dailyProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyProfit.Location = new System.Drawing.Point(117, 141);
            this.dailyProfit.Name = "dailyProfit";
            this.dailyProfit.Size = new System.Drawing.Size(115, 25);
            this.dailyProfit.TabIndex = 6;
            this.dailyProfit.Text = "Profit/day: ";
            // 
            // Warning
            // 
            this.Warning.Enabled = false;
            this.Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(60, 547);
            this.Warning.Multiline = true;
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(275, 39);
            this.Warning.TabIndex = 9;
            this.Warning.Text = "WARNING: If Nano address is incorrect, funds may not be transferred.";
            this.Warning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EZNANO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.Nvidia);
            this.Controls.Add(this.selectGPUText);
            this.Controls.Add(this.AMD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.NanoAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EZNANO";
            this.Text = "EZ NANO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stats.ResumeLayout(false);
            this.stats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NanoAddress;
        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AMD;
        private System.Windows.Forms.Label selectGPUText;
        private System.Windows.Forms.Button Nvidia;
        private System.Windows.Forms.GroupBox stats;
        private System.Windows.Forms.Label sols;
        private System.Windows.Forms.Label acceptedShares;
        private System.Windows.Forms.Label rejectedShares;
        private System.Windows.Forms.Label kWh;
        private System.Windows.Forms.Label electricCost;
        private System.Windows.Forms.Label revenueDay;
        private System.Windows.Forms.Label dailyProfit;
        private System.Windows.Forms.TextBox Warning;
    }
}

