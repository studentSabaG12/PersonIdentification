using PersonIdentification.DTO;
using PersonIdentification.Service.Interfaces.Repository;

namespace PersonIdentification.Repository
{
    internal class NumberRepository : RepositoryBase<Number>,INumberRepository
    {
        public NumberRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
