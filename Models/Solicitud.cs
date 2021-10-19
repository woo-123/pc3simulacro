using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc3simulacro.Models
{

    [Table("solicitud")]
    public class Solicitud
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombreP")]
        public string NombreP {get; set;}

        [Column("foto")]
        public string Foto {get; set;}
        [Column("descripcion")]
        public string Descripcion {get; set;}
        [Column("precio")]
        public string Precio {get; set;}
         [Column("telefono")]
        public int Telefono {get; set;}
        [Column("direccion")]
        public string Direccion {get; set;}
          [Column("usuario")]
        public Usuario Usuario {get; set;}

        public int? UsuarioId{get; set;}

          [Column("categoria")]
        public string Categoria {get; set;}
        [Column("fecha")]
        public DateTime Fecha {get; set;}

        public Solicitud (){
            Fecha = DateTime.Now;
        }



    }
}