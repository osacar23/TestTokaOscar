using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TestToka.Data.Entities;
using TestToka.Data.Properties;

namespace TestToka.Data
{
    public class TestTokaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TestTokaDbContext>
    {
        protected override void Seed(TestTokaDbContext ctx)
        {
            if(ctx.Auto.Select(x => x).FirstOrDefault() == null)
            {
                var autos = JsonConvert.DeserializeObject<List<Auto>>(Resources.Autos);                
                autos.ForEach(s => ctx.Auto.Add(s));
                ctx.SaveChanges();
            }
            
            
        }
    }
}