namespace CrankshaftServices.Services.IRepository.Global
{
    public interface IUnitOfWork
    {
        //Global methods
        Task UpdateDatabaseAsync();
    }
}