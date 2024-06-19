using DropletForms.DBCommunication;

namespace DropletForms
{
    public partial class DropletMain : Form
    {
        private readonly IDatabaseCommunicationService databaseCommunicationService;
        private readonly AddImageFormFactory addImageFormFactory;
        public DropletMain(IDatabaseCommunicationService databaseCommunicationService, AddImageFormFactory addImageFormFactory)
        {
            this.databaseCommunicationService = databaseCommunicationService;
            this.addImageFormFactory = addImageFormFactory;

            InitializeComponent();
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            using (var addImageForm = addImageFormFactory.Invoke())
            {
                addImageForm.ShowDialog(this);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
