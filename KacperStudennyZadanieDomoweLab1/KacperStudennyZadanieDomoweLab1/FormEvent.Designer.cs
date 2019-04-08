namespace KacperStudennyZadanieDomoweLab1
{
    partial class FormEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvent));
            this.pictureBoxLetter = new System.Windows.Forms.PictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLetter
            // 
            this.pictureBoxLetter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLetter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLetter.BackgroundImage")));
            this.pictureBoxLetter.Location = new System.Drawing.Point(2, 3);
            this.pictureBoxLetter.Name = "pictureBoxLetter";
            this.pictureBoxLetter.Size = new System.Drawing.Size(360, 456);
            this.pictureBoxLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLetter.TabIndex = 0;
            this.pictureBoxLetter.TabStop = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Location = new System.Drawing.Point(47, 85);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(63, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Wiadomość";
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(368, 539);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBoxLetter);
            this.Name = "FormEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEvent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLetter;
        private System.Windows.Forms.Label labelMessage;
    }
}