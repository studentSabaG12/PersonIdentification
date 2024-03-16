namespace PersonIdentification.DTO;

public class RelatedPerson
{
    public int Id { get; set; }
    public int ToPersonId { get; set; }
    public Person ToPerson { get; set; }
    public int FromPersonId { get; set; }
    public Person FromPerson { get; set; }
    public ConnectionType Type { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }

    public enum ConnectionType : byte
    {
        Colleague = 0,
        Acquaintance = 1,
        Relative = 2,
        Other = 3
    }
}
