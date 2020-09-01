using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccsess.Context;
namespace DataAccsess.Generic
{
    public class GenericCrystel<T> : IGenericCrystel<T> where T : class
    {
        public void Delete(object id)
        {
            CrystelContext con = new CrystelContext();
            T del = con.Set<T>().Find(id);
            con.Set<T>().Remove(del);
            con.SaveChanges();
        }

        public void Insert(T obj)
        {
            CrystelContext con = new CrystelContext();
            con.Set<T>().Add(obj);
            con.SaveChanges();
        }

        public T Load(int id)
        {
            CrystelContext con = new CrystelContext();
            return con.Set<T>().Find(id);

        }

        public List<T> LoadAll()
        {
            CrystelContext con = new CrystelContext();
            return con.Set<T>().ToList<T>();
        }

        public void Update(T obj)
        {
            CrystelContext con = new CrystelContext();
            con.Set<T>().Attach(obj);
            con.Entry(obj).State = EntityState.Modified;
            con.SaveChanges();
        }
    }
}
