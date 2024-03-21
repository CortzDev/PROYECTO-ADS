using ADSProject.Models;
using System.Collections.Generic;

namespace ADSProject.Interfaces
{
    public interface ICarrera
    {
        public int AgregarCarrera(Carrera carrera);
        public int ActualizarCarrera(int idCarrera, Carrera carrera);
        public bool EliminarCarrera(int idCarrera);
        public List<Carrera> ObtenerTodasLasCarreras();
        public Carrera ObtenerCarreraPorID(int idCarrera);
    }
}
