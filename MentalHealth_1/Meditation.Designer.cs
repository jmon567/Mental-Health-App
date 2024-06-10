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
            button_types = new Button();
            button_audio = new Button();
            button_facts = new Button();
            button1 = new Button();
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
            button_poses.Location = new Point(86, 300);
            button_poses.Name = "button_poses";
            button_poses.Size = new Size(236, 79);
            button_poses.TabIndex = 1;
            button_poses.Text = "Meditation Poses";
            button_poses.UseVisualStyleBackColor = true;
            // 
            // button_types
            // 
            button_types.Location = new Point(882, 294);
            button_types.Name = "button_types";
            button_types.Size = new Size(198, 85);
            button_types.TabIndex = 2;
            button_types.Text = "Meditation Types";
            button_types.UseVisualStyleBackColor = true;
            // 
            // button_audio
            // 
            button_audio.Location = new Point(471, 178);
            button_audio.Name = "button_audio";
            button_audio.Size = new Size(203, 106);
            button_audio.TabIndex = 3;
            button_audio.Text = "Meditation Audio";
            button_audio.UseVisualStyleBackColor = true;
            // 
            // button_facts
            // 
            button_facts.Location = new Point(471, 456);
            button_facts.Name = "button_facts";
            button_facts.Size = new Size(203, 104);
            button_facts.TabIndex = 4;
            button_facts.Text = "More about Meditation";
            button_facts.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 742);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Meditation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 818);
            Controls.Add(button1);
            Controls.Add(button_facts);
            Controls.Add(button_audio);
            Controls.Add(button_types);
            Controls.Add(button_poses);
            Controls.Add(richTextBox1);
            Name = "Meditation";
            Text = "Meditation";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_poses;
        private Button button_types;
        private Button button_audio;
        private Button button_facts;
        private Button button1;
    }
}