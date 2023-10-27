using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IMessageRepository Messages { get; }
    IAccountHistoryRepository AccountHistories { get; }


    Task<int> CommitAsync();
}