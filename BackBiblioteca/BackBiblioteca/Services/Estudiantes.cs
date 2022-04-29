using BackBiblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BackBiblioteca.Services
{
    public class EstudiantesService : ApiController, IEstudiantes
    {
        // GET: Estudiantes
        [HttpGet]
        public List<ListTablaEstudiantes> GetEstudiantes()
        {
            LibreriaDataBase db = new LibreriaDataBase();
            List<ListTablaEstudiantes> lista = (from estudiantes in db.Estudiantes
                                                select new ListTablaEstudiantes
                                                {
                                                    Id = estudiantes.Id,
                                                    Nombre = estudiantes.NombreEstudiante
                                                }).ToList();

            return lista;
        }

    }
}