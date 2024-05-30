public class ProductosDb : MongoCollectionItem{
            public string SKU {get;set;} = string.Empty;
            public string Descripcion {get;set;} = string.Empty;
            public int Precio {get;set;} 
            public int? PrecioConDescuento {get;set;}
            public bool? EnvioGratis {get;set;}
            public int Calificacion {get;set;}  

}