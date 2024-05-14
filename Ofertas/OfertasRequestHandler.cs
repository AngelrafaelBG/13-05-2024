using MongoDB.Driver;

public class OfertasRequesHandler{
    public static IResult ObtenerOfertas() {
        var collection = MongoDbFactory.GetCollection<OfertasDB>("Ofertas");
        FilterDefinitionBuilder<OfertasDB> filter = new FilterDefinitionBuilder<OfertasDB>();
        var list = collection.Find(filter.Empty).ToList();
        return Results.Ok(list);
    }
}