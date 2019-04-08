namespace KacperStudennyZadanieDomoweLab1
{
    partial class FormResources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResources));
            this.labelCurrentLevelDescription = new System.Windows.Forms.Label();
            this.labelCurrentLevel = new System.Windows.Forms.Label();
            this.labelCurrentProductionDescription = new System.Windows.Forms.Label();
            this.labelCurrentProduction = new System.Windows.Forms.Label();
            this.labelCurrentBuildingCostDescription = new System.Windows.Forms.Label();
            this.labelCurrentBuildingCost = new System.Windows.Forms.Label();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentLevelDescription
            // 
            this.labelCurrentLevelDescription.AutoSize = true;
            this.labelCurrentLevelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentLevelDescription.ForeColor = System.Drawing.Color.White;
            this.labelCurrentLevelDescription.Location = new System.Drawing.Point(34, 33);
            this.labelCurrentLevelDescription.Name = "labelCurrentLevelDescription";
            this.labelCurrentLevelDescription.Size = new System.Drawing.Size(128, 13);
            this.labelCurrentLevelDescription.TabIndex = 1;
            this.labelCurrentLevelDescription.Text = "Obecny Poziom budynku:";
            // 
            // labelCurrentLevel
            // 
            this.labelCurrentLevel.AutoSize = true;
            this.labelCurrentLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentLevel.ForeColor = System.Drawing.Color.White;
            this.labelCurrentLevel.Location = new System.Drawing.Point(168, 33);
            this.labelCurrentLevel.Name = "labelCurrentLevel";
            this.labelCurrentLevel.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentLevel.TabIndex = 1;
            this.labelCurrentLevel.Text = "0";
            // 
            // labelCurrentProductionDescription
            // 
            this.labelCurrentProductionDescription.AutoSize = true;
            this.labelCurrentProductionDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentProductionDescription.ForeColor = System.Drawing.Color.White;
            this.labelCurrentProductionDescription.Location = new System.Drawing.Point(34, 58);
            this.labelCurrentProductionDescription.Name = "labelCurrentProductionDescription";
            this.labelCurrentProductionDescription.Size = new System.Drawing.Size(119, 26);
            this.labelCurrentProductionDescription.TabIndex = 1;
            this.labelCurrentProductionDescription.Text = "Obecnie produkowana \r\nilość zasobów na dzień:";
            // 
            // labelCurrentProduction
            // 
            this.labelCurrentProduction.AutoSize = true;
            this.labelCurrentProduction.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentProduction.ForeColor = System.Drawing.Color.White;
            this.labelCurrentProduction.Location = new System.Drawing.Point(168, 71);
            this.labelCurrentProduction.Name = "labelCurrentProduction";
            this.labelCurrentProduction.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentProduction.TabIndex = 1;
            this.labelCurrentProduction.Text = "0";
            // 
            // labelCurrentBuildingCostDescription
            // 
            this.labelCurrentBuildingCostDescription.AutoSize = true;
            this.labelCurrentBuildingCostDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentBuildingCostDescription.ForeColor = System.Drawing.Color.White;
            this.labelCurrentBuildingCostDescription.Location = new System.Drawing.Point(34, 100);
            this.labelCurrentBuildingCostDescription.Name = "labelCurrentBuildingCostDescription";
            this.labelCurrentBuildingCostDescription.Size = new System.Drawing.Size(136, 26);
            this.labelCurrentBuildingCostDescription.TabIndex = 1;
            this.labelCurrentBuildingCostDescription.Text = "Zaprotrzebowanie każdego\r\nz zasobów na rozbudowę:";
            // 
            // labelCurrentBuildingCost
            // 
            this.labelCurrentBuildingCost.AutoSize = true;
            this.labelCurrentBuildingCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentBuildingCost.ForeColor = System.Drawing.Color.White;
            this.labelCurrentBuildingCost.Location = new System.Drawing.Point(168, 113);
            this.labelCurrentBuildingCost.Name = "labelCurrentBuildingCost";
            this.labelCurrentBuildingCost.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentBuildingCost.TabIndex = 1;
            this.labelCurrentBuildingCost.Text = "0";
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(78, 153);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(75, 37);
            this.buttonBuild.TabIndex = 2;
            this.buttonBuild.Text = "Rozbuduj";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // FormResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.labelCurrentLevel);
            this.Controls.Add(this.labelCurrentBuildingCost);
            this.Controls.Add(this.labelCurrentProduction);
            this.Controls.Add(this.labelCurrentBuildingCostDescription);
            this.Controls.Add(this.labelCurrentProductionDescription);
            this.Controls.Add(this.labelCurrentLevelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormResources";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResources";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentLevelDescription;
        private System.Windows.Forms.Label labelCurrentLevel;
        private System.Windows.Forms.Label labelCurrentProductionDescription;
        private System.Windows.Forms.Label labelCurrentProduction;
        private System.Windows.Forms.Label labelCurrentBuildingCostDescription;
        private System.Windows.Forms.Label labelCurrentBuildingCost;
        private System.Windows.Forms.Button buttonBuild;
    }
}