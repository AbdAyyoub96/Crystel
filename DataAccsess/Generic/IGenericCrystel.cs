using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Generic
{
  public interface IGenericCrystel<T> where T : class
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        T Load(int id);
        List<T> LoadAll();
    }
}
