﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;
using DropletLib;

namespace DropletForms.DBCommunication
{
    /// <summary>
    /// The purpose of this class is:
    /// 1. Communication with the database
    /// This is the only place where ImageModels are created - so there is no discrepancy between runtime data and database
    /// </summary>
    public class DatabaseCommunicationService : IDatabaseCommunicationService
    {
        IDbConnection connection;

        private List<ImageModel> currentlyDisplayedImages;
        public DatabaseCommunicationService(string connectionString)
        {
            this.connection = new SQLiteConnection(connectionString);
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
