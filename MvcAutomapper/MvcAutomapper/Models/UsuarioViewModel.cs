using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAutomapper.Models
{
    public class UsuarioViewModel
    {
        public int ID { get; set; }
        public string DNI { get; set; }
        public string NombreApellidos { get; set; }
        public int Edad { get; set; }
    }
}