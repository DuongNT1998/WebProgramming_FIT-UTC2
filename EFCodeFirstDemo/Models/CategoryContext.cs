using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFCodeFirstDemo
{
    public partial class CategoryContext : DbContext
    {
        public CategoryContext()
            : base("name=CategoryContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
