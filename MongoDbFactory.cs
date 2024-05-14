using MongoDB.Driver;

public class MongoDbFactory{
    private static string connectionString ="mongodb+srv://angelrafael:29-sep-2007@cluster0.tiezro2.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

    public static IMongoCollection<T> GetCollection<T> (string collectionName)
    where T : MongoCollectionItem {
        MongoClient client = new MongoClient (connectionString);
        IMongoDatabase database = client.GetDatabase ("Proyecto14");
        IMongoCollection<T> collection = database.GetCollection<T>(collectionName);
        return collection;
    }
}