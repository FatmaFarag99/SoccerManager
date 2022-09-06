namespace Coaches.Server;
public class CoachConfigurations : PersonConfiguration<Coach>
{
    public override void Configure(EntityTypeBuilder<Coach> builder)
    {
        base.Configure(builder);

        builder.Property(e => e.Nationality).IsRequired();
        builder.HasOne(e => e.Nationality).WithMany().HasForeignKey(e => e.NationalityId);
    }
}