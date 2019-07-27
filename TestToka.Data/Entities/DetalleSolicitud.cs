using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToka.Data.Entities
{
    public class DetalleSolicitud
    {
        public int Id { get; set; }
        public int IdSolicitud { get; set; }
        public virtual Auto Auto { get; set; }
    }
}
