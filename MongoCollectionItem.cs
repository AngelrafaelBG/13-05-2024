using MongoDB.Bson;

public abstract class MongoCollectionItem{
    public ObjectId Id {get; set;}
    public string ItemId {
        get {return this.Id.ToString (); }
    }
}