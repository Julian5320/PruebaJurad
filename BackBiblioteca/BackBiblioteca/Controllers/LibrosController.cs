using BackBiblioteca.Models;
using BackBiblioteca.Models.ViewModels;
using BackBiblioteca.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BackBiblioteca.Controllers
{
    public class LibrosController : ApiController
    {
        ILibros libros;
        public LibrosController(ILibros librosA)
        {
            libros = librosA;
        }
        readonly ILibros LibrosC = new LibrosService();

        public LibrosController()
        {
            libros = LibrosC;
        }
        public List<ListTableLibros> GetLibros()
        {
            return libros.GetLibros();
        }

    }
}
