public class Serie{
    public int IdSerie {get;set;}
    public string Nombre {get;set;}
    public string AñoInicio {get;set;}
    public string Sinopsis {get;set;}
    public string ImagenSerie {get;set;}

    public Serie(){
    }

    public Serie(int idserie, string nombre, string añoinicio, string sinopsis, string imagenserie){
        IdSerie = idserie;
        Nombre = nombre;
        AñoInicio = añoinicio;
        Sinopsis = sinopsis;
        ImagenSerie = imagenserie;
    }
}