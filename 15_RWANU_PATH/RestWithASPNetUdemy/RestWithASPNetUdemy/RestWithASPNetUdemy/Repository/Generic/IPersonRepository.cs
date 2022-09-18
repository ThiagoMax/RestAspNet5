using RestWithASPNetUdemy.Model;

namespace RestWithASPNetUdemy.Repository
{
    public interface IPersonRepository : IPersonRepository<Person>
    {
        Person Disable(long id);
    }
}
