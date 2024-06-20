using System;

namespace DropletLib
{
    public class ImageModel
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Location { get; private set; }
        public string Filepath { get; private set; }
        public int Rating { get; private set; }

        public ImageModel() 
        {
            Id = Guid.NewGuid().ToString();
            Rating = 0;
        }

        public ImageModel(string filepath) : this() 
        {
            Filepath = filepath;
        }

        public ImageModel(string name, string location, string filepath) : this(filepath) 
        {
            Name = name;
            Location = location;
        }
    }
}
