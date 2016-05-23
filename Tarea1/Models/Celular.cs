using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tarea1.Models
{
    [Table("Celulares")]
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IMEI { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
    }
}