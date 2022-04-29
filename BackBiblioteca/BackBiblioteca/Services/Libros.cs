using BackBiblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BackBiblioteca.Services
{
    public class LibrosService : ApiController, ILibros
    {
        // GET: Estudiantes
        [HttpGet]
        public List<ListTableLibros> GetLibros()
        {
            LibreriaDataBase db = new LibreriaDataBase();
            List<ListTableLibros> lista = (from libros in db.Libros
                                           select new ListTableLibros
                                           {
                                               Id = libros.Id,
                                               Nombre = libros.NombreLibro
                                           }).ToList();

            return lista;
        }

    }
}