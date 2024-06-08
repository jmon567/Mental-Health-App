namespace MentalHealth_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_signIn = new Button();
            button_signUp = new Button();
            label_welcome = new Label();
            label_username = new Label();
            label_password = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button_signIn
            // 
            button_signIn.Location = new Point(271, 465);
            button_signIn.Name = "button_signIn";
            button_signIn.Size = new Size(188, 84);
            button_signIn.TabIndex = 0;
            button_signIn.Text = "Sign in";
            button_signIn.UseVisualStyleBackColor = true;
            // 
            // button_signUp
            // 
            button_signUp.Location = new Point(642, 465);
            button_signUp.Name = "button_signUp";
            button_signUp.Size = new Size(201, 84);
            button_signUp.TabIndex = 1;
            button_signUp.Text = "Sign up";
            button_signUp.UseVisualStyleBackColor = true;
            // 
            // label_welcome
            // 
            label_welcome.Location = new Point(251, 69);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(655, 64);
            label_welcome.TabIndex = 2;
            label_welcome.Text = "Welcome friend. Congratulations on taking a step towards managing your mental health(: Please sign-in below.";
            label_welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(237, 214);
            label_username.Name = "label_username";
            label_username.Size = new Size(137, 32);
            label_username.TabIndex = 3;
            label_username.Text = "Username>";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(237, 309);
            label_password.Name = "label_password";
            label_password.Size = new Size(127, 32);
            label_password.TabIndex = 4;
            label_password.Text = "Password>";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(488, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 831);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(label_welcome);
            Controls.Add(button_signUp);
            Controls.Add(button_signIn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_signIn;
        private Button button_signUp;
        private Label label_welcome;
        private Label label_username;
        private Label label_password;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
