using RestWithASPNetUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNetUdemy.Repository
{
    public interface IPersonRepository : IPersonRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string lastName);
    }
}
