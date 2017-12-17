﻿namespace DemolitionFalcons.Data.EntityConfigurations
{
    using DemolitionFalcons.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CharacterConfig : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(ch => ch.Id);

            builder.Property(ch => ch.Name)
                .HasMaxLength(12)
                .IsRequired();
        }
    }
}