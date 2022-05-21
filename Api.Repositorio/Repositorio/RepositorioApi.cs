using Api.Models.web.BDCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repositorio.Repositorio
{
    public class RepositorioApi
    {
        public RepositorioApi() { }
        public void Add<T>(T Register) where T : class
        {
            using (ClienteContext _ClienteContext = new ClienteContext())
            {
                _ClienteContext.Set<T>().Add(Register);
                _ClienteContext.SaveChanges();
            }
        }
        public void Update<T>(T Register) where T : class
        {
            using (ClienteContext _ClienteContext = new ClienteContext())
            {
                _ClienteContext.Entry(Register).State = System.Data.Entity.EntityState.Modified;
                _ClienteContext.SaveChanges();
            }
        }
        public void Remove<T>(T Register) where T : class
        {
            using (ClienteContext _ClienteContext = new ClienteContext())
            {
                _ClienteContext.Set<T>().Remove(Register);
                _ClienteContext.SaveChanges();
            }
        }
        public Cliente GetClienteById(int _Id)
        {
            using (ClienteContext _Context = new ClienteContext())
            {
                return _Context.Cliente.FirstOrDefault(x => x.Id.Equals(_Id));
            }

        }
    }
}
