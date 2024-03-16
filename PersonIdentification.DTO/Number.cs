namespace PersonIdentification.DTO;

public class Number
{

    public int Id { get; set; }
    public NumberType Type { get; set; }
    public Person Person { get; set; }
    public string TextNumber { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }

    public enum NumberType : byte 
    {
        Mobilephone = 0,
        Officenumber = 1,
        HouseNumber = 2
    }

}