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
            components = new System.ComponentModel.Container();
            label_instructions = new Label();
            label_Happy = new Label();
            label_Motivation = new Label();
            label_depression = new Label();
            label_anxiety = new Label();
            label_content = new Label();
            label_Anxious = new Label();
            button_dashboard = new Button();
            numericUpDown_Happiness = new NumericUpDown();
            numericUpDown_motivation = new NumericUpDown();
            numericUpDown_depression = new NumericUpDown();
            numericUpDown_anxiety = new NumericUpDown();
            numericUpDown_peace = new NumericUpDown();
            button_save = new Button();
            pictureBox_mood = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Happiness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_motivation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_depression).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_anxiety).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_peace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label_instructions
            // 
            label_instructions.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_instructions.Location = new Point(67, 21);
            label_instructions.Name = "label_instructions";
            label_instructions.Size = new Size(1085, 93);
            label_instructions.TabIndex = 0;
            label_instructions.Text = "Rate the intensity of each feeling. (It's best to do this daily as a mindfullnes excersice). 5 being very intense. 0 being least intense.";
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
            // numericUpDown_Happiness
            // 
            numericUpDown_Happiness.Location = new Point(442, 175);
            numericUpDown_Happiness.Name = "numericUpDown_Happiness";
            numericUpDown_Happiness.Size = new Size(78, 39);
            numericUpDown_Happiness.TabIndex = 8;
            numericUpDown_Happiness.Validating += numericUpDown_Happiness_Validating;
            // 
            // numericUpDown_motivation
            // 
            numericUpDown_motivation.Location = new Point(442, 261);
            numericUpDown_motivation.Name = "numericUpDown_motivation";
            numericUpDown_motivation.Size = new Size(78, 39);
            numericUpDown_motivation.TabIndex = 9;
            numericUpDown_motivation.Validating += numericUpDown_motivation_Validating;
            // 
            // numericUpDown_depression
            // 
            numericUpDown_depression.BackColor = SystemColors.ControlLightLight;
            numericUpDown_depression.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown_depression.Location = new Point(442, 340);
            numericUpDown_depression.Name = "numericUpDown_depression";
            numericUpDown_depression.Size = new Size(78, 39);
            numericUpDown_depression.TabIndex = 10;
            numericUpDown_depression.Validating += numericUpDown_depression_Validating;
            // 
            // numericUpDown_anxiety
            // 
            numericUpDown_anxiety.Location = new Point(442, 431);
            numericUpDown_anxiety.Name = "numericUpDown_anxiety";
            numericUpDown_anxiety.Size = new Size(78, 39);
            numericUpDown_anxiety.TabIndex = 11;
            numericUpDown_anxiety.Validating += numericUpDown_anxiety_Validating;
            // 
            // numericUpDown_peace
            // 
            numericUpDown_peace.Location = new Point(442, 522);
            numericUpDown_peace.Name = "numericUpDown_peace";
            numericUpDown_peace.Size = new Size(78, 39);
            numericUpDown_peace.TabIndex = 12;
            numericUpDown_peace.Validating += numericUpDown_peace_Validating;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MoodTracker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 692);
            Controls.Add(pictureBox_mood);
            Controls.Add(button_save);
            Controls.Add(numericUpDown_peace);
            Controls.Add(numericUpDown_anxiety);
            Controls.Add(numericUpDown_depression);
            Controls.Add(numericUpDown_motivation);
            Controls.Add(numericUpDown_Happiness);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Happiness).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_motivation).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_depression).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_anxiety).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_peace).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_mood).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private NumericUpDown numericUpDown_Happiness;
        private NumericUpDown numericUpDown_motivation;
        private NumericUpDown numericUpDown_depression;
        private NumericUpDown numericUpDown_anxiety;
        private NumericUpDown numericUpDown_peace;
        private Button button_save;
        private PictureBox pictureBox_mood;
        private ErrorProvider errorProvider1;
    }
}