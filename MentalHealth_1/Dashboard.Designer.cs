namespace MentalHealth_1
{
    partial class Dashboard
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
            pictureBox_journal = new PictureBox();
            pictureBox_meditation = new PictureBox();
            pictureBox_mood = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_journal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_meditation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_journal
            // 
            pictureBox_journal.Image = Properties.Resources.Journal;
            pictureBox_journal.Location = new Point(193, 86);
            pictureBox_journal.Name = "pictureBox_journal";
            pictureBox_journal.Size = new Size(257, 245);
            pictureBox_journal.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_journal.TabIndex = 0;
            pictureBox_journal.TabStop = false;
            // 
            // pictureBox_meditation
            // 
            pictureBox_meditation.Image = Properties.Resources.meditation;
            pictureBox_meditation.Location = new Point(878, 86);
            pictureBox_meditation.Name = "pictureBox_meditation";
            pictureBox_meditation.Size = new Size(286, 260);
            pictureBox_meditation.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_meditation.TabIndex = 1;
            pictureBox_meditation.TabStop = false;
            // 
            // pictureBox_mood
            // 
            pictureBox_mood.Image = Properties.Resources.mood;
            pictureBox_mood.Location = new Point(171, 492);
            pictureBox_mood.Name = "pictureBox_mood";
            pictureBox_mood.Size = new Size(303, 243);
            pictureBox_mood.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_mood.TabIndex = 2;
            pictureBox_mood.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.habit;
            pictureBox4.Location = new Point(878, 492);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(286, 243);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 833);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox_mood);
            Controls.Add(pictureBox_meditation);
            Controls.Add(pictureBox_journal);
            Name = "Dashboard";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox_journal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_meditation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_journal;
        private PictureBox pictureBox_meditation;
        private PictureBox pictureBox_mood;
        private PictureBox pictureBox4;
    }
}