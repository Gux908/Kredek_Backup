namespace KacperStudennyZadanieDomoweLab1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxMenuBoard = new System.Windows.Forms.PictureBox();
            this.buttonBarracks = new System.Windows.Forms.Button();
            this.buttonSteelMine = new System.Windows.Forms.Button();
            this.buttonFarm = new System.Windows.Forms.Button();
            this.buttonWoodcutter = new System.Windows.Forms.Button();
            this.buttonCastle = new System.Windows.Forms.Button();
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSteel = new System.Windows.Forms.PictureBox();
            this.labelSteelAmount = new System.Windows.Forms.Label();
            this.pictureBoxWood = new System.Windows.Forms.PictureBox();
            this.labelWoodAmount = new System.Windows.Forms.Label();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.labelGoldAmount = new System.Windows.Forms.Label();
            this.pictureBoxPeople = new System.Windows.Forms.PictureBox();
            this.labelPeopleAmount = new System.Windows.Forms.Label();
            this.pictureBoxWarriors = new System.Windows.Forms.PictureBox();
            this.labelWarriorsAmount = new System.Windows.Forms.Label();
            this.timerFPS = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCalendar = new System.Windows.Forms.PictureBox();
            this.labelDayNumber = new System.Windows.Forms.Label();
            this.buttonMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarriors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMenuBoard
            // 
            this.pictureBoxMenuBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenuBoard.BackgroundImage")));
            this.pictureBoxMenuBoard.Location = new System.Drawing.Point(960, -3);
            this.pictureBoxMenuBoard.Name = "pictureBoxMenuBoard";
            this.pictureBoxMenuBoard.Size = new System.Drawing.Size(201, 540);
            this.pictureBoxMenuBoard.TabIndex = 0;
            this.pictureBoxMenuBoard.TabStop = false;
            // 
            // buttonBarracks
            // 
            this.buttonBarracks.Location = new System.Drawing.Point(989, 387);
            this.buttonBarracks.Name = "buttonBarracks";
            this.buttonBarracks.Size = new System.Drawing.Size(95, 30);
            this.buttonBarracks.TabIndex = 1;
            this.buttonBarracks.Text = "Koszary";
            this.buttonBarracks.UseVisualStyleBackColor = true;
            this.buttonBarracks.Click += new System.EventHandler(this.buttonBarracks_Click);
            // 
            // buttonSteelMine
            // 
            this.buttonSteelMine.Location = new System.Drawing.Point(989, 217);
            this.buttonSteelMine.Name = "buttonSteelMine";
            this.buttonSteelMine.Size = new System.Drawing.Size(95, 30);
            this.buttonSteelMine.TabIndex = 1;
            this.buttonSteelMine.Text = "Kopalnia";
            this.buttonSteelMine.UseVisualStyleBackColor = true;
            this.buttonSteelMine.Click += new System.EventHandler(this.buttonSteelMine_Click);
            // 
            // buttonFarm
            // 
            this.buttonFarm.Location = new System.Drawing.Point(989, 328);
            this.buttonFarm.Name = "buttonFarm";
            this.buttonFarm.Size = new System.Drawing.Size(95, 30);
            this.buttonFarm.TabIndex = 1;
            this.buttonFarm.Text = "Farma";
            this.buttonFarm.UseVisualStyleBackColor = true;
            this.buttonFarm.Click += new System.EventHandler(this.buttonFarm_Click);
            // 
            // buttonWoodcutter
            // 
            this.buttonWoodcutter.Location = new System.Drawing.Point(989, 270);
            this.buttonWoodcutter.Name = "buttonWoodcutter";
            this.buttonWoodcutter.Size = new System.Drawing.Size(95, 30);
            this.buttonWoodcutter.TabIndex = 1;
            this.buttonWoodcutter.Text = "Drwal";
            this.buttonWoodcutter.UseVisualStyleBackColor = true;
            this.buttonWoodcutter.Click += new System.EventHandler(this.buttonWoodcutter_Click);
            // 
            // buttonCastle
            // 
            this.buttonCastle.Location = new System.Drawing.Point(989, 160);
            this.buttonCastle.Name = "buttonCastle";
            this.buttonCastle.Size = new System.Drawing.Size(95, 30);
            this.buttonCastle.TabIndex = 1;
            this.buttonCastle.Text = "Zamek";
            this.buttonCastle.UseVisualStyleBackColor = true;
            this.buttonCastle.Click += new System.EventHandler(this.buttonCastle_Click);
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 2000;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSteel
            // 
            this.pictureBoxSteel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSteel.Image")));
            this.pictureBoxSteel.Location = new System.Drawing.Point(160, 8);
            this.pictureBoxSteel.Name = "pictureBoxSteel";
            this.pictureBoxSteel.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxSteel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSteel.TabIndex = 4;
            this.pictureBoxSteel.TabStop = false;
            // 
            // labelSteelAmount
            // 
            this.labelSteelAmount.AutoSize = true;
            this.labelSteelAmount.Location = new System.Drawing.Point(197, 26);
            this.labelSteelAmount.Name = "labelSteelAmount";
            this.labelSteelAmount.Size = new System.Drawing.Size(13, 13);
            this.labelSteelAmount.TabIndex = 5;
            this.labelSteelAmount.Text = "0";
            // 
            // pictureBoxWood
            // 
            this.pictureBoxWood.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWood.Image")));
            this.pictureBoxWood.Location = new System.Drawing.Point(272, 8);
            this.pictureBoxWood.Name = "pictureBoxWood";
            this.pictureBoxWood.Size = new System.Drawing.Size(30, 31);
            this.pictureBoxWood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxWood.TabIndex = 4;
            this.pictureBoxWood.TabStop = false;
            // 
            // labelWoodAmount
            // 
            this.labelWoodAmount.AutoSize = true;
            this.labelWoodAmount.Location = new System.Drawing.Point(309, 26);
            this.labelWoodAmount.Name = "labelWoodAmount";
            this.labelWoodAmount.Size = new System.Drawing.Size(13, 13);
            this.labelWoodAmount.TabIndex = 5;
            this.labelWoodAmount.Text = "0";
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGold.Image")));
            this.pictureBoxGold.Location = new System.Drawing.Point(389, 8);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGold.TabIndex = 4;
            this.pictureBoxGold.TabStop = false;
            // 
            // labelGoldAmount
            // 
            this.labelGoldAmount.AutoSize = true;
            this.labelGoldAmount.Location = new System.Drawing.Point(426, 26);
            this.labelGoldAmount.Name = "labelGoldAmount";
            this.labelGoldAmount.Size = new System.Drawing.Size(13, 13);
            this.labelGoldAmount.TabIndex = 5;
            this.labelGoldAmount.Text = "0";
            // 
            // pictureBoxPeople
            // 
            this.pictureBoxPeople.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPeople.Image")));
            this.pictureBoxPeople.Location = new System.Drawing.Point(502, 8);
            this.pictureBoxPeople.Name = "pictureBoxPeople";
            this.pictureBoxPeople.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPeople.TabIndex = 4;
            this.pictureBoxPeople.TabStop = false;
            // 
            // labelPeopleAmount
            // 
            this.labelPeopleAmount.AutoSize = true;
            this.labelPeopleAmount.Location = new System.Drawing.Point(539, 26);
            this.labelPeopleAmount.Name = "labelPeopleAmount";
            this.labelPeopleAmount.Size = new System.Drawing.Size(13, 13);
            this.labelPeopleAmount.TabIndex = 5;
            this.labelPeopleAmount.Text = "0";
            // 
            // pictureBoxWarriors
            // 
            this.pictureBoxWarriors.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarriors.Image")));
            this.pictureBoxWarriors.Location = new System.Drawing.Point(608, 8);
            this.pictureBoxWarriors.Name = "pictureBoxWarriors";
            this.pictureBoxWarriors.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxWarriors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWarriors.TabIndex = 4;
            this.pictureBoxWarriors.TabStop = false;
            // 
            // labelWarriorsAmount
            // 
            this.labelWarriorsAmount.AutoSize = true;
            this.labelWarriorsAmount.Location = new System.Drawing.Point(645, 26);
            this.labelWarriorsAmount.Name = "labelWarriorsAmount";
            this.labelWarriorsAmount.Size = new System.Drawing.Size(13, 13);
            this.labelWarriorsAmount.TabIndex = 5;
            this.labelWarriorsAmount.Text = "0";
            // 
            // timerFPS
            // 
            this.timerFPS.Tick += new System.EventHandler(this.timerFPS_Tick);
            // 
            // pictureBoxCalendar
            // 
            this.pictureBoxCalendar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCalendar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCalendar.Image")));
            this.pictureBoxCalendar.Location = new System.Drawing.Point(57, 4);
            this.pictureBoxCalendar.Name = "pictureBoxCalendar";
            this.pictureBoxCalendar.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCalendar.TabIndex = 4;
            this.pictureBoxCalendar.TabStop = false;
            // 
            // labelDayNumber
            // 
            this.labelDayNumber.AutoSize = true;
            this.labelDayNumber.Location = new System.Drawing.Point(99, 26);
            this.labelDayNumber.Name = "labelDayNumber";
            this.labelDayNumber.Size = new System.Drawing.Size(13, 13);
            this.labelDayNumber.TabIndex = 5;
            this.labelDayNumber.Text = "0";
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(989, 102);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(95, 32);
            this.buttonMap.TabIndex = 6;
            this.buttonMap.Text = "Mapa";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KacperStudennyZadanieDomoweLab1.Properties.Resources.Village_small;
            this.ClientSize = new System.Drawing.Size(1157, 538);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.labelWarriorsAmount);
            this.Controls.Add(this.pictureBoxWarriors);
            this.Controls.Add(this.labelPeopleAmount);
            this.Controls.Add(this.pictureBoxPeople);
            this.Controls.Add(this.labelGoldAmount);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.labelWoodAmount);
            this.Controls.Add(this.pictureBoxWood);
            this.Controls.Add(this.labelDayNumber);
            this.Controls.Add(this.labelSteelAmount);
            this.Controls.Add(this.pictureBoxCalendar);
            this.Controls.Add(this.pictureBoxSteel);
            this.Controls.Add(this.buttonWoodcutter);
            this.Controls.Add(this.buttonFarm);
            this.Controls.Add(this.buttonCastle);
            this.Controls.Add(this.buttonSteelMine);
            this.Controls.Add(this.buttonBarracks);
            this.Controls.Add(this.pictureBoxMenuBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarriors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMenuBoard;
        private System.Windows.Forms.Button buttonBarracks;
        private System.Windows.Forms.Button buttonSteelMine;
        private System.Windows.Forms.Button buttonFarm;
        private System.Windows.Forms.Button buttonWoodcutter;
        private System.Windows.Forms.Button buttonCastle;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxSteel;
        private System.Windows.Forms.Label labelSteelAmount;
        private System.Windows.Forms.PictureBox pictureBoxWood;
        private System.Windows.Forms.Label labelWoodAmount;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.Label labelGoldAmount;
        private System.Windows.Forms.PictureBox pictureBoxPeople;
        private System.Windows.Forms.Label labelPeopleAmount;
        private System.Windows.Forms.PictureBox pictureBoxWarriors;
        private System.Windows.Forms.Label labelWarriorsAmount;
        private System.Windows.Forms.Timer timerFPS;
        private System.Windows.Forms.PictureBox pictureBoxCalendar;
        private System.Windows.Forms.Label labelDayNumber;
        private System.Windows.Forms.Button buttonMap;
    }
}

