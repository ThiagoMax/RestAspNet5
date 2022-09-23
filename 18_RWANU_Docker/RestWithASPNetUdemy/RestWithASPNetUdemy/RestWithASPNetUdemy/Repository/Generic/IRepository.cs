using RestWithASPNetUdemy.Model;
using RWANU.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Repository
{
    public interface IPersonRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);

        List<T> FindWithPagedSearch(string query);
        int GetCount(string query);
    }
}
