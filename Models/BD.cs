namespace TP06.Models;
using Microsoft.Data.SqlClient;

public class BD{
    public List<Integrante> iniciarSesion(string nombreUsuario, string contraseña)
{
    List <Integrante> integrantes = new List<Integrante>();
    using(SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = "SELECT * FROM Integrante WHERE nombreUsuario = @pnombreUsuario";
        integrantes = connection.Query<Integrante>(query).ToList();
    }
     return integrantes;

}
    
}