using BackBiblioteca.Models;
using BackBiblioteca.Models.ViewModels;
using BackBiblioteca.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BackBiblioteca.Controllers
{
    public class EstudiantesController : ApiController
    {

        IEstudiantes estudiantesA;
        public EstudiantesController(IEstudiantes estudiantesB)
        {
            estudiantesA = estudiantesB;
        }
        readonly IEstudiantes EstudianteC = new EstudiantesService();

        public EstudiantesController()
        {
            estudiantesA = EstudianteC;
        }
        // GET: Estudiantes
        [HttpGet]
        public List<ListTablaEstudiantes> GetEstudiantes()
        {

            return estudiantesA.GetEstudiantes();
        }


    }
}
