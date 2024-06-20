using DropletForms.DBCommunication;
using DropletForms.Forms;
using DropletForms.RatingCalculation;
using DropletLib;
using DropletLib.ExampleData;

namespace DropletForms
{
    /// <summary>
    /// This form is the main view of the programm
    /// The user can open a new Form to add new images to the DB (AddNewImageButton)
    /// The user can start displaying four images and click one of them to enhance the rating by 1, which will be refreshed afterwards.
    /// The user can open a new Form to view which image has been voted for the most (ShowWinnerButton)
    /// </summary>
    public partial class DropletMain : Form
    {
        private readonly IDatabaseCommunicationService databaseCommunicationService;
        private readonly AddImageFormFactory addImageFormFactory;
        private readonly WinnerFormFactory winnerFormFactory;
        private readonly IRatingCalculator ratingCalculator;

        private ImageModel pictureBox1ImageModel, pictureBox2ImageModel, pictureBox3ImageModel, pictureBox4ImageModel;

        public DropletMain(IDatabaseCommunicationService databaseCommunicationService, AddImageFormFactory addImageFormFactory, WinnerFormFactory winnerFormFactory, IRatingCalculator ratingCalculator)
        {
            this.databaseCommunicationService = databaseCommunicationService;
            this.addImageFormFactory = addImageFormFactory;
            this.winnerFormFactory = winnerFormFactory;
            this.ratingCalculator = ratingCalculator;

            InitializeComponent();

            SetupView();
        }

        private void SetupView()
        {
            if (databaseCommunicationService.GetImageCount() > 4)
            {
                InstructionLabel.Visible = false;
                AddExampleDataButton.Visible = false;
                StartRatingButton.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                ShowWinnerButton.Visible = true;
            }
            else
            {
                InstructionLabel.Visible = true;
                AddExampleDataButton.Visible = true;
                StartRatingButton.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                ShowWinnerButton.Visible = false;
            }

        }
        private void AddExampleDataButton_Click(object sender, EventArgs e)
        {
            AddExampleDataService addExampleDataService = new AddExampleDataService(databaseCommunicationService);
            addExampleDataService.AddExampleData();
            SetupView();
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            using (var addImageForm = addImageFormFactory.Invoke())
            {
                addImageForm.ShowDialog(this);
                //Check if 4 images are in the DB and change content appropriately
                SetupView();
            }
        }

        private void StartRatingButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetupNewRatingView();
                ClickMostBeautifulLabel.Visible = true;
            }
            catch (Exception exception)
            {
                //TODO: Handle exception - e.g.: If DB contains less than 4 entries
            }
        }

        private void ShowWinnerButton_Click(object sender, EventArgs e)
        {
            using (var winnerForm = winnerFormFactory.Invoke())
            {
                winnerForm.ShowDialog(this);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ratingCalculator.AddOneToRating(pictureBox1ImageModel);
            SetupNewRatingView();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ratingCalculator.AddOneToRating(pictureBox2ImageModel);
            SetupNewRatingView();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ratingCalculator.AddOneToRating(pictureBox3ImageModel);
            SetupNewRatingView();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ratingCalculator.AddOneToRating(pictureBox4ImageModel);
            SetupNewRatingView();
        }

        private void SetupNewRatingView()
        {
            List<ImageModel> filepaths = databaseCommunicationService.GetFourRandomImages();
            //TODO: Check filepath and if it doesnt work show notification to the user
            pictureBox1.Image = Image.FromFile(filepaths[0].Filepath);
            pictureBox1ImageModel = filepaths[0];
            pictureBox2.Image = Image.FromFile(filepaths[1].Filepath);
            pictureBox2ImageModel = filepaths[1];
            pictureBox3.Image = Image.FromFile(filepaths[2].Filepath);
            pictureBox3ImageModel = filepaths[2];
            pictureBox4.Image = Image.FromFile(filepaths[3].Filepath);
            pictureBox4ImageModel = filepaths[3];
        }


    }
}
