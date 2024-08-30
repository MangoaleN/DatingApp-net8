namespace API.Entites;

public class AppUser
{
    //[Key]
    public int Id { get; set; }
    //To Not all nulls
    public required string UserName { get; set;}
}
