using MongoDB.Driver;

public class ProductosRequestHandler {
    public static IResult MostrarImagenes(string sku){
        var collection = MongoDbFactory.GetCollection<ProductosImagenesDB>("ProductosImagenes");
        FilterDefinitionBuilder<ProductosImagenesDB> filter = new FilterDefinitionBuilder<ProductosImagenesDB>();
        var filterValue = filter.Eq("SKU", sku);
        var list = collection.Find(filterValue).ToList();
        var orderedList = list.OrderBy(x => x.Orden).ToList();

        return Results.Ok(orderedList);
    }
}