using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabApp.Models;

namespace LabApp.Data_Access_Layer
{
    public class DbCtx : DbContext
    {
        public DbCtx() : base("BookCS")
        {
            Database.SetInitializer<DbCtx>(new Initp());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ContactInfo> ContactsInfo { get; set; }

    }
}