namespace NationalTeams.Server;
public class NationalTeamConfigurations : BaseEntityConfiguration<NationalTeam>
{
    public override void Configure(EntityTypeBuilder<NationalTeam> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.Name).IsRequired();
    }
}