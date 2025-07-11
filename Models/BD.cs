namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public class BD
{
  
   private static string _connectionString = @"Server=localhost; 
   DataBase = TP06; Integrated Security=True; TrustServerCertificate=True;";
    public Integrante IniciarSesion(string nombreUsuario, string contraseña)
    {
        Integrante integrante = new Integrante();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Integrante WHERE nombreUsuario = @nombreUsuario AND contraseña = @contraseña ";
            integrante = connection.QueryFirstOrDefault<Integrante>(query, new {nombreUsuario, contraseña} );

        }
        return integrante;
    }
    public List<Integrante> buscarEquipo(Integrante integrante)
    {
        string equipo = integrante.equipo;
        List<Integrante> integrantes = new List<Integrante>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Integrante WHERE equipo = @equipo";
            integrantes = connection.Query<Integrante>(query, new {equipo}).ToList();

        }

        Console.WriteLine("INTEGRANTESSS " + integrante);
        return integrantes;
    }

}