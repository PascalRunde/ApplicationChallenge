using DropletLib;

namespace DropletForms.RatingCalculation
{
    public interface IRatingCalculator
    {
        void AddOneToRating(ImageModel image);
        ImageModel GetWinner();
    }
}
