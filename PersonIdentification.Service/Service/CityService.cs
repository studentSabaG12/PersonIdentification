using PersonIdentification.DTO;
using PersonIdentification.Service.Interfaces.Repository;
using PersonIdentification.Service.IService;

namespace PersonIdentification.Service.Service
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<City> GetCity(int cityId)
        {
            City city = _unitOfWork.CityRepository.Get(cityId) ?? throw new InvalidDataException("CityId could not be found");
            if (city != null)
            {
                return Task.FromResult(city);
            }
            else
            {
                throw new InvalidDataException("The CityId could not be found");
            }

        }

        public Task<IQueryable<City>> GetCities()
        {
            var cities = _unitOfWork.CityRepository.Set() ?? throw new InvalidDataException("Cities could not be loaded");
            if (cities != null)
            {
                return Task.FromResult(cities);
            }
            else
            {
                throw new InvalidDataException("The CityId could not be found");
            }
        }

        public void AddCity(City city)
        {
            if (city == null) throw new ArgumentNullException(nameof(city));
            _unitOfWork.CityRepository.Insert(city);
            _unitOfWork.SaveChanges();
        }
        public void UpdateCity(City city)
        {
            if (city == null) throw new ArgumentNullException(nameof(city));
            _unitOfWork.CityRepository.Update(city);
            _unitOfWork.SaveChanges();
        }

        public void DeleteCity(int cityId)
        {
            City city = _unitOfWork.CityRepository.Get(cityId) ?? throw new InvalidDataException("CityId Could not be found");
            city.IsDelete = true;
            _unitOfWork.CityRepository.Update(city);
            _unitOfWork.SaveChanges();
        }
    }
}
