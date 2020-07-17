using LinqToDB;
using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Model;
using ProAgil.WebAPI.Properties;
using System;

namespace ProAgil.WebAPI.Data
{
    public class DataContexts : DbContext  
    {
        public DataContexts(DbContextOptions<DataContexts> options) : base (options){}
        
        public DbSet<Event> Events {get; set;}

        public static implicit operator DataContexts(DataContext v)
        {
            throw new NotImplementedException();
        }
    }
}