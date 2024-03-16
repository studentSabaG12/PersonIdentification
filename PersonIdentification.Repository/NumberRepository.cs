using PersonIdentification.DTO;

namespace PersonIdentification.Repository
{
    internal class NumberRepository : RepositoryBase<Number>
    {
        public NumberRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
