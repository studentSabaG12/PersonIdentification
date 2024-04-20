using PersonIdentification.DTO;

namespace PersonIdentification.Service.IService
{
    public interface IPersonService
    {
        Task<Person> GetPerson(int personId);
        Task<IQueryable<Person>> GetPeople();
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int personId);
    }
}
