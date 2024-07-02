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
            button_save = new Button();
            button_clear = new Button();
            PriviousEntries = new Button();
            textBox_username = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBox_journal
            // 
            richTextBox_journal.Location = new Point(38, 118);
            richTextBox_journal.Margin = new Padding(2);
            richTextBox_journal.Name = "richTextBox_journal";
            richTextBox_journal.Size = new Size(610, 133);
            richTextBox_journal.TabIndex = 0;
            richTextBox_journal.Text = "";
            // 
            // button_save
            // 
            button_save.Location = new Point(82, 269);
            button_save.Margin = new Padding(2);
            button_save.Name = "button_save";
            button_save.Size = new Size(92, 29);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(526, 269);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 3;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // PriviousEntries
            // 
            PriviousEntries.Location = new Point(254, 269);
            PriviousEntries.Name = "PriviousEntries";
            PriviousEntries.Size = new Size(173, 29);
            PriviousEntries.TabIndex = 4;
            PriviousEntries.Text = "See Previous Entries";
            PriviousEntries.UseVisualStyleBackColor = true;
            PriviousEntries.Click += PriviousEntries_Click;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(267, 62);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(125, 27);
            textBox_username.TabIndex = 6;
            // 
            // label2
            // 
            label2.Location = new Point(292, 23);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // Form_Journal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 389);
            Controls.Add(label2);
            Controls.Add(textBox_username);
            Controls.Add(PriviousEntries);
            Controls.Add(button_clear);
            Controls.Add(button_save);
            Controls.Add(richTextBox_journal);
            Margin = new Padding(2);
            Name = "Form_Journal";
            Text = "Journal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_journal;
        private Button button_save;
        private Button button_clear;
        private Button PriviousEntries;
        private TextBox textBox_username;
        private Label label2;
    }
}