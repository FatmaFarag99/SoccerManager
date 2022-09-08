namespace Players.Server;
public class PlayerConfigurations : PersonConfiguration<Player>
{
    public override void Configure(EntityTypeBuilder<Player> builder)
    {
        base.Configure(builder);

        builder.Property(e => e.CurrentNumber).IsRequired();
        builder.Property(e => e.Weight).IsRequired();
    }
}