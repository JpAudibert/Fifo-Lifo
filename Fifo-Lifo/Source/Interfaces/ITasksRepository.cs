using Fifo_Lifo.Source.Domain;

namespace Fifo_Lifo.Source.Interfaces;

public interface ITasksRepository
{
    public TaskList InsertTask(string owner, string task);
    public TaskList RemoveTask();
    public string ReturnNextTask();
}
