using Microsoft.EntityFrameworkCore;
using PersonIdentification.DTO;
using PersonIdentification.Repository.Migrations;
using PersonIdentification.Service.Interfaces;

namespace PersonIdentification.Repository
{
    internal class PersonRepository : RepositoryBase<Person>,IPersonRepository
    {
        public PersonRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
        public List<Relation> GetAllRelationsForPerson(int personId)
        {

            return _context.Relations
                .Where(r => r.FromPersonId.Equals(personId) || r.ToPersonId.Equals(personId))
                .ToList();
        }
    }
}
