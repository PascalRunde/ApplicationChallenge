﻿using DropletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropletForms.DBCommunication
{
    public interface IDatabaseCommunicationService
    {
        void AddImage(string filepath);

        void AddImage(string name, string location, string filepath);

        void ImproveImageRating(ImageModel image);


    }
}
