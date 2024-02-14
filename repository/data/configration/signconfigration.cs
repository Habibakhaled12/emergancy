using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sign.core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sign.repository.data.configration
{
    internal class signconfigration : IEntityTypeConfiguration<signup>
    {
        public void Configure(EntityTypeBuilder<signup> builder)
        {
            builder.Property(p => p.e_mail).HasMaxLength(30);
        }
    }
}
