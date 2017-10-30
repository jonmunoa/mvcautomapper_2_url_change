using AutoMapper;
using MvcAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAutomapper.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Usuario, UsuarioViewModel>()

                    // No mapeamos la propiedad DNI
                    .ForMember(m => m.DNI, opt => opt.Ignore())

                    // Mapeamos el nombre y apellidos a la propiedad NombreApellidos
                    .ForMember(m => m.NombreApellidos, mv => mv.MapFrom(m => string.Concat(m.Nombre, " ", m.Apellidos)))

                    // Calculamos la edad del usuario a partir de su fecha de nacimiento
                    .ForMember(m => m.Edad, mv => mv.MapFrom(m => DateTime.Now.Subtract(m.FechaNacimiento).Days / 365));
            });
        }
    }
}