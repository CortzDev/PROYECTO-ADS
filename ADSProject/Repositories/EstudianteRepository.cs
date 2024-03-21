using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        private List<Estudiante> lstEstudiante = new List<Estudiante>
        {
            new Estudiante{ IdEstudiante = 1, NombreEstudiante = "JUAN CARLOS",
            ApellidosEstudiante = "PEREZ SOSA", CodigoEstudiante = "PS24I04002",
            CorreoEstudiante = "PS24I04002@usonsonate.edu.sv"
            }
        };

        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                if(lstEstudiante.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiante.Last().IdEstudiante + 1;
                }
                lstEstudiante.Add(estudiante);

                return estudiante.IdEstudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                int indice = lstEstudiante.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                lstEstudiante[indice] = estudiante;

                return idEstudiante;
            }
            catch(Exception) 
            { 
                throw; 
            }
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                int indice = lstEstudiante.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                lstEstudiante.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Estudiante> ObtenerTodosLosEstudiante()
        {
            try
            {
                return lstEstudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante ObtenerEstudiantePorID(int idEstudiante)
        {
            try
            {
                Estudiante estudiante = lstEstudiante.FirstOrDefault(tmp => tmp.IdEstudiante == idEstudiante);
                return estudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }
 
    }
}
