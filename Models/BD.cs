namespace TP06.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public class BD
{
    private static string _connectionString = @"Server=localhost; 
    DataBase TP06; Integrated Security=True; TrustServerCertificate=True;";
    public List<Integrante> IniciarSesion(string nombreUsuario, string contraseña)
    {
        List<Integrante> integrantes = new List<Integrante>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Integrante WHERE nombreUsuario = @nombreUsuario AND contraseña = @contraseña ";
            integrantes = connection.Query<Integrante>(query).ToList();

        }
        return integrantes;
    }
    public List<Integrante> buscarEquipo(Integrante integrante, string equipo)
    {
        List<Integrante> integrantes = new List<Integrante>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Integrante WHERE equipo = @equipo";
            integrantes = connection.Query<Integrante>(query).ToList();

        }
        return integrantes;
    }

}