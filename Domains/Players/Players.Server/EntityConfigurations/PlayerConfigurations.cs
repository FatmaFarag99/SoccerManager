namespace Players.Server;
public class PlayerConfigurations : PersonConfiguration<Player>
{
    public override void Configure(EntityTypeBuilder<Player> builder)
    {
        base.Configure(builder);

        builder.Property(e => e.CurrentNumber).IsRequired();
       // builder.Property(e => e.PlaceOfBirth).IsRequired();
    //    builder.Property(e => e.BirthDate).IsRequired();
      //  builder.Property(e => e.Hight).IsRequired();
        builder.Property(e => e.Weight).IsRequired();
     //   builder.Property(e => e.Position).IsRequired();

    }
}