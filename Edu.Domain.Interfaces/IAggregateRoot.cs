namespace Edu.Domain.Interfaces
{
    public interface IAggregateRoot
    {
        int ID { get; }

        bool IsSaveable { get; }
    }
}
