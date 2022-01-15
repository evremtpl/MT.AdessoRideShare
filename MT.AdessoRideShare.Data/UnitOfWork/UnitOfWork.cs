using MT.AdessoRideShare.Core.Interfaces.UnitOfWork;
using MT.AdessoRideShare.Data.Context;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
