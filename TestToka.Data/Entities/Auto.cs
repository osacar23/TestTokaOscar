using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToka.Data.Entities
{
    public class Auto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Folio { get; set; }
        public string Color { get; set; }
        public string TipoTransmision { get; set; }
        public string DescripcionEstatica { get; set; }
    }
}
