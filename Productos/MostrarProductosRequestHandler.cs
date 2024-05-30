using MongoDB.Driver;

public class MostrarProductoRequestHandler{

public static IResult MostrarProducto (string sku){
    var collection = MongoDbFactory.GetCollection<ProductosDb>("Productos");
    FilterDefinitionBuilder<ProductosDb> filter = new FilterDefinitionBuilder<ProductosDb>();
    var filterValue = filter.Eq ("SKU", sku);
    var producto = collection.Find(filterValue).FirstOrDefault();

    if(producto == null){
        return Results.NotFound($"No existe un producto con SKU {sku}");
        }
        return Results.Ok(producto);
    }
}