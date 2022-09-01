using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace GalacticMongo.Repositories
{
    public class GalacticRepository
    {

        /*
                 private readonly IMongoCollection<Comment> _commentsCollection;
                 private readonly MoviesRepository _moviesRepository;

        public CommentsRepository(IMongoClient mongoClient)
        {
            var camelCaseConvention = new ConventionPack {new CamelCaseElementNameConvention()};
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);

            _commentsCollection = mongoClient.GetDatabase("sample_mflix").GetCollection<Comment>("comments");
            _moviesRepository = new MoviesRepository(mongoClient);
        }*/
 
        private MongoClient IMongoCollection<Galaxy> _galaxyCollection;
        
        public GalacticRepository(IMongoClient mongoClient)
        {
            _galaxyCollection = mongoClient.GetDatabase("galaxies").GetCollection<Galaxy>("galacticCol");
        }


    }
}
