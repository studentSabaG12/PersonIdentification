using PersonIdentification.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentification.Service.IService
{
    public interface ICityService
    {
        Task<City> GetCity(int cityId);
        Task<IQueryable<City>> GetCities();
        void AddCity(City city);
        void UpdateCity(City city);
        void DeleteCity(int cityId);
    }
}
