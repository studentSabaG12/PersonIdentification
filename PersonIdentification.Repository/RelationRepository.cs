using PersonIdentification.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentification.Repository
{
    internal class RelationRepository : RepositoryBase<Relation>
    {
        public RelationRepository(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
