namespace LeagueTeams.Server;
public class LeagueTeamConfigurations : BaseEntityConfiguration<LeagueTeam>
{
    public override void Configure(EntityTypeBuilder<LeagueTeam> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.Name).IsRequired();
    }
}