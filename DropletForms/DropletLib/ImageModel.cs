using System;

namespace DropletLib
{
    public class ImageModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Filepath { get; set; }
        public int Rating { get; set; }

        public ImageModel() 
        {
            Id = Guid.NewGuid();
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
