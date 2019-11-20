using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.DataLayer.MongoDB.Models
{
    public class LiveFeedsModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("PCount")]
        public int PCount { get; set; }

        [BsonElement("CCount")]
        public int CCount { get; set; }
    }
}
