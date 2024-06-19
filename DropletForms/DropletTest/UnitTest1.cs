using DropletForms.DBCommunication;
using DropletForms.RatingCalculation;
using DropletLib;

namespace DropletTest
{
    public class UnitTest1 : IDisposable
    {
        IDatabaseCommunicationService databaseCommunicationService;
        RatingCalculator ratingCalculator;
        public UnitTest1()
        {
            databaseCommunicationService = new DatabaseCommunicationService(@"Data Source=.\Data\DropletSQLite.db");
            ratingCalculator = new RatingCalculator(databaseCommunicationService);
        }

        [Fact]
        public void AddImagenAndReadImage()
        {
            databaseCommunicationService.AddImage("test");
            var image = databaseCommunicationService.GetHighestRatedImages().FirstOrDefault();
        }
        public void Dispose()
        {
            databaseCommunicationService.Dispose();
        }
    }
}