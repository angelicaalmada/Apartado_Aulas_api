using Apartado_Aulas_api.Data.Models;
using System.Collections.Generic;

namespace Apartado_Aulas_api.Data
{
    internal class Edificios
    {
        public int NumeroEdificio { get; set; }
        public string NombreEdificio { get; set; }
        public string Encargado { get; set; }
        public int CantAulas { get; set; }
    }
}