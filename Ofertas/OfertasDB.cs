using MongoDB.Bson;

public class OfertasDB : MongoCollectionItem{
    public string UrlImagen {get;set;} = string.Empty;
    public string Descripcion {get;set;} = string.Empty;
    public decimal Precio {get;set;}
    public decimal? PrecioConDescuento {get;set;}
    public int? Descuento {get;set;}
    public bool? EnvioGratis {get;set;}
}