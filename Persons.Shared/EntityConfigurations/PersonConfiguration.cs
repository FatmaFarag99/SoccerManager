﻿namespace Persons.Shared;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

public abstract class PersonConfiguration<T> : BaseEntityConfiguration<T> where T : Person
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.NickName).IsRequired();
        builder.Property(e => e.Age).IsRequired();
        builder.Property(e => e.PlaceOfBirth).IsRequired();
        builder.Property(e => e.BirthDate).IsRequired();
        builder.Property(e => e.Hight).IsRequired();
        builder.Property(e => e.Position).IsRequired();
    }
}