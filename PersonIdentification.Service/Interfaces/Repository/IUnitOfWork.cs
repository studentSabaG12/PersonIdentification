namespace PersonIdentification.Service.Interfaces.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository CityRepository { get; }
        INumberRepository NumberRepository { get; }
        IPersonRepository PersonRepository { get; }
        IRelationRepository RelationRepository { get; }
        int SaveChanges();
        void BeginTransaction();
        void CommitTransaction();
        void RollBack();

    }
}
