namespace DropletForms
{
    partial class AddImageForm
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
            LocationTextBox = new TextBox();
            LocationLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            SelectPathButton = new Button();
            FilepathLabel = new Label();
            FilepathTextBox = new TextBox();
            AddImageButton = new Button();
            HeadlineLabel = new Label();
            SuspendLayout();
            // 
            // LocationTextBox
            // 
            LocationTextBox.Font = new Font("Segoe UI", 12F);
            LocationTextBox.Location = new Point(142, 131);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(125, 34);
            LocationTextBox.TabIndex = 0;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Segoe UI", 12F);
            LocationLabel.Location = new Point(37, 134);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(87, 28);
            LocationLabel.TabIndex = 1;
            LocationLabel.Text = "Location";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F);
            NameLabel.Location = new Point(37, 80);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 28);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 12F);
            NameTextBox.Location = new Point(142, 77);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 34);
            NameTextBox.TabIndex = 2;
            // 
            // SelectPathButton
            // 
            SelectPathButton.Font = new Font("Segoe UI", 12F);
            SelectPathButton.Location = new Point(273, 187);
            SelectPathButton.Name = "SelectPathButton";
            SelectPathButton.Size = new Size(40, 34);
            SelectPathButton.TabIndex = 4;
            SelectPathButton.Text = "...";
            SelectPathButton.UseVisualStyleBackColor = true;
            SelectPathButton.Click += SelectPathButton_Click;
            // 
            // FilepathLabel
            // 
            FilepathLabel.AutoSize = true;
            FilepathLabel.Font = new Font("Segoe UI", 12F);
            FilepathLabel.Location = new Point(37, 190);
            FilepathLabel.Name = "FilepathLabel";
            FilepathLabel.Size = new Size(82, 28);
            FilepathLabel.TabIndex = 6;
            FilepathLabel.Text = "Filepath";
            // 
            // FilepathTextBox
            // 
            FilepathTextBox.Font = new Font("Segoe UI", 12F);
            FilepathTextBox.Location = new Point(142, 187);
            FilepathTextBox.Name = "FilepathTextBox";
            FilepathTextBox.Size = new Size(125, 34);
            FilepathTextBox.TabIndex = 5;
            // 
            // AddImageButton
            // 
            AddImageButton.Font = new Font("Segoe UI", 12F);
            AddImageButton.Location = new Point(127, 263);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(140, 50);
            AddImageButton.TabIndex = 7;
            AddImageButton.Text = "Add Image";
            AddImageButton.UseVisualStyleBackColor = true;
            AddImageButton.Click += AddImageButton_Click;
            // 
            // HeadlineLabel
            // 
            HeadlineLabel.AutoSize = true;
            HeadlineLabel.Font = new Font("Segoe UI", 16F);
            HeadlineLabel.Location = new Point(120, 23);
            HeadlineLabel.Name = "HeadlineLabel";
            HeadlineLabel.Size = new Size(147, 37);
            HeadlineLabel.TabIndex = 8;
            HeadlineLabel.Text = "Add Image";
            // 
            // AddImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 365);
            Controls.Add(HeadlineLabel);
            Controls.Add(AddImageButton);
            Controls.Add(FilepathLabel);
            Controls.Add(FilepathTextBox);
            Controls.Add(SelectPathButton);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(LocationLabel);
            Controls.Add(LocationTextBox);
            Name = "AddImageForm";
            Text = "AddImageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LocationTextBox;
        private Label LocationLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button SelectPathButton;
        private Label FilepathLabel;
        private TextBox FilepathTextBox;
        private Button AddImageButton;
        private Label HeadlineLabel;
    }
}