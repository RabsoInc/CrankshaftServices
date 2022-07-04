using CrankshaftServices.Services.IRepository.Global;
using HorsePowerLtd.DbAccess;

namespace CrankshaftServices.Services.Implementation.Global
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db;

        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task UpdateDatabaseAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}