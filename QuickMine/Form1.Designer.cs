namespace EZNANO
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
            this.StartButton = new System.Windows.Forms.Button();
            this.selectGPUText = new System.Windows.Forms.Label();
            this.dailyProfit = new System.Windows.Forms.Label();
            this.revenueDay = new System.Windows.Forms.Label();
            this.electricCost = new System.Windows.Forms.Label();
            this.kWh = new System.Windows.Forms.Label();
            this.rejectedShares = new System.Windows.Forms.Label();
            this.acceptedShares = new System.Windows.Forms.Label();
            this.sols = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kwhCost = new System.Windows.Forms.TextBox();
            this.nanoPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NvidiaPicture = new System.Windows.Forms.PictureBox();
            this.RightGPU = new System.Windows.Forms.Button();
            this.leftGPU = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.REJECTEDLABEL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Intensity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minedLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.VersionNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NvidiaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // NanoAddress
            // 
            this.NanoAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NanoAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NanoAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NanoAddress.Location = new System.Drawing.Point(12, 366);
            this.NanoAddress.Name = "NanoAddress";
            this.NanoAddress.Size = new System.Drawing.Size(360, 14);
            this.NanoAddress.TabIndex = 0;
            this.NanoAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(1, 671);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(383, 110);
            this.StartButton.TabIndex = 1;
            this.StartButton.Tag = "start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // selectGPUText
            // 
            this.selectGPUText.BackColor = System.Drawing.Color.Transparent;
            this.selectGPUText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGPUText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectGPUText.Location = new System.Drawing.Point(1, 48);
            this.selectGPUText.Name = "selectGPUText";
            this.selectGPUText.Size = new System.Drawing.Size(383, 29);
            this.selectGPUText.TabIndex = 5;
            this.selectGPUText.Text = "SELECT GPU";
            this.selectGPUText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dailyProfit
            // 
            this.dailyProfit.BackColor = System.Drawing.Color.Transparent;
            this.dailyProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyProfit.ForeColor = System.Drawing.Color.Green;
            this.dailyProfit.Location = new System.Drawing.Point(12, 504);
            this.dailyProfit.Name = "dailyProfit";
            this.dailyProfit.Size = new System.Drawing.Size(179, 42);
            this.dailyProfit.TabIndex = 6;
            this.dailyProfit.Text = "≈$0";
            this.dailyProfit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // revenueDay
            // 
            this.revenueDay.BackColor = System.Drawing.Color.Transparent;
            this.revenueDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueDay.ForeColor = System.Drawing.Color.Green;
            this.revenueDay.Location = new System.Drawing.Point(1, 575);
            this.revenueDay.Name = "revenueDay";
            this.revenueDay.Size = new System.Drawing.Size(124, 35);
            this.revenueDay.TabIndex = 5;
            this.revenueDay.Text = "≈$0";
            this.revenueDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // electricCost
            // 
            this.electricCost.BackColor = System.Drawing.Color.Transparent;
            this.electricCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electricCost.ForeColor = System.Drawing.Color.Green;
            this.electricCost.Location = new System.Drawing.Point(65, 575);
            this.electricCost.Name = "electricCost";
            this.electricCost.Size = new System.Drawing.Size(256, 25);
            this.electricCost.TabIndex = 4;
            this.electricCost.Text = "≈$0";
            this.electricCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kWh
            // 
            this.kWh.BackColor = System.Drawing.Color.Transparent;
            this.kWh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kWh.ForeColor = System.Drawing.Color.Green;
            this.kWh.Location = new System.Drawing.Point(258, 575);
            this.kWh.Name = "kWh";
            this.kWh.Size = new System.Drawing.Size(126, 35);
            this.kWh.TabIndex = 3;
            this.kWh.Text = "0";
            this.kWh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rejectedShares
            // 
            this.rejectedShares.BackColor = System.Drawing.Color.Transparent;
            this.rejectedShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedShares.ForeColor = System.Drawing.Color.OrangeRed;
            this.rejectedShares.Location = new System.Drawing.Point(1, 639);
            this.rejectedShares.Name = "rejectedShares";
            this.rejectedShares.Size = new System.Drawing.Size(383, 29);
            this.rejectedShares.TabIndex = 2;
            this.rejectedShares.Text = "0";
            this.rejectedShares.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // acceptedShares
            // 
            this.acceptedShares.BackColor = System.Drawing.Color.Transparent;
            this.acceptedShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedShares.ForeColor = System.Drawing.Color.Green;
            this.acceptedShares.Location = new System.Drawing.Point(2, 639);
            this.acceptedShares.Name = "acceptedShares";
            this.acceptedShares.Size = new System.Drawing.Size(122, 29);
            this.acceptedShares.TabIndex = 1;
            this.acceptedShares.Text = "0";
            this.acceptedShares.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sols
            // 
            this.sols.BackColor = System.Drawing.Color.Transparent;
            this.sols.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sols.ForeColor = System.Drawing.Color.Green;
            this.sols.Location = new System.Drawing.Point(258, 639);
            this.sols.Name = "sols";
            this.sols.Size = new System.Drawing.Size(126, 29);
            this.sols.TabIndex = 0;
            this.sols.Text = "0";
            this.sols.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost per kWh:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kwhCost
            // 
            this.kwhCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kwhCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwhCost.Location = new System.Drawing.Point(70, 298);
            this.kwhCost.Name = "kwhCost";
            this.kwhCost.Size = new System.Drawing.Size(41, 15);
            this.kwhCost.TabIndex = 11;
            this.kwhCost.Text = "0.1";
            this.kwhCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nanoPrice
            // 
            this.nanoPrice.BackColor = System.Drawing.Color.Transparent;
            this.nanoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nanoPrice.ForeColor = System.Drawing.Color.Green;
            this.nanoPrice.Location = new System.Drawing.Point(191, 504);
            this.nanoPrice.Name = "nanoPrice";
            this.nanoPrice.Size = new System.Drawing.Size(176, 42);
            this.nanoPrice.TabIndex = 12;
            this.nanoPrice.Text = "$0";
            this.nanoPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "NANO ADDRESS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NvidiaPicture
            // 
            this.NvidiaPicture.BackColor = System.Drawing.Color.Transparent;
            this.NvidiaPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NvidiaPicture.BackgroundImage")));
            this.NvidiaPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NvidiaPicture.Location = new System.Drawing.Point(70, 80);
            this.NvidiaPicture.Name = "NvidiaPicture";
            this.NvidiaPicture.Size = new System.Drawing.Size(251, 187);
            this.NvidiaPicture.TabIndex = 15;
            this.NvidiaPicture.TabStop = false;
            // 
            // RightGPU
            // 
            this.RightGPU.BackColor = System.Drawing.Color.Transparent;
            this.RightGPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightGPU.BackgroundImage")));
            this.RightGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightGPU.FlatAppearance.BorderSize = 0;
            this.RightGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightGPU.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightGPU.Location = new System.Drawing.Point(313, 131);
            this.RightGPU.Name = "RightGPU";
            this.RightGPU.Size = new System.Drawing.Size(60, 89);
            this.RightGPU.TabIndex = 16;
            this.RightGPU.UseVisualStyleBackColor = false;
            this.RightGPU.Click += new System.EventHandler(this.RightGPU_Click_1);
            // 
            // leftGPU
            // 
            this.leftGPU.BackColor = System.Drawing.Color.Transparent;
            this.leftGPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftGPU.BackgroundImage")));
            this.leftGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftGPU.FlatAppearance.BorderSize = 0;
            this.leftGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftGPU.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftGPU.Location = new System.Drawing.Point(12, 131);
            this.leftGPU.Name = "leftGPU";
            this.leftGPU.Size = new System.Drawing.Size(62, 89);
            this.leftGPU.TabIndex = 17;
            this.leftGPU.UseVisualStyleBackColor = false;
            this.leftGPU.Click += new System.EventHandler(this.leftGPU_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "PROFIT/DAY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "NANO PRICE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "REV/DAY";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "COST/DAY";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "GPU KWH";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // REJECTEDLABEL
            // 
            this.REJECTEDLABEL.BackColor = System.Drawing.Color.Transparent;
            this.REJECTEDLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REJECTEDLABEL.Location = new System.Drawing.Point(1, 610);
            this.REJECTEDLABEL.Name = "REJECTEDLABEL";
            this.REJECTEDLABEL.Size = new System.Drawing.Size(383, 29);
            this.REJECTEDLABEL.TabIndex = 23;
            this.REJECTEDLABEL.Text = "REJECTED";
            this.REJECTEDLABEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 610);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "SOL/S";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 610);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "ACCEPTED";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(383, 61);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(1, 671);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(383, 110);
            this.stopButton.TabIndex = 28;
            this.stopButton.Tag = "start";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(100, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 187);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Intensity
            // 
            this.Intensity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Intensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intensity.Location = new System.Drawing.Point(263, 298);
            this.Intensity.Name = "Intensity";
            this.Intensity.Size = new System.Drawing.Size(41, 15);
            this.Intensity.TabIndex = 31;
            this.Intensity.Text = "75";
            this.Intensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(195, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Intensity (1-100):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minedLabel
            // 
            this.minedLabel.BackColor = System.Drawing.Color.Transparent;
            this.minedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minedLabel.ForeColor = System.Drawing.Color.Green;
            this.minedLabel.Location = new System.Drawing.Point(1, 424);
            this.minedLabel.Name = "minedLabel";
            this.minedLabel.Size = new System.Drawing.Size(379, 42);
            this.minedLabel.TabIndex = 32;
            this.minedLabel.Text = "0.00000000";
            this.minedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(383, 29);
            this.label12.TabIndex = 33;
            this.label12.Text = "NANO MINED";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.BackColor = System.Drawing.Color.Transparent;
            this.autoStart.Location = new System.Drawing.Point(300, 12);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(70, 17);
            this.autoStart.TabIndex = 34;
            this.autoStart.Text = "AutoStart";
            this.autoStart.UseVisualStyleBackColor = false;
            // 
            // VersionNumber
            // 
            this.VersionNumber.AutoSize = true;
            this.VersionNumber.BackColor = System.Drawing.Color.Transparent;
            this.VersionNumber.Location = new System.Drawing.Point(5, 12);
            this.VersionNumber.Name = "VersionNumber";
            this.VersionNumber.Size = new System.Drawing.Size(32, 13);
            this.VersionNumber.TabIndex = 35;
            this.VersionNumber.Text = "V 0.8";
            // 
            // EZNANO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 780);
            this.Controls.Add(this.VersionNumber);
            this.Controls.Add(this.autoStart);
            this.Controls.Add(this.minedLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Intensity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acceptedShares);
            this.Controls.Add(this.NvidiaPicture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectGPUText);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dailyProfit);
            this.Controls.Add(this.nanoPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NanoAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sols);
            this.Controls.Add(this.kWh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.REJECTEDLABEL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftGPU);
            this.Controls.Add(this.RightGPU);
            this.Controls.Add(this.kwhCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.revenueDay);
            this.Controls.Add(this.electricCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rejectedShares);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.stopButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EZNANO";
            this.Text = "EZ NANO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EZNANO_FormClosing);
            this.Load += new System.EventHandler(this.EZNANO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NvidiaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NanoAddress;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label selectGPUText;
        private System.Windows.Forms.Label sols;
        private System.Windows.Forms.Label acceptedShares;
        private System.Windows.Forms.Label rejectedShares;
        private System.Windows.Forms.Label kWh;
        private System.Windows.Forms.Label electricCost;
        private System.Windows.Forms.Label revenueDay;
        private System.Windows.Forms.Label dailyProfit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kwhCost;
        private System.Windows.Forms.Label nanoPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox NvidiaPicture;
        private System.Windows.Forms.Button RightGPU;
        private System.Windows.Forms.Button leftGPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label REJECTEDLABEL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Intensity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minedLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.Label VersionNumber;
    }
}

