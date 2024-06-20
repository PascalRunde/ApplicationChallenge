using DropletForms.DBCommunication;
using DropletForms.RatingCalculation;
using DropletLib;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace DropletTest
{
    public class UnitTest1 : IDisposable
    {
        IDatabaseCommunicationService databaseCommunicationService;
        RatingCalculator ratingCalculator;
        System.Data.IDbConnection connection;
        public UnitTest1()
        { 
            string connectionString = @"Data Source=.\Data\DropletSQLite.db";
            databaseCommunicationService = new DatabaseCommunicationService(connectionString);
            ratingCalculator = new RatingCalculator(databaseCommunicationService);
            this.connection = new SQLiteConnection(connectionString);
        }

        [Fact]
        public void AddImage_Test()
        {
            ImageModel expectedModel = new ImageModel("Image", "Germany", "C:/testfile");
            
            databaseCommunicationService.AddImage("Image", "Germany", "C:/testfile");
            
            ImageModel model = connection.Query<ImageModel>("SELECT * FROM Images", new DynamicParameters()).First();

            Assert.Equal(expectedModel.Name, model.Name);
            Assert.Equal(expectedModel.Filepath, model.Filepath);
            Assert.Equal(expectedModel.Location, model.Location);
            Assert.Equal(expectedModel.Rating, model.Rating);
        }

        [Fact]
        public void ImproveImageRating_Test()
        {

            databaseCommunicationService.AddImage("Image", "Germany", "C:/testfile");

            ImageModel model = connection.Query<ImageModel>("SELECT * FROM Images", new DynamicParameters()).First();

            int expectedRating = model.Rating + 1;

            databaseCommunicationService.ImproveImageRating(model);

            ImageModel improvedModel = connection.Query<ImageModel>("SELECT Rating FROM Images WHERE Id = @Id", model).First();

            Assert.Equal(expectedRating, improvedModel.Rating);
        }

        public void Dispose()
        {
            databaseCommunicationService.Dispose();
        }
    }
}