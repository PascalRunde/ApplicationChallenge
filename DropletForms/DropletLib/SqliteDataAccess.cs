using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropletLib
{
    public class SqliteDataAccess : ISqliteDataAccess, IDisposable
    {
        IDbConnection connection;
        public SqliteDataAccess() 
        {
            connection = new SQLiteConnection(LoadConnectionString());
        }


        public List<ImageModel> LoadImages()
        {
            //Dont leave connections open
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<ImageModel>("SELECT * FROM Images ORDER BY random() LIMIT 4", new DynamicParameters());
                return output.ToList();
            }
        }

        public void AddImageToDatabase(ImageModel image)
        {
            string connectionString = LoadConnectionString();
            //Dont leave connections open
            using (IDbConnection connection = new SQLiteConnection(connectionString))
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
        }

        public void SetImageRating(ImageModel image, int newRating)
        {
            connection.Execute("UPDATE Images SET Rating = @newRating WHERE Id = @Id", new { newRating, image.Id });

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

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
