using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDominio
{
    public class Articulos
    {
        public string  Codigo { get; set; }
        public string Nombre  { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public Marcas Marcas { get; set; }
        public Categorias Categoria{ get; set; }
       
        


    }
}