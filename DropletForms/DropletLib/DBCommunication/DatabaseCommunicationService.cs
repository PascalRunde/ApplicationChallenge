using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DropletLib;
using static System.Net.Mime.MediaTypeNames;

namespace DropletForms.DBCommunication
{
    public class DatabaseCommunicationService : IDatabaseCommunicationService, IDisposable
    {
        IDbConnection connection;

        private List<ImageModel> currentlyDisplayedImages;
        public DatabaseCommunicationService()
        {
            connection = new SQLiteConnection(LoadConnectionString());
        }

        /// <summary>
        /// Get the configuration string which is defined in DropletForms/App.config
        /// </summary>
        /// <param name="id"> This parameter is optional. If there should be additional databases in the future it would be possible to choose which to load.</param>
        /// <returns></returns>
        private static string LoadConnectionString(string id = "DBconnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public void AddImage(string filepath)
        {
            ImageModel image = new ImageModel(filepath);
            AddImageToDatabase(image);
        }

        public void AddImage(string name, string location, string filepath)
        {
            ImageModel image = new ImageModel(name, location, filepath);
            AddImageToDatabase(image);
        }

        private void AddImageToDatabase(ImageModel image)
        {
            if (image.Name != null)
            {
                connection.Execute("INSERT INTO Images (Id, Name, Location, Filepath, Rating) VALUES (@Id, @Name, @Location, @Filepath, @Rating)", image);
            }
            else
            {
                connection.Execute("INSERT INTO Images (Id, Filepath, Rating) VALUES (@Id, @Filepath, @Rating)", image);
            }
        }

        public List<ImageModel> GetHighestRatedImages()
        {
            var output = connection.Query<ImageModel>("SELECT *,MAX(Rating) FROM Images", new DynamicParameters());
            return output.ToList();
        }

        public List<ImageModel> GetFourRandomImages()
        {
            try
            {
                return connection.Query<ImageModel>("SELECT * FROM Images ORDER BY random() LIMIT 4", new DynamicParameters()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ImageModel> GetCurrentlyDisplayedImages()
        {
            return currentlyDisplayedImages;
        }

        public void ImproveImageRating(ImageModel image) 
        {
            int newRating = image.Rating + 1;
            connection.Execute("UPDATE Images SET Rating = @newRating WHERE Id = @Id", new { newRating, image.Id });
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
