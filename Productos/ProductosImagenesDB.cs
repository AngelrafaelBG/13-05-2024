public class ProductosImagenesDB : MongoCollectionItem{
        public string SKU {get;set;} = string.Empty;
        public string URLImagen {get;set;} = string.Empty;
        public int Orden {get;set;}
}