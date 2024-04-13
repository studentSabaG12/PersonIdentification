using PersonIdentification.DTO;

namespace PersonIdentification.Service.IService
{
    internal interface INumberService
    {
        Task<Number> GetNumber(int cityId);
        Task<IQueryable<Number>> GetNumbers();
        void AddNumber(Number number);
        void UpdateNumber(Number number);
        void DeleteNumber(int numberId);
    }
}
