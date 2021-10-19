using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace pc3simulacro.Models
{
    public class Usuario
    {
          [Column("id")]
         public int Id {get; set;}
        
        [Column("nombre")]
        public string Nombre {get; set;}
    
        
    }
}