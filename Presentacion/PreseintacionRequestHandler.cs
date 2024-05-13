public class PresentacionRequestHandler {
    public static IResult ListarAlumnos(){
        List<Alumno> list = new List<Alumno>();

        
        Alumno alumno1 = new Alumno();
        alumno1.NumControl ="22328051050165";
        alumno1.Nombre = "Alexia De la Fuente Torres";
        alumno1.Foto ="Alexia.jpg";
        alumno1.FechaNaciemiento="20-nov-2007";
        alumno1.Rol="Diseñador web";
        alumno1.RedSocial="https://www.facebook.com/alexia.delafuente.587?locale=es_LA";

        Alumno alumno2 = new Alumno();
        alumno2.NumControl="2234543235566743";
        alumno2.Nombre="Angel rafael maldonado perez";
        alumno2.Foto= "Angel.jpg";
        alumno2.Rol="Manager";
        alumno2.FechaNaciemiento="29-sep-2007";
        alumno2.RedSocial="https://www.facebook.com/angelrafael.maldonadoperez.1/?locale=es_LA";
        
        Alumno alumno3 = new Alumno();
        alumno3.NumControl="2233244323211";
        alumno3.Nombre="Dennise Alessandra Resendez Martinez";
        alumno3.Foto="Dennise.jpg";
        alumno3.Rol="Programadora";
        alumno3.FechaNaciemiento="13-dic-2007";
        alumno3.RedSocial="https://www.facebook.com/ale.resendez.39?locale=es_LA";


        list.Add(alumno1);
        list.Add(alumno2);
        list.Add(alumno3);
        return Results.Ok(list);
        
    }
}