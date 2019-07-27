using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToka.Data.Entities
{
    public class Solicitud 
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha solicitud")]
        public DateTime FechaSolicitud { get; set; }
        public int NumeroLote { get; set; }
    }
}
