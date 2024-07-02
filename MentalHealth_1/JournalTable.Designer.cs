namespace MentalHealth_1
{
    partial class JournalTable
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
            journalentryBindingSource = new BindingSource(components);
            journalData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)journalentryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)journalData).BeginInit();
            SuspendLayout();
            // 
            // journalentryBindingSource
            // 
            journalentryBindingSource.DataSource = typeof(journalentry);
            // 
            // journalData
            // 
            journalData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            journalData.Dock = DockStyle.Fill;
            journalData.Location = new Point(0, 0);
            journalData.Name = "journalData";
            journalData.RowHeadersWidth = 51;
            journalData.Size = new Size(1071, 450);
            journalData.TabIndex = 0;
            // 
            // JournalTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 450);
            Controls.Add(journalData);
            Name = "JournalTable";
            Text = "Journal Table";
            ((System.ComponentModel.ISupportInitialize)journalentryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)journalData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource journalentryBindingSource;
        private DataGridView journalData;
    }
}