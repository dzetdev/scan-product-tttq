namespace Scan_Product_TTTQ.Domain.Abstractions;

public interface IUnitOfWork : IDisposable
{
    int Commit();
}