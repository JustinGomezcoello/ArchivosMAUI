using ArchivosMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosMAUI.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        bool CrearEstudianteUDLA(EstudianteUDLA estudiante);
        bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        bool EliminarEstudianteUDLA(int Id);
        IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantesUDLA();
        EstudianteUDLA DevuelveInfoEstudiante(int Id);

    }
}
