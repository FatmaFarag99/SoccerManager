namespace Persons.Shared;

using Nationalities.Server;

public class Person : BaseEntity
    {
    public string Name { get; set; }
    public string NickName { get; set; }
    public int Age { get; set; }
    public string PlaceOfBirth { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Hight { get; set; }
    public string Position { get; set; }
    public Guid NationalityId { get; set; }
    public Nationality Nationality { get; set; }

    // public string CurrentTeam { get; set; }
}