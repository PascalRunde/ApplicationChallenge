using DropletForms.DBCommunication;
using DropletLib;
using System;
using System.Collections.Generic;

namespace DropletForms.RatingCalculation
{
    public class RatingCalculator : IRatingCalculator, IDisposable
    {
        IDatabaseCommunicationService databaseCommunicationService;
        public RatingCalculator(IDatabaseCommunicationService databaseCommunicationService) 
        {
            this.databaseCommunicationService = databaseCommunicationService;
        }

        public void AddOneToRating(ImageModel image)
        {
            
            databaseCommunicationService.ImproveImageRating(image);
        }

        public ImageModel GetWinner()
        {
            List<ImageModel> bestImages = databaseCommunicationService.GetHighestRatedImages();
            return bestImages[0];
        }

        public void Dispose()
        {
            
        }
    }
}
