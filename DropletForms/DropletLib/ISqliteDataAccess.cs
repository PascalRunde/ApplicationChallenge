using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropletLib
{
    internal interface ISqliteDataAccess
    {
        List<ImageModel> LoadImages();

        void AddImageToDatabase(ImageModel image);

        void SetImageRating(ImageModel image, int newRating);
    }
}
