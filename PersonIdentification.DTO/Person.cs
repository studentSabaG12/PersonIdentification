using System.ComponentModel.DataAnnotations;

namespace PersonIdentification.DTO;

public class Person
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public PersonGender Gender { get; set; } 
    public string PersonalNumber {  get; set; } = null!;
    public City City { get; set; } = null!;
    public int CityId {  get; set; }
    public DateTime BirthDate {  get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public ICollection<Number> Numbers { get; set; }
    public ICollection<Relation>? FromRelations { get; set; }
    public ICollection<Relation>? ToRelations { get; set; }
}
public enum PersonGender : byte
{
    Male = 0,
    Female = 1
}
