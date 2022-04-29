using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BackBiblioteca.Models;
using BackBiblioteca.Models.ViewModels;
using BackBiblioteca.Services;

namespace BackBiblioteca.Controllers
{

    public class EstadosPrestamosController : ApiController
    {
        private LibreriaDataBase db = new LibreriaDataBase();
        IEstadosPrestamosServices Prestamos;
        public EstadosPrestamosController(IEstadosPrestamosServices Iprestamos)
        {
            Prestamos = Iprestamos;
        }

        readonly IEstadosPrestamosServices PrestamosC = new EstadoPrestamosServices();

        public EstadosPrestamosController()
        {
            Prestamos = PrestamosC;
        }


        // GET: api/EstadosPrestamos/5
        [ResponseType(typeof(EstadosPrestamos))]
        public List<ListTableEstados> GetEstados()
        {
            return Prestamos.GetEstados();
        }

        // POST: api/EstadosPrestamos
        public string CrearEstadoPrestamo([FromBody] EstadosCrear Estado)
        {

            return Prestamos.CrearEstadoPrestamo(Estado);
        }

        // PUT: api/EstadosPrestamos1/5
        [ResponseType(typeof(void))]
        public string PutEstadosPrestamos(int estadoA)
        {
            return Prestamos.PutEstadosPrestamos(estadoA);
        }


    }
}