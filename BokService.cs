using ConsoleApp1.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace ConsoleApp1.Services  
{
    public class BokService
    {
        private readonly IMongoCollection<Bok> _böcker;

        public BokService()
        {
            var db = new MongoDBConnection();
            _böcker = db.GetCollection<Bok>("Böcker");
        }

        public List<Bok> GetAll()
        {
            return _böcker.Find(b => true).ToList();
        }

        public void AddBok(Bok bok)
        {
            _böcker.InsertOne(bok);
        }

        public void UpdateBok(string id, Bok updatedBok)
        {
            _böcker.ReplaceOne(b => b.Id == id, updatedBok);
        }

        public void DeleteOne(string id)
        {
            _böcker.DeleteOne(b => b.Id == id);
        }
    }
}
