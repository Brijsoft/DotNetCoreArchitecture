using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Database
{
    public sealed class DatabaseUnitOfWork : IDatabaseUnitOfWork
    {
        public DatabaseUnitOfWork(DatabaseContext context)
        {
            Context = context;
        }

        private DatabaseContext Context { get; }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}
