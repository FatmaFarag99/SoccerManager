namespace Coaches.Server;
public class CoachConfigurations : PersonConfiguration<Coach>
{
    public override void Configure(EntityTypeBuilder<Coach> builder)
    {
        base.Configure(builder);

    }
}