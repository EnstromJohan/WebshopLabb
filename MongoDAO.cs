using MongoDB.Bson;
using MongoDB.Driver;
using WebshopLabb;

internal class MongoDAO : IDAO
{
    IMongoCollection<FilmsODM> collection;
    public MongoDAO(string mongoDb, string mongoURI)
    {
        var dbClient = new MongoClient(mongoURI);
        var database = dbClient.GetDatabase(mongoDb);
        this.collection = database.GetCollection<FilmsODM>("Films");
    }
    public void Create(FilmsODM films)
    {
        this.collection.InsertOne(films);
    }

    public void Delete(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public List<FilmsODM> ReadAll()
    {
        return this.collection.Find(new BsonDocument()).ToList();
    }

    public void Update(string Title, string Director, string Genre, int Price)
    {
        throw new NotImplementedException();
    }
}