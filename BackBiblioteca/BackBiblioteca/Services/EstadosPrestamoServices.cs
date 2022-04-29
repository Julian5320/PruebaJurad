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

    public class EstadoPrestamosServices : ApiController, IEstadosPrestamosServices
    {
        private LibreriaDataBase db = new LibreriaDataBase();



        // GET: api/EstadosPrestamos/5
        [ResponseType(typeof(EstadosPrestamos))]
        public List<ListTableEstados> GetEstados()
        {
            LibreriaDataBase db = new LibreriaDataBase();
            List<ListTableEstados> lista = (from estados in db.EstadosPrestamos
                                            join estudiantes in db.Estudiantes on estados.IDEstudiante equals estudiantes.Id
                                            join libros in db.Libros on estados.IDLibro equals libros.Id
                                            select new ListTableEstados
                                            {
                                                Id = estados.ID,
                                                NombreLibro = libros.NombreLibro,
                                                NombreEstudiante = estudiantes.NombreEstudiante,
                                                FechaSolicitud = (DateTime)estados.FechaPrestamo,
                                                FechaEntrega = (DateTime)estados.FechaDevolucion,
                                                Dias = (EntityFunctions.DiffDays(estados.FechaPrestamo, (DateTime)estados.FechaDevolucion)).ToString()
                                            }).ToList();

            return lista;
        }

        // POST: api/EstadosPrestamos
        public string CrearEstadoPrestamo([FromBody] EstadosCrear Estado)
        {
            if (!ModelState.IsValid)
            {
                return "Modelo no valido";
            }
            EstadosPrestamos estadosPrestamos = new EstadosPrestamos()
            {
                IDEstudiante = Estado.IdEstudiante,
                IDLibro = Estado.IdLibro,
                FechaDevolucion = Convert.ToDateTime("2000/01/01"),
                FechaPrestamo = Estado.FechaSolicitud,


            };

            db.EstadosPrestamos.Add(estadosPrestamos);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EstadosPrestamosExists(estadosPrestamos.IDLibro))
                {
                    return "Fallo al crear, ya lo tiene algun usuario";
                }
                else
                {
                    throw;
                }
            }

            return "Correcto";
        }

        // PUT: api/EstadosPrestamos1/5
        [ResponseType(typeof(void))]
        public string PutEstadosPrestamos(int estadoA)
        {
            if (!ModelState.IsValid)
            {
                return "Modelo no valido";
            }
            var a = (from ae in db.EstadosPrestamos where ae.ID == estadoA select ae).Single();
            a.FechaDevolucion = DateTime.Now;

            db.SaveChanges();

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {

                return "Fallo al editar";

            }

            return "Correcto";
        }

        private bool EstadosPrestamosExists(int id)
        {
            return db.EstadosPrestamos.Count(e => e.IDLibro == id) > 0;
        }
    }
}