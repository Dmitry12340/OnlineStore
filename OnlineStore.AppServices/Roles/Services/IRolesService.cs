namespace OnlineStore.AppServices.Roles.Services
{
    public interface IRolesService
    {
        Task AddAsync(string roleName, CancellationToken cancellation);
        Task DeleteAsync(int id, CancellationToken cancellation);
    }
}
