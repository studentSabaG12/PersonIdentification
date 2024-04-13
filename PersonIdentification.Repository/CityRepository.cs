using PersonIdentification.DTO;
using PersonIdentification.Service.Interfaces.Repository;

namespace PersonIdentification.Repository
{
    internal class CityRepository : RepositoryBase<City>,ICityRepository
    {
        public CityRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
