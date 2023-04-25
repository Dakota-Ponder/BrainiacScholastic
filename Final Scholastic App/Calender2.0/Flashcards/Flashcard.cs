// import the namesapces to be able to use mongoDB
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // properties for the spaced repetition algorithm
        //    Box 1: Review daily
        //    Box 2: Review every 3 days
        //    Box 3: Review every 5 days
        //    Box 4: Review every 7 days(or more)
        public int Box { get; set; } = 1;  // default value is 1 (box 1)
        public DateTime LastReviewDate { get; set; } = DateTime.Now; // default value is now

        // properties for the progress statistics 
        public int CorrectAnswers { get; set; }
        public int IncorrectAnswers { get; set; }

        // property for more detailed stats over time 
        public DateTime? LastCorrectAnswerDate { get; set; }
        public DateTime? LastIncorrectAnswerDate { get; set; }
    }
}
