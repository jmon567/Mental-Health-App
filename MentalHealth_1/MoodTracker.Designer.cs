namespace MentalHealth_1
{
    partial class MoodTracker
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
            label_instructions = new Label();
            label_Happy = new Label();
            label_Motivation = new Label();
            label_depression = new Label();
            label_anxiety = new Label();
            label_content = new Label();
            label_Anxious = new Label();
            button_dashboard = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            button_save = new Button();
            pictureBox_mood = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mood).BeginInit();
            SuspendLayout();
            // 
            // label_instructions
            // 
            label_instructions.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_instructions.Location = new Point(67, 21);
            label_instructions.Name = "label_instructions";
            label_instructions.Size = new Size(1085, 93);
            label_instructions.TabIndex = 0;
            label_instructions.Text = "Rate the intensity of each feeling. (It's best to do this daily as a mindfullnes excersice). 5 being very intense. 1 being least intense.";
            // 
            // label_Happy
            // 
            label_Happy.AutoSize = true;
            label_Happy.Location = new Point(90, 177);
            label_Happy.Name = "label_Happy";
            label_Happy.Size = new Size(206, 32);
            label_Happy.TabIndex = 1;
            label_Happy.Text = "Overall Happiness";
            // 
            // label_Motivation
            // 
            label_Motivation.AutoSize = true;
            label_Motivation.Location = new Point(90, 263);
            label_Motivation.Name = "label_Motivation";
            label_Motivation.Size = new Size(192, 32);
            label_Motivation.TabIndex = 2;
            label_Motivation.Text = "Motivation Level";
            // 
            // label_depression
            // 
            label_depression.AutoSize = true;
            label_depression.Location = new Point(90, 347);
            label_depression.Name = "label_depression";
            label_depression.Size = new Size(195, 32);
            label_depression.TabIndex = 3;
            label_depression.Text = "Depression Level";
            // 
            // label_anxiety
            // 
            label_anxiety.AutoSize = true;
            label_anxiety.Location = new Point(90, 431);
            label_anxiety.Name = "label_anxiety";
            label_anxiety.Size = new Size(0, 32);
            label_anxiety.TabIndex = 4;
            // 
            // label_content
            // 
            label_content.AutoSize = true;
            label_content.Location = new Point(90, 529);
            label_content.Name = "label_content";
            label_content.Size = new Size(232, 32);
            label_content.TabIndex = 5;
            label_content.Text = "Content/Peace Level";
            // 
            // label_Anxious
            // 
            label_Anxious.AutoSize = true;
            label_Anxious.Location = new Point(90, 431);
            label_Anxious.Name = "label_Anxious";
            label_Anxious.Size = new Size(155, 32);
            label_Anxious.TabIndex = 6;
            label_Anxious.Text = "Anxiety Level";
            // 
            // button_dashboard
            // 
            button_dashboard.Location = new Point(801, 601);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(272, 46);
            button_dashboard.TabIndex = 7;
            button_dashboard.Text = "Return to Dashboard";
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(442, 175);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 39);
            numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(442, 261);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(78, 39);
            numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(442, 340);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(78, 39);
            numericUpDown3.TabIndex = 10;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(442, 431);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(78, 39);
            numericUpDown4.TabIndex = 11;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(442, 522);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(78, 39);
            numericUpDown5.TabIndex = 12;
            // 
            // button_save
            // 
            button_save.Location = new Point(172, 601);
            button_save.Name = "button_save";
            button_save.Size = new Size(226, 46);
            button_save.TabIndex = 13;
            button_save.Text = "Save Answers";
            button_save.UseVisualStyleBackColor = true;
            // 
            // pictureBox_mood
            // 
            pictureBox_mood.Image = Properties.Resources.mood;
            pictureBox_mood.Location = new Point(697, 141);
            pictureBox_mood.Name = "pictureBox_mood";
            pictureBox_mood.Size = new Size(471, 408);
            pictureBox_mood.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_mood.TabIndex = 14;
            pictureBox_mood.TabStop = false;
            // 
            // MoodTracker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 692);
            Controls.Add(pictureBox_mood);
            Controls.Add(button_save);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button_dashboard);
            Controls.Add(label_Anxious);
            Controls.Add(label_content);
            Controls.Add(label_anxiety);
            Controls.Add(label_depression);
            Controls.Add(label_Motivation);
            Controls.Add(label_Happy);
            Controls.Add(label_instructions);
            Name = "MoodTracker";
            Text = "Mood Tracker";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_instructions;
        private Label label_Happy;
        private Label label_Motivation;
        private Label label_depression;
        private Label label_anxiety;
        private Label label_content;
        private Label label_Anxious;
        private Button button_dashboard;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private Button button_save;
        private PictureBox pictureBox_mood;
    }
}