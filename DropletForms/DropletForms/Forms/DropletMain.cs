using DropletForms.DBCommunication;
using DropletForms.Forms;

namespace DropletForms
{
    public partial class DropletMain : Form
    {
        private readonly IDatabaseCommunicationService databaseCommunicationService;
        private readonly AddImageFormFactory addImageFormFactory;
        private readonly WinnerFormFactory winnerFormFactory;
        public DropletMain(IDatabaseCommunicationService databaseCommunicationService, AddImageFormFactory addImageFormFactory, WinnerFormFactory winnerFormFactory)
        {
            this.databaseCommunicationService = databaseCommunicationService;
            this.addImageFormFactory = addImageFormFactory;
            this.winnerFormFactory = winnerFormFactory;

            InitializeComponent();
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            using (var addImageForm = addImageFormFactory.Invoke())
            {
                addImageForm.ShowDialog(this);
            }
        }

        private void StartRatingButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowWinnerButton_Click(object sender, EventArgs e)
        {
            using (var winnerForm = winnerFormFactory.Invoke())
            {
                winnerForm.ShowDialog(this);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
