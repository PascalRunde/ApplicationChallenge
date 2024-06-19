using DropletForms.RatingCalculation;
using DropletLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropletForms.Forms
{
    //Add a delegate factory, so the main form can invoke the WinnerForm with dependency injection
    public delegate WinnerForm WinnerFormFactory();
    public partial class WinnerForm : Form
    {
        IRatingCalculator ratingCalculator;
        public WinnerForm(IRatingCalculator ratingCalculator)
        {
            this.ratingCalculator = ratingCalculator;
            InitializeComponent();
            ImageModel image = ratingCalculator.GetWinner();
            DisplayWinner(image);
        }

        private void DisplayWinner(ImageModel image)
        {
            WinnerLabel.Text = image.Location;
            pictureBox1.Image = Image.FromFile(image.Filepath);
        }

    }
}
