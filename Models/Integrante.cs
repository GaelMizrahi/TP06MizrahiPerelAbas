namespace TP06.Models;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;


public class Integrante
{

    [JsonProperty]
    public string nombreUsuario { get; private set; }

    [JsonProperty]

    public string contraseña { get; private set; }

    [JsonProperty]

    public string equipo { get; private set; }

    [JsonProperty]
    public int edad { get; private set; }

    [JsonProperty]
    public string comidaFav { get; private set; }

    [JsonProperty]
    public string cancionFav { get; private set; }
    [JsonProperty]
    public int dineroBanco{get;private set;}


    public Integrante()
    {

    }



}