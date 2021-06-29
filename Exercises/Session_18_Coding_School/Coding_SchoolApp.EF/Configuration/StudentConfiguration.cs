using Coding_School.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_SchoolApp.EF.Configuration {
    public class StudentConfiguration : IEntityTypeConfiguration<Student> {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Student> builder) {
            builder.ToTable("Student", "Coding_School");

            builder.HasKey(student => student.Id);
            builder.Property(student => student.Id).ValueGeneratedOnAdd();

            builder.Property(student => student.Name).HasMaxLength(200).IsRequired(true);
            builder.Property(student => student.Surname).HasMaxLength(200).IsRequired(true);
            builder.Property(student => student.Birthdate).IsRequired(true);
            builder.Property(student => student.Address).HasMaxLength(200).IsRequired(true);

        }
    }
}
