using Fifo_Lifo.Source.Domain;

namespace Fifo_Lifo.Source.Interfaces;

public interface ITasksRepository
{
    public TaskList InsertTask(Owner owner, string task);
    public TaskList RemoveTask(Owner owner);
    public string ReturnNextTask(Owner owner);
}
