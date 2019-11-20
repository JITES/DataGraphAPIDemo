using DataGrapiApi.DataLayer.MongoDB.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.DataLayer.MongoDB
{
    public class LiveFeedRepository
    {
        // Implemented Repository pattern as per MSDN

        private readonly IMongoCollection<LiveFeedsModel> _liveFeeds;

        public LiveFeedRepository(IDataGraphDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _liveFeeds = database.GetCollection<LiveFeedsModel>(settings.CollectionName);
        }

        public List<LiveFeedsModel> Get() {
            return _liveFeeds.Find(book => true).ToList();
        }

        public LiveFeedsModel Get(string id) =>
            _liveFeeds.Find<LiveFeedsModel>(book => book.Id == id).FirstOrDefault();

        public LiveFeedsModel Create(LiveFeedsModel _objData)
        {
            _liveFeeds.InsertOne(_objData);
            return _objData;
        }

        public void Update(string id, LiveFeedsModel _liveFeedInfo) =>
            _liveFeeds.ReplaceOne(o => o.Id == id, _liveFeedInfo);

        public void Remove(LiveFeedsModel _objModel) =>
            _liveFeeds.DeleteOne(o => o.Id == _objModel.Id);

        public void Remove(string id) =>
            _liveFeeds.DeleteOne(book => book.Id == id);
    }
}
