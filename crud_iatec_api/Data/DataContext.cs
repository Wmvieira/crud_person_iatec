using Microsoft.EntityFrameworkCore;

namespace crud_iatec_api.Data
{
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options) { }

            public DbSet<Person> Person { get; set; }

            public DbSet<Phone> Phone { get; set; }


        }
}
