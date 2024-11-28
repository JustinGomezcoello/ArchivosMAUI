using ArchivosMAUI.Interfaces;
using ArchivosMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosMAUI.Repositories
{
    public class EstudianteUDLAAPisRepository : IEstudianteUDLARepository

    {

        public string urlEndpoint = "https://www.freetestapi.com/api/v1/students ";
        public HttpClient _httpClient;
        public EstudianteUDLAAPisRepository()
        {
            _httpClient = new HttpClient();
        }
        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA DevuelveInfoEstudiante(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EstudianteUDLA>> DevuelveListadoEstudiantesUDLA()
        {
            List<EstudianteUDLA> estudiantesUDLA = new List<EstudianteUDLA>();
            try
            {
                using (_httpClient)
                {
                    var respone = await _httpClient.GetAsync(urlEndpoint);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
