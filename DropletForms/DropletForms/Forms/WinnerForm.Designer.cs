namespace DropletForms.Forms
{
    partial class WinnerForm
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
            pictureBox1 = new PictureBox();
            WinnerTextLabel = new Label();
            BestRatedLabel = new Label();
            WinnerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(90, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 464);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // WinnerTextLabel
            // 
            WinnerTextLabel.AutoSize = true;
            WinnerTextLabel.Font = new Font("Segoe UI", 12F);
            WinnerTextLabel.Location = new Point(304, 86);
            WinnerTextLabel.Name = "WinnerTextLabel";
            WinnerTextLabel.Size = new Size(268, 28);
            WinnerTextLabel.TabIndex = 4;
            WinnerTextLabel.Text = "The most beautiful country is:";
            // 
            // BestRatedLabel
            // 
            BestRatedLabel.AutoSize = true;
            BestRatedLabel.Font = new Font("Segoe UI", 12F);
            BestRatedLabel.Location = new Point(330, 280);
            BestRatedLabel.Name = "BestRatedLabel";
            BestRatedLabel.Size = new Size(217, 28);
            BestRatedLabel.TabIndex = 6;
            BestRatedLabel.Text = "The best rated image is:";
            // 
            // WinnerLabel
            // 
            WinnerLabel.AutoSize = true;
            WinnerLabel.Font = new Font("Segoe UI", 18F);
            WinnerLabel.Location = new Point(345, 182);
            WinnerLabel.Name = "WinnerLabel";
            WinnerLabel.Size = new Size(0, 41);
            WinnerLabel.TabIndex = 7;
            WinnerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 904);
            Controls.Add(WinnerLabel);
            Controls.Add(BestRatedLabel);
            Controls.Add(WinnerTextLabel);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label WinnerTextLabel;
        private Label BestRatedLabel;
        private Label WinnerLabel;
    }
}