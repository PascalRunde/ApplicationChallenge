using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DropletForms.DBCommunication;
using DropletLib;

namespace DropletForms
{
    //Add a delegate factory, so the main form can invoke the AddImageForm with dependency injection
    public delegate AddImageForm AddImageFormFactory();
    public partial class AddImageForm : Form
    {
        private readonly IDatabaseCommunicationService databaseCommunicationService;
        public AddImageForm(IDatabaseCommunicationService databaseCommunicationService)
        {
            InitializeComponent();
            this.databaseCommunicationService = databaseCommunicationService;
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            if (!HasFilePath())
            {
                return;
            }
            if (IsFilledCompletely())
            {
                databaseCommunicationService.AddImage(NameTextBox.Text, LocationTextBox.Text, FilepathTextBox.Text);
            }
            else
            {
                databaseCommunicationService.AddImage(FilepathTextBox.Text);
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
            var FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                FilepathTextBox.Text = FD.FileName;
            }
        }
    }
}
