namespace PersonIdentification.DTO;

public class City
{

    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public ICollection<Person>? People { get; set; }
}
