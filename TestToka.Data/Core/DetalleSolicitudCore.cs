using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestToka.Data.Entities;
using TestToka.Data.Services;

namespace TestToka.Data.Core
{
    public class DetalleSolicitudCore
    {
        private Crud<DetalleSolicitud> crud;
        private TestTokaDbContext _ctx;
        public DetalleSolicitudCore(TestTokaDbContext ctx)
        {
            _ctx = ctx;
            crud = new Crud<DetalleSolicitud>(_ctx);
        }

        public List<DetalleSolicitud> GetListById(int id)
        {
            return crud.GetListById(x => x.IdSolicitud == id);
        }
    }
}
