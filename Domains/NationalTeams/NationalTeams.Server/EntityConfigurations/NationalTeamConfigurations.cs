namespace NationalTeams.Server;
public class NationalTeamConfigurations : BaseEntityConfiguration<NationalTeam>
{
    public override void Configure(EntityTypeBuilder<NationalTeam> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.NickName).IsRequired();
        builder.Property(e => e.FifaCode).IsRequired();
        builder.Property(e => e.MostCaps).IsRequired();
        builder.Property(e => e.Association).IsRequired();
    }
}