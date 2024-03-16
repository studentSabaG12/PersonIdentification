﻿namespace PersonIdentification.DTO;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public PersonGender Gender { get; set; } 
    public string PersonalNumber {  get; set; } = null!;
    public City City { get; set; } = null!;
    public int CityId {  get; set; }
    public DateTime BirthDate {  get; set; }
    public bool IsDelete { get; set; }
    public ICollection<Number> Numbers { get; set; }
    public ICollection<RelatedPerson>? FromRelatedPeople { get; set; }
    public ICollection<RelatedPerson>? ToRelatedPeople { get; set; }
}
public enum PersonGender : byte
{
    Male = 0,
    Female = 1
}
