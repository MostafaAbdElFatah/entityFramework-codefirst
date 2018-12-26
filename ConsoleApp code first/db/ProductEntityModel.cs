namespace ConsoleApp_code_first.db
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    class ProductEntityModel : DbContext
    {
        public ProductEntityModel()
            : base("name=ProductEntityModel")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}

   