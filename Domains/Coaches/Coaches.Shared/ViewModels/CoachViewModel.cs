namespace Coaches.Shared;
public class CoachViewModel : PersonViewModel
{
    public Guid NationalityId { get; set; }
    public NationalityViewModel Nationality { get; set; }
}