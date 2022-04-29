using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackBiblioteca.Models.ViewModels
{
    public class ListTableEstados
    {
        public int Id { get; set; }
        public string NombreLibro { get; set; }
        public string NombreEstudiante { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Dias { get; set; }
    }
    public class EstadosCrear
    {
        public int IdLibro { get; set; }
        public int IdEstudiante { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}