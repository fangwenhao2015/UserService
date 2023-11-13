using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserService.Data.Entities;
using UserService.Entities;

namespace UserService.Data
{
    public class UserServiceContext : DbContext
    {
        static Type entityBase = typeof(UniqueEntityBase);

        public UserServiceContext(DbContextOptions<UserServiceContext> options) : base(options)
        {
            //Model
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var types=  Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (!type.IsAbstract&&type.IsSubclassOf(entityBase))
                {
                    modelBuilder.Entity(type);
                }
            }
            modelBuilder.Entity<UniqueEntityBase>().UseTpcMappingStrategy();
           
        }


    }
}
