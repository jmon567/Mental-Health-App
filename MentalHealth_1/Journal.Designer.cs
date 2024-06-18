namespace MentalHealth_1
{
    partial class Form_Journal
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
            richTextBox_journal = new RichTextBox();
            button_load = new Button();
            button_save = new Button();
            SuspendLayout();
            // 
            // richTextBox_journal
            // 
            richTextBox_journal.Location = new Point(46, 35);
            richTextBox_journal.Name = "richTextBox_journal";
            richTextBox_journal.Size = new Size(988, 210);
            richTextBox_journal.TabIndex = 0;
            richTextBox_journal.Text = "";
            // 
            // button_load
            // 
            button_load.Location = new Point(229, 406);
            button_load.Name = "button_load";
            button_load.Size = new Size(150, 46);
            button_load.TabIndex = 1;
            button_load.Text = "Load";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += button_load_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(574, 406);
            button_save.Name = "button_save";
            button_save.Size = new Size(150, 46);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // Form_Journal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 623);
            Controls.Add(button_save);
            Controls.Add(button_load);
            Controls.Add(richTextBox_journal);
            Name = "Form_Journal";
            Text = "Journal";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_journal;
        private Button button_load;
        private Button button_save;
    }
}