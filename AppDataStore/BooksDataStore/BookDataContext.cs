using AppDataStore.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AppDataStore.BooksDataStore
{
    public class BookDataContext: DbContext
    {
        public BookDataContext() : base(ConfigurationManager.ConnectionStrings["BookData"].ConnectionString)
        {
            Database.SetInitializer<BookDataContext>(null);
            //this.Configuration.ProxyCreationEnabled = true;
            //this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Dept> Department { get; set; }
    }
}