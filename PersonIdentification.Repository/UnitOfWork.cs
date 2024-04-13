﻿using PersonIdentification.Service.Interfaces;
using PersonIdentification.Service.Interfaces.Repository;

namespace PersonIdentification.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly PersonIdentificationDbContext _context;
        private readonly Lazy<ICityRepository> _cityRepository;
        private readonly Lazy<INumberRepository> _numberRepository;
        private readonly Lazy<IPersonRepository> _personRepository;
        private readonly Lazy<IRelationRepository> _relationRepository;
      

        public UnitOfWork(PersonIdentificationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _cityRepository = new Lazy<ICityRepository>(() => new CityRepository(context));
            _numberRepository = new Lazy<INumberRepository>(() => new NumberRepository(context));
            _personRepository = new Lazy<IPersonRepository>(() => new PersonRepository(context));
            _relationRepository = new Lazy<IRelationRepository>(() => new RelationRepository(context));

          
        }

        public ICityRepository CityRepository => _cityRepository.Value;
        public INumberRepository NumberRepository => _numberRepository.Value;
        public IPersonRepository PersonRepository => _personRepository.Value;
        public IRelationRepository RelationRepository => _relationRepository.Value;

        public int SaveChanges() => _context.SaveChanges();

        public void BeginTransaction()
        {
            if (_context.Database.CurrentTransaction != null)
            {
                throw new InvalidOperationException("A Transaction is already in progress.");
            }

            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            try
            {
                _context.Database.CurrentTransaction?.Commit();
            }
            catch
            {
                _context.Database.CurrentTransaction?.Rollback();
                throw;
            }
            finally
            {
                _context.Database.CurrentTransaction?.Dispose();
            }
        }

        public void RollBack()
        {
            try
            {
                _context.Database.CurrentTransaction?.Rollback();
            }
            finally
            {
                _context.Database.CurrentTransaction?.Dispose();
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
