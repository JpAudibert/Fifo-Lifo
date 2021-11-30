using Fifo_Lifo.Source.Domain;

namespace Fifo_Lifo.Source.Interfaces;

public interface ITasksRepository
{
    public TaskStack InsertTask(string owner, string task);
    public TaskStack RemoveTask();
    public string ReturnNextTask();
}
