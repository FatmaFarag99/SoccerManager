namespace Coaches.Server;
public class Coach : Person
{
    public Guid NationalityId { get; set; }
    public Nationality Nationality { get; set; }
}