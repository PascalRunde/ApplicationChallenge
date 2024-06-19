using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DropletLib;

namespace DropletForms
{
    public partial class AddImageForm : Form
    {
        public AddImageForm()
        {
            InitializeComponent();
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            if (!HasFilePath())
            {
                return;
            }
            if (IsFilledCompletely())
            {
                SqliteDataAccess.AddImage(NameTextBox.Text, LocationTextBox.Text, FilepathTextBox.Text);
            }
            else
            {
                SqliteDataAccess.AddImage(FilepathTextBox.Text);
            }
        }

        private bool HasFilePath()
        {
            //TODO: Make this a more sophisticated check
            return FilepathTextBox.Text.Length > 0;
        }

        private bool IsFilledCompletely() 
        {
            if (NameTextBox.Text.Length > 0 && LocationTextBox.Text.Length > 0) 
            {
                return true;
            }

            return false;
        }

        private void SelectPathButton_Click(object sender, EventArgs e)
        {

        }
    }
}
