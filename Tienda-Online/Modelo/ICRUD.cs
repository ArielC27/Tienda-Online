using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface ICRUD<T>
    {
        //public List<T> GetById(int id); Consultar
        public List<T> GetAll();

        public bool Create(T entity);

        public bool Update(T entity);

        public bool Delete(int id);

    }
}
