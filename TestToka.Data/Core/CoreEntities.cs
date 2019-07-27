using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestToka.Data.Entities;
using TestToka.Data.Services;

namespace TestToka.Data.Core
{
    public class CoreEntities
    {
        private Crud<Solicitud> crud;
        private TestTokaDbContext _ctx;
        public CoreEntities(TestTokaDbContext ctx)
        {
            _ctx = ctx;
            crud = new Crud<Solicitud>(_ctx);
        }
        public List<Solicitud> GetAllRequests()
        {
            return crud.GetAll();
        }
        public Solicitud Create(Solicitud solicitud)
        {
            return crud.Save(solicitud);
        }

        public Solicitud GetById(int id)
        {
            return crud.GetById(x => x.Id == id);
            
        }

        public bool Update(Solicitud solicitud)
        {
            return crud.Update(solicitud); 
        }

        
    }
}
