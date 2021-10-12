using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Repository.EFCore.DataContext
{
    //Add-Migration InitialCreate -s Repository.EFCore -p Repository.EFCore -c RepositoryContext -o Migrations
    //
    public class AplicationContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();

            OptionsBuilder.UseSqlServer("Data Source = .;Initial Catalog = repositoryDemoDb; Integrated Security = True;");

            return new RepositoryContext(OptionsBuilder.Options);
        }
    }
}
