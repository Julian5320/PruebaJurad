using BackBiblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBiblioteca.Services
{
    public interface ILibros
    {
        List<ListTableLibros> GetLibros();
    }
}
