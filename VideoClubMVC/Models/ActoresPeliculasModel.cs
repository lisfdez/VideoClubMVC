using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoClubMVC.Models
{
    public class ActoresPeliculasModel
    {
        public int idActor_Pelicula { get; set; }
        public int idPelicula { get; set; }
        public int idActor { get; set; }
        public int? Sueldo { get; set; }
    }
}