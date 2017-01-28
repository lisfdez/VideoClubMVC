using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoClubMVC.Models
{
    public class PeliculasModel
    {
        public int idPelicula { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public string Pais { get; set; }
        public string Genero { get; set; }
        public string Descripcion { get; set; }
        public int? idCliente { get; set; }
    }
}