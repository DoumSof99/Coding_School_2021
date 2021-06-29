using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Coding_SchoolApp.EF.Context {
    public class Coding_SchoolAppContextFactory : IDesignTimeDbContextFactory<Coding_SchoolAppContext> {

        public Coding_SchoolAppContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<Coding_SchoolAppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbCoding_SchoolApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new Coding_SchoolAppContext(optionsBuilder.Options);
        }
    }
}
