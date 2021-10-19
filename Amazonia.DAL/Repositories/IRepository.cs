using System.Collections.Generic;

namespace Amazonia.DAL.Repositories
{
    interface IRepository<T>
    {
        void Create(T obj);
        T ReadByName(string nome);
        List<T> ReadAll();
        T Update(T obj);
        void Delete(T obj);
    }
}