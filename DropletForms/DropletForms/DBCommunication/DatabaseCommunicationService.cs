using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropletLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DropletForms.DBCommunication
{
    public class DatabaseCommunicationService : IDatabaseCommunicationService, IDisposable
    {
        SqliteDataAccess dataAccess;
        public DatabaseCommunicationService()
        {
            dataAccess = new SqliteDataAccess();
        }
        public void AddImage(string filepath)
        {
            ImageModel image = new ImageModel(filepath);
            dataAccess.AddImageToDatabase(image);
        }

        public void AddImage(string name, string location, string filepath)
        {
            ImageModel image = new ImageModel(name, location, filepath);
            dataAccess.AddImageToDatabase(image);
        }

        public void ImproveImageRating(ImageModel image) 
        {
            int newRating = image.Rating + 1;
            dataAccess.SetImageRating(image, newRating);
        }

        public void Dispose()
        {
            dataAccess.Dispose();
        }
    }
}
