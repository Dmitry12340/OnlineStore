namespace OnlineStore.AppServices.Authentication.Services
{
    /// <summary>
    /// Интерфейс сервиса аутентификации пользователя.
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Осуществляет вход пользователя.
        /// </summary>
        /// <param name="email">Email пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        Task SignInAsync(string email, string password, CancellationToken cancellationToken);

        /// <summary>
        /// Осуществляет выход пользователя.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        Task SignOutAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Осуществляет регистрацию пользователя.
        /// </summary>
        /// <param name="email">Email пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns></returns>
        Task RegisterAsync(string email, string password, CancellationToken cancellationToken);
    }
}
