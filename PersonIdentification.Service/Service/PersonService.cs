using PersonIdentification.DTO;
using PersonIdentification.Service.Interfaces.Repository;
using PersonIdentification.Service.IService;

namespace PersonIdentification.Service.Service
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<Person> GetPerson(int personId)
        {
            Person person= _unitOfWork.PersonRepository.Get(personId) ?? throw new InvalidDataException("PersonId could not be found");

            if (person  != null)
            {
                return Task.FromResult(person);
            }
            else
            {
                throw new InvalidDataException("The NumberId could not be found");
            }
        }

        public Task<IQueryable<Person>> GetPeople()
        {
            var people = _unitOfWork.PersonRepository.Set() ?? throw new InvalidDataException("People could not be loaded");

            if (people != null)
            {
                return Task.FromResult(people);
            }
            else
            {
                throw new InvalidDataException("The NumberId could not be found");
            }
        }
        public void AddPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));
            _unitOfWork.PersonRepository.Insert(person);
            _unitOfWork.SaveChanges();
            
        }

        public void UpdatePerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));
           _unitOfWork.PersonRepository.Update(person);
            _unitOfWork.SaveChanges();

        }

        public void DeletePerson(int personId)
        {
            Person person = _unitOfWork.PersonRepository.Get(personId) ?? throw new InvalidDataException("PersonId Could not be found");
            person.IsDelete = true;
            _unitOfWork.PersonRepository.Delete(person);
            _unitOfWork.SaveChanges();
        }
    }
}





