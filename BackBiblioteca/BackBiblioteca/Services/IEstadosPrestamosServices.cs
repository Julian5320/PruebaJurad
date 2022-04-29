using BackBiblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace BackBiblioteca.Services
{
    public interface IEstadosPrestamosServices
    {
        string PutEstadosPrestamos(int estadoA);
        string CrearEstadoPrestamo([FromBody] EstadosCrear Estado);
        List<ListTableEstados> GetEstados();
    }
}
