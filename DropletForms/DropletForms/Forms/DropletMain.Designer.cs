namespace DropletForms
{
    partial class DropletMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropletMain));
            AddImageButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            StartRatingButton = new Button();
            ShowWinnerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // AddImageButton
            // 
            AddImageButton.BackColor = Color.White;
            AddImageButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            AddImageButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            AddImageButton.ForeColor = SystemColors.ControlText;
            AddImageButton.Location = new Point(43, 92);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(161, 80);
            AddImageButton.TabIndex = 0;
            AddImageButton.Text = "Add Image";
            AddImageButton.UseVisualStyleBackColor = false;
            AddImageButton.Click += AddImageButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(275, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 464);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1010, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(696, 464);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(275, 592);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(696, 464);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(1010, 592);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(696, 464);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // StartRatingButton
            // 
            StartRatingButton.BackColor = Color.White;
            StartRatingButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            StartRatingButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            StartRatingButton.ForeColor = SystemColors.ControlText;
            StartRatingButton.Location = new Point(43, 194);
            StartRatingButton.Name = "StartRatingButton";
            StartRatingButton.Size = new Size(161, 80);
            StartRatingButton.TabIndex = 5;
            StartRatingButton.Text = "Start Rating";
            StartRatingButton.UseVisualStyleBackColor = false;
            StartRatingButton.Click += this.StartRatingButton_Click;
            // 
            // ShowWinnerButton
            // 
            ShowWinnerButton.BackColor = Color.White;
            ShowWinnerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            ShowWinnerButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            ShowWinnerButton.ForeColor = SystemColors.ControlText;
            ShowWinnerButton.Location = new Point(43, 295);
            ShowWinnerButton.Name = "ShowWinnerButton";
            ShowWinnerButton.Size = new Size(161, 80);
            ShowWinnerButton.TabIndex = 6;
            ShowWinnerButton.Text = "Show Winner";
            ShowWinnerButton.UseVisualStyleBackColor = false;
            ShowWinnerButton.Click += this.ShowWinnerButton_Click;
            // 
            // DropletMain
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1748, 1101);
            Controls.Add(ShowWinnerButton);
            Controls.Add(StartRatingButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(AddImageButton);
            Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "DropletMain";
            Text = "Droplet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddImageButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button StartRatingButton;
        private Button ShowWinnerButton;
    }
}
