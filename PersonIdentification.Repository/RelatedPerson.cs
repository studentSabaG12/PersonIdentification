namespace PersonIdentification.Repository
{
    internal class RelatedPerson : RepositoryBase<RelatedPerson>
    {
        public RelatedPerson(PersonIdentificationDbContext context) : base(context)
        {
        }
    }
}
