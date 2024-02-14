using Microsoft.EntityFrameworkCore;
using sign.core.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace sign.repository.data
{
    public class signupcontext:DbContext
    {
        //ctor the abstraction of constructor
        public signupcontext(DbContextOptions<signupcontext>options) : base(options) 
        {
            
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<signup> signup { get; set; }
    }
}
