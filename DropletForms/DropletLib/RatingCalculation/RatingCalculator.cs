using DropletForms.DBCommunication;
using DropletLib;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //TODO: Resolve a tie reasonable
            return bestImages.First();
        }

        public void Dispose()
        {
            
        }
    }
}
