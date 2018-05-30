using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace belnovosti.Models
{
    public class ArticleContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

    }

    public class ArticleDbInitializer : DropCreateDatabaseAlways<ArticleContext>
    {
        protected override void Seed(ArticleContext db)
        {
            base.Seed(db);
        }
    }
}