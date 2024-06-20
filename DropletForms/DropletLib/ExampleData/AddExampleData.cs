using DropletForms.DBCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropletLib.ExampleData
{
    public class AddExampleDataService : IDisposable
    {
        private IDatabaseCommunicationService databaseCommunicationService;
        public AddExampleDataService(IDatabaseCommunicationService databaseCommunicationService) 
        {
            this.databaseCommunicationService = databaseCommunicationService;
        }

        public void AddExampleData()
        {
            databaseCommunicationService.AddImage("Bolivia01", "Bolivia", @"./Data/ExampleData/Bolivia01.png");
            databaseCommunicationService.AddImage("CostaRica01", "CostaRica", @"./Data/ExampleData/CostaRica01.png");
            databaseCommunicationService.AddImage("Galapagos01", "Galapagos", @"./Data/ExampleData/Galapagos01.png");
            databaseCommunicationService.AddImage("Germany01", "Germany", @"./Data/ExampleData/Germany01.png");
            databaseCommunicationService.AddImage("Germany02", "Germany", @"./Data/ExampleData/Germany02.png");
            databaseCommunicationService.AddImage("Iceland01", "Iceland", @"./Data/ExampleData/Iceland01.png");
            databaseCommunicationService.AddImage("India01", "India", @"./Data/ExampleData/India01.png");
            databaseCommunicationService.AddImage("Thailand01", "Thailand", @"./Data/ExampleData/Thailand01.png");
            databaseCommunicationService.AddImage("USA01", "USA", @"./Data/ExampleData/USA01.png");
        }

        public void Dispose()
        {
            
        }
    }
}
