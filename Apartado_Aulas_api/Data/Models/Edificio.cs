using System.Data;

namespace Apartado_Aulas_api.Data.Models
{
    public class Edificio
    {
       public int Id { get; set; }
       public int NumeroEdificio { get; set; }
       public string NombreEdificio { get; set; }
       public string Encargado { get; set; }
       public int CantAulas { get; set; }
    
    }
}
