using RestWithAspNetUdemy.Models;

namespace RestWithAspNetUdemy.Services.Implementations
{
    public class PersonService : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(int id)
        {

        }

        public Person Get(int id)
        {
            return new Person { FirstName = "Mário", LastName = "Mateus", Adrress = "Rua Raphael Magalhães", Gender = "Masculino", Id = id };
        }

        public IList<Person> GetAll()
        {
            return new List<Person> {
                new Person{ FirstName = "João", LastName = "Silva", Adrress = "Rua Raphael Magalhães", Gender = "Masculino", Id = 1},
                new Person{ FirstName = "Maria", LastName = "Paixão", Adrress = "Rua Y", Gender = "Feminino", Id = 2},
                new Person{ FirstName = "Jose", LastName = "Ferreira", Adrress = "Rua Z", Gender = "Masculino", Id = 3},
                new Person{ FirstName = "Carlos", LastName = "Santos", Adrress = "Rua W", Gender = "Masculino", Id = 4},
                new Person{ FirstName = "Francisco", LastName = "Oliveira", Adrress = "Rua D", Gender = "Masculino", Id = 5} };
        }
    }
}
