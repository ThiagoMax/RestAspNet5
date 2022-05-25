using RestWithASPNetUdemy.Model;
using RWANU.Model;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Business
{
    public interface IBooksBusiness
    {
        Books Create(Books book);
        Books FindById(long id);
        List<Books> FindAll();
        Books Update(Books book);
        void Delete(long id);
    }
}
