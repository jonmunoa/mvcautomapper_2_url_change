using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAutomapper.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}