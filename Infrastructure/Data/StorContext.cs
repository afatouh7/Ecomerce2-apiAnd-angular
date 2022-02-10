using Api.Entites;
using Microsoft.EntityFrameworkCore;
using System;

namespace Api.Data
{
    public class StorContext :DbContext
    {
        public StorContext(DbContextOptions<StorContext> options) : base(options)
        {

        }
        public DbSet<Products>  Products { get; set; }

       
    }
}
