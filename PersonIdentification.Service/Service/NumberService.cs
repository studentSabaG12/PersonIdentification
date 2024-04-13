using PersonIdentification.DTO;
using PersonIdentification.Service.Interfaces.Repository;
using PersonIdentification.Service.IService;
using System;

namespace PersonIdentification.Service.Service
{
    public  class NumberService:INumberService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NumberService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<Number> GetNumber(int numberId)
        {
            Number number = _unitOfWork.NumberRepository.Get(numberId) ?? throw new InvalidDataException("NumberId could not be found");
            if (number != null)
            {
                return Task.FromResult(number);
            }
            else
            {
                throw new InvalidDataException("The NumberId could not be found");
            }
        }

        public Task<IQueryable<Number>> GetNumbers()
        {
            var numbers = _unitOfWork.NumberRepository.Set() ?? throw new InvalidDataException("Numbers could not be loaded");
            if (numbers != null)
            {
                return Task.FromResult(numbers);
            }
            else
            {
                throw new InvalidDataException("The NumberId could not be found");
            }
        }
        public void AddNumber(Number number)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            _unitOfWork.NumberRepository.Insert(number);
            _unitOfWork.SaveChanges();
        }
          
        public void UpdateNumber(Number number)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            _unitOfWork.NumberRepository.Update(number);
            _unitOfWork.SaveChanges();
            
        }

        public void DeleteNumber(int numberId)
        {
           Number number = _unitOfWork.NumberRepository.Get(numberId) ?? throw new InvalidDataException("NumberId Could not be found");
            number.IsDelete = true;
            _unitOfWork.NumberRepository.Update(number);
            _unitOfWork.SaveChanges();
        }
    }
}

