namespace MentalHealth_1
{
    partial class Meditation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meditation));
            richTextBox1 = new RichTextBox();
            button_poses = new Button();
            button_audio = new Button();
            button_facts = new Button();
            button_dashboard = new Button();
            pictureBox_Front = new PictureBox();
            pictureBox_Poses = new PictureBox();
            richTextBox_Facts = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Front).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Poses).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1265, 140);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button_poses
            // 
            button_poses.Location = new Point(39, 198);
            button_poses.Name = "button_poses";
            button_poses.Size = new Size(217, 79);
            button_poses.TabIndex = 1;
            button_poses.Text = "Meditation Poses";
            button_poses.UseVisualStyleBackColor = true;
            button_poses.Click += button_poses_Click;
            // 
            // button_audio
            // 
            button_audio.Location = new Point(39, 361);
            button_audio.Name = "button_audio";
            button_audio.Size = new Size(203, 80);
            button_audio.TabIndex = 3;
            button_audio.Text = "Meditation Audio";
            button_audio.UseVisualStyleBackColor = true;
            button_audio.Click += button_audio_Click;
            // 
            // button_facts
            // 
            button_facts.Location = new Point(39, 536);
            button_facts.Name = "button_facts";
            button_facts.Size = new Size(203, 104);
            button_facts.TabIndex = 4;
            button_facts.Text = "More about Meditation";
            button_facts.UseVisualStyleBackColor = true;
            button_facts.Click += button_facts_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.Location = new Point(39, 742);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(283, 46);
            button_dashboard.TabIndex = 5;
            button_dashboard.Text = "Return to Dashboard";
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // pictureBox_Front
            // 
            pictureBox_Front.Image = Properties.Resources.meditationpic;
            pictureBox_Front.Location = new Point(500, 218);
            pictureBox_Front.Name = "pictureBox_Front";
            pictureBox_Front.Size = new Size(648, 531);
            pictureBox_Front.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Front.TabIndex = 6;
            pictureBox_Front.TabStop = false;
            // 
            // pictureBox_Poses
            // 
            pictureBox_Poses.Image = Properties.Resources.Meditation_Postures;
            pictureBox_Poses.Location = new Point(438, 188);
            pictureBox_Poses.Name = "pictureBox_Poses";
            pictureBox_Poses.Size = new Size(796, 625);
            pictureBox_Poses.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Poses.TabIndex = 7;
            pictureBox_Poses.TabStop = false;
            pictureBox_Poses.Visible = false;
            // 
            // richTextBox_Facts
            // 
            richTextBox_Facts.Location = new Point(346, 257);
            richTextBox_Facts.Name = "richTextBox_Facts";
            richTextBox_Facts.Size = new Size(985, 461);
            richTextBox_Facts.TabIndex = 8;
            richTextBox_Facts.Text = resources.GetString("richTextBox_Facts.Text");
            richTextBox_Facts.Visible = false;
            // 
            // Meditation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 992);
            Controls.Add(richTextBox_Facts);
            Controls.Add(pictureBox_Poses);
            Controls.Add(pictureBox_Front);
            Controls.Add(button_dashboard);
            Controls.Add(button_facts);
            Controls.Add(button_audio);
            Controls.Add(button_poses);
            Controls.Add(richTextBox1);
            Name = "Meditation";
            Text = "Meditation";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Front).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Poses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_poses;
        private Button button_audio;
        private Button button_facts;
        private Button button_dashboard;
        private PictureBox pictureBox_Front;
        private PictureBox pictureBox_Poses;
        private RichTextBox richTextBox_Facts;
    }
}