using RestWithAspNetUdemy.Models;

namespace RestWithAspNetUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        void Delete(int id);
        Person Get(int id);
        IList<Person> GetAll();
    }
}
