using AutoMapper;
using ManejosTareas.Seguridad.JC.Entidades;
using ManejosTareas.Seguridad.JC.Models;

namespace ManejosTareas.Seguridad.JC.Servicios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Tarea, TareaDTO>();
        }
    }
}
