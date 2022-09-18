using RestWithASPNetUdemy.Model;
using RWANU.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
    }
}
