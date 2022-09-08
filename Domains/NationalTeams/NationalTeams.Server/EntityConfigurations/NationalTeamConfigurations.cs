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

        builder.HasMany(e => e.Players).WithOne().HasForeignKey(e => e.NationalTeamId);
        builder.HasOne(e => e.Coach).WithOne().HasForeignKey<Coach>(e => e.NationalTeamId);

    }
}