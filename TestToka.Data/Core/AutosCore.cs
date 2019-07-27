using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestToka.Data.Entities;
using TestToka.Data.Services;

namespace TestToka.Data.Core
{
    public class AutosCore
    {
        private Crud<Auto> crud;
        private TestTokaDbContext _ctx;
        public AutosCore(TestTokaDbContext ctx)
        {
            _ctx = ctx;
            crud = new Crud<Auto>(_ctx);
        }

        public List<Auto> GetAll()
        {
            return crud.GetAll();
        }
        public Auto Create(Auto auto)
        {
            return crud.Save(auto);
        }

        public Auto GetById(int id)
        {
            return crud.GetById(x => x.Id == id);

        }

        public bool Update(Auto auto)
        {
            return crud.Update(auto);
        }
    }
}
