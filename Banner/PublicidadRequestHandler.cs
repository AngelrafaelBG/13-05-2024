public class PubliciadRequestHandler {
    public static IResult ListarPublicidad(){
        List<Publicidad> list = new List<Publicidad>();

        Publicidad publicidad1 = new Publicidad();

        publicidad1.UrlImagen="https://imanesdeviaje.com/wp-content/uploads/2020/03/paisajes-mas-bonitos-del-mundo-cascada-islandia-1.jpg";
        publicidad1.Titulo="Paisaje";
        publicidad1.Texto="La primera condicion del paisaje es su capacidad de decir casi todo sin una sola palabra";
        publicidad1.UrlAccion="http://localhost:3014/Presentacion";
        publicidad1.TextoAccion="Suscríbete aqui";


        Publicidad publicidad2 = new Publicidad();

        publicidad2.UrlImagen="https://i.pinimg.com/564x/1d/20/2d/1d202dc56775b178df045c3c0189e190.jpg";
        publicidad2.Titulo="Lechuza";
        publicidad2.Texto="A diferencia de los búhos, no tienen plumas alzadas que parecen orejas";
        publicidad2.UrlAccion="http://localhost:3014/Presentacion";
        publicidad2.TextoAccion="Suscríbete aqui";

        Publicidad publicidad3 = new Publicidad();

        publicidad3.UrlImagen="https://i.pinimg.com/564x/1d/d6/99/1dd69902f1a473835970e761f0b55181.jpg";
        publicidad3.Titulo="Saturno";
        publicidad3.Texto="el 6° planeta del sistema solar contando desde el Sol, el 2° en tamaño y masa después de Júpiter y el único con un sistema de anillos visible desde la Tierra. ";
        publicidad3.UrlAccion="http://localhost:3014/Presentacion";
        publicidad3.TextoAccion="Suscríbete aqui";

        Publicidad publicidad4 = new Publicidad();

        publicidad4.UrlImagen="https://i.pinimg.com/564x/f3/39/56/f33956bb2de9a1e439a0b81cca176bd6.jpg";
        publicidad4.Titulo="Calentamiento global";
        publicidad4.Texto="El cambio climático hace referencia a los cambios a largo plazo de las temperaturas y los patrones climáticos.";
        publicidad4.UrlAccion="http://localhost:3014/Presentacion";
        publicidad4.TextoAccion="Suscríbete aqui";

        Publicidad publicidad5 = new Publicidad();

        publicidad5.UrlImagen="https://i.pinimg.com/564x/e6/f6/ac/e6f6ac0c882f2672feb8f915dc4f7de6.jpg";
        publicidad5.Titulo="Taj Mahal";
        publicidad5.Texto="Monumento funerario construido entre 1632 y 1654 en la ciudad de Agra, estado de Uttar Pradesh.";
        publicidad5.UrlAccion="http://localhost:3014/Presentacion";
        publicidad5.TextoAccion="Suscríbete aqui";


        list.Add(publicidad1);
        list.Add(publicidad2);
        list.Add(publicidad3);
        list.Add(publicidad4);
        list.Add(publicidad5);

        return Results.Ok(list);

    }
}