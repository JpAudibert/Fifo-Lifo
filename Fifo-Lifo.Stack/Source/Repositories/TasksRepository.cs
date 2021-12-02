using Fifo_Lifo.Source.Domain;
using Fifo_Lifo.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Repositories;

public class TasksRepository : ITasksRepository
{
    public TaskStack TaskStack { get; set; }

    public TasksRepository(TaskStack? stack = null)
    {
        if (stack != null)
        {
            TaskStack = stack;
            return;
        }

        TaskStack = new TaskStack();
    }

    public TaskStack InsertTask(string owner, string task)
    {
        try
        {
            if (task == null || owner == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            TaskStack.Tasks.Push(new Domain.Task(owner, task));

            return TaskStack;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public TaskStack RemoveTask()
    {
        try
        {
            if (TaskStack.Tasks.Count > 0)
            {
                TaskStack.Tasks.Pop();

            }

            return TaskStack;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public string ReturnNextTask()
    {
        try
        {
            if(TaskStack.Tasks.Count > 0)
            {
                return $"{TaskStack.Tasks.Peek().Owner} - {TaskStack.Tasks.Peek().TaskName}";
            }
            return "There's no tasks";
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

