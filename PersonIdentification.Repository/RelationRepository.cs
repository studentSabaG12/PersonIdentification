using PersonIdentification.DTO;
using PersonIdentification.Service.Interfaces.Repository;

namespace PersonIdentification.Repository
{
    internal class RelationRepository : RepositoryBase<Relation> ,IRelationRepository
    {
        public RelationRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
