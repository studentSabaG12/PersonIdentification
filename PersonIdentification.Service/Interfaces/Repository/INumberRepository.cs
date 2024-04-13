using PersonIdentification.DTO;

namespace PersonIdentification.Service.Interfaces.Repository
{
    public interface INumberRepository : IRepositoryBase<Number>
    {
        void Update(int numberId);
    }
}
