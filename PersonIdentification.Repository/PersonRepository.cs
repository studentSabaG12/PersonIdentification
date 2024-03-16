using PersonIdentification.DTO;

namespace PersonIdentification.Repository
{
    internal class PersonRepository : RepositoryBase<Person>
    {
        public PersonRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
