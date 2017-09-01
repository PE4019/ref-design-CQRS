namespace Edu.Domain.Interfaces
{
    public interface IRepository<TAggregate, in TKey> where TAggregate : IAggregateRoot
    {
        TAggregate GetByID(TKey id);

        void Save(TAggregate aggregate);

        void Delete(TAggregate aggregate);
    }
}
