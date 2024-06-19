using DropletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropletForms.RatingCalculation
{
    public interface IRatingCalculator
    {
        void AddOneToRating(ImageModel image);
        ImageModel GetWinner();
    }
}
