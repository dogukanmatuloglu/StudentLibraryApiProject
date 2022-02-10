using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Data.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.GDate).IsRequired();
            builder.Property(x => x.TDate).IsRequired();
            builder.HasOne<Student>().WithMany(x => x.Operations);
            builder.HasOne<Book>().WithMany(x => x.Operations);

        }
    }
}
