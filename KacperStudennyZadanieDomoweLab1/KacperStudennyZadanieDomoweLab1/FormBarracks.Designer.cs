namespace KacperStudennyZadanieDomoweLab1
{
    partial class FormBarracks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarracks));
            this.labelSoldiersNumberDescription = new System.Windows.Forms.Label();
            this.textBoxRecrutingSoldierNumber = new System.Windows.Forms.TextBox();
            this.labelSoldiersNumber = new System.Windows.Forms.Label();
            this.buttonRecruit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSoldiersNumberDescription
            // 
            this.labelSoldiersNumberDescription.AutoSize = true;
            this.labelSoldiersNumberDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelSoldiersNumberDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSoldiersNumberDescription.Location = new System.Drawing.Point(40, 48);
            this.labelSoldiersNumberDescription.Name = "labelSoldiersNumberDescription";
            this.labelSoldiersNumberDescription.Size = new System.Drawing.Size(169, 13);
            this.labelSoldiersNumberDescription.TabIndex = 0;
            this.labelSoldiersNumberDescription.Text = "Można zrekrutować maksymalnie: ";
            // 
            // textBoxRecrutingSoldierNumber
            // 
            this.textBoxRecrutingSoldierNumber.Location = new System.Drawing.Point(80, 99);
            this.textBoxRecrutingSoldierNumber.Name = "textBoxRecrutingSoldierNumber";
            this.textBoxRecrutingSoldierNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecrutingSoldierNumber.TabIndex = 1;
            // 
            // labelSoldiersNumber
            // 
            this.labelSoldiersNumber.AutoSize = true;
            this.labelSoldiersNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelSoldiersNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSoldiersNumber.Location = new System.Drawing.Point(121, 73);
            this.labelSoldiersNumber.Name = "labelSoldiersNumber";
            this.labelSoldiersNumber.Size = new System.Drawing.Size(13, 13);
            this.labelSoldiersNumber.TabIndex = 0;
            this.labelSoldiersNumber.Text = "0";
            // 
            // buttonRecruit
            // 
            this.buttonRecruit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecruit.Location = new System.Drawing.Point(90, 146);
            this.buttonRecruit.Name = "buttonRecruit";
            this.buttonRecruit.Size = new System.Drawing.Size(75, 23);
            this.buttonRecruit.TabIndex = 2;
            this.buttonRecruit.Text = "Zrekrutuj";
            this.buttonRecruit.UseVisualStyleBackColor = true;
            this.buttonRecruit.Click += new System.EventHandler(this.buttonRecruit_Click);
            // 
            // FormBarracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(243, 222);
            this.Controls.Add(this.buttonRecruit);
            this.Controls.Add(this.textBoxRecrutingSoldierNumber);
            this.Controls.Add(this.labelSoldiersNumber);
            this.Controls.Add(this.labelSoldiersNumberDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBarracks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarracks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoldiersNumberDescription;
        private System.Windows.Forms.TextBox textBoxRecrutingSoldierNumber;
        private System.Windows.Forms.Label labelSoldiersNumber;
        private System.Windows.Forms.Button buttonRecruit;
    }
}