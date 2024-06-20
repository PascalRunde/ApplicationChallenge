using DropletLib;
using System;
using System.Collections.Generic;

namespace DropletForms.DBCommunication
{
    public interface IDatabaseCommunicationService : IDisposable
    {
        int GetImageCount();
        void AddImage(string filepath);

        void AddImage(string name, string location, string filepath);

        List<ImageModel> GetFourRandomImages();

        List<ImageModel> GetHighestRatedImages();

        void ImproveImageRating(ImageModel image);


    }
}
