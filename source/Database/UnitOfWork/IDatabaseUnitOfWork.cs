using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Database
{
    public interface IDatabaseUnitOfWork
    {
        void SaveChanges();

        Task SaveChangesAsync();
    }
}
