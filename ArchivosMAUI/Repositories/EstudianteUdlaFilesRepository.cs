using ArchivosMAUI.Interfaces;
using ArchivosMAUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosMAUI.Repositories
{
    public class EstudianteUdlaFilesRepository : IEstudianteUDLARepository
    {
        public string _filename = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_filename, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

      

        public EstudianteUDLA DevuelveInfoEstudiante(int Id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();
            try
            {
                if (File.Exists(_filename))
                {
                    string json_data = File.ReadAllText(_filename);
                    estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(json_data);
                }
            }
            catch (Exception)
            {
              throw;
            }
            return estudiante;
        }

        public Task<IEnumerable<EstudianteUDLA>> DevuelveListadoEstudiantesUDLA()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

