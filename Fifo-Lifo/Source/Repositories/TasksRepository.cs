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
    public TaskList TaskList { get; set; }

    public TasksRepository(TaskList? list = null)
    {
        if (list != null)
        {
            TaskList = list;
            return;
        }

        TaskList = new TaskList();
    }

    public TaskList InsertTask(string owner, string task)
    {
        try
        {
            if (task == null || owner == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            TaskList.Tasks.Add(new Domain.Task(owner, task));

            return TaskList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public TaskList RemoveTask()
    {
        try
        {
            if (TaskList.Tasks.Count > 0)
            {
                TaskList.Tasks.RemoveAt(TaskList.Tasks.Count - 1);

            }

            return TaskList;
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
            if(TaskList.Tasks.Count > 0)
            {
                return $"{TaskList.Tasks[TaskList.Tasks.Count - 1].Owner} - {TaskList.Tasks[TaskList.Tasks.Count - 1].TaskName}";
            }
            return "There's no tasks";
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

