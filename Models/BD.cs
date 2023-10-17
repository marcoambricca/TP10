using System.Data.SqlClient;
using Dapper;

public static class BD{
    private static string ConnectionString {get; set;} = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static List<Serie> ObtenerSeries(){
        List<Serie> user = new List<Serie>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Series";
            user = db.Query<Serie>(sql).ToList();                                                              
        }
        return user;
    }

    public static List<Actor> ObtenerActores(int Idserie){
        List<Actor> user = new List<Actor>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Actores WHERE IdSerie = @idserie";
            user = db.Query<Actor>(sql, new {idserie = Idserie}).ToList();                                                              
        }
        return user;
    }
    public static List<Temporada> ObtenerTemporadas(int Idserie){
        List<Temporada> user = new List<Temporada>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @idserie";
            user = db.Query<Temporada>(sql, new {idserie = Idserie}).ToList();                                                              
        }
        return user;
    }
}