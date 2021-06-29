using Coding_School.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_SchoolApp.EF.Configuration {
    public class CourseConfiguration : IEntityTypeConfiguration<Course> {
        public void Configure(EntityTypeBuilder<Course> builder) {
            builder.ToTable("Course", "Coding_School");
            builder.HasKey(course => course.Id);
            builder.Property(course => course.Id).ValueGeneratedOnAdd();

            builder.Property(course => course.Title).HasMaxLength(200).IsRequired(true);
            builder.Property(course => course.Category).HasMaxLength(200).IsRequired(true); 
            builder.Property(course => course.Date).IsRequired(true);
            builder.Property(course => course.Duration).IsRequired(true);


        }
    }
}
