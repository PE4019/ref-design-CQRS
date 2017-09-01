namespace Edu.Domain.Interfaces
{
    public class Command : ICommand
    {
        public Command(int id)
        {
            this.ID = id;
        }

        public int ID { get; private set; }
    }
}
