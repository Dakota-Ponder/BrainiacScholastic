// import the namesapces to be able to use mongoDB
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainiac
{
    public class FlashCard
    {
        // BsonId attribute tells MongoDB to use this property as the document's ID
        [BsonId]

        // this specifies that the Id will be stored as an ObjectId in MongoDB
        [BsonRepresentation(BsonType.ObjectId)]

        // these are all the properties that will be stored in the database
        public string Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Chapter { get; set; }
    }
}
