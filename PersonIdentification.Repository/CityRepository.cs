using PersonIdentification.DTO;

namespace PersonIdentification.Repository
{
    internal class CityRepository : RepositoryBase<City>
    {
        public CityRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
